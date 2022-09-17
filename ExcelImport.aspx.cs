using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ExcelImport : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    clsSales objsales = new clsSales();
    SqlDataReader objReader;
    string value;
    public static string gbVoiceConnection = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlConnection Con = new SqlConnection(gbVoiceConnection);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }

    //Button to Import Client login Excel
    protected void Submit_Btn_Click(object sender, EventArgs e)
    {
        string filename = "";
        try
        {

            string COMPANYID, CUSTOMER_ID, ROLES, STATUS, USERNAME, PASSWORD, CREATEDBY, AUTHORISEDPERSON;

            DataSet Ds1 = new DataSet();
            DataSet ds = new DataSet();

            string path = string.Concat(Server.MapPath("~/ImportFile/" + fuExcel.PostedFile.FileName));
            fuExcel.SaveAs(path);
            filename = fuExcel.PostedFile.FileName;


            // Connection String to Excel Workbook
            string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = excelConnectionString;
            OleDbDataAdapter OdbcAdp = new OleDbDataAdapter("select * from[Sheet1$]", connection);

            connection.Open();
            OdbcAdp.Fill(Ds1);
            connection.Close();
            if (Ds1 != null && Ds1.Tables[0].Rows.Count == 0)
            {
                lblMsg.Text = "No Record Found. Please excel upload once again.";
                return;
            }

            ds = ExucuteDataAdapter("Exec sproc_DeleteTempInOut");

            int i = 0;

            while (Ds1.Tables[0].Rows.Count > i)
            {
                COMPANYID = Ds1.Tables[0].Rows[i]["COMPANYID"].ToString().Replace("'", " ");
                CUSTOMER_ID = Ds1.Tables[0].Rows[i]["EmployeeId"].ToString().Replace("'", " ");
                ROLES = "Client";
                STATUS = "Active";
                USERNAME = Ds1.Tables[0].Rows[i]["USERNAME"].ToString().Replace("'", " ");
                PASSWORD = Ds1.Tables[0].Rows[i]["PASSWORD"].ToString().Replace("'", " ");
                CREATEDBY = Session["user_id"].ToString();
                AUTHORISEDPERSON = Ds1.Tables[0].Rows[i]["EmployeeName"].ToString().Replace("'", " ");

                string str_insert = "";
                str_insert = " INSERT INTO TempInOut (COMPANYID,CUSTOMER_ID,ROLES,STATUS,USERNAME,PASSWORD,CREATEDBY,CREATEDDATE,MODIFYDATE,AUTHORISEDPERSON)"
                           + " values('" + COMPANYID + "','" + CUSTOMER_ID + "','" + ROLES + "','" + STATUS + "','" + USERNAME + "','" + PASSWORD + "','" + CREATEDBY + "','" + null + "','" + null + "','" + AUTHORISEDPERSON + "')";

                SqlCommand cmd = new SqlCommand(str_insert, Con);
                Con.Open();
                int j = cmd.ExecuteNonQuery();
                Con.Close();
                //Con.ExecuteNonQry(str_insert);
                i = i + 1;
            }

            ds = ExucuteDataAdapter("Exec sproc_checkTempInOut");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                lblMsg.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                DataSet ds2 = new DataSet();
                ds2 = ExucuteDataAdapter("Exec sproc_InsInOut ");
                lblMsg.Text = ds2.Tables[0].Rows[0][0].ToString();
            }
            // lblMsg.Text = "Import Sucessfullly";

            System.IO.File.Delete(Server.MapPath("~/ImportFile/" + filename + ""));
        }
        catch (Exception ex)
        {
            System.IO.File.Delete(Server.MapPath("~/ImportFile/" + filename + ""));
            lblMsg.Text = ex.Message.ToString();
        }
    }

    public DataSet ExucuteDataAdapter(string Qrystr)
    {

        DataSet ds = new DataSet();
        try
        {

            SqlDataAdapter Dabps = new SqlDataAdapter(Qrystr, Con);
            Dabps.Fill(ds);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException(ex.Message);
        }
        return ds;
    }


    //Button to Import Document Master Detais Excel
    protected void Button1_Click(object sender, EventArgs e)
    {
        string filename = "";
        try
        {

            string COMPANYID, CUSTOMER_ID, document_type, financial_year, fileupload, filepath, created_by, docmonth;
            DataSet Ds1 = new DataSet();
            DataSet ds = new DataSet();

            string path = string.Concat(Server.MapPath(@"ImportFile\\" + FileUpload1.PostedFile.FileName));
            FileUpload1.SaveAs(path);
            filename = FileUpload1.PostedFile.FileName;


            // Connection String to Excel Workbook
            string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = excelConnectionString;
            OleDbDataAdapter OdbcAdp = new OleDbDataAdapter("select * from[Sheet1$]", connection);
            Ds1.Clear();
            connection.Open();
            OdbcAdp.Fill(Ds1);
            connection.Close();
            if (Ds1 != null && Ds1.Tables[0].Rows.Count == 0)
            {
                lblMsg.Text = "No Record Found. Please excel upload once again.";
                return;
            }

            ds = ExucuteDataAdapter("Exec sproc_DeleteTempInOutDocument");

            int i = 0;

            while (Ds1.Tables[0].Rows.Count > i)
            {
                COMPANYID = Ds1.Tables[0].Rows[i]["CompanyId"].ToString().Replace("'", " ");
                CUSTOMER_ID = Ds1.Tables[0].Rows[i]["EmployeeId"].ToString().Replace("'", " ");
                document_type = Ds1.Tables[0].Rows[i]["document_type"].ToString().Replace("'", " ");
                financial_year = Ds1.Tables[0].Rows[i]["financial_year"].ToString().Replace("'", " ");
                fileupload = Ds1.Tables[0].Rows[i]["fileupload"].ToString().Replace("'", " ");
                filepath = Ds1.Tables[0].Rows[i]["filepath"].ToString().Replace("'", " ");
                docmonth = Ds1.Tables[0].Rows[i]["Month"].ToString().Replace("'", " ");
                created_by = Session["user_id"].ToString();


                string str_insert = "";

                str_insert = " INSERT INTO InOutTempDocument (COMPANYID,Customer_Id,document_type,financial_year,fileupload,filepath,created_by,DocMonth)"
                           + " values('" + COMPANYID + "','" + CUSTOMER_ID + "','" + document_type + "','" + financial_year + "','" + fileupload + "','" + filepath + "','" + created_by + "','" + Convert.ToInt16(docmonth) + "')";

                SqlCommand cmd = new SqlCommand(str_insert, Con);
                Con.Open();
                int j = cmd.ExecuteNonQuery();
                Con.Close();
                //Con.ExecuteNonQry(str_insert);
                i = i + 1;
            }

            ds = ExucuteDataAdapter("Exec sproc_checkTempInOutDocument");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                lblMsg.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                DataSet ds2 = new DataSet();
                ds2 = ExucuteDataAdapter("Exec sproc_InsInOutDocuments ");
                lblMsg.Text = ds2.Tables[0].Rows[0][0].ToString();
            }
            System.IO.File.Delete(Server.MapPath(@"ImportFile\\" + filename + ""));
        }
        catch (Exception ex)
        {
            System.IO.File.Delete(Server.MapPath(@"ImportFile\\" + filename + ""));
            lblMsg.Text = ex.Message.ToString();
        }
    }

    //insert client details
    protected void SubmitClientDetail_Btn_Click(object sender, EventArgs e)
    {
        string filename = "";
        try
        {
            string CustomerId, CompanyName, AssociateCompany, AuthorisedPerson, Contact, Mobile, OtherContact, Email, Address, BusinessType, Services, Pan, Tan,
                Remarks, OtherDetail, CIN, RegistrationNo, CompanyId, Createdby, Birth;


            DataSet Ds1 = new DataSet();
            DataSet ds = new DataSet();

            string path = string.Concat(Server.MapPath(@"ImportFile\\" + FileUploadClientDetail.PostedFile.FileName));
            filename = FileUploadClientDetail.PostedFile.FileName;
            if (filename == "")
            { lblMsg.Text = "Please select file first"; }
            else
            {
                FileUploadClientDetail.SaveAs(path);



                // Connection String to Excel Workbook
                string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = excelConnectionString;
                OleDbDataAdapter OdbcAdp = new OleDbDataAdapter("select * from[Sheet1$]", connection);
                Ds1.Clear();
                connection.Open();
                OdbcAdp.Fill(Ds1);
                connection.Close();
                if (Ds1 != null && Ds1.Tables[0].Rows.Count == 0)
                {
                    lblMsg.Text = "No Record Found. Please excel upload once again.";
                    return;
                }

                ds = ExucuteDataAdapter("Exec sproc_DeleteTempInOutDocument");

                int i = 0;

                while (Ds1.Tables[0].Rows.Count > i)
                {
                    CompanyId = Ds1.Tables[0].Rows[i]["CompanyId"].ToString().Replace("'", " ");
                    CompanyName = Ds1.Tables[0].Rows[i]["CompanyName"].ToString().Replace("'", " ");
                    CustomerId = Ds1.Tables[0].Rows[i]["EmployeeId"].ToString().Replace("'", " ");
                    AuthorisedPerson = Ds1.Tables[0].Rows[i]["EmployeeName"].ToString().Replace("'", " ");
                    AssociateCompany = "Test";

                    Contact = Ds1.Tables[0].Rows[i]["Contact"].ToString().Replace("'", " ");
                    Mobile = Ds1.Tables[0].Rows[i]["Mobile"].ToString().Replace("'", " ");
                    OtherContact = Ds1.Tables[0].Rows[i]["OtherContact"].ToString().Replace("'", " ");
                    Email = Ds1.Tables[0].Rows[i]["Email"].ToString().Replace("'", " ");
                    Address = Ds1.Tables[0].Rows[i]["Address"].ToString().Replace("'", " ");

                    Remarks = Ds1.Tables[0].Rows[i]["Remarks"].ToString().Replace("'", " ");
                    OtherDetail = Ds1.Tables[0].Rows[i]["OtherDetail"].ToString().Replace("'", " ");
                    Birth = "";
                    //Extra column please remove
                    BusinessType = "";
                    Services = "";
                    Pan = "";
                    Tan = "";
                    CIN = "";
                    RegistrationNo = "";

                    //DateTime.ParseExact(Ds1.Tables[0].Rows[i]["Birth"].ToString().Replace("'", " "), "yyyy-MM-dd HHmmss", CultureInfo.InvariantCulture);

                    Createdby = Session["user_id"].ToString();

                    string str_insert = "";
                    str_insert = "INSERT INTO TempInOutClient (Customer_Id, company_name, Associate_company, Authorised_person, contact, mobile, other_contact, email, address, business_type, bu_service, pan, ta_n, remarks, other_detail, CIN, registrationno, CompanyId,created_by)"
                               + " values('" + CustomerId + "','" + CompanyName + "','" + AssociateCompany + "','" + AuthorisedPerson + "','" + Contact + "','" + Mobile + "','" + OtherContact + "','" + Email + "','" + Address + "','" + BusinessType + "','" + Services + "','" + Pan + "','" + Tan + "','" + Remarks + "','" + OtherDetail + "','" + CIN + "','" + RegistrationNo + "','" + CompanyId + "','" + Createdby + "')";

                    SqlCommand cmd = new SqlCommand(str_insert, Con);
                    Con.Open();
                    int j = cmd.ExecuteNonQuery();
                    Con.Close();
                    //Con.ExecuteNonQry(str_insert);
                    i = i + 1;
                }

                ds = ExucuteDataAdapter("Exec sproc_checkTempInOutClient");
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    lblMsg.Text = ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    DataSet ds2 = new DataSet();
                    ds2 = ExucuteDataAdapter("Exec sproc_InsInOutClients ");
                    lblMsg.Text = ds2.Tables[0].Rows[0][0].ToString();
                }
                System.IO.File.Delete(Server.MapPath(@"ImportFile\\" + filename + ""));
            }
        }
        catch (Exception ex)
        {
            // System.IO.File.Delete(Server.MapPath(@"ImportFile\\" + filename + ""));
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
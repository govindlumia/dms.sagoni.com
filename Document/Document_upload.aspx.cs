using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;

public partial class Document_Document_upload : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    clsSales objsales = new clsSales();
    SqlDataReader objReader;
    string value;
    string SlickTicket = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                ViewState["flag"] = "I";
                objReader = obj_main.dd_document(ViewState["flag"].ToString(), "");
                dd_document.DataSource = objReader;
                dd_document.DataTextField = "document_type";
                dd_document.DataValueField = "document_type";
                dd_document.DataBind();
                dd_document.Items.Insert(0, "Select Document");
                dd_document.Items[0].Value = "0";
                dd_document.SelectedIndex = 0;
                objReader.Close();

                objReader = obj_main.financial_select(ViewState["flag"].ToString(), "");
                ddfinancial.DataSource = objReader;
                ddfinancial.DataTextField = "f_name";
                ddfinancial.DataValueField = "f_name";
                ddfinancial.DataBind();
                ddfinancial.Items.Insert(0, "Select Financial");
                ddfinancial.Items[0].Value = "0";
                ddfinancial.SelectedIndex = 0;
                objReader.Close();

                objReader = obj_main.client_id();
                ddclient.DataSource = objReader;
                ddclient.DataTextField = "customer_id";
                ddclient.DataValueField = "customer_id";
                ddclient.DataBind();
                ddclient.Items.Insert(0, "Select Customer ID");
                ddclient.Items[0].Value = "0";
                ddclient.SelectedIndex = 0;
                objReader.Close();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void Btn_search_Click(object sender, EventArgs e)
    {

    }
    protected void Btn_Add_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddclient.SelectedIndex == 0)
            {
                lbl_error.Text = "Please Select Customer ID";
                return;
            }
            else
            {
                if ((fupload.PostedFile != null) && (fupload.PostedFile.ContentLength > 0))
                {

                    // string fileName =System.DateTime.Now.ToString("ddMMyyhhmmss")+ Path.GetFileName(fupload.PostedFile.FileName) ;
                    string fileName = Path.GetFileName(fupload.PostedFile.FileName);
                    objReader = obj_main.fileupload_check(fileName, ddclient.SelectedValue.ToString());
                    if (objReader.Read())
                    {
                        Lblfileerror.Text = "This File Name Already Exits";
                        Lblfileerror.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    string path = @"~\UploadFile\" + fileName.Trim();
                    int DocMonth = 1;
                    fupload.PostedFile.SaveAs(Server.MapPath(@"~\UploadFile\" + fileName.Trim()));
                    using (SqlConnection sqlConn = new SqlConnection(SlickTicket))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand())
                        {
                            sqlCmd.CommandText = @"insert into document_detail(Customer_Id,document_type,financial_year,fileupload,filepath,created_by,DocMonth,created_on)
                        VALUES (@Customer_Id,@document_type,@financial_year,@fileupload,@filepath,@created_by,@DocType,GETDATE());";
                            sqlCmd.Parameters.AddWithValue("@Customer_Id", ddclient.SelectedValue.ToString());
                            sqlCmd.Parameters.AddWithValue("@document_type", dd_document.SelectedValue.ToString());
                            sqlCmd.Parameters.AddWithValue("@financial_year", ddfinancial.SelectedValue.ToString());
                            sqlCmd.Parameters.AddWithValue("@fileupload", fileName);
                            sqlCmd.Parameters.AddWithValue("@filepath", path);
                            sqlCmd.Parameters.AddWithValue("@DocMonth", DocMonth);
                            sqlCmd.Parameters.AddWithValue("@created_by", Session["user_id"].ToString());
                            sqlCmd.Connection = sqlConn;
                            sqlConn.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlConn.Close();
                            // BindGridviewFileData();
                        }
                    }
                    Lblfileerror.Text = "File Uploaded And Data Submitted Successfully!";
                    Lblfileerror.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    Lblfileerror.Text = "Please Select File To Upload";
                    Lblfileerror.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }

    }
    protected void ddclient_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            objReader = obj_main.Customer_search(ddclient.SelectedValue.ToString());
            if (objReader.Read())
            {
                Txt_Company.Text = objReader["company_name"].ToString();
                Txt_Authorised.Text = objReader["Authorised_person"].ToString();
                Txt_Associate.Text = objReader["Associate_company"].ToString();
                Txt_Mobile.Text = objReader["mobile"].ToString();
                Txt_Email.Text = objReader["email"].ToString();
                Txt_Address.Text = objReader["address"].ToString();
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "This Customer Not In Our Database";
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
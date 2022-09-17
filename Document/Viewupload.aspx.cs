using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Text;

public partial class Document_Viewupload : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds = new DataSet();
    StringBuilder htmlTable = new StringBuilder();

    string SlickTicket = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    maincode obj_main = new maincode();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {

                objReader = obj_main.dd_company();
                ddcompany.DataSource = objReader;
                ddcompany.DataTextField = "company_name";
                ddcompany.DataValueField = "CompanyId";
                ddcompany.DataBind();
                ddcompany.Items.Insert(0, "Select Company");
                ddcompany.Items[0].Value = "0";
                ddcompany.SelectedIndex = 0;
                objReader.Close();


                objReader = obj_main.dd_document("I", "");
                dd_document.DataSource = objReader;
                dd_document.DataTextField = "document_type";
                dd_document.DataValueField = "document_type";
                dd_document.DataBind();
                dd_document.Items.Insert(0, "Select Document");
                dd_document.Items[0].Value = "0";
                dd_document.SelectedIndex = 0;
                objReader.Close();

                objReader = obj_main.financial_select("I", "");
                ddfinancial.DataSource = objReader;
                ddfinancial.DataTextField = "f_name";
                ddfinancial.DataValueField = "f_name";
                ddfinancial.DataBind();
                ddfinancial.Items.Insert(0, "Select Financial");
                ddfinancial.Items[0].Value = "0";
                ddfinancial.SelectedIndex = 0;
                objReader.Close();

                obj_main.company_name = ddcompany.SelectedValue.ToString();
                obj_main.Associate_company = dd_Associate.SelectedValue.ToString();
                obj_main.financial_year = ddfinancial.SelectedValue.ToString();
                obj_main.document_type = dd_document.SelectedValue.ToString();
                //BindData();
                GridView1.DataSource = obj_main.document_detail_select(obj_main);
                GridView1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    maincode main = new maincode();
    private void BindData()
    {
        
        SqlConnection con = new SqlConnection();
        con.ConnectionString = SlickTicket;

        SqlCommand cmd = new SqlCommand("select distinct d.sno as sno ,d.Customer_Id as  Customer_Id,document_type ,financial_year,c.company_name as company_name,  d.COMPANYID, c.Associate_company as Associate_company, fileupload, filepath, convert(char(10), d.created_on, 103) as created_on from document_detail d join customer c on d.Customer_Id = c.Customer_Id and d.COMPANYID = c.COMPANYID ", con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds);

        con.Open();
        //SqlCommand cmd = new SqlCommand("document_detail_select", con);
        //cmd.Parameters.Add(new SqlParameter("@company_name", main.company_name));
        //cmd.Parameters.Add(new SqlParameter("@Associate_company", main.Associate_company));
        //cmd.Parameters.Add(new SqlParameter("@document_type", main.document_type));
        //cmd.Parameters.Add(new SqlParameter("@financial_year", main.financial_year));
        //cmd.CommandType = CommandType.StoredProcedure;
        //da.Fill(ds);
        
        cmd.ExecuteNonQuery();
        con.Close();

        htmlTable.Append("<div class='table-responsive'>");
        htmlTable.Append("<table id='myTable' class='display table' width='100%' >");
        htmlTable.Append("<thead>");
        htmlTable.Append("<tr> <th> companyid </th> <th>Customer_id</th> <th>Document Type</th> <th>Financial Year</th> <th>File Upload</th> <th>Created On</th>  </tr> </thead> <tbody> <tr>");

        if (!object.Equals(ds.Tables[0], null))
        {
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    htmlTable.Append("<tr>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["companyid"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["Customer_id"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["document_type"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["financial_year"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["fileupload"] + "</td>");
                    htmlTable.Append("<td>" + ds.Tables[0].Rows[i]["created_on"] + "</td>");
                    htmlTable.Append("</tr>");
                }
                htmlTable.Append("</tbody>");
                htmlTable.Append("</table>");
                htmlTable.Append("</div>");
               // DBDataPlaceHolder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
            else
            {
                htmlTable.Append("<tr>");
                htmlTable.Append("<td align='center' colspan='4'>There is no Record.</td>");
                htmlTable.Append("</tr>");
            }
        }
    }

    protected void FilesDownload(object sender, EventArgs e)
    {
        try
        {
            string fPath = (sender as LinkButton).CommandArgument;
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(fPath));
            Response.Clear();
            Response.WriteFile(fPath);
            Response.End();
            Response.Close();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void Submit_Btn_Click(object sender, EventArgs e)
    {
        try
        {
            obj_main.company_name = ddcompany.SelectedValue.ToString();
            obj_main.Associate_company = dd_Associate.SelectedValue.ToString();
            obj_main.financial_year = ddfinancial.SelectedValue.ToString();
            obj_main.document_type = dd_document.SelectedValue.ToString();
            GridView1.DataSource = obj_main.document_detail_select(obj_main);
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Delete")
            {
                GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
                Label lblserialno = (Label)row.FindControl("lblserialno");
                obj_main.sno = lblserialno.Text;
                objReader = obj_main.document_detail_image_filter();
                if (objReader.Read())
                {
                    Label1.Text = objReader["fileupload"].ToString();
                    string path = Server.MapPath(@"~/UploadFile/" + Label1.Text);
                    FileInfo file = new FileInfo(path);
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                    else
                    {

                    }
                }
                obj_main.document_detail_delete(obj_main);


                Response.Redirect("~/Document/Viewupload.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }

    protected void ddcompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            objReader = obj_main.dd_Associate_company(ddcompany.SelectedValue);
            dd_Associate.DataSource = objReader;
            dd_Associate.DataTextField = "Customer_Id";
            dd_Associate.DataValueField = "Customer_Id";
            dd_Associate.DataBind();
            dd_Associate.Items.Insert(0, "Select Employee Name");
            dd_Associate.Items[0].Value = "0";
            dd_Associate.SelectedIndex = 0;
            objReader.Close();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
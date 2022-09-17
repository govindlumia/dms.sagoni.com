using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InvestmentDocument_InvestmentView : System.Web.UI.Page
{
    string SlickTicket = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    maincode obj_main = new maincode();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!IsPostBack)
            {
                if (Session["customer_id"] == null || Session["name"] == null)
                {
                    Response.Redirect("~/clientsession.html");
                }
                objReader = obj_main.Investmentdd_document(Session["customer_id"].ToString(), Session["CompanyId"].ToString());
                dd_document.DataSource = objReader;
                dd_document.DataTextField = "DocumentType";
                dd_document.DataValueField = "DocumentType";
                dd_document.DataBind();
                dd_document.Items.Insert(0, "Select Document");
                dd_document.Items[0].Value = "0";
                dd_document.SelectedIndex = 0;
                objReader.Close();

                objReader = obj_main.Investmentfinancial_select(Session["customer_id"].ToString(), Session["CompanyId"].ToString());
                ddfinancial.DataSource = objReader;
                ddfinancial.DataTextField = "FinancialYear";
                ddfinancial.DataValueField = "FinancialYear";
                ddfinancial.DataBind();
                ddfinancial.Items.Insert(0, "Select Financial");
                ddfinancial.Items[0].Value = "0";
                ddfinancial.SelectedIndex = 0;
                objReader.Close();
                obj_main.customer_id = Session["customer_id"].ToString();
                obj_main.financial_year = ddfinancial.SelectedValue.ToString();
                obj_main.document_type = dd_document.SelectedValue.ToString();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
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
                obj_main.InvestmentDocumentDelete(obj_main);


                Response.Redirect("~/InvestmentDocument/InvestmentView.aspx");
            }
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
            if (Session["role"].ToString() == "Company")
            {
                obj_main.branch_name = Session["Company"].ToString();
                obj_main.company_id = Session["CompanyId"].ToString();
                obj_main.financial_year = ddfinancial.SelectedValue.ToString();
                obj_main.document_type = dd_document.SelectedValue.ToString();
                GridView1.DataSource = obj_main.GetInvestmentdocument(obj_main);
                GridView1.DataBind();
            }
            else
            {
                obj_main.customer_id = Session["customer_id"].ToString();
                obj_main.company_id = Session["CompanyId"].ToString();
                obj_main.financial_year = ddfinancial.SelectedValue.ToString();
                obj_main.document_type = dd_document.SelectedValue.ToString();
                GridView1.DataSource = obj_main.GetInvestmentdocument(obj_main);
                GridView1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
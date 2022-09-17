using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InvestmentDocument_InvestmentView_Admin : System.Web.UI.Page
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
                objReader = obj_main.dd_company();
                ddcompany.DataSource = objReader;
                ddcompany.DataTextField = "company_name";
                ddcompany.DataValueField = "CompanyId";
                ddcompany.DataBind();
                ddcompany.Items.Insert(0, "Select Company");
                ddcompany.Items[0].Value = "0";
                ddcompany.SelectedIndex = 0;
                objReader.Close();

                objReader = obj_main.Investmentdd_document("I", "0");
                dd_document.DataSource = objReader;
                dd_document.DataTextField = "document_type";
                dd_document.DataValueField = "document_type";
                dd_document.DataBind();
                dd_document.Items.Insert(0, "Select Document");
                dd_document.Items[0].Value = "0";
                dd_document.SelectedIndex = 0;
                objReader.Close();

                objReader = obj_main.Investmentfinancial_select("I", "0");
                ddfinancial.DataSource = objReader;
                ddfinancial.DataTextField = "f_name";
                ddfinancial.DataValueField = "f_name";
                ddfinancial.DataBind();
                ddfinancial.Items.Insert(0, "Select Financial");
                ddfinancial.Items[0].Value = "0";
                ddfinancial.SelectedIndex = 0;
                objReader.Close();
                
                obj_main.company_name = ddcompany.SelectedValue.ToString();
                obj_main.financial_year = ddfinancial.SelectedValue.ToString();
                obj_main.document_type = dd_document.SelectedValue.ToString();
                //BindData();
                GridView1.DataSource = obj_main.GetInvestmentdocument(obj_main);
                GridView1.DataBind();

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
    protected void Submit_Btn_Click(object sender, EventArgs e)
    {
        try
        {
            //obj_main.company_name = ddcompany.SelectedValue.ToString();
            obj_main.customer_id = dd_Associate.SelectedValue.ToString();
            obj_main.financial_year = ddfinancial.SelectedValue.ToString();
            obj_main.document_type = dd_document.SelectedValue.ToString();
            GridView1.DataSource = obj_main.GetInvestmentdocument(obj_main);
            GridView1.DataBind();

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
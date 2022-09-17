using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class search_value : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    SqlDataReader objReader;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["user_id"] == null || Session["user_name"] == null)
            {
                Response.Redirect("~/Admin_Login.aspx");
            }
            if (Request.QueryString["search_value"] != null)
            {

                Session["search_value"] = Request.QueryString["search_value"].ToString();
                string search_value = Request.QueryString["search_value"].ToString();

                //[customer_serch_view]


                grdenquery.DataSource = obj_main.search_report_select(Request.QueryString["search_value"].ToString(), "Client");
                grdenquery.DataBind();

                grdquotation.DataSource = obj_main.search_report_select(Request.QueryString["search_value"].ToString(), "Document");
                grdquotation.DataBind();

            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void lblLeadNo_Click(object sender, EventArgs e)
    {
        try
        {
            GridViewRow row = (GridViewRow)((LinkButton)sender).NamingContainer;
            Label lblserialno = (Label)row.FindControl("lblserial");
            Response.Redirect("~/Customer/Customer_Entry.aspx?orderId=" + lblserialno.Text);
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }

}
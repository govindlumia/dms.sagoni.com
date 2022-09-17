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

public partial class MasterPage : System.Web.UI.MasterPage
{
    string SlickTicket = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    maincode obj_main = new maincode();
    SqlDataReader objReader;

    protected void Page_Load(object sender, EventArgs e)
    {
        try { 
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/session.html");
        }
        else
        {
            lblusername.Text = Session["name"].ToString();
            string des = Session["role"].ToString();
            if ((Session["role"].ToString() == "User"))
            {
                //ADMIN
                HyperLink18.Visible = false;
                //ADD DROPDOWN
                HyperLink32.Visible = false;
                //CLIENT LOGIN
                HyperLink5.Visible = false;
                //REPORT
                //HyperLink3.Visible = false;
                //Excel Import
                HyperLink9.Visible = false;
                //Company Request Dashboard
                HyperLink10.Visible = false;
                //Reset db table data
                //LinkButtonReset.Visible = false;

            }
            if ((Session["role"].ToString() == "Admin"))
            {
                // HyperLink1.Visible = false;
                //Company Request Dashboard
                HyperLink10.Visible = false;

            }
            if ((Session["role"].ToString() == "Company"))
            {
                //ADMIN
                HyperLink18.Visible = false;
                //ADD DROPDOWN
                HyperLink32.Visible = false;
                //CLIENT LOGIN
                HyperLink5.Visible = false;
                //REPORT
                //HyperLink3.Visible = false;
                //Excel Import
                HyperLink9.Visible = false;
                //Request Dashboard
                HyperLink1.Visible = false;
                //Add Client
                HyperLink25.Visible = false;
                //Add Document
                HyperLink16.Visible = false;
                //Home
                HyperLink8.Visible = false;
                Hypl_att.Visible = false;
                hypl_sale.Visible = false;
                //Reset db table data
               // LinkButtonReset.Visible = false;

            }
        }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void ImgCompany_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/home.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        Session.Abandon();
        Response.Redirect("~/Admin_Login.aspx");

    }
    protected void txtsearch_TextChanged(object sender, EventArgs e)
    {
        obj_main.search_value = txtsearch.Text.ToString();

        Response.Redirect("~/search_value.aspx?search_value=" + txtsearch.Text);
    }

    //protected void LinkButtonReset_Click(object sender, EventArgs e)
    //{
    //    objReader= obj_main.Proc_Resetdata();
    //    if (objReader != null)
    //    { Response.Write("<script>alert('Data Reset successfully')</script>"); }
    //}
}

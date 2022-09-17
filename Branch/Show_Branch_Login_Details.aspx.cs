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
using System.Net.NetworkInformation;

public partial class Show_Branch_Login_Details : System.Web.UI.Page
{

    maincode obj_main = new maincode();

    clsUser objuser = new clsUser();

    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["user_id"] == null || Session["user_name"] == null)
            {
                Response.Redirect("~/Admin_Login.aspx");
            }

            if (!IsPostBack)
            {
                grdLead.DataSource = objuser.crm_user_Detail_select();
                grdLead.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void grdLead_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "edit")
            {

                GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
                Label lblemp_id = (Label)row.FindControl("lblemp_id");
                Response.Redirect("~/Branch/generate_branch.aspx?empid=" + lblemp_id.Text);

            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
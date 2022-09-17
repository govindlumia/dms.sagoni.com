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
using System.Data;
using System.Data.SqlClient;

public partial class ClientPassword : System.Web.UI.Page
{
    SqlDataReader objReader;
    clsUser objuser = new clsUser();
    maincode obj_main = new maincode();
    protected void Page_Load(object sender, EventArgs e)
    {
        try { 
        if (Session["customer_id"] == null || Session["name"] == null)
        {
            Response.Redirect("clientsession.html");
        }
        if (!IsPostBack)
        {
            Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
        }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void btnSubmitt_Click(object sender, EventArgs e)
    {
        try { 
            if (Page.IsValid)
            {
                objReader = objuser.user_login_selectforlogin(Session["username"].ToString(), txtCuurentPass.Text);
                // objReader = objuser.Change_password(, Session["user_id"].ToString());
                if (objReader.Read())
                {
                    Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());
                    objReader = objuser.user_login_Change_password(txtNewPass.Text, Session["user_id"].ToString());
                    lblMsg.Visible = true;
                    lblMsg.Text = "Password changed successfully";
                    txtNewPass.Text = "";
                    txtCuurentPass.Text = "";
                    txtConfPass.Text = "";

                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Current password does not match";
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
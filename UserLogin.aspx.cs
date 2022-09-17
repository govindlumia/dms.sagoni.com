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

public partial class UserLogin : System.Web.UI.Page
{

    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    maincode obj_main = new maincode();
    SqlDataReader objReader, objReader1, objReader2;
    string password, username, ip_address;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string ip_address = HttpContext.Current.Request.UserHostAddress;
            objReader = obj_main.user_login_selectforlogin(txtcode.Text, txtPassword.Text);

            if (objReader.Read())
            {
                Session["role"] = objReader["roles"].ToString();
                //Session["designation"] = objReader["designation"].ToString();
                // string des = Session["designation"].ToString();
                if (Session["role"].ToString() == "Client")
                {
                    rfvEngPass.Validate();
                    rfvempcode.Validate();
                    if (rfvempcode.IsValid && rfvEngPass.IsValid)
                    {
                        password = txtPassword.Text.Trim();
                        username = txtcode.Text.Trim();
                        objReader = obj_main.user_login_selectforlogin(txtcode.Text, txtPassword.Text);
                        if (objReader.Read())
                        {
                            Session["user_id"] = objReader["sno"].ToString();
                            Session["customer_id"] = objReader["customer_id"].ToString();
                            Session["roles"] = objReader["roles"].ToString();
                            Session["name"] = objReader["Authorised_person"].ToString();
                            Session["username"] = objReader["username"].ToString();
                            Session["CompanyId"] = objReader["CompanyId"].ToString();
                            Response.Redirect("~/Document/View_yourfiles.aspx");
                        }
                    }
                }
            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Please Enter Correct User Name and Password";
                Session.Abandon();
                return;
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/UserLogin.aspx");
    }
}
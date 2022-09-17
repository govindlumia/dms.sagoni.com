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

public partial class admin_login : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();

    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            
            string ip_address = HttpContext.Current.Request.UserHostAddress;
            objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);

            if (objReader.Read())
            {

                Session["role"] = objReader["role"].ToString();
                //Session["designation"] = objReader["designation"].ToString();
                // string des = Session["designation"].ToString();
                if (Session["role"].ToString() == "Admin" || Session["role"].ToString() == "User" || Session["role"].ToString() == "Company")
                {
                    rfvEngPass.Validate();
                    rfvempcode.Validate();
                    if (rfvempcode.IsValid && rfvEngPass.IsValid)
                    {
                        password = txtPassword.Text.Trim();
                        empcode = txtcode.Text.Trim();
                        objReader = objuser.crm_user_selectforlogin(txtcode.Text, txtPassword.Text);
                        if (objReader.Read())
                        {
                            Session["user_id"] = objReader["emp_id"].ToString();
                            Session["emp_id"] = objReader["emp_id"].ToString();
                            Session["emp_code"] = objReader["emp_code"].ToString();
                            Session["username"] = objReader["emp_name"].ToString();
                            Session["user_name"] = objReader["emp_name"].ToString();
                            Session["name"] = objReader["user_name"].ToString();
                            Session["Company"] = "1";
                            Session["role"] = objReader["role"].ToString();
                            Response.Redirect("home.aspx");
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
        Response.Redirect("~/Admin_Login.aspx");
    }
}
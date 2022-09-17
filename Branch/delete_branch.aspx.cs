using System;
using System.Collections.Generic;
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

public partial class delete_branch : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    SqlDataReader objReader;
    string value;
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
                objReader = obj_main.Branch_select(1);
                Ddlbranchname.DataSource = objReader;
                Ddlbranchname.DataTextField = "Branch_Name";
                Ddlbranchname.DataValueField = "emp_id";
                Ddlbranchname.DataBind();
                Ddlbranchname.Items.Insert(0, "Select Branch ");
                Ddlbranchname.Items[0].Value = "0";
                Ddlbranchname.SelectedIndex = 0;
                objReader.Close();

            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void submit_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            obj_main.emp_id = Ddlbranchname.SelectedValue.ToString();
            value = obj_main.Branch_deactive(obj_main);
            Response.Redirect("~/Branch/Show_Branch_Login_Details.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void reset_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            Response.Redirect("~/Branch/Show_Branch_Login_Details.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
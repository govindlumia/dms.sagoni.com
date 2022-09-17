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

public partial class ClientMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["role"].ToString() == "Company")
        //{
        //    if (Session["Company"] == null || Session["user_id"] == null)
        //    {
        //        Response.Redirect("~/session.html");
        //    }
        //    else
        //    {
        //        lblusername.Text = Session["name"].ToString();
        //        string des = Session["role"].ToString();
        //    }
        //}
        //else
        //{
        try
        {
            if (Session["customer_id"] == null || Session["name"] == null)
            {
                Response.Redirect("~/clientsession.html");
            }
            else
            {
                lblusername.Text = Session["name"].ToString();
                string des = Session["role"].ToString();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
        // }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        try
        {
            Session.Abandon();
            if (Session["role"].ToString() == "Company")
            {
                Response.Redirect("~/session.html");
            }
            else
            {
                Response.Redirect("~/UserLogin.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}

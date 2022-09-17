using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Request_View_request : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        try { 
        if (!IsPostBack)
        {
            obj_main.created_by = Session["customer_id"].ToString();
            GridView1.DataSource = obj_main.Request_select(obj_main);
            GridView1.DataBind();
        }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
   
    protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
        try { 
        if (e.CommandName == "reopen")
        {

            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            Label lblserialno = (Label)row.FindControl("lblserialno");
            Response.Redirect("~/Request/Submit_Request.aspx?s_no=" + lblserialno.Text);

        }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
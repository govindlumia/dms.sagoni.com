using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ClientLogin_ViewClient_Login : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                obj_main.search_value = Txt_Search.Text;
                GridView1.DataSource = obj_main.user_login_select(obj_main);
                GridView1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Edit")
            {
                GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
                Label lblserialno = (Label)row.FindControl("lblserialno");
                Response.Redirect("~/ClientLogin/Client_insert.aspx?orderId=" + lblserialno.Text);
            }
            if (e.CommandName == "Delete")
            {
                GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
                Label lblserialno = (Label)row.FindControl("lblserialno");
                obj_main.sno = lblserialno.Text;
                obj_main.user_login_delete(obj_main);
                Response.Redirect("ViewClient_Login.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void Submit_Btn_Click(object sender, EventArgs e)
    {
        try { 
        obj_main.search_value = Txt_Search.Text;
        GridView1.DataSource = obj_main.user_login_select(obj_main);
        GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
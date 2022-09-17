using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Request_Viewreq : System.Web.UI.Page
{

    maincode obj_main = new maincode();
    SqlDataReader objReader;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                Txt_From.Text = DateTime.Today.ToShortDateString();
                Txt_to.Text = DateTime.Today.ToShortDateString();
                obj_main.from_date = Convert.ToDateTime(Txt_From.Text);
                obj_main.to_date = Convert.ToDateTime(Txt_to.Text);
                GridView1.DataSource = obj_main.Request_select_Admin(obj_main);
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
                Response.Redirect("~/Request/Request.aspx?s_no=" + lblserialno.Text);

            }
            if (e.CommandName == "Delete")
            {
                GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
                Label lblserialno = (Label)row.FindControl("lblserialno");
                obj_main.sno = lblserialno.Text;
                obj_main.Request_delete(obj_main);
                Response.Redirect("~/Request/Viewreq.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            obj_main.from_date = Convert.ToDateTime(Txt_From.Text);
            obj_main.to_date = Convert.ToDateTime(Txt_to.Text);
            GridView1.DataSource = obj_main.Request_select_Admin(obj_main);
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
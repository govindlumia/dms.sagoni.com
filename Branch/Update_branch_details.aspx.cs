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

public partial class Branch_Update_branch_details : System.Web.UI.Page
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
                objReader = obj_main.Branch_select(1);
                Ddlbranchname.DataSource = objReader;
                Ddlbranchname.DataTextField = "Branch_Name";
                Ddlbranchname.DataValueField = "Branch_Name";
                Ddlbranchname.DataBind();
                Ddlbranchname.Items.Insert(0, "Select Branches ");
                Ddlbranchname.Items[0].Value = "0";
                Ddlbranchname.SelectedIndex = 0;
                objReader.Close();
                // obj_main.agent_name = ddlagent.SelectedValue.ToString();
                obj_main.Branch_Name = Ddlbranchname.SelectedValue.ToString();

                grdLead.DataSource = objuser.crm_user_Detail_select();
                grdLead.DataBind();
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
            obj_main.Branch_Name = Ddlbranchname.SelectedValue.ToString();

            grdLead.DataSource = objuser.crm_user_Detail_select();
            grdLead.DataBind();
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
                Response.Redirect("generate_branch.aspx?empid=" + lblemp_id.Text);
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
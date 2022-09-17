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

public partial class ClientLogin_Client_insert : System.Web.UI.Page
{
    SqlDataReader objReader;
    maincode obj_main = new maincode();
    string data;
    protected void Page_Load(object sender, EventArgs e)
    {
        try { 
        if (!IsPostBack)
        {
            ViewState["flag"] = "I";
            objReader = obj_main.ddstatu_s();
            ddstatus.DataSource = objReader;
            ddstatus.DataTextField = "sname";
            ddstatus.DataValueField = "sname";
            ddstatus.DataBind();
            ddstatus.Items.Insert(0, "Select Status");
            ddstatus.Items[0].Value = "0";
            ddstatus.SelectedIndex = 0;
            objReader.Close();

            objReader = obj_main.dd_company();
            ddcompany.DataSource = objReader;
            ddcompany.DataTextField = "company_name";
            ddcompany.DataValueField = "CompanyId";
            ddcompany.DataBind();
            ddcompany.Items.Insert(0, "Select Company");
            ddcompany.Items[0].Value = "0";
            ddcompany.SelectedIndex = 0;
            objReader.Close();
           
            if (Request.QueryString["orderId"] != null)
            {

                objReader = obj_main.user_login_view(Request.QueryString["orderId"].ToString());
                if (objReader.Read())
                {
                    dd_Associate.Enabled = false;
                    dd_Associate.SelectedValue = objReader["customer_id"].ToString();
                    ddstatus.SelectedValue = objReader["status_s"].ToString();
                    Txt_username.Text = objReader["username"].ToString();
                    Txt_pass.Text = objReader["password"].ToString();
                    ddcompany.Text = objReader["Authorised_person"].ToString();
                }
                ViewState["flag"] = "U";
            }
        }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try { 
        obj_main.customer_id = dd_Associate.SelectedValue.ToString();
        obj_main.role = "Client";
        obj_main.status = ddstatus.SelectedValue.ToString();
        obj_main.username = Txt_username.Text;
        obj_main.password = Txt_pass.Text;
        obj_main.Authorised_person = ddcompany.Text;
        obj_main.created_by = Session["user_id"].ToString();
        lblmsg.Visible = false;
        if (ViewState["flag"].ToString() == "I")
        {
            objReader = obj_main.user_login_check(Txt_username.Text);
            if (objReader.Read())
            {
                if (objReader["username"].ToString() != Txt_username.Text)
                {
                    lblmsg.Visible = false;
                    lblmsg.Text = "";


                }
               else if (Txt_username.Text=="")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Please Enter User Name ";


                }
                else if (Txt_pass.Text == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Please Enter Password ";


                }
                else
                {

                    lblmsg.Visible = true;
                    lblmsg.Text = " User Name Already Exist Please try For Another  User Name";
                    return;

                }
            }
            objReader = obj_main.client_login_check(dd_Associate.SelectedValue.ToString());
            if (objReader.Read())
            {
                if (objReader["customer_id"].ToString() != dd_Associate.SelectedValue.ToString())
                {
                    lblmsg.Visible = false;
                    lblmsg.Text = "";


                }
                else if (Txt_username.Text == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Please Enter User Name ";


                }
                else if (Txt_pass.Text == "")
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Please Enter Password ";


                }
                else
                {

                    lblmsg.Visible = true;
                    lblmsg.Text = " Sorry Only One UserName Provided For Client ";
                    return;

                }
            }
            obj_main.flag = "I";
            obj_main.sno = "0";
           

            data = obj_main.user_login_insert(obj_main);
        }
        else if (ViewState["flag"].ToString() == "U")
        {
            obj_main.flag = "U";
           // objuser.emp_id = "0";
           // objuser.active = "Inactive";
            obj_main.sno = Request.QueryString["orderId"];
            data = obj_main.user_login_insert(obj_main);

        }

        Response.Redirect("~/ClientLogin/ViewClient_Login.aspx");

        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }

    }

    protected void reset_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/ClientLogin/Client_insert.aspx");
    }

    protected void ddcompany_SelectedIndexChanged(object sender, EventArgs e)
    {
        try { 
        objReader = obj_main.dd_Associate_company(ddcompany.SelectedValue);
        dd_Associate.DataSource = objReader;
        dd_Associate.DataTextField = "Customer_Id";
        dd_Associate.DataValueField = "Customer_Id";
        dd_Associate.DataBind();
        dd_Associate.Items.Insert(0, "Select Employee Name");
        dd_Associate.Items[0].Value = "0";
        dd_Associate.SelectedIndex = 0;
        objReader.Close();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    
}
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

public partial class generate_branch : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    maincode obj_main = new maincode();
    string value;
    
    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address,data;
    protected void Page_Load(object sender, EventArgs e)
    {
        ddcompany.Visible = false;
        if (Session["user_id"] == null || Session["user_name"] == null)
        {
            Response.Redirect("~/Admin_Login.aspx");
        }

        if (!IsPostBack)
        {
            ViewState["flag"] = "I";

            objReader = obj_main.ddrol_e();
            ddrole.DataSource = objReader;
            ddrole.DataTextField = "rname";
            ddrole.DataValueField = "rname";
            ddrole.DataBind();
            ddrole.Items.Insert(0, "Select Role");
            ddrole.Items[0].Value = "0";
            ddrole.SelectedIndex = 0;
            objReader.Close();

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
            ddcompany.DataValueField = "company_name";
            ddcompany.DataBind();
            ddcompany.Items.Insert(0, "Select Company");
            ddcompany.Items[0].Value = "0";
            ddcompany.SelectedIndex = 0;
            objReader.Close();

            if (Request.QueryString["empid"] != null)
            {


                objReader = obj_main.crm_user_Detail_update(Request.QueryString["empid"].ToString());
                if (objReader.Read())
                {

                    ddrole.SelectedValue = objReader["role"].ToString();
                    Txtbranchname.Text = objReader["Branch_Name"].ToString();
                    Txtauthperson.Text = objReader["emp_name"].ToString();
                    txtBranchuser.Text = objReader["emp_code"].ToString();
                    Txtauthmob.Text = objReader["mobile_no"].ToString();
                    txtadd.Text = objReader["address"].ToString();
                    Txtpasscode.Text = objReader["password"].ToString();
                    ddstatus.SelectedValue = objReader["active"].ToString();
                 
                }
                ViewState["flag"] = "U";
            }
        }
    }
    protected void submit_Click(object sender, ImageClickEventArgs e)
    {
        if (ddrole.SelectedIndex == 3)
        {
           
            objuser.Branch_Name = ddcompany.SelectedValue.ToString();
        }
        else
        {
            objuser.Branch_Name = Txtbranchname.Text;
            
        }

        objuser.role = ddrole.SelectedValue.ToString();
        
        objuser.emp_name = Txtauthperson.Text;
        objuser.emp_code =txtBranchuser.Text;
        objuser.mobile_no = Txtauthmob.Text;
        objuser.address = txtadd.Text;
        objuser.password = Txtpasscode.Text;
        
        // objuser.flag = "I";
        objuser.active = ddstatus.SelectedValue.ToString();
        objuser.created_by = Session["user_id"].ToString();


        lblmsg.Visible = false;
        if (ViewState["flag"].ToString() == "I")
        {
            objReader = objuser.crm_user_login_check(txtBranchuser.Text);
            if (objReader.Read())
            {
                if (objReader["emp_code"].ToString() != txtBranchuser.Text)
                {
                    lblmsg.Visible = false;
                    lblmsg.Text = "";


                }
                else
                {

                    lblmsg.Visible = true;
                    lblmsg.Text = " User Name Already Exist Please try For Another  User Name";
                    return;

                }
            }
            objuser.flag = "I";
            objuser.emp_id = "0";
           

            data = objuser.crm_user_insert(objuser);
        }
        else if (ViewState["flag"].ToString() == "U")
        {
            objuser.flag = "U";
           // objuser.emp_id = "0";
           // objuser.active = "Inactive";
            objuser.emp_id =Request.QueryString["empid"];
            data = objuser.crm_user_insert(objuser);

        }

        Response.Redirect("~/Branch/Show_Branch_Login_Details.aspx");



    }

    protected void ddrole_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddrole.SelectedIndex == 3)
        {
            ddcompany.Visible = true;
            Txtbranchname.Visible = false;
        }
        else
        {
            ddcompany.Visible = false;
            Txtbranchname.Visible = true;
        }

    }

    protected void reset_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Branch/generate_branch.aspx");

    }
}
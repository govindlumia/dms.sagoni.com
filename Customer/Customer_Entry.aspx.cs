using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Customer_Customer_Entry : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    clsSales objsales = new clsSales();
    SqlDataReader objReader;
    string value;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                Txt_Birth.Text = DateTime.Now.ToShortDateString();
                ViewState["flag"] = "I";
                objReader = obj_main.dd_company();
                ddcompany.DataSource = objReader;
                ddcompany.DataTextField = "company_name";
                ddcompany.DataValueField = "company_name";
                ddcompany.DataBind();
                ddcompany.Items.Insert(0, "Select Company");
                ddcompany.Items[0].Value = "0";
                ddcompany.SelectedIndex = 0;
                objReader.Close();
                if (Request.QueryString["orderId"] != null)
                {

                    objReader = obj_main.customer_select_view(Request.QueryString["orderId"].ToString());
                    if (objReader.Read())
                    {
                        Txt_Reg.Text = objReader["registrationno"].ToString();
                        Txt_Cin.Text = objReader["CIN"].ToString();
                        Txt_Birth.Text = objReader["birth"].ToString();
                        ddcompany.SelectedValue = objReader["company_name"].ToString();
                        Txt_associatecompany.Text = "No Data";
                        Txt_Authorised.Text = objReader["Authorised_person"].ToString();
                        Txt_Contact.Text = objReader["contact"].ToString();
                        Txt_Mobile.Text = objReader["mobile"].ToString();
                        Txt_othercontact.Text = objReader["other_contact"].ToString();
                        Txt_Email.Text = objReader["email"].ToString();
                        Txt_Address.Text = objReader["address"].ToString();
                        Txt_Businesstype.Text = objReader["business_type"].ToString();
                        Txt_services.Text = objReader["bu_service"].ToString();
                        Txt_pan.Text = objReader["pan"].ToString();
                        Txt_tan.Text = objReader["ta_n"].ToString();
                        Txt_remarks.Text = objReader["remarks"].ToString();
                        Txt_otherdetails.Text = objReader["other_detail"].ToString();
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
    protected void Btn_Submit_Click(object sender, EventArgs e)
    {
        try
        {
            obj_main.CIN = Txt_Cin.Text;
            obj_main.birth = Convert.ToDateTime(Txt_Birth.Text);
            obj_main.registrationno = Txt_Reg.Text;
            obj_main.company_name = ddcompany.SelectedValue.ToString();
            obj_main.Associate_company = Txt_associatecompany.Text;
            obj_main.Authorised_person = Txt_Authorised.Text;
            obj_main.Contact_Person = Txt_Contact.Text;
            obj_main.mobile = Txt_Mobile.Text;
            obj_main.other_contact = Txt_othercontact.Text;
            obj_main.email = Txt_Email.Text;
            obj_main.address = Txt_Address.Text;
            obj_main.business_type = Txt_Businesstype.Text;
            obj_main.bu_service = Txt_services.Text;
            obj_main.pan = Txt_pan.Text;
            obj_main.ta_n = Txt_tan.Text;
            obj_main.remark = Txt_remarks.Text;
            obj_main.other_detail = Txt_otherdetails.Text;
            obj_main.created_by = Session["user_id"].ToString();
            if (ViewState["flag"].ToString() == "I")
            {
                objReader = obj_main.CheckExistingclient(ddcompany.SelectedValue.ToString(), Txt_associatecompany.Text);
                if (objReader.Read())
                {

                    lblduplicacy.Visible = true;
                    lblduplicacy.Text = "Company and its Associated Company already registered";
                    return;
                }
                objReader.Close();
                obj_main.flag = "I";
                obj_main.sno = "0";

                value = obj_main.Customer_insert(obj_main);
            }
            else if (ViewState["flag"].ToString() == "U")
            {
                obj_main.flag = "U";
                obj_main.sno = Request.QueryString["orderId"].ToString();
                value = obj_main.Customer_insert(obj_main);
            }
            Response.Redirect("~/Customer/ViewCustomer.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void Btn_reset_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("~/Customer/Customer_Entry.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
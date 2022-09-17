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

public partial class Company_Add_com_document : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    clsSales objsales = new clsSales();
    SqlDataReader objReader;
    string value;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["user_id"] == null || Session["user_name"] == null)
            {
                Response.Redirect("~/session.html");
            }
            if (!IsPostBack)
            {
                ViewState["flag"] = "I";

                if (Request.QueryString["orderId"] != null)
                {

                    objReader = obj_main.company_select_view(Request.QueryString["orderId"].ToString());
                    if (objReader.Read())
                    {

                        Txt_Company_Name.Text = objReader["company_name"].ToString();
                    }
                    ViewState["flag"] = "U";
                }
                if (Request.QueryString["documentId"] != null)
                {

                    objReader = obj_main.document_select_view(Request.QueryString["documentId"].ToString());
                    if (objReader.Read())
                    {

                        Txt_document.Text = objReader["document_type"].ToString();
                    }
                    ViewState["flag"] = "U";
                }
                if (Request.QueryString["financial"] != null)
                {

                    objReader = obj_main.financial_select_view_update(Request.QueryString["financial"].ToString());
                    if (objReader.Read())
                    {

                        Txt_financial.Text = objReader["f_name"].ToString();
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
    protected void Btn_Comp_Click(object sender, EventArgs e)
    {
        try
        {
            if (Txt_Company_Name.Text == "" || Txt_Company_Name.Text == null)
            {
                lbl_comperror.Text = "Please Enter Company Name";
                return;
            }
            else
            {
                obj_main.company_name = Txt_Company_Name.Text;
                obj_main.created_by = Session["user_id"].ToString();
                if (ViewState["flag"].ToString() == "I")
                {
                    objReader = obj_main.CheckExistingcomp(Txt_Company_Name.Text);
                    if (objReader.Read())
                    {
                        lbl_comperror.Visible = true;
                        lbl_comperror.Text = "Company already registered";
                        lbl_comperror.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    objReader.Close();
                    obj_main.flag = "I";
                    obj_main.sno = "0";

                    value = obj_main.company_Insert(obj_main);
                    lbl_comperror.Text = "Successfully Added Company Name";
                    lbl_comperror.ForeColor = System.Drawing.Color.Green;
                }
                else if (ViewState["flag"].ToString() == "U")
                {
                    objReader = obj_main.CheckExistingcomp(Txt_Company_Name.Text);
                    if (objReader.Read())
                    {
                        lbl_comperror.Visible = true;
                        lbl_comperror.Text = "Company already registered";
                        return;
                    }
                    objReader.Close();
                    obj_main.flag = "U";
                    obj_main.sno = Request.QueryString["orderId"].ToString();
                    value = obj_main.company_Insert(obj_main);
                    lbl_comperror.Text = "Successfully Updated Company Name";
                    lbl_comperror.ForeColor = System.Drawing.Color.Green;
                }
                Txt_Company_Name.Text = "";
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void Btn_document_Click(object sender, EventArgs e)
    {
        try
        {
            if (Txt_document.Text == "" || Txt_document.Text == null)
            {
                lbl_document_error.Text = "Please Enter Document Type";
                return;
            }
            else
            {
                obj_main.document_type = Txt_document.Text;
                obj_main.created_by = Session["user_id"].ToString();
                if (ViewState["flag"].ToString() == "I")
                {
                    objReader = obj_main.CheckExistingdoctype(Txt_document.Text);
                    if (objReader.Read())
                    {
                        lbl_document_error.Visible = true;
                        lbl_document_error.Text = "Document Type already Exist";
                        lbl_document_error.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    objReader.Close();
                    obj_main.flag = "I";
                    obj_main.sno = "0";

                    value = obj_main.document_Insert(obj_main);
                    lbl_document_error.Visible = true;
                    lbl_document_error.Text = "Successfully Added Document Type";
                    lbl_document_error.ForeColor = System.Drawing.Color.Green;
                }
                else if (ViewState["flag"].ToString() == "U")
                {
                    objReader = obj_main.CheckExistingdoctype(Txt_document.Text);
                    if (objReader.Read())
                    {
                        lbl_document_error.Visible = true;
                        lbl_document_error.Text = "Document Type already Exist";
                        lbl_document_error.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    objReader.Close();
                    obj_main.flag = "U";
                    obj_main.sno = Request.QueryString["documentId"].ToString();
                    value = obj_main.document_Insert(obj_main);
                    lbl_document_error.Text = "Successfully Updated Document Type";
                    lbl_document_error.ForeColor = System.Drawing.Color.Green;
                }
                Txt_document.Text = "";
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void Btn_Financial_Click(object sender, EventArgs e)
    {
        try
        {
            if (Txt_financial.Text == "" || Txt_financial.Text == null)
            {
                lblfinancial.Text = "Please Enter Financial Year";
                return;
            }
            else
            {
                obj_main.financial = Txt_financial.Text;
                obj_main.created_by = Session["user_id"].ToString();
                if (ViewState["flag"].ToString() == "I")
                {
                    objReader = obj_main.CheckExistingfinyr(Txt_financial.Text);
                    if (objReader.Read())
                    {
                        lblfinancial.Visible = true;
                        lblfinancial.Text = "Financial Year already Exist";
                        lblfinancial.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    objReader.Close();
                    obj_main.flag = "I";
                    obj_main.f_id = "0";

                    value = obj_main.financial_Insert(obj_main);
                    lblfinancial.Text = "Successfully Added New Financial Year";
                    lblfinancial.ForeColor = System.Drawing.Color.Green;
                }
                else if (ViewState["flag"].ToString() == "U")
                {
                    objReader = obj_main.CheckExistingfinyr(Txt_financial.Text);
                    if (objReader.Read())
                    {
                        lblfinancial.Visible = true;
                        lblfinancial.Text = "Financial Year already Exist";
                        lblfinancial.ForeColor = System.Drawing.Color.Red;
                        return;
                    }
                    objReader.Close();
                    obj_main.flag = "U";
                    obj_main.f_id = Request.QueryString["financial"].ToString();
                    value = obj_main.financial_Insert(obj_main);
                    lblfinancial.Text = "Successfully Updated Financial Year";
                    lblfinancial.ForeColor = System.Drawing.Color.Green;
                }
                Txt_financial.Text = "";
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }

}
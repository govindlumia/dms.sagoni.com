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

public partial class Request_Submit_Request : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    clsSales objsales = new clsSales();
    SqlDataReader objReader;
    string value;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["role"].ToString() == "Company")
            {
                ViewState["flag"] = "I";
                if (Session["Company"].ToString() != null)
                {
                    pnlreq.Visible = true;
                    objReader = obj_main.Request_select_view(Request.QueryString["s_no"].ToString());
                    if (objReader.Read())
                    {
                        Txt_discription.Text = objReader["desription"].ToString();
                        Txt_subject.Text = objReader["subject"].ToString();
                        ddstatus.SelectedValue = objReader["STATUS"].ToString();
                        obj_main.sno = Request.QueryString["s_no"].ToString();
                    }
                    ViewState["flag"] = "U";
                }



            }
            else
            {
                if (Session["customer_id"] == null || Session["name"] == null)
                {
                    Response.Redirect("~/clientsession.html");
                }
                if (!IsPostBack)
                {
                    ViewState["flag"] = "I";


                    if (Request.QueryString["s_no"] != null)
                    {
                        pnlreq.Visible = true;
                        objReader = obj_main.Request_select_view(Request.QueryString["s_no"].ToString());
                        if (objReader.Read())
                        {
                            Txt_discription.Text = objReader["desription"].ToString();
                            Txt_subject.Text = objReader["subject"].ToString();
                            ddstatus.SelectedValue = objReader["STATUS"].ToString();
                            obj_main.sno = Request.QueryString["s_no"].ToString();
                        }
                        ViewState["flag"] = "U";
                    }


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
            if (ViewState["flag"].ToString() == "I")
            {
                obj_main.flag = "I";
                obj_main.sno = "0";
                obj_main.STATUS = "Pending";
                obj_main.subject = Txt_subject.Text;
                obj_main.description = Txt_discription.Text;
                obj_main.created_by = Session["customer_id"].ToString();
                value = obj_main.Request_insert(obj_main);
            }
            else if (ViewState["flag"].ToString() == "U")
            {

                pnlreq.Visible = true;
                obj_main.flag = "U";
                obj_main.sno = Request.QueryString["s_no"].ToString();
                obj_main.STATUS = ddstatus.SelectedValue.ToString();

                obj_main.subject = Txt_subject.Text;
                obj_main.description = Txt_discription.Text;
                obj_main.created_by = Session["customer_id"].ToString();
                value = obj_main.Request_insert(obj_main);
            }

            Response.Redirect("~/Request/View_request.aspx");
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
            Response.Redirect("~/Request/View_request.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
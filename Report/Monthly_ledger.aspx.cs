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

public partial class Report_Monthly_ledger : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    SqlDataReader objReader;
    clsSales objsales = new clsSales();

    decimal Totalexpanse = 0, Totalexpanse1 = 0, Totalexpanse2 = 0, Totalexpanse3 = 0, trcv = 0, tdues = 0, prcv = 0, pdues = 0;
    decimal Totaldues = 0, Totaldues1 = 0, Totaldues2 = 0;
    decimal Totalrcv = 0, Totalrcv1 = 0, Totalrcv2 = 0, Totalamount = 0, Totalamount1 = 0, Totalamount2 = 0, Totalrendues = 0, Totalrendues1 = 0;
    int Totalatt1 = 0, Totalatt2 = 0, Totalatt3 = 0, Totalatt4 = 0, Totalatt5 = 0, Totalatt6 = 0, Totalatt7 = 0;
    decimal t_expan_dues = 0, t_expan_dues1 = 0, t_exp_col = 0, t_exp_col1 = 0;

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
                txtfromdate.Text = DateTime.Today.ToShortDateString();
                txttodate.Text = DateTime.Today.ToShortDateString();
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            obj_main.from_date = Convert.ToDateTime(txtfromdate.Text);
            obj_main.to_date = Convert.ToDateTime(txttodate.Text);

            grden.DataSource = obj_main.enquery_Ledger_report(obj_main);
            grden.DataBind();

            grdquo.DataSource = obj_main.quotation_Ledger_report(obj_main);
            grdquo.DataBind();

            grdinv.DataSource = obj_main.Invoice_Ledger_report(obj_main);
            grdinv.DataBind();

            grdpo.DataSource = obj_main.purchase_Ledger_report(obj_main);
            grdpo.DataBind();

            grdvendor.DataSource = obj_main.vendor_Ledger_report(obj_main);
            grdvendor.DataBind();

            grdstaff.DataSource = obj_main.employee_Ledger_report(obj_main);
            grdstaff.DataBind();

            grdofficeex.DataSource = obj_main.Expense_Entry_SELECT(obj_main);
            grdofficeex.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }

    protected void back_buton_Click1(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("~/home.aspx");
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }

    }
}
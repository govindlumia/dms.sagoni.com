using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;

public partial class Report_Client_Report : System.Web.UI.Page
{
    SqlDataReader objReader;
    maincode obj_main = new maincode();
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
                txtfromdate.Text = DateTime.Today.ToShortDateString();
                txttodate.Text = DateTime.Today.ToShortDateString();
                obj_main.from_date = Convert.ToDateTime(txtfromdate.Text);
                obj_main.to_date = Convert.ToDateTime(txttodate.Text);
                grdLead.DataSource = obj_main.Customer_select_Report(obj_main);
                grdLead.DataBind();

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
            grdLead.DataSource = obj_main.Customer_select_Report(obj_main);
            grdLead.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    protected void btnExcell_Click(object sender, EventArgs e)
    {
        try
        {
            string serach_criteria, from_date, to_date;
            obj_main.from_date = Convert.ToDateTime(txtfromdate.Text);
            obj_main.to_date = Convert.ToDateTime(txttodate.Text);

            grdLead.DataSource = obj_main.Customer_select_Report(obj_main);
            grdLead.DataBind();


            obj_main.Customer_select_Report(obj_main);
            PrepareGridViewForExport(grdLead);
            ExportGridview();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    private void ExportGridview()
    {
        try
        {
            string attachment = "attachment; filename=Client_Report.xls";
            Response.ClearContent();
            Response.AddHeader("content-disposition", attachment);
            Response.ContentType = "application/ms-excel";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            grdLead.RenderControl(htw);
            Response.Write(sw.ToString());
            Response.End();
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        // Confirms that an HtmlForm control is rendered for the
        //specified ASP.NET server control at run time.
    }
    private void PrepareGridViewForExport(Control gv)
    {
        try
        {
            LinkButton lb = new LinkButton();
            Literal l = new Literal();
            string name = String.Empty;
            for (int i = 0; i < gv.Controls.Count; i++)
            {

                if (gv.Controls[i].GetType() == typeof(LinkButton))
                {

                    l.Text = (gv.Controls[i] as LinkButton).Text;

                    gv.Controls.Remove(gv.Controls[i]);

                    gv.Controls.AddAt(i, l);

                }
                if (gv.Controls[i].GetType() == typeof(ImageButton))
                {

                    // l.Text = (gv.Controls[i] as ImageButton);

                    gv.Controls.Remove(gv.Controls[i]);

                    gv.Controls.AddAt(i, l);

                }

                else if (gv.Controls[i].GetType() == typeof(DropDownList))
                {

                    l.Text = (gv.Controls[i] as DropDownList).SelectedItem.Text;

                    gv.Controls.Remove(gv.Controls[i]);

                    gv.Controls.AddAt(i, l);

                }

                else if (gv.Controls[i].GetType() == typeof(CheckBox))
                {

                    l.Text = (gv.Controls[i] as CheckBox).Checked ? "True" : "False";

                    gv.Controls.Remove(gv.Controls[i]);

                    gv.Controls.AddAt(i, l);

                }

                if (gv.Controls[i].HasControls())
                {

                    PrepareGridViewForExport(gv.Controls[i]);


                }

            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}
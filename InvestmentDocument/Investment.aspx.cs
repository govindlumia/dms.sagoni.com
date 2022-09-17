using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InvestmentDocument_Investment : System.Web.UI.Page
{
    maincode obj_main = new maincode();
    clsSales objsales = new clsSales();
    SqlDataReader objReader;
    string value;
    string SlickTicket = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["role"] == null)
            {
                Response.Redirect("~/UserLogin.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    ViewState["flag"] = "I";
                    objReader = obj_main.dd_document(ViewState["flag"].ToString(), "");
                    DropDownList1.DataSource = objReader;
                    DropDownList1.DataTextField = "document_type";
                    DropDownList1.DataValueField = "document_type";
                    DropDownList1.DataBind();
                    DropDownList1.Items.Insert(0, "Select Document");
                    DropDownList1.Items[0].Value = "0";
                    DropDownList1.SelectedIndex = 0;
                    objReader.Close();

                    objReader = obj_main.financial_select(ViewState["flag"].ToString(), "");
                    DropDownList2.DataSource = objReader;
                    DropDownList2.DataTextField = "f_name";
                    DropDownList2.DataValueField = "f_name";
                    DropDownList2.DataBind();
                    DropDownList2.Items.Insert(0, "Select Financial");
                    DropDownList2.Items[0].Value = "0";
                    DropDownList2.SelectedIndex = 0;
                    objReader.Close();
                }
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
            if (DropDownList1.SelectedIndex == 0)
            {
                Response.Write(@"<script language='javascript'>alert('Please Select Customer ID.');</script>");
                return;
            }
            else
            {
                string customerId = Session["customer_id"].ToString();
                if ((fupload.PostedFile != null) && (fupload.PostedFile.ContentLength > 0))
                {

                    string fileName =System.DateTime.Now.ToString("ddMMyyhhmmss")+ Path.GetFileName(fupload.PostedFile.FileName) ;
                   // string fileName = Path.GetFileName(fupload.PostedFile.FileName);
                    objReader = obj_main.Investmentfileupload_check(fileName, customerId);
                    if (objReader.Read())
                    {
                        Lblfileerror.Text = "This File Name Already Exits";
                        Lblfileerror.ForeColor = System.Drawing.Color.Red;
                        return;
                    }

                    string path = @"~\UploadInvestment\" + fileName.Trim();
                    int DocMonth = 1;
                    fupload.PostedFile.SaveAs(Server.MapPath(@"~\UploadInvestment\" + fileName.Trim()));
                    using (SqlConnection sqlConn = new SqlConnection(SlickTicket))
                    {
                        using (SqlCommand sqlCmd = new SqlCommand())
                        {
                            sqlCmd.CommandText = @"insert into tbl_InvestmentDocument(DocumentType,FinancialYear,FileUpload,filepath,Remark,CREATEDBY,CREATEDDATE)
                        VALUES (@DocumentType,@FinancialYear,@FileUpload,@filepath,@Remark,@CREATEDBY,GETDATE());";
                            sqlCmd.Parameters.AddWithValue("@DocumentType", DropDownList1.SelectedValue.ToString());
                            sqlCmd.Parameters.AddWithValue("@FinancialYear", DropDownList2.SelectedValue.ToString());
                            sqlCmd.Parameters.AddWithValue("@FileUpload", fileName);
                            sqlCmd.Parameters.AddWithValue("@filepath", path);
                            sqlCmd.Parameters.AddWithValue("@Remark", txtRemark.Text);
                            sqlCmd.Parameters.AddWithValue("@CREATEDBY", Session["customer_id"].ToString());
                            sqlCmd.Connection = sqlConn;
                            sqlConn.Open();
                            sqlCmd.ExecuteNonQuery();
                            sqlConn.Close();
                            // BindGridviewFileData();
                        }
                    }
                    Lblfileerror.Text = "File Uploaded And Data Submitted Successfully!";
                    Lblfileerror.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    Lblfileerror.Text = "Please Select File To Upload";
                    Lblfileerror.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }
        }
        catch (Exception ex)
        {
            Response.Write(@"<script language='javascript'>alert('The following errors have occurred:\n" + ex.ToString() + " .');</script>");
        }
    }
}

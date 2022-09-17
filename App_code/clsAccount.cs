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

/// <summary>
/// Summary description for clsAccount
/// </summary>
public class clsAccount
{
    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    DataTable dt;
    DataTable objDataTable;
    public clsAccount()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    
    private string _customerName;
    public string customerName
    {
        get
        {
            return _customerName;
        }
        set
        {
            _customerName = value;
        }
    }
    private string _invoiceno;
     public string invoiceno
    {
        get
        {
            return _invoiceno;
        }
        set
        {
            _invoiceno = value;
        }
    }
    
    private string _collected_by;
    public string collected_by
    {

        get
        {
            return _collected_by;
        }
        set
        {
            _collected_by = value;
        }
    }
    private string _collected_amount;
    public string collected_amount
    {
        get
        {
            return _collected_amount;
        }
        set
        {
            _collected_amount = value;
        }
    }

    private string _collection_status;
    public string collection_status
    {
        get
        {
            return _collection_status;
        }
        set
        {
            _collection_status = value;
        }
    }
      
         private string _Repair_Invoice_no;
         public string Repair_Invoice_no
    {
        get
        {
            return _Repair_Invoice_no;
        }
        set
        {
            _Repair_Invoice_no = value;
        }
    }


    private string _Refund_invoice_no;
     public string Refund_invoice_no
    {
        get
        {
            return _Refund_invoice_no;
        }
        set
        {
            _Refund_invoice_no = value;
        }
    }

    private string _customerType;
    public string customerType
    {
        get
        {
            return _customerType;
        }
        set
        {
            _customerType = value;
        }
    }

    private string _fname;
    public string fname
    {
        get
        {
            return _fname;
        }
        set
        {
            _fname = value;
        }
    }
    private string _lanme;
    public string Lname
    {
        get
        {
            return _lanme;
        }
        set
        {
            _lanme = value;
        }
    }
    private string _professional_email;
    public string professional_email
    {
        get
        {
            return _professional_email;
        }
        set
        {
            _professional_email = value;
        }
    }
    private string _personal_email;
    public string personal_email
    {
        get
        {
            return _personal_email;
        }
        set
        {
            _personal_email = value;
        }
    }
    private string _Phoneno;
    public string Phoneno
    {
        get
        {
            return _Phoneno;
        }
        set
        {
            _Phoneno = value;
        }
    }
    private string _mobile_no;
    public string mobile_no
    {
        get
        {
            return _mobile_no;
        }
        set
        {
            _mobile_no = value;
        }
    }
    private string _fax;
    public string fax
    {
        get
        {
            return _fax;
        }
        set
        {
            _fax = value;
        }
    }

    private string _Locationname;
    public string Locationname
    {
        get
        {
            return _Locationname;
        }
        set
        {
            _Locationname = value;
        }
    }
    private string _address;
    public string address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }
    private string _city;
    public string city
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }
    private string _postalCode;
    public string postalCode
    {
        get
        {
            return _postalCode;
        }
        set
        {
            _postalCode = value;
        }
    }
    private string _country;
    public string country
    {
        get
        {
            return _country;
        }
        set
        {
            _country = value;
        }
    }

    private string _customerId;
    public string customerId
    {
        get
        {
            return _customerId;
        }
        set
        {
            _customerId = value;
        }
    }


    private string _permission;
    public string Permission
    {
        get
        {
            return _permission;
        }
        set
        {
            _permission = value;
        }
    }
    private string _created_by;
    public string created_by
    {
        get
        {
            return _created_by;
        }
        set
        {
            _created_by = value;
        }
    }

    private string _flag;
    public string flag
    {
        get
        {
            return _flag;
        }
        set
        {
            _flag = value;
        }
    }
    private string _comp_id;
    public string compId
    {
        get
        {
            return _comp_id;
        }
        set
        {
            _comp_id = value;
        }
    }
    private string _companyName;
    public string companyName
    {
        get
        {
            return _companyName;
        }
        set
        {
            _companyName = value;
        }
    }

    private string _serviceType;
    public string servicetype
    {
        get
        {
            return _serviceType;
        }
        set
        {
            _serviceType = value;
        }
    }
    private string _NoOfNode;
    public string NoOfNode
    {
        get
        {
            return _NoOfNode;
        }
        set
        {
            _NoOfNode = value;
        }
    }
    private string _discount;
    public string Discount
    {
        get
        {
            return _discount;
        }
        set
        {
            _discount = value;
        }
    }
    private string _service;
    public string Service
    {
        get
        {
            return _service;
        }
        set
        {
            _service = value;
        }
    }

    private decimal _amount;
    public decimal Amount
    {
        get
        {
            return _amount;
        }
        set
        {
            _amount = value;
        }
    }
  
    private string _serial_no;
    public string serial_no
    {
        get
        {
            return _serial_no;
        }
        set
        {
            _serial_no = value;
        }
    }
    private string _invoice_no;
    public string Invoice_no
    {
        get
        {
            return _invoice_no;
        }
        set
        {
            _invoice_no = value;
        }
    }
    private string _lead_no;
    public string lead_no
    {
        get
        {
            return _lead_no;
        }
        set
        {
            _lead_no = value;
        }
    }
    private string _Description;
    public string Description
    {
        get
        {
            return _Description;
        }
        set
        {
            _Description = value;
        }
    }

    private string _paymentMode;
    public string paymentMode
    {
        get
        {
            return _paymentMode;
        }
        set
        {
            _paymentMode = value;
        }
    }
    private string _chequeNo;
    public string chequeNo
    {
        get
        {
            return _chequeNo;
        }
        set
        {
            _chequeNo = value;
        }
    }
    private string _saleReturn;
    public string SaleReturn
    {
        get
        {
            return _saleReturn;
        }
        set
        {
            _saleReturn = value;
        }
    }
    private string _tax;
    public string tax
    {
        get
        {
            return _tax;
        }
        set
        {
            _tax = value;
        }
    }

    private string _upgrade;
    public string upgrade
    {
        get
        {
            return _upgrade;
        }
        set
        {
            _upgrade = value;
        }
    }
    private string _upgrade_by;
    public string upgrade_by
    {
        get
        {
            return _upgrade_by;
        }
        set
        {
            _upgrade_by = value;
        }
    }
    private string _upgrade_From;
    public string upgrade_from
    {
        get
        {
            return _upgrade_From;
        }
        set
        {
            _upgrade_From = value;
        }
    }
    private string _upgrade_to;
    public string upgrade_to
    {
        get
        {
            return _upgrade_to;
        }
        set
        {
            _upgrade_to = value;
        }
    }
    private string _upgrade_amount;
    public string upgrade_amount
    {
        get
        {
            return _upgrade_amount;
        }
        set
        {
            _upgrade_amount = value;
        }
    }

    private string _return_desc;
    public string Return_desc
    {
        get
        {
            return _return_desc;
        }
        set
        {
            _return_desc = value;
        }
    }
    private string _requestid;
    public string requestid
    {
        get
        {
            return _requestid;
        }
        set
        {
            _requestid = value;
        }
    }

    private string _requestId;
    public string requestId
    {
        get
        {
            return _requestId;
        }
        set
        {
            _requestId = value;
        }
    }
    private string _detailid;
    public string detailid
    {
        get
        {
            return _detailid;
        }
        set
        {
            _detailid = value;
        }
    }
    private string _customerid;
    public string customerid
    {
        get
        {
            return _customerid;
        }
        set
        {
            _customerid = value;
        }
    }
    private string _unit;
    public string unit
    {
        get
        {
            return _unit;
        }
        set
        {
            _unit = value;
        }
    }
    private string _item;
    public string item
    {
        get
        {
            return _item;
        }
        set
        {
            _item = value;
        }
    }
    private string _Refund_Repairinvoice_no;
    public string Refund_Repairinvoice_no
    {
        get
        {
            return _Refund_Repairinvoice_no;
        }
        set
        {
            _Refund_Repairinvoice_no = value;
        }
    }

    private string _amount1;
    public string amount
    {
        get
        {
            return _amount1;
        }
        set
        {
            _amount1 = value;
        }
    }
    private string _billingtype;
    public string billingtype
    {
        get
        {
            return _billingtype;
        }
        set
        {
            _billingtype = value;
        }
    }
    private string _refund_reason;
    public string refund_reason
    {
        get
        {
            return _refund_reason;
        }
        set
        {
            _refund_reason = value;
        }
    }

    private string _state;
    public string state
    {
        get
        {
            return _state;
        }
        set
        {
            _state = value;
        }
    }
    private string _Active;
    public string Active
    {
        get
        {
            return _Active;
        }
        set
        {
            _Active = value;
        }
    }
    private string _lead_created_by;
    public string lead_created_by
    {
        get
        {
            return _lead_created_by;
        }
        set
        {
            _lead_created_by = value;
        }
    }
    private string _Paytax;
    public string Paytax
    {
        get
        {
            return _Paytax;
        }
        set
        {
            _Paytax = value;
        }
    }
    private string _officeid;
    public string officeid
    {
        get
        {
            return _officeid;
        }
        set
        {
            _officeid = value;
        }
    }
    private string _Registered_by;
    public string Registered_by
    {
        get
        {
            return _Registered_by;
        }
        set
        {
            _Registered_by = value;
        }
    }
    private string _user;
    public string user
    {
        get
        {
            return _user;
        }
        set
        {
            _user = value;
        }
    }
    private string _search;
    public string Search
    {
        get
        {
            return _search;
        }
        set
        {
            _search = value;
        }
    }
    private string _paymentstatus;
    public string paymentstatus
    {
        get
        {
            return _paymentstatus;
        }
        set
        {
            _paymentstatus = value;
        }
    }
    private string _remarks;
    public string remarks
    {

        get
        {
            return _remarks;
        }
        set
        {
            _remarks = value;
        }
    }
    private string _details;
    public string details
    {

        get
        {
            return _details;
        }
        set
        {
            _details = value;
        }
    }

    private string _vat_per;
    public string vat_per
    {

        get
        {
            return _vat_per;
        }
        set
        {
            _vat_per = value;
        }
    }
    private string _taxtype;
    public string taxtype
    {

        get
        {
            return _taxtype;
        }
        set
        {
            _taxtype = value;
        }
    }
    private string _partcost;
    public string partcost
    {

        get
        {
            return _partcost;
        }
        set
        {
            _partcost = value;
        }
    }
    private DateTime _to_date;
    public DateTime to_date
    {
        get
        {
            return _to_date;
        }
        set
        {
            _to_date = value;
        }
    }
    private DateTime _from_date;
    public DateTime from_date
    {
        get
        {
            return _from_date;
        }
        set
        {
            _from_date = value;
        }
    }
    private string _leadsource;
    public string leadsource
    {

        get
        {
            return _leadsource;
        }
        set
        {
            _leadsource = value;
        }
    }

    private string _invoice_amount;
    public string invoice_amount
    {

        get
        {
            return _invoice_amount;
        }
        set
        {
            _invoice_amount = value;
        }
    }
    private string _Return_amount;
    public string Return_amount
    {

        get
        {
            return _Return_amount;
        }
        set
        {
            _Return_amount = value;
        }
    }
    private string _Remarks;
    public string Remarks
    {

        get
        {
            return _Remarks;
        }
        set
        {
            _Remarks = value;
        }
    }

    private string _office_id;
    public string office_id
    {

        get
        {
            return _office_id;
        }
        set
        {
            _office_id = value;
        }
    }
    private string _RequestId;
    public string RequestId
    {

        get
        {
            return _RequestId;
        }
        set
        {
            _RequestId = value;
        }
    }
    private string _Deduction_amount;
    public string Deduction_amount
    {

        get
        {
            return _Deduction_amount;
        }
        set
        {
            _Deduction_amount = value;
        }
    }
    private string _CustomerId;
    public string CustomerId
    {

        get
        {
            return _CustomerId;
        }
        set
        {
            _CustomerId = value;
        }
    }
    private string _invoice_remarks;
     public string invoice_remarks
    {

        get
        {
            return _invoice_remarks;
        }
        set
        {
            _invoice_remarks = value;
        }
    }
     private string _modify_by;
     public string modify_by
     {

         get
         {
             return _modify_by;
         }
         set
         {
             _modify_by = value;
         }
     }
     private string _Service_Invoice_no;
     public string Service_Invoice_no
     {

         get
         {
             return _Service_Invoice_no;
         }
         set
         {
             _Service_Invoice_no = value;
         }
     }
     private DateTime _created_on;
     public DateTime created_on
     {
         get
         {
             return _created_on;
         }
         set
         {
             _created_on = value;
         }
     }
     private DateTime _modify_on;
     public DateTime modify_on
     {
         get
         {
             return _modify_on;
         }
         set
         {
             _modify_on = value;
         }
     }
     private string _Detail_id;
     public string Detail_id
     {
         get
         {
             return _Detail_id;
         }
         set
         {
             _Detail_id = value;
         }
     }
    
     private DateTime _refund_invoice_date;
     public DateTime refund_invoice_date
     {
         get
         {
             return _refund_invoice_date;
         }
         set
         {
             _refund_invoice_date = value;
         }
     }

     private string _lead_source;
     public string lead_source
     {
         get
         {
             return _lead_source;
         }
         set
         {
             _lead_source = value;
         }
     }
    
    private string _details_id;
    public string details_id
    {

        get
        {
            return _details_id;
        }
        set
        {
            _details_id = value;
        }
    }

    public string crmcustomerplandetail_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crmcustomerplandetail_insert";
            objCommand.Parameters.AddWithValue("@CustomerId", objAccount.CustomerId);
            objCommand.Parameters.AddWithValue("@created_by", objAccount.created_by);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@requestid", objAccount.requestid);
            objCommand.Parameters.AddWithValue("@serial_no", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@servicetype", objAccount.servicetype);
            objCommand.Parameters.AddWithValue("@NoOfNode", objAccount.NoOfNode);
            objCommand.Parameters.AddWithValue("@paymentMode", objAccount.paymentMode);
            objCommand.Parameters.AddWithValue("@chequeNo", objAccount.chequeNo);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
            objCommand.Parameters.AddWithValue("@tax", objAccount.tax);
            objCommand.Parameters.AddWithValue("@Registered_by", objAccount.Registered_by);
            objCommand.Parameters.AddWithValue("@upgrade_by", objAccount.upgrade_by);
            objCommand.Parameters.AddWithValue("@upgrade_to", objAccount.upgrade_to);
            objCommand.Parameters.AddWithValue("@upgrade_from", objAccount.upgrade_from);
            objCommand.Parameters.AddWithValue("@upgrade", objAccount.upgrade);
            objCommand.Parameters.AddWithValue("@upgrade_amount", objAccount.upgrade_amount);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }

    public SqlDataReader CheckExisting_req(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExisting_req";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader CheckExisting_lead(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExisting_lead";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public string customerInsert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMcustomer_insert";
            objCommand.Parameters.AddWithValue("@customerId", objAccount.customerId);
            objCommand.Parameters.AddWithValue("@customerName", objAccount.customerName);
            objCommand.Parameters.AddWithValue("@customerType", objAccount.customerType);
            objCommand.Parameters.AddWithValue("@companyName", objAccount.companyName);
            objCommand.Parameters.AddWithValue("@Description", objAccount.Description);
            objCommand.Parameters.AddWithValue("@fname", objAccount.fname);
            objCommand.Parameters.AddWithValue("@lname", objAccount.Lname);
            objCommand.Parameters.AddWithValue("@professional_email", objAccount.professional_email);
            objCommand.Parameters.AddWithValue("@personal_email", objAccount.personal_email);
            objCommand.Parameters.AddWithValue("@Phoneno", objAccount.Phoneno);
            objCommand.Parameters.AddWithValue("@mobile_no", objAccount.mobile_no);
            objCommand.Parameters.AddWithValue("@address", objAccount.address);
            objCommand.Parameters.AddWithValue("@city", objAccount.city);
            objCommand.Parameters.AddWithValue("@state", objAccount.state);
            objCommand.Parameters.AddWithValue("@postalCode", objAccount.postalCode);
            objCommand.Parameters.AddWithValue("@fax", objAccount.fax);
            objCommand.Parameters.AddWithValue("@country", objAccount.country);
            objCommand.Parameters.AddWithValue("@Active", objAccount.Active);
            objCommand.Parameters.AddWithValue("@created_by", objAccount.created_by);
            objCommand.Parameters.AddWithValue("@lead_created_by", objAccount.lead_created_by);
            objCommand.Parameters.AddWithValue("@Paytax", objAccount.Paytax);
            objCommand.Parameters.AddWithValue("@billingtype", objAccount.billingtype);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@lead_no", objAccount.lead_no);
            objCommand.Parameters.AddWithValue("@requestid", objAccount.requestid);
            objCommand.Parameters.AddWithValue("@serial_no", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@servicetype", objAccount.servicetype);
            objCommand.Parameters.AddWithValue("@NoOfNode", objAccount.NoOfNode);
            objCommand.Parameters.AddWithValue("@paymentMode", objAccount.paymentMode);
            objCommand.Parameters.AddWithValue("@chequeNo", objAccount.chequeNo);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
            objCommand.Parameters.AddWithValue("@tax", objAccount.tax);
            objCommand.Parameters.AddWithValue("@Registered_by", objAccount.Registered_by);
            objCommand.Parameters.AddWithValue("@upgrade_by", objAccount.upgrade_by);
            objCommand.Parameters.AddWithValue("@upgrade_to", objAccount.upgrade_to);
            objCommand.Parameters.AddWithValue("@upgrade_from", objAccount.upgrade_from);
            objCommand.Parameters.AddWithValue("@upgrade", objAccount.upgrade);
            objCommand.Parameters.AddWithValue("@upgrade_amount", objAccount.upgrade_amount);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }


    public string CRM_Serviceinvoice_Refund_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRM_Serviceinvoice_Refund_insert";
            objCommand.Parameters.AddWithValue("@RequestId", objAccount.RequestId);
            objCommand.Parameters.AddWithValue("@CustomerId", objAccount.CustomerId);
            objCommand.Parameters.AddWithValue("@Deduction_amount", objAccount.Deduction_amount);
            objCommand.Parameters.AddWithValue("@invoice_remarks", objAccount.invoice_remarks);
            objCommand.Parameters.AddWithValue("@NoOfNode", objAccount.NoOfNode);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
            objCommand.Parameters.AddWithValue("@created_by", objAccount.created_by);
            objCommand.Parameters.AddWithValue("@lead_created_by", objAccount.lead_created_by);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@Service_Invoice_no", objAccount.Service_Invoice_no);
             objCommand.Parameters.AddWithValue("@lead_source", objAccount.lead_source);
           // objCommand.Parameters.AddWithValue("@refund_invoice_date", objAccount.refund_invoice_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }

    public SqlDataReader CheckExistingrequestid1(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingrequestid1";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader CheckExistingrequestid(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingrequestid";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public string CRM_Repairinvoice_Refund_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRM_Repairinvoice_Refund_insert";
            objCommand.Parameters.AddWithValue("@RequestId", objAccount.RequestId);
            objCommand.Parameters.AddWithValue("@CustomerId", objAccount.CustomerId);
            objCommand.Parameters.AddWithValue("@Deduction_amount", objAccount.Deduction_amount);
            objCommand.Parameters.AddWithValue("@invoice_remarks", objAccount.invoice_remarks);
            objCommand.Parameters.AddWithValue("@unit", objAccount.unit);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
            objCommand.Parameters.AddWithValue("@created_by", objAccount.created_by);
            objCommand.Parameters.AddWithValue("@lead_created_by", objAccount.lead_created_by);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@Repair_Invoice_no", objAccount.Repair_Invoice_no);
            objCommand.Parameters.AddWithValue("@lead_source", objAccount.lead_source);
            // objCommand.Parameters.AddWithValue("@refund_invoice_date", objAccount.refund_invoice_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }


    public SqlDataReader txt_refundinvoice_requestid_search(string requestid, int flag)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "txt_refundinvoice_requestid_search";
        objCommand.Parameters.AddWithValue("@requestid ", requestid);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;

    }

    public SqlDataReader txt_refund_repairinvoice_requestid_search(string requestid, int flag)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "txt_refund_repairinvoice_requestid_search";
        objCommand.Parameters.AddWithValue("@requestid ", requestid);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;

    }



    public SqlDataReader CRMcustomer_update(string customerId, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMcustomer_update";

        objCommand.Parameters.AddWithValue("@customerId", customerId);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;

    }
    public SqlDataReader CRM_Serviceinvoice_Refund_update(string customerId, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRM_Serviceinvoice_Refund_update";
        objCommand.Parameters.AddWithValue("@customerId", customerId);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;

    }


    public SqlDataReader CRM_Repairinvoice_Refund_update(string customerId, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRM_Repairinvoice_Refund_update";
        objCommand.Parameters.AddWithValue("@customerId", customerId);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;

    }

    public SqlDataReader crmservicetype_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmservicetype_select";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public DataTable crmcustomer_select(clsAccount objAccount)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmcustomer_select";
            objCommand.Parameters.AddWithValue("@Search", objAccount.Search);
            objCommand.Parameters.AddWithValue("@customerType", objAccount.customerType);
            objCommand.Parameters.AddWithValue("@servicetype", objAccount.servicetype);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }


    }
    public string crmcustomer_nodedetail_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crmcustomer_nodedetail_insert";
            objCommand.Parameters.AddWithValue("@detailid", objAccount.detailid);
            objCommand.Parameters.AddWithValue("@serial_no", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@unit", objAccount.unit);
            objCommand.Parameters.AddWithValue("@item", objAccount.item);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
            objCommand.Parameters.AddWithValue("@user", objAccount.user);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
    public string CRMProductSale_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMProductSale_insert";
            objCommand.Parameters.AddWithValue("@serial_no", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@lead_no", objAccount.lead_no);
            objCommand.Parameters.AddWithValue("@invoice_no", objAccount.Invoice_no);
            objCommand.Parameters.AddWithValue("@paymentMode", objAccount.paymentMode);
            objCommand.Parameters.AddWithValue("@chequeNo", objAccount.chequeNo);
            objCommand.Parameters.AddWithValue("@user", objAccount.user);
            objCommand.Parameters.AddWithValue("@status", objAccount.paymentstatus);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objCommand.Parameters.AddWithValue("@requestid", objAccount.requestid);
            objCommand.Parameters.AddWithValue("@remarks", objAccount.remarks);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }

    public string CRMProductSale_print_Invoicedetails_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
           
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMProductSale_print_Invoicedetails_insert";
            objCommand.Parameters.AddWithValue("@Detail_id", objAccount.Detail_id);
            objCommand.Parameters.AddWithValue("@serial_no", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@unit", objAccount.unit);
            //objCommand.Parameters.AddWithValue("@details", objAccount.details);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
           // objCommand.Parameters.AddWithValue("@vat_per", objAccount.vat_per);
           // objCommand.Parameters.AddWithValue("@taxtype", objAccount.taxtype);
            objCommand.Parameters.AddWithValue("@created_by", objAccount.created_by);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objCommand.Parameters.AddWithValue("@item", objAccount.item);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }


    public string CRMProductSaleDetails_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMProductSaleDetails_insert";
            objCommand.Parameters.AddWithValue("@details_id", objAccount.detailid);
            objCommand.Parameters.AddWithValue("@serial_no", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@unit", objAccount.unit);
            objCommand.Parameters.AddWithValue("@details", objAccount.details);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
            objCommand.Parameters.AddWithValue("@vat_per", objAccount.vat_per);
            objCommand.Parameters.AddWithValue("@taxtype", objAccount.taxtype);
            objCommand.Parameters.AddWithValue("@user", objAccount.user);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objCommand.Parameters.AddWithValue("@item", objAccount.item);
            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }

    public DataTable crmrepair_invoice_select(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmrepair_invoice_select";
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@leadsource", objAccount.leadsource);
            objCommand.Parameters.AddWithValue("@paymentstatus", objAccount.paymentstatus);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public DataTable crmcustomer_service_upgrade_Report(clsAccount objAccount)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmcustomer_service_upgrade_Report";
            objCommand.Parameters.AddWithValue("@Search", objAccount.Search);
            objCommand.Parameters.AddWithValue("@customerType", objAccount.customerType);
            objCommand.Parameters.AddWithValue("@servicetype", objAccount.servicetype);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }

    }

    public DataTable crmcustomer_select_Report(clsAccount objAccount)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmcustomer_select_Report";
            objCommand.Parameters.AddWithValue("@Search", objAccount.Search);
            objCommand.Parameters.AddWithValue("@customerType", objAccount.customerType);
            objCommand.Parameters.AddWithValue("@servicetype", objAccount.servicetype);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }

    }


    public DataTable CRM_Repairinvoice_Refund_select(clsAccount objAccount)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRM_Repairinvoice_Refund_select";
            objCommand.Parameters.AddWithValue("@Search", objAccount.Search);
            objCommand.Parameters.AddWithValue("@lead_source", objAccount.lead_source);
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }

    }

    public DataTable CRM_Serviceinvoice_Refund_select(clsAccount objAccount)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRM_Serviceinvoice_Refund_select";
            objCommand.Parameters.AddWithValue("@Search", objAccount.Search);
            objCommand.Parameters.AddWithValue("@lead_source", objAccount.lead_source);
            objCommand.Parameters.AddWithValue("@lead_created_by", objAccount.lead_created_by);
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }

    }
    public DataTable Service_Invoice_Report(clsAccount objAccount)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Service_Invoice_Report";
            objCommand.Parameters.AddWithValue("@Search", objAccount.Search);
            objCommand.Parameters.AddWithValue("@customerType", objAccount.customerType);
            objCommand.Parameters.AddWithValue("@servicetype", objAccount.servicetype);
            objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }

    }
    public DataTable CRMmember_regd_select(clsAccount objAccount)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMmember_regd_select";
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }

    }
    public string creditnotes_service_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "creditnotes_service_insert";
            objCommand.Parameters.AddWithValue("@Serialno", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@customerid", objAccount.customerid);
            objCommand.Parameters.AddWithValue("@Invoice_no", objAccount.Invoice_no);
            objCommand.Parameters.AddWithValue("@invoice_amount", objAccount.invoice_amount);
            objCommand.Parameters.AddWithValue("@Return_amount", objAccount.Return_amount);
            objCommand.Parameters.AddWithValue("@Remarks", objAccount.Remarks);
            objCommand.Parameters.AddWithValue("@user", objAccount.user);
            objCommand.Parameters.AddWithValue("@office_id", objAccount.office_id);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);

            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }





    public SqlDataReader invoicedetail_select_forcreditnotes(string invoice_no)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "invoicedetail_select_forcreditnotes";
        objCommand.Parameters.AddWithValue("@invoice_no", invoice_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader CRM_repair_invoice_panel_Update(clsAccount objAccount)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRM_repair_invoice_panel_Update";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Parameters.AddWithValue("@amount", amount);
        objCommand.Parameters.AddWithValue("@paymentstatus", paymentstatus);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

   


    public SqlDataReader creditnotes_service_selectforupdate(string invoice_no)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "creditnotes_service_selectforupdate";
        objCommand.Parameters.AddWithValue("@invoice_no", invoice_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader CheckExisting_requestid_CRMProductSale(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExisting_requestid_CRMProductSale";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader CheckExisting_requestid_print_Invoice(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExisting_requestid_print_Invoice";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public DataTable creditnotes_service_selectforreport(DateTime from_date, DateTime to_date, int flag)
    {

        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "creditnotes_service_selectforreport  ";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }


    public SqlDataReader CRM_repair_invoice_panel_select(int flag, string requestid)
    {


        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRM_repair_invoice_panel_select";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;



    }
    public SqlDataReader Print_service_invoice(string customerId)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Print_service_invoice";
        objCommand.Parameters.AddWithValue("@customerId", customerId);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader CRMProductSale_print_Invoice_update(string serial_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMProductSale_print_Invoice_update";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public DataTable crmservice_revenue_collection_select(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmservice_revenue_collection_select";
            objCommand.Parameters.AddWithValue("@Search", objAccount.Search);
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@collection_status", objAccount.collection_status);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }
    public SqlDataReader CRMServiceRevenue_collection_panel_select(int flag, string requestid)
    {


        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMServiceRevenue_collection_panel_select";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader CRMServiceRevenue_collection_panel_update(clsAccount objAccount)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMServiceRevenue_collection_panel_update";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Parameters.AddWithValue("@collected_amount", collected_amount);
        objCommand.Parameters.AddWithValue("@collection_status", collection_status);
        objCommand.Parameters.AddWithValue("@collected_by", collected_by);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public string CRMProductSale_print_Invoice_insert(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMProductSale_print_Invoice_insert";
            objCommand.Parameters.AddWithValue("@serial_no", objAccount.serial_no);
            objCommand.Parameters.AddWithValue("@paymentMode", objAccount.paymentMode);
            objCommand.Parameters.AddWithValue("@chequeNo", objAccount.chequeNo);
            objCommand.Parameters.AddWithValue("@requestid", objAccount.requestid);
            objCommand.Parameters.AddWithValue("@remarks", objAccount.remarks);
            objCommand.Parameters.AddWithValue("@unit", objAccount.unit);
            //objCommand.Parameters.AddWithValue("@details", objAccount.details);
            objCommand.Parameters.AddWithValue("@item", objAccount.item);
            objCommand.Parameters.AddWithValue("@amount", objAccount.amount);
            objCommand.Parameters.AddWithValue("@created_by", objAccount.created_by);
           // objCommand.Parameters.AddWithValue("@created_on", objAccount.created_on);
            objCommand.Parameters.AddWithValue("@partcost", objAccount.partcost);
           // objCommand.Parameters.AddWithValue("@officeid", objAccount.officeid);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);

            dataReader = objCommand.ExecuteReader();
            string j = "0";
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
    public DataTable CRMProductSale_print_Invoice_select(clsAccount objAccount)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMProductSale_print_Invoice_select";
            objCommand.Parameters.AddWithValue("@from_date", objAccount.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objAccount.to_date);
            objCommand.Parameters.AddWithValue("@requestid", objAccount.requestid);
            objCommand.Parameters.AddWithValue("@flag", objAccount.flag);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public SqlDataReader Print_Repair_invoice(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Print_Repair_invoice";
        objCommand.Parameters.AddWithValue("@requestid", requestid);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader Repair_invoice_print(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Repair_invoice_print";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader Delete_Last_Repair_Invoice(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Delete_Last_Repair_Invoice";
        objCommand.Parameters.AddWithValue("@requestid", requestid);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader Check_for_Delete_Repair_Invoice(clsAccount objAccount)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Check_for_Delete_Repair_Invoice";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
   

    public SqlDataReader Delete_duplicate_print_Invoice(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Delete_duplicate_print_Invoice";
        objCommand.Parameters.AddWithValue("@requestid", requestid);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
}

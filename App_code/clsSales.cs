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

/// <summary>
/// Summary description for clsSales
/// </summary>
public class clsSales
{
    public clsSales()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    DataTable objDataTable;
    private string _flag;
    public string Flag
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
    private string _relatedto_name;
    public string relatedto_name
    {
        get
        {
            return _relatedto_name;
        }
        set
        {
            _relatedto_name = value;
        }
    }

    private string _first_name;
    public string first_name
    {
        get
        {
            return _first_name;
        }
        set
        {
            _first_name = value;
        }
    }
    private string _last_name;
    public string last_name
    {
        get
        {
            return _last_name;
        }
        set
        {
            _last_name = value;
        }
    }
    private string _phone;
    public string phone
    {
        get
        {
            return _phone;
        }
        set
        {
            _phone = value;
        }
    }
    private string _mobile;
    public string mobile
    {
        get
        {
            return _mobile;
        }
        set
        {
            _mobile = value;
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
    private string _title;
    public string title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }
    private string _company;
    public string company
    {
        get
        {
            return _company;
        }
        set
        {
            _company = value;
        }
    }
    private string _street;
    public string street
    {
        get
        {
            return _street;
        }
        set
        {
            _street = value;
        }
    }
    private string _landmark;
    public string landmark
    {
        get
        {
            return _landmark;
        }
        set
        {
            _landmark = value;
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
    private string _postal_code;
    public string postal_code
    {
        get
        {
            return _postal_code;
        }
        set
        {
            _postal_code = value;
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
    private string _Office_id;
    public string Office_id
    {
        get
        {
            return _Office_id;
        }
        set
        {
            _Office_id = value;
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
    private string _lead_status;
    public string lead_status
    {
        get
        {
            return _lead_status;
        }
        set
        {
            _lead_status = value;
        }
    }
    private string _cancel_reason;
    public string cancel_reason
    {
        get
        {
            return _cancel_reason;
        }
        set
        {
            _cancel_reason = value;
        }
    }
    private string _description;
    public string description
    {
        get
        {
            return _description;
        }
        set
        {
            _description = value;
        }
    }
    private string _customer_Type;
    public string customer_Type
    {
        get
        {
            return _customer_Type;
        }
        set
        {
            _customer_Type = value;
        }
    }
    private string _ExpectedRevenue;
    public string ExpectedRevenue
    {
        get
        {
            return _ExpectedRevenue;
        }
        set
        {
            _ExpectedRevenue = value;
        }
    }
    private string _assign_emp;
    public string assign_emp
    {
        get
        {
            return _assign_emp;
        }
        set
        {
            _assign_emp = value;
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
    private DateTime _expecteddate;
    public DateTime expecteddate
    {
        get
        {
            return _expecteddate;
        }
        set
        {
            _expecteddate = value;
        }
    }
    private string _expectedtime;
    public string expectedtime
    {
        get
        {
            return _expectedtime;
        }
        set
        {
            _expectedtime = value;
        }
    }
    private DateTime _Closerdate;
    public DateTime Closerdate
    {
        get
        {
            return _Closerdate;
        }
        set
        {
            _Closerdate = value;
        }
    }
    private string _IPADs;
    public string IPADs
    {
        get
        {
            return _IPADs;
        }
        set
        {
            _IPADs = value;
        }
    }

    private string _Tablets;
    public string Tablets
    {
        get
        {
            return _Tablets;
        }
        set
        {
            _Tablets = value;
        }
    }
    private string _Smartphones;
    public string Smartphones
    {
        get
        {
            return _Smartphones;
        }
        set
        {
            _Smartphones = value;
        }
    }
    private string _Other;
    public string Other
    {
        get
        {
            return _Other;
        }
        set
        {
            _Other = value;
        }
    }
    private string _promocode_addon1;
    public string promocode_addon1
    {
        get
        {
            return _promocode_addon1;
        }
        set
        {
            _promocode_addon1 = value;
        }
    }
    private string _promocode_addon2;
    public string promocode_addon2
    {
        get
        {
            return _promocode_addon2;
        }
        set
        {
            _promocode_addon2 = value;
        }
    }
    private string _promocode_addon3;
    public string promocode_addon3
    {
        get
        {
            return _promocode_addon3;
        }
        set
        {
            _promocode_addon3 = value;
        }
    }

    private string _assign_to;
    public string assign_to
    {
        get
        {
            return _assign_to;
        }
        set
        {
            _assign_to = value;
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

    private string _promocode_addon4;
    public string promocode_addon4
    {
        get
        {
            return _promocode_addon4;
        }
        set
        {
            _promocode_addon4 = value;
        }
    }
    private string _search_value;
    public string search_value
    {
        get
        {
            return _search_value;
        }
        set
        {
            _search_value = value;
        }
    }
    private string _origin;
    public string origin
    {
        get
        {
            return _origin;
        }
        set
        {
            _origin = value;
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
    //private string _time;
    //public string Time
    //{
    //    get
    //    {
    //        return _time;
    //    }
    //    set
    //    {
    //        _time = value;
    //    }
    //}
    //private string _QRTSpl;
    //public string QRTSpl
    //{
    //    get
    //    {
    //        return _QRTSpl;
    //    }
    //    set
    //    {
    //        _QRTSpl = value;
    //    }
    //}
    //private string _zone;
    //public string Zone
    //{
    //    get
    //    {
    //        return _zone;
    //    }
    //    set
    //    {
    //        _zone = value;
    //    }
    //}
    //private string _titleType;
    //public string TitleType
    //{
    //    get
    //    {
    //        return _titleType;
    //    }
    //    set
    //    {
    //        _titleType = value;
    //    }
    //}
    //private string _customerType;
    //public string CustomerType
    //{
    //    get
    //    {
    //        return _customerType;
    //    }
    //    set
    //    {
    //        _customerType = value;
    //    }
    //}
    //private string _ExpectedRevenue;
    //public string ExpectedRevenue
    //{
    //    get
    //    {
    //        return _ExpectedRevenue;
    //    }
    //    set
    //    {
    //        _ExpectedRevenue = value;
    //    }
    //}
    //private string _RelatedTo;
    //public string RelatedTo
    //{
    //    get
    //    {
    //        return _RelatedTo;
    //    }
    //    set
    //    {
    //        _RelatedTo = value;
    //    }
    //}
    //private string _Requestid;
    //public string Requestid
    //{
    //    get
    //    {
    //        return _Requestid;
    //    }
    //    set
    //    {
    //        _Requestid = value;
    //    }
    //}
    //private string _equipmentid;
    //public string equipmentid
    //{
    //    get
    //    {
    //        return _equipmentid;
    //    }
    //    set
    //    {
    //        _equipmentid = value;
    //    }
    //}
    //private string _expectedtime;
    //public string Expectedtime
    //{
    //    get
    //    {
    //        return _expectedtime;
    //    }
    //    set
    //    {
    //        _expectedtime = value;
    //    }
    //}
    //private string _promocode;
    //public string promocode
    //{
    //    get
    //    {
    //        return _promocode;
    //    }
    //    set
    //    {
    //        _promocode = value;
    //    }
    //}
    //private string _businesstype;
    //public string businesstype
    //{
    //    get
    //    {
    //        return _businesstype;
    //    }
    //    set
    //    {
    //        _businesstype = value;
    //    }
    //}
    //private string _Probabilty_ages;
    //public string Probabilty_ages
    //{
    //    get
    //    {
    //        return _Probabilty_ages;
    //    }
    //    set
    //    {
    //        _Probabilty_ages = value;
    //    }
    //}
    //private string _orgin;
    //public string orgin
    //{
    //    get
    //    {
    //        return _orgin;
    //    }
    //    set
    //    {
    //        _orgin = value;
    //    }
    //}
    //private string _SMS_datetime;
    //public string SMS_datetime
    //{
    //    get
    //    {
    //        return _SMS_datetime;
    //    }
    //    set
    //    {
    //        _SMS_datetime = value;
    //    }
    //}
    //private string _requestid;
    //public string requestid
    //{
    //    get
    //    {
    //        return _requestid;
    //    }
    //    set
    //    {
    //        _requestid = value;
    //    }
    //}
    //private string _name;
    //public string name
    //{
    //    get
    //    {
    //        return _name;
    //    }
    //    set
    //    {
    //        _name = value;
    //    }
    //}
    //private string _source;
    //public string source
    //{
    //    get
    //    {
    //        return _source;
    //    }
    //    set
    //    {
    //        _source = value;
    //    }
    //}
    //private string _empid;
    //public string empid
    //{
    //    get
    //    {
    //        return _empid;
    //    }
    //    set
    //    {
    //        _empid = value;
    //    }
    //}
    //private string _status;
    //public string status
    //{
    //    get
    //    {
    //        return _status;
    //    }
    //    set
    //    {
    //        _status = value;
    //    }
    //}
    //private string _officeid;
    //public string officeid
    //{
    //    get
    //    {
    //        return _officeid;
    //    }
    //    set
    //    {
    //        _officeid = value;
    //    }
    //}

    //private DateTime _from_date;
    //public DateTime from_date
    //{
    //    get
    //    {
    //        return _from_date;
    //    }
    //    set
    //    {
    //        _from_date = value;
    //    }
    //}
    //private DateTime _to_date;
    //public DateTime to_date
    //{
    //    get
    //    {
    //        return _to_date;
    //    }
    //    set
    //    {
    //        _to_date = value;
    //    }
    //}
    //private string _sourceofsale;
    //public string sourceofsale
    //{
    //    get
    //    {
    //        return _sourceofsale;
    //    }
    //    set
    //    {
    //        _sourceofsale = value;
    //    }
    //}
    //private string _sourcename;
    //public string sourcename
    //{
    //    get
    //    {
    //        return _sourcename;
    //    }
    //    set
    //    {
    //        _sourcename = value;
    //    }
    //}
    //private string _servicetype;
    //public string servicetype
    //{
    //    get
    //    {
    //        return _servicetype;
    //    }
    //    set
    //    {
    //        _servicetype = value;
    //    }
    //}
    //private decimal _amount;
    //public decimal amount
    //{
    //    get
    //    {
    //        return _amount;
    //    }
    //    set
    //    {
    //        _amount = value;
    //    }
    //}
    //private string _paymentmode;
    //public string paymentmode
    //{
    //    get
    //    {
    //        return _paymentmode;
    //    }
    //    set
    //    {
    //        _paymentmode = value;
    //    }
    //}
    //private string _ChequeNo;
    //public string ChequeNo
    //{
    //    get
    //    {
    //        return _ChequeNo;
    //    }
    //    set
    //    {
    //        _ChequeNo = value;
    //    }
    //}
    //private string _duetime;
    //public string duetime
    //{
    //    get
    //    {
    //        return _duetime;
    //    }
    //    set
    //    {
    //        _duetime = value;
    //    }
    //}
    //private string _address_landmark;
    //public string address_landmark
    //{
    //    get
    //    {
    //        return _address_landmark;
    //    }
    //    set
    //    {
    //        _address_landmark = value;
    //    }
    //}
    //private string _address_location;
    //public string address_location
    //{
    //    get
    //    {
    //        return _address_location;
    //    }
    //    set
    //    {
    //        _address_location = value;
    //    }
    //}

    public string crmlead_Insert(clsSales objSales)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMLead_Insert";
            objCommand.Parameters.AddWithValue("@lead_no", objSales.lead_no);
            objCommand.Parameters.AddWithValue("@first_name", objSales.first_name);
            objCommand.Parameters.AddWithValue("@last_name", objSales.last_name);
            objCommand.Parameters.AddWithValue("@phone", objSales.phone);
            objCommand.Parameters.AddWithValue("@mobile", objSales.mobile);
            objCommand.Parameters.AddWithValue("@professional_email", objSales.professional_email);
            objCommand.Parameters.AddWithValue("@personal_email", objSales.personal_email);
            objCommand.Parameters.AddWithValue("@title", objSales.title);
            objCommand.Parameters.AddWithValue("@company", objSales.company);
            objCommand.Parameters.AddWithValue("@street", objSales.street);
            objCommand.Parameters.AddWithValue("@city", objSales.city);
            objCommand.Parameters.AddWithValue("@state", objSales.state);
            objCommand.Parameters.AddWithValue("@postal_code", objSales.postal_code);
            objCommand.Parameters.AddWithValue("@fax", objSales.fax);
            objCommand.Parameters.AddWithValue("@country", objSales.country);
            objCommand.Parameters.AddWithValue("@Office_id", objSales.Office_id);
            objCommand.Parameters.AddWithValue("@lead_source", objSales.lead_source);
            objCommand.Parameters.AddWithValue("@lead_status", objSales.lead_status);
            objCommand.Parameters.AddWithValue("@cancel_reason", objSales.cancel_reason);
            objCommand.Parameters.AddWithValue("@description", objSales.description);
            objCommand.Parameters.AddWithValue("@customer_Type", objSales.customer_Type);
            objCommand.Parameters.AddWithValue("@ExpectedRevenue", objSales.ExpectedRevenue);
            objCommand.Parameters.AddWithValue("@assign_emp", objSales.assign_emp);
            objCommand.Parameters.AddWithValue("@created_by", objSales.created_by);
            objCommand.Parameters.AddWithValue("@expecteddate", objSales.expecteddate);
            objCommand.Parameters.AddWithValue("@expectedtime", objSales.expectedtime);
            objCommand.Parameters.AddWithValue("@Closerdate", objSales.Closerdate);
            objCommand.Parameters.AddWithValue("@IPADs", objSales.IPADs);
            objCommand.Parameters.AddWithValue("@Tablets", objSales.Tablets);
            objCommand.Parameters.AddWithValue("@Smartphones", objSales.Smartphones);
            objCommand.Parameters.AddWithValue("@Other", objSales.Other);
            objCommand.Parameters.AddWithValue("@promocode_addon1", objSales.promocode_addon1);
            objCommand.Parameters.AddWithValue("@promocode_addon2", objSales.promocode_addon2);
            objCommand.Parameters.AddWithValue("@promocode_addon3", objSales.promocode_addon3);
            objCommand.Parameters.AddWithValue("@promocode_addon4", objSales.promocode_addon4);
            objCommand.Parameters.AddWithValue("@landmark", objSales.landmark);
            objCommand.Parameters.AddWithValue("@Flag", objSales.Flag);
            dataReader = objCommand.ExecuteReader();
            //int i=objCommand.ExecuteNonQuery();
            string j = "0";
            //if(i>0)
            //{
            //    j = "inserted";
            //}
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

    public SqlDataReader CRMOffice_Select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMOffice_Select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader Sale_Agentperformance_snapshot(DateTime from_date, DateTime to_date, char flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Sale_Agentperformance_snapshot";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader Dailylead_allocation_report(DateTime from_date, DateTime to_date, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Dailylead_allocation_report";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader Mysales_performance_Snapshot(DateTime from_date, DateTime to_date, char flag, string created_by)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mysales_performance_Snapshot";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@created_by", created_by);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader CheckExistingLead(string mobile)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingLead";
        objCommand.Parameters.AddWithValue("@mobile", mobile);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader crmLeadSource_Select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmLeadSource_Select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    //public SqlDataReader LeadSourceSelectForOther(int type)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "LeadSourceSelectForOther";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}

    public SqlDataReader websitetype_Select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "websitetype_Select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader servicetype_Select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "servicetype_Select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader serviceprovides_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "serviceprovides_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader Domainprovider_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Domainprovider_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader Billtype_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Billtype_select";
        //objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader crmleadstatus_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmleadstatus_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader customerissue_status_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "customerissue_status_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader customerissue_type_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "customerissue_type_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public DataTable CRMLead_select(clsSales objSales)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMLead_select";
            objCommand.Parameters.AddWithValue("@Flag", objSales.Flag);
            objCommand.Parameters.AddWithValue("@search_value", objSales.search_value);
            objCommand.Parameters.AddWithValue("@created_by", objSales.created_by);
            objCommand.Parameters.AddWithValue("@lead_source", objSales.lead_source);
            objCommand.Parameters.AddWithValue("@lead_status", objSales.lead_status);
            objCommand.Parameters.AddWithValue("@Office_id", objSales.Office_id);
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
    public void CRMLead_delete(string lead_no)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMLead_delete";
            objCommand.Parameters.AddWithValue("@lead_no", lead_no);
            objCommand.ExecuteNonQuery();


        }
    }
    public SqlDataReader CRMLeadSelect_for_update(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMLeadSelect_for_update";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader crmstate_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmstate_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader CRMCity_Select(string state_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMCity_Select";
        objCommand.Parameters.AddWithValue("@flag", state_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader crmLead_cancelReason(int @Lead_statusid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmLead_cancelReason";
        objCommand.Parameters.AddWithValue("@Lead_statusid", @Lead_statusid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public string lead_allocationto_agent_insert(clsSales objSales)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "lead_allocationto_agent_insert";
            objCommand.Parameters.AddWithValue("@customername", objSales.first_name);
            objCommand.Parameters.AddWithValue("@email", objSales.personal_email);
            objCommand.Parameters.AddWithValue("@mobile_no", objSales.mobile);
            objCommand.Parameters.AddWithValue("@lead_source", objSales.lead_source);
            objCommand.Parameters.AddWithValue("@office_id", objSales.Office_id);
            objCommand.Parameters.AddWithValue("@issue", objSales.description);
            objCommand.Parameters.AddWithValue("@origin", objSales.origin);
            dataReader = objCommand.ExecuteReader();
            //int i=objCommand.ExecuteNonQuery();
            string j = "0";
            //if(i>0)
            //{
            //    j = "inserted";
            //}
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
    public SqlDataReader Lead_allocation_agent_view(clsSales objSales)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Lead_allocation_agent_view";
        objCommand.Parameters.AddWithValue("@from_date ", objSales.from_date);
        objCommand.Parameters.AddWithValue("@to_date", objSales.to_date);
        objCommand.Parameters.AddWithValue("@Office_id ", objSales.Office_id);
        objCommand.Parameters.AddWithValue("@created_by ", objSales.created_by);
        objCommand.Parameters.AddWithValue("@search ", objSales.lead_source);
        objCommand.Parameters.AddWithValue("@Flag ", objSales.Flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;



    }
    public SqlDataReader Lead_allocation_duplicacy_check(DateTime fromdate, DateTime todate, string office_id, string search, int Flag)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Lead_allocation_duplicacy_check";
        objCommand.Parameters.AddWithValue("@from_date ", fromdate);
        objCommand.Parameters.AddWithValue("@to_date", todate);
        objCommand.Parameters.AddWithValue("@office_id ", office_id);
        objCommand.Parameters.AddWithValue("@search", search);
        objCommand.Parameters.AddWithValue("@Flag ", Flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;



    }
    public SqlDataReader Expense_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Expense_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public string leadallocationstatus_update(string Lead_no, string status, string allocated_to, string Flag)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "leadallocationstatus_update";
            objCommand.Parameters.AddWithValue("@Lead_no", Lead_no);
            objCommand.Parameters.AddWithValue("@status", status);
            objCommand.Parameters.AddWithValue("@allocated_to", allocated_to);
            objCommand.Parameters.AddWithValue("@Flag", Flag);
            dataReader = objCommand.ExecuteReader();
            //int i=objCommand.ExecuteNonQuery();
            string j = "0";
            //if(i>0)
            //{
            //    j = "inserted";
            //}
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

    public DataTable Mylead_followup_detail_select(clsSales objSales)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Mylead_followup_detail_select";
            objCommand.Parameters.AddWithValue("@Flag", objSales.Flag);
            objCommand.Parameters.AddWithValue("@created_by", objSales.created_by);
            objCommand.Parameters.AddWithValue("@from_date", objSales.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objSales.to_date);
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

    public DataTable CRMLead_selectforreport(clsSales objSales)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMLead_selectforreport";
            objCommand.Parameters.AddWithValue("@Flag", objSales.Flag);
            objCommand.Parameters.AddWithValue("@search_value", objSales.search_value);
            objCommand.Parameters.AddWithValue("@created_by", objSales.created_by);
            objCommand.Parameters.AddWithValue("@lead_source", objSales.lead_source);
            objCommand.Parameters.AddWithValue("@lead_status", objSales.lead_status);
            objCommand.Parameters.AddWithValue("@cancel_reason", objSales.cancel_reason);
            objCommand.Parameters.AddWithValue("@Office_id", objSales.Office_id);
            objCommand.Parameters.AddWithValue("@from_date", objSales.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objSales.to_date);
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

    public SqlDataReader Mylead_detail_select(DateTime from_date, DateTime to_date, string created_by, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Mylead_detail_select";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@created_by", created_by);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader MyTransation_sale_select(DateTime from_date, char flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "MyTransation_sale_select";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader Daywise_Sales_Summary(DateTime from_date, char flag, string lead_created_by, string assign_to)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Daywise_Sales_Summary";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@lead_created_by", lead_created_by);
        objCommand.Parameters.AddWithValue("@assign_to", assign_to);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Jobwork_incoming_status(DateTime from_date, DateTime to_date, string assign_to, char flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Jobwork_incoming_status";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@assign_to", assign_to);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader AMC_Transaction_select(DateTime from_date, DateTime to_date, string flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "AMC_Transaction_select";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader MyTransation_select(DateTime from_date, char flag, string created_by)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "MyTransation_select";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Parameters.AddWithValue("@created_by", created_by);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader daily_jobwork_transaction_select(DateTime from_date, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "daily_jobwork_transaction_select";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@flag", flag);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }





    //public string leadallocationstatus_update(string Lead_no, string status, string allocated_to, string Flag)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "leadallocationstatus_update";
    //        objCommand.Parameters.AddWithValue("@Lead_no", Lead_no);
    //        objCommand.Parameters.AddWithValue("@status", status);
    //        objCommand.Parameters.AddWithValue("@allocated_to", allocated_to);
    //        objCommand.Parameters.AddWithValue("@Flag", Flag);                       
    //        dataReader = objCommand.ExecuteReader();
    //        //int i=objCommand.ExecuteNonQuery();
    //        string j = "0";
    //        //if(i>0)
    //        //{
    //        //    j = "inserted";
    //        //}
    //        if (dataReader.Read())
    //        {
    //            j = dataReader[0].ToString();
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}
    public SqlDataReader CheckExisting_requestid_productsale(string requestid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExisting_requestid_productsale";
        objCommand.Parameters.AddWithValue("@requestid", requestid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader leaddetail_selectforticket(string search, int flag)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "leaddetail_selectforticket";
        objCommand.Parameters.AddWithValue("@search ", search);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;



    }

    //public SqlDataReader leadstatusforreport()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "leadstatusforreport";
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader crmdeparmentreport(string supervisorid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "crmdeparmentreport";
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader crmsupervisorreport(string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "crmsupervisorreport";
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader crmattendanceemploye(string supervisorid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "crmattendanceemploye";
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader LeadCRMIndustry()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "LeadCRMIndustry";
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader LeadAssign(string group_type)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "LeadAssign";
    //    objCommand.Parameters.AddWithValue("@group_type", group_type);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}



    //public SqlDataReader CRMRegionSelect()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMRegionSelect";
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}

    //public SqlDataReader CRMOfficeSelectForCity(string city_id)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMOfficeSelectForCity";
    //    objCommand.Parameters.AddWithValue("@city_id", city_id);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public DataTable CRMLeadSelectforReport(string region, string state, string city, string office_id, DateTime from_date, DateTime to_date, string assign_emp, string type, string lead_source, string leadStatus, string createdBy, string otherUser, string lead_no, int ExpectedRevenue)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "CRMLeadSelectforReport";
    //        objCommand.Parameters.AddWithValue("@region_id", region);
    //        objCommand.Parameters.AddWithValue("@state_id", state);
    //        objCommand.Parameters.AddWithValue("@city_id", city);
    //        objCommand.Parameters.AddWithValue("@office_id", office_id);
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@assign_emp", assign_emp);
    //        objCommand.Parameters.AddWithValue("@type", type);
    //        objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //        objCommand.Parameters.AddWithValue("@leadStatus", leadStatus);
    //        objCommand.Parameters.AddWithValue("@createdBy", createdBy);
    //        objCommand.Parameters.AddWithValue("@otherUser", otherUser);
    //        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
    //        objCommand.Parameters.AddWithValue("@ExpectedRevenue", ExpectedRevenue);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];

    //    }
    //}
    //public SqlDataReader SalesExecSelect(string office_id)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "SalesExecSelect";
    //    objCommand.Parameters.AddWithValue("@office_id", office_id);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader CRMUserselectForMsg(string office_id)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMUserselectForMsg";
    //    objCommand.Parameters.AddWithValue("@office_id", office_id);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader CRMIndUserselectForMsg(string office_id, string user_id)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMIndUserselectForMsg";
    //    objCommand.Parameters.AddWithValue("@office_id", office_id);
    //    objCommand.Parameters.AddWithValue("@user_id", user_id);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader CheckQuote(string lead_no)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CheckQuote";
    //    objCommand.Parameters.AddWithValue("@lead_no", lead_no);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader CheckExistingLead(string email)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CheckExistingLead";
    //    objCommand.Parameters.AddWithValue("@email", email);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader AllLeadStatus(string lead_no)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "AllLeadStatus";
    //    objCommand.Parameters.AddWithValue("@lead_no", lead_no);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader CRMLeadZone_select(string lead_source)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMLeadZone_select";
    //    objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader CRMZone_wise_emp(string zone_id)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMZone_wise_emp";
    //    objCommand.Parameters.AddWithValue("@zone_id", zone_id);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader State_select_all(string country)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "State_select_all";
    //    objCommand.Parameters.AddWithValue("@country", @country);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader city_select_all(string state)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "city_select_all";
    //    objCommand.Parameters.AddWithValue("@state", state);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader RelatedTopicSelect()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "RelatedTopicSelect";

    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader RelatedRequestId(string Leadno)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "RelatedRequestId";
    //    objCommand.Parameters.AddWithValue("@Lead_no", Leadno);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader RelatedEquipmentId(string Leadno)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "RelatedEquipmentId";
    //    objCommand.Parameters.AddWithValue("@Lead_no", Leadno);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader select_callog(string Lead_no)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "select_callog";
    //    objCommand.Parameters.AddWithValue("@Lead_no", Lead_no);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public string CallLogInsert(clsSales objSales)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "CallLogInsert";
    //        objCommand.Parameters.AddWithValue("@lead_no", objSales.LeadNo);
    //        objCommand.Parameters.AddWithValue("@description", objSales.Description);
    //        objCommand.Parameters.AddWithValue("@Relatedto", objSales.RelatedTo);
    //        objCommand.Parameters.AddWithValue("@Requestid", objSales.Requestid);
    //        objCommand.Parameters.AddWithValue("@equipmentid", objSales.equipmentid);
    //        objCommand.Parameters.AddWithValue("@Created_by", objSales.User);


    //        dataReader = objCommand.ExecuteReader();
    //        string j = "0";
    //        if (dataReader.Read())
    //        {
    //            j = "1";
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}
    //public DataTable CRMAssignLeadReport(DateTime from_date, DateTime to_date, string leadStatus, string lead_no, int service_type, string @officeid)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "CRMAssignLeadReport";

    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@leadStatus", leadStatus);
    //        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
    //        objCommand.Parameters.AddWithValue("@service_type", service_type);
    //        objCommand.Parameters.AddWithValue("@officeid", officeid);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];

    //    }
    //}

    //public SqlDataReader CRMDepartment()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "crmdeparmentreport";
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public DataSet CRMAttendancestatusreport()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMAttendancestatusreport";
    //    objCommand.Connection = objConnection;
    //    objDataAdapter = new SqlDataAdapter();
    //    objDataAdapter.SelectCommand = objCommand;
    //    objDataSet = new DataSet();
    //    objDataAdapter.Fill(objDataSet);
    //    objCommand.Dispose();
    //    objConnection.Close();
    //    objConnection.Dispose();
    //    return objDataSet;

    //    //dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    //objCommand.Dispose();
    //    //objCommand = null;
    //    //objConnection = null;

    //    //return dataReader;
    //}
    //public DataSet CRMReason()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMReasonreport";
    //    objCommand.Connection = objConnection;

    //    objDataAdapter = new SqlDataAdapter();
    //    objDataAdapter.SelectCommand = objCommand;
    //    objDataSet = new DataSet();
    //    objDataAdapter.Fill(objDataSet);
    //    objCommand.Dispose();
    //    objConnection.Close();
    //    objConnection.Dispose();
    //    return objDataSet;
    //    //dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    //objCommand.Dispose();
    //    //objCommand = null;
    //    //objConnection = null;

    //    //return dataReader;
    //}
    //public SqlDataReader attendanceviewforinsert(string supervisorid, string departmentid, DateTime from_date)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "attendanceviewforinsert";
    //    objCommand.Parameters.AddWithValue("@departmentid", departmentid);
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public int CRMattendanceinsert(string id, string name, string attstatus, string reasonid, string remarks, DateTime from_date, char flag, string user, string supervisorid, string departmentid)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "CRMattendanceinsert";
    //        objCommand.Parameters.AddWithValue("@id", id);
    //        objCommand.Parameters.AddWithValue("@name", name);
    //        objCommand.Parameters.AddWithValue("@attendance_status", attstatus);
    //        objCommand.Parameters.AddWithValue("@reason", reasonid);
    //        objCommand.Parameters.AddWithValue("@remarks", remarks);
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@flag", flag);
    //        objCommand.Parameters.AddWithValue("@user", user);
    //        objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //        objCommand.Parameters.AddWithValue("@departmentid", departmentid);

    //        dataReader = objCommand.ExecuteReader();
    //        int j = 0;
    //        if (dataReader.Read())
    //        {
    //            j = 1;
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}

    //public DataSet CRMOffice()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMOfficeSelect";
    //    objCommand.Connection = objConnection;
    //    objDataAdapter = new SqlDataAdapter();
    //    objDataAdapter.SelectCommand = objCommand;
    //    objDataSet = new DataSet();
    //    objDataAdapter.Fill(objDataSet);
    //    objCommand.Dispose();
    //    objConnection.Close();
    //    objConnection.Dispose();
    //    return objDataSet;

    //    //dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    //objCommand.Dispose();
    //    //objCommand = null;
    //    //objConnection = null;
    //    //return dataReader;
    //}
    //public SqlDataReader crmUserCheck(string supervisorid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "crmUserCheck";
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}


    //public SqlDataReader attendancereport(string monthid, string department, string supervisor)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "attendancereport";
    //    objCommand.Parameters.AddWithValue("@month", monthid);
    //    objCommand.Parameters.AddWithValue("@department", department);
    //    objCommand.Parameters.AddWithValue("@supervisor", supervisor);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader attendancereportdetail(string monthid, string empid, string department, string supervisor)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "attendancereportdetail";
    //    objCommand.Parameters.AddWithValue("@month", monthid);
    //    objCommand.Parameters.AddWithValue("@empid", empid);
    //    objCommand.Parameters.AddWithValue("@department", department);
    //    objCommand.Parameters.AddWithValue("@supervisor", supervisor);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public DataTable calllogdetail_report(DateTime from_date, DateTime to_date, string lead_no, string lead_source, string leadStatus, string officeid)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "calllogdetail_report";
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
    //        objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //        objCommand.Parameters.AddWithValue("@lead_Status", leadStatus);
    //        objCommand.Parameters.AddWithValue("@officeid", officeid);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];

    //    }
    //}
    //public SqlDataReader LeadcancelReason(int status)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "LeadcancelReason";
    //    objCommand.Parameters.AddWithValue("@status", status);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader SelectEmployee()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "SelectEmployee";
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader selectservice()
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "selectservice";
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader Daytoday_transactioncount(string type)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transactioncount";
    //    objCommand.Parameters.AddWithValue("@type", type);

    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public DataTable sp_renewal_report(DateTime from_date, DateTime to_date, int type)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "sp_invoice_report";
    //        objCommand.Parameters.AddWithValue("@type", type);
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);


    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];

    //    }
    //}
    //public SqlDataReader Daytoday_transaction(string type, DateTime fromdate, string officeid, DateTime todate)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transaction";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", fromdate);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Parameters.AddWithValue("@todate", todate);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader Daytoday_transactionReq(string type, DateTime from_date, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transactionReq";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", from_date);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader Daytoday_transactionReqCount(string type)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transactionReqCount";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}

    //public DataTable salesdashboard_revenue(string type, DateTime from_date, DateTime to_date, string userid, string supervisorid, string lead_source, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "salesdashboard_revenue";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@userid", userid);
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    objDataAdapter = new SqlDataAdapter();
    //    objDataAdapter.SelectCommand = objCommand;
    //    objDataTable = new DataTable();
    //    objDataAdapter.Fill(objDataTable);
    //    objCommand.Dispose();
    //    objConnection.Close();
    //    objConnection.Dispose();
    //    return objDataTable;

    //}
    //public DataTable salesdashboard_topconversion(DateTime from_date, DateTime to_date)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "salesdashboard_topconversion";
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Connection = objConnection;
    //    objDataAdapter = new SqlDataAdapter();
    //    objDataAdapter.SelectCommand = objCommand;
    //    objDataTable = new DataTable();
    //    objDataAdapter.Fill(objDataTable);
    //    objCommand.Dispose();
    //    objConnection.Close();
    //    objConnection.Dispose();
    //    return objDataTable;

    //}
    //public SqlDataReader salesdashboard_employee(string type, string name)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "salesdashboard_employee";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@name", name);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader salesdashboard_leaddetail(string type, DateTime from_date, DateTime to_date, string userid, string supervisorid, string lead_source)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "salesdashboard_leaddetail";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@userid", userid);
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader salesdashboard_individualconversion(DateTime from_date, DateTime to_date, string userid, string lead_source, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "salesdashboard_individualconversion";
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@userid", userid);
    //    objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader crmsupervisor_employee(string supervisorid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "crmsupervisor_employee";
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader crmsupervisorreport_fordashboard(string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "crmsupervisorreport_fordashboard";
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader salesdashboard_totalconversion_Sup(DateTime from_date, DateTime to_date, string supervisorid, string lead_source, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "salesdashboard_totalconversion_Sup";
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}
    //public SqlDataReader dealsandu_promocode_select(string promocode, int type)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "dealsandu_promocode_select";
    //    objCommand.Parameters.AddWithValue("@promocode", promocode);
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}

    //public DataTable leadorgin_report(DateTime from_date, DateTime to_date, string lead_source, string officeid, string search, string search1, string type)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "leadorgin_report";
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //        objCommand.Parameters.AddWithValue("@officeid", officeid);
    //        objCommand.Parameters.AddWithValue("@search", search);
    //        objCommand.Parameters.AddWithValue("@search1", search1);
    //        objCommand.Parameters.AddWithValue("@type", type);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];
    //    }
    //}
    //public string leadorgin_insert(clsSales objSales)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "leadorgin_insert";
    //        objCommand.Parameters.AddWithValue("@lead_no", objSales.LeadNo);
    //        objCommand.Parameters.AddWithValue("@first_name", objSales.FirstName);
    //        objCommand.Parameters.AddWithValue("@last_name", objSales.LastName);
    //        objCommand.Parameters.AddWithValue("@company", objSales.Company);
    //        objCommand.Parameters.AddWithValue("@lead_source", objSales.LeadSource);
    //        objCommand.Parameters.AddWithValue("@mobile", objSales.Mobile);
    //        objCommand.Parameters.AddWithValue("@email", objSales.Email);
    //        objCommand.Parameters.AddWithValue("@Assign_office", objSales.Assign_office);
    //        objCommand.Parameters.AddWithValue("@street", objSales.Street);
    //        objCommand.Parameters.AddWithValue("@city", objSales.City);
    //        objCommand.Parameters.AddWithValue("@description", objSales.Description);
    //        objCommand.Parameters.AddWithValue("@user", objSales.User);
    //        objCommand.Parameters.AddWithValue("@orgin", objSales.orgin);
    //        objCommand.Parameters.AddWithValue("@SMS_datetime", objSales.SMS_datetime);
    //        dataReader = objCommand.ExecuteReader();
    //        string j = "0";
    //        if (dataReader.Read())
    //        {
    //            j = dataReader[0].ToString();
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}
    //public string support_smsshortcode_insert(clsSales objSales)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "support_smsshortcode_insert";
    //        objCommand.Parameters.AddWithValue("@requestid", objSales.requestid);
    //        objCommand.Parameters.AddWithValue("@name", objSales.name);
    //        objCommand.Parameters.AddWithValue("@source", objSales.source);
    //        objCommand.Parameters.AddWithValue("@mobile", objSales.Mobile);
    //        objCommand.Parameters.AddWithValue("@email", objSales.Email);
    //        objCommand.Parameters.AddWithValue("@Assign_office", objSales.Assign_office);
    //        objCommand.Parameters.AddWithValue("@city", objSales.City);
    //        objCommand.Parameters.AddWithValue("@description", objSales.Description);
    //        objCommand.Parameters.AddWithValue("@user", objSales.User);
    //        objCommand.Parameters.AddWithValue("@orgin", objSales.orgin);
    //        objCommand.Parameters.AddWithValue("@SMS_datetime", objSales.SMS_datetime);
    //        dataReader = objCommand.ExecuteReader();
    //        string j = "0";
    //        if (dataReader.Read())
    //        {
    //            j = dataReader[0].ToString();
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}
    //public DataTable support_smsshortcode_report(DateTime from_date, DateTime to_date, string source, string officeid)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "support_smsshortcode_report ";
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@source", source);
    //        objCommand.Parameters.AddWithValue("@officeid", officeid);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];
    //    }
    //}

    //public SqlDataReader daytodayTRC_transaction(DateTime from_date, DateTime to_date, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "daytodayTRC_transaction";
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}

    //public SqlDataReader TRC_dashboardrevenue(DateTime from_date, DateTime to_date, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "TRC_dashboardrevenue";
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader Daytoday_transactionRequest(string type, DateTime from_date, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transactionRequest";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", from_date);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public DataTable callback_reminder_view(DateTime from_date, DateTime to_date, string office_id, string search, string search1, string status, string reminder_to)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "callback_reminder_view";
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@office_id", office_id);
    //        objCommand.Parameters.AddWithValue("@search", search);
    //        objCommand.Parameters.AddWithValue("@search1", search1);
    //        objCommand.Parameters.AddWithValue("@status", status);
    //        objCommand.Parameters.AddWithValue("@reminder_to", reminder_to);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];
    //    }
    //}
    //public SqlDataReader callback_reminder_view1(DateTime from_date, DateTime to_date, string office_id, string search)
    //{
    //    //using (SqlConnection objConnection = new SqlConnection(con_str))
    //    //{


    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "callback_reminder_view";
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@office_id", office_id);
    //    objCommand.Parameters.AddWithValue("@search", search);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //    //}

    //}
    //public SqlDataReader callback_reminder_foredit(string sno)
    //{
    //    //using (SqlConnection objConnection = new SqlConnection(con_str))
    //    //{


    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "callback_reminder_foredit";
    //    objCommand.Parameters.AddWithValue("@sno", sno);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //    //}
    //}
    //public SqlDataReader get_timeconversion(string time)
    //{
    //    //using (SqlConnection objConnection = new SqlConnection(con_str))
    //    //{


    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "get_timeconversion";
    //    objCommand.Parameters.AddWithValue("@time", time);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //    //}
    //}

    //public SqlDataReader Daytoday_transaction_bdsales(string type, DateTime from_date, string officeid)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transaction_bdsales";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", from_date);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public string CRMstatus_insert(clsSales objSales)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "sp_CRMstatus_insert";
    //        objCommand.Parameters.AddWithValue("@empid", empid);
    //        objCommand.Parameters.AddWithValue("@status", status);
    //        dataReader = objCommand.ExecuteReader();
    //        string j = "0";
    //        if (dataReader.Read())
    //        {
    //            j = dataReader[0].ToString();
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;
    //    }
    //}
    //public DataTable crmworkingstatus_view()
    //{
    //    //objConnection = new SqlConnection(con_str);
    //    //objConnection.ConnectionString = con_str;
    //    //objConnection.Open();
    //    //objCommand = new SqlCommand();
    //    //objCommand.CommandType = CommandType.StoredProcedure;
    //    //objCommand.CommandTimeout = 0;
    //    //objCommand.CommandText = "crmworkingstatus_view";
    //    //objCommand.Connection = objConnection;
    //    //dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    //objCommand.Dispose();
    //    ////objConnection.Close();
    //    //objCommand = null;
    //    //objConnection = null;    
    //    //return dataReader;

    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "crmworkingstatus_view";
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];
    //    }

    //}
    //public SqlDataReader CRMstatus_select(clsSales objSales)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMstatus_select ";
    //    objCommand.Parameters.AddWithValue("@empid", empid);
    //    objCommand.Parameters.AddWithValue("@status", status);
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@to_date", to_date);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Parameters.AddWithValue("@flag", Flag);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public DataTable CRMstatus_select_agent(clsSales objSales)
    //{


    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "CRMstatus_select_agent";
    //        objCommand.Parameters.AddWithValue("@empid", empid);
    //        objCommand.Parameters.AddWithValue("@status", status);
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@officeid", officeid);
    //        objCommand.Parameters.AddWithValue("@flag", Flag);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];
    //    }

    //}
    //public string lead_allocationto_agent_insert(clsSales objSales)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "lead_allocationto_agent_insert";
    //        objCommand.Parameters.AddWithValue("@customername", objSales.FirstName);
    //        objCommand.Parameters.AddWithValue("@email", objSales.Email);
    //        objCommand.Parameters.AddWithValue("@mobile_no", objSales.Mobile);
    //        objCommand.Parameters.AddWithValue("@lead_source", objSales.LeadSource);
    //        objCommand.Parameters.AddWithValue("@officeid", objSales.Assign_office);
    //        objCommand.Parameters.AddWithValue("@issue", objSales.Description);

    //        dataReader = objCommand.ExecuteReader();
    //        string j = "0";
    //        if (dataReader.Read())
    //        {
    //            j = dataReader[0].ToString();
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}
    //public DataTable Lead_allocation_agent_view(DateTime from_date, DateTime to_date, string officeid, string allocate_to, string search, string type)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "Lead_allocation_agent_view";
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@officeid", officeid);
    //        objCommand.Parameters.AddWithValue("@allocate_to", allocate_to);
    //        objCommand.Parameters.AddWithValue("@search", search);
    //        objCommand.Parameters.AddWithValue("@type", type);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];
    //    }
    //}
    //public string leadallocationstatus_update(string leadno, string lead_status, string allocate_to, string type)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "leadallocationstatus_update";
    //        objCommand.Parameters.AddWithValue("@leadno", leadno);
    //        objCommand.Parameters.AddWithValue("@lead_status", lead_status);
    //        objCommand.Parameters.AddWithValue("@allocate_to", allocate_to);
    //        objCommand.Parameters.AddWithValue("@type", type);
    //        dataReader = objCommand.ExecuteReader();
    //        string j = "0";
    //        if (dataReader.Read())
    //        {
    //            j = dataReader[0].ToString();
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}
    //public SqlDataReader Daytoday_transaction_inbound(string type, DateTime fromdate, string officeid, DateTime todate)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transaction_inbound";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", fromdate);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Parameters.AddWithValue("@todate", todate);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public string Lead_customer_insert_attero(clsSales objSales)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objConnection.Open();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandTimeout = 0;
    //        objCommand.CommandText = "Lead_customer_insert_attero";
    //        objCommand.Parameters.AddWithValue("@lead_no", objSales.LeadNo);
    //        objCommand.Parameters.AddWithValue("@first_name", objSales.FirstName);
    //        objCommand.Parameters.AddWithValue("@last_name", objSales.LastName);
    //        objCommand.Parameters.AddWithValue("@company", objSales.Company);
    //        objCommand.Parameters.AddWithValue("@lead_source", objSales.LeadSource);
    //        objCommand.Parameters.AddWithValue("@lead_status", objSales.LeadStatus);
    //        objCommand.Parameters.AddWithValue("@phone", objSales.Phone);
    //        objCommand.Parameters.AddWithValue("@mobile", objSales.Mobile);
    //        objCommand.Parameters.AddWithValue("@email", objSales.Email);
    //        objCommand.Parameters.AddWithValue("@Assign_office", objSales.Assign_office);
    //        objCommand.Parameters.AddWithValue("@street", objSales.Street);
    //        objCommand.Parameters.AddWithValue("@country", objSales.Country);
    //        objCommand.Parameters.AddWithValue("@city", objSales.City);
    //        objCommand.Parameters.AddWithValue("@state", objSales.State);
    //        objCommand.Parameters.AddWithValue("@description", objSales.Description);
    //        objCommand.Parameters.AddWithValue("@user", objSales.User);
    //        objCommand.Parameters.AddWithValue("@flag", objSales.Flag);
    //        objCommand.Parameters.AddWithValue("@valid_date", objSales.ValidDate);
    //        objCommand.Parameters.AddWithValue("@Desktop", objSales.Desktop);
    //        objCommand.Parameters.AddWithValue("@Laptop", objSales.Laptop);
    //        objCommand.Parameters.AddWithValue("@Server", objSales.Server);
    //        objCommand.Parameters.AddWithValue("@Printer", objSales.Printer);
    //        objCommand.Parameters.AddWithValue("@titleType", objSales.TitleType);
    //        objCommand.Parameters.AddWithValue("@servicetype", objSales.servicetype);
    //        objCommand.Parameters.AddWithValue("@promocode_addon1", objSales.sourceofsale);
    //        objCommand.Parameters.AddWithValue("@promocode_addon2", objSales.sourcename);
    //        objCommand.Parameters.AddWithValue("@ExpectedRevenue", objSales.ExpectedRevenue);
    //        objCommand.Parameters.AddWithValue("@paymentmode", objSales.paymentmode);
    //        objCommand.Parameters.AddWithValue("@ChequeNo", objSales.ChequeNo);
    //        dataReader = objCommand.ExecuteReader();
    //        string j = "0";
    //        if (dataReader.Read())
    //        {
    //            j = dataReader[0].ToString();
    //        }
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        dataReader.Close();
    //        return j;

    //    }
    //}
    //public DataTable crmleadlist_attero(DateTime from_date, DateTime to_date, string leadStatus, string search)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "crmleadlist_attero";
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@leadStatus", leadStatus);
    //        objCommand.Parameters.AddWithValue("@search", search);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];

    //    }

    //}
    //public SqlDataReader CRMLeadSelect_for_update_attero(string lead_no)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "CRMLeadSelect_for_update_attero";
    //    objCommand.Parameters.AddWithValue("@lead_no", lead_no);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader Daytoday_transaction_supervisor(string type, DateTime fromdate, string supervisorid, DateTime todate)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transaction_supervisor";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", fromdate);
    //    objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //    objCommand.Parameters.AddWithValue("@todate", todate);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public DataTable agentsalesreport(string office_id, DateTime from_date, DateTime to_date, string lead_source, string leadStatus, string supervisorid, string createdBy)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {


    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "agentsalesreport";
    //        objCommand.Parameters.AddWithValue("@office_id", office_id);
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@lead_source", lead_source);
    //        objCommand.Parameters.AddWithValue("@leadStatus", leadStatus);
    //        objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //        objCommand.Parameters.AddWithValue("@createdBy", createdBy);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];

    //    }
    //}
    //public DataTable agentsales_performance_report(string office_id, DateTime from_date, DateTime to_date, string supervisorid)
    //{
    //    using (SqlConnection objConnection = new SqlConnection(con_str))
    //    {

    //        SqlCommand objCommand;
    //        objCommand = objConnection.CreateCommand();
    //        objCommand.CommandType = CommandType.StoredProcedure;
    //        objCommand.CommandText = "agentsales_performance_report";
    //        objCommand.Parameters.AddWithValue("@office_id", office_id);
    //        objCommand.Parameters.AddWithValue("@from_date", from_date);
    //        objCommand.Parameters.AddWithValue("@to_date", to_date);
    //        objCommand.Parameters.AddWithValue("@supervisorid", supervisorid);
    //        objConnection.Open();
    //        objDataAdapter = new SqlDataAdapter();
    //        objDataAdapter.SelectCommand = objCommand;
    //        objDataSet = new DataSet();
    //        objDataAdapter.Fill(objDataSet);
    //        objCommand.Dispose();
    //        objConnection.Close();
    //        objConnection.Dispose();
    //        return objDataSet.Tables[0];

    //    }
    //}
    //public SqlDataReader Daytoday_transaction_agent(string type, DateTime fromdate, string agentid, DateTime todate)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transaction_agent";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", fromdate);
    //    objCommand.Parameters.AddWithValue("@agentid", agentid);
    //    objCommand.Parameters.AddWithValue("@todate", todate);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    //public SqlDataReader Daytoday_transaction_outbound(string type, DateTime fromdate, string officeid, DateTime todate)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "Daytoday_transaction_outbound";
    //    objCommand.Parameters.AddWithValue("@type", type);
    //    objCommand.Parameters.AddWithValue("@fromdate", fromdate);
    //    objCommand.Parameters.AddWithValue("@officeid", officeid);
    //    objCommand.Parameters.AddWithValue("@todate", todate);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
}

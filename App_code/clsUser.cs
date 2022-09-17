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
using System.Configuration;
using System.Net.Mail;
using System.Data;

/// <summary>
/// Summary description for clsUser
/// </summary>
public class clsUser
{
    public clsUser()
    {

    }
    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;

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
    private string _w;
         public string w
    {
        get
        {
            return _w;
        }
        set
        {
            _w = value;
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
    private string _emp_id;
    public string emp_id
    {
        get
        {
            return _emp_id;
        }
        set
        {
            _emp_id = value;
        }
    }
    private string _emp_code;
    public string emp_code
    {
        get
        {
            return _emp_code;
        }
        set
        {
            _emp_code = value;
        }
    }
    private string _emp_name;
    public string emp_name
    {
        get
        {
            return _emp_name;
        }
        set
        {
            _emp_name = value;
        }
    }
    private string _password;
    public string password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
        }
    }
    private string _write;
    public string write
    {
        get
        {
            return _write;
        }
        set
        {
            _write = value;
        }
    }
    private string _rd;
    public string rd
    {
        get
        {
            return _rd;
        }
        set
        {
            _rd = value;
        }
    }
    private string _comp_id;
    public string comp_id
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
    private string _middle_name;
    public string middle_name
    {
        get
        {
            return _middle_name;
        }
        set
        {
            _middle_name = value;
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

    private string _Serial_no;
        public string Serial_no
    {
        get
        {
            return _Serial_no;
        }
        set
        {
            _Serial_no = value;
        }
    }
    private string _mobile_no1;
    public string mobile_no1
    {
        get
        {
            return _mobile_no1;
        }
        set
        {
            _mobile_no1 = value;
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
    private DateTime _DOJ;
    public DateTime DOJ
    {
        get
        {
            return _DOJ;
        }
        set
        {
            _DOJ = value;
        }
    }
    private DateTime _DOb;
    public DateTime DOb
    {
        get
        {
            return _DOb;
        }
        set
        {
            _DOb = value;
        }
    }
    private string _emp_image;
    public string emp_image
    {
        get
        {
            return _emp_image;
        }
        set
        {
            _emp_image = value;
        }
    }
    private string _active;
    public string active
    {
        get
        {
            return _active;
        }
        set
        {
            _active = value;
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
    private string _designation;
    public string designation
    {
        get
        {
            return _designation;
        }
        set
        {
            _designation = value;
        }
    }
    private string _subDesignation;
    public string subDesignation
    {
        get
        {
            return _subDesignation;
        }
        set
        {
            _subDesignation = value;
        }
    }
    private string _departmentid;
    public string departmentid
    {
        get
        {
            return _departmentid;
        }
        set
        {
            _departmentid = value;
        }
    }
    private string _Supervisorid;
    public string Supervisorid
    {
        get
        {
            return _Supervisorid;
        }
        set
        {
            _Supervisorid = value;
        }
    }

//private string _Supervisorid;
//    public string Supervisorid
//    {
//        get
//        {
//            return _Supervisorid;
//        }
//        set
//        {
//            _Supervisorid = value;
//        }
//    }



    private string _role;
    public string role
    {
        get
        {
            return _role;
        }
        set
        {
            _role = value;
        }
    }
    private string _cityid;
    public string cityid
    {
        get
        {
            return _cityid;
        }
        set
        {
            _cityid = value;
        }
    }
    private string _zoneid;
    public string zoneid
    {
        get
        {
            return _zoneid;
        }
        set
        {
            _zoneid = value;
        }
    }
    private string _location;
    public string location
    {
        get
        {
            return _location;
        }
        set
        {
            _location = value;
        }
    }
    private string _last_reset_date;
    public string last_reset_date
    {
        get
        {
            return _last_reset_date;
        }
        set
        {
            _last_reset_date = value;
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
    private string _Branch_Name;
    public string Branch_Name
    {
        get
        {
            return _Branch_Name;
        }
        set
        {
            _Branch_Name = value;
        }
    }


    public SqlDataReader tempEMPLOYEE_Attendance_Report(string monthid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "tempEMPLOYEE_Attendance_Report";

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader EMPLOYEE_Attendance_Report(string monthid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "EMPLOYEE_Attendance_Report";
        objCommand.Parameters.AddWithValue("@monthid", monthid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader attendancereport_pivot(string monthid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "attendancereport_pivot";
        objCommand.Parameters.AddWithValue("@monthid", monthid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

   
    public SqlDataReader Daily_Attendance_Report(DateTime from_date)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Daily_Attendance_Report";
        //  objCommand.Parameters.AddWithValue("@department_id", department_id);
        // objCommand.Parameters.AddWithValue("@Supervisor_id", Supervisor_id);
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public string crm_user_insert(clsUser objUser)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crm_user_insert";
            objCommand.Parameters.AddWithValue("@emp_id", objUser.emp_id);
            objCommand.Parameters.AddWithValue("@emp_code", objUser.emp_code);
            objCommand.Parameters.AddWithValue("@emp_name", objUser.emp_name);
            objCommand.Parameters.AddWithValue("@password", objUser.password);
            objCommand.Parameters.AddWithValue("@address", objUser.address);
            objCommand.Parameters.AddWithValue("@active", objUser.active);
            objCommand.Parameters.AddWithValue("@Branch_Name", objUser.Branch_Name);
            objCommand.Parameters.AddWithValue("@mobile_no", objUser.mobile_no);
            objCommand.Parameters.AddWithValue("@role", objUser.role);
            objCommand.Parameters.AddWithValue("@created_by", objUser.created_by);
            objCommand.Parameters.AddWithValue("@flag", flag);

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


    public SqlDataReader crm_user_Detail_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_Detail_select";
       // objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader crmDepartment_att_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmDepartment_att_select";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public DataSet Leave_Reason_dd_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Leave_Reason_dd_select";
        objCommand.Connection = objConnection;
        objDataAdapter = new SqlDataAdapter();
        objDataAdapter.SelectCommand = objCommand;
        objDataSet = new DataSet();
        objDataAdapter.Fill(objDataSet);
        objCommand.Dispose();
        objConnection.Close();
        objConnection.Dispose();
        return objDataSet;

        //dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //objCommand.Dispose();
        //objCommand = null;
        //objConnection = null;

        //return dataReader;
    }

    public DataSet attendance_dd_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "attendance_dd_select";
        objCommand.Connection = objConnection;
        objDataAdapter = new SqlDataAdapter();
        objDataAdapter.SelectCommand = objCommand;
        objDataSet = new DataSet();
        objDataAdapter.Fill(objDataSet);
        objCommand.Dispose();
        objConnection.Close();
        objConnection.Dispose();
        return objDataSet;

        //dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        //objCommand.Dispose();
        //objCommand = null;
        //objConnection = null;

        //return dataReader;
    }

    public int CRM_attendance_insert(string Serial_no,string emp_id, string att_name, DateTime attendance_date,char flag, string created_by)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRM_attendance_insert";
            objCommand.Parameters.AddWithValue("@Serial_no", Serial_no);
            objCommand.Parameters.AddWithValue("@emp_id", emp_id);
            objCommand.Parameters.AddWithValue("@att_name", att_name);
            //objCommand.Parameters.AddWithValue("@intime", intime);
            //objCommand.Parameters.AddWithValue("@outtime", outtime);
            //objCommand.Parameters.AddWithValue("@leave_name", leave_name);
            //objCommand.Parameters.AddWithValue("@remarks", remarks);
            objCommand.Parameters.AddWithValue("@attendance_date", attendance_date);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@flag", flag);

            dataReader = objCommand.ExecuteReader();
            int j = 0;
            if (dataReader.Read())
            {
                j = 1;
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }

    public SqlDataReader CRM_attendance_insert_view( DateTime from_date)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRM_attendance_insert_view";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader crm_user_Detail_search(string emp_code, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_Detail_search";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public DataTable monthly_Attendance_Report(clsUser objUser)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "monthly_Attendance_Report";
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
    public DataTable crm_user_login_report(clsUser objUser)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crm_user_login_report";
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

    public SqlDataReader crm_user_login_check(string emp_code)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_login_check";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
       // objCommand.Parameters.AddWithValue("@emp_name", emp_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader crm_user_selectforlogin(string emp_code, string password)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_selectforlogin";
        objCommand.Parameters.AddWithValue("@emp_code",emp_code);
        objCommand.Parameters.AddWithValue("@password", password);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader user_login_selectforlogin(string username, string password)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "user_login_selectforlogin";
        objCommand.Parameters.AddWithValue("@username", username);
        objCommand.Parameters.AddWithValue("@password", password);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public string crmuserLogin_insert(string emp_id, string emp_code, string ipaddress, string sessionid, char Flag)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crmuserLogin_insert";
            objCommand.Parameters.AddWithValue("@emp_id", emp_id);
            objCommand.Parameters.AddWithValue("@emp_code", emp_code);
            objCommand.Parameters.AddWithValue("ipaddress", ipaddress);
            objCommand.Parameters.AddWithValue("@sessionid", sessionid);
            objCommand.Parameters.AddWithValue("@Flag", Flag);
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
    public SqlDataReader CRM_attendance_insert_view(string Branch_Name, DateTime from_date)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRM_attendance_insert_view";
        objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader user_login_Change_password(string password, string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "user_login_Change_password";
        objCommand.Parameters.AddWithValue("@password", password);
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Change_password(string password, string userid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Change_password";
        objCommand.Parameters.AddWithValue("@password", password);
        objCommand.Parameters.AddWithValue("@userid", userid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader crm_user_selectfordropdown(string designation, string officeid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_selectfordropdown";
        objCommand.Parameters.AddWithValue("@designation", designation);
        objCommand.Parameters.AddWithValue("@officeid", officeid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader crm_user_selectfordropdown1(string designation)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_selectfordropdown1";
        objCommand.Parameters.AddWithValue("@designation", designation);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader crm_user_select(string designation,string flag, string officeid)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_select";
        objCommand.Parameters.AddWithValue("@designation", designation);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Parameters.AddWithValue("@officeid", officeid);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();

        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader crm_iptable_select(string ip_address)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_iptable_select";
        objCommand.Parameters.AddWithValue("@ip_address",ip_address);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();

        objCommand = null;
        objConnection = null;

        return dataReader;

    }
    public SqlDataReader crmdesignationselect(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmdesignationselect";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader CheckUser(String emp_code)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckUser";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }


    public SqlDataReader crm_user_Detail_update(String emp_code,int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_Detail_update";
        objCommand.Parameters.AddWithValue("@emp_code", emp_code);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    //public SqlDataReader userSelectForUpdate(int id)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "userSelectForUpdate";
    //    objCommand.Parameters.AddWithValue("@id", id);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;

    //    return dataReader;
    //}


    public SqlDataReader crmsubdesignationselect(string designation_id,int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmsubdesignationselect";
        objCommand.Parameters.AddWithValue("@designation_id", designation_id);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
   
    public SqlDataReader companySelect(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "companySelect";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader RoleSelectProc(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "RoleSelectProc";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader crmsupervisor_select(string office_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmsupervisor_select";
        objCommand.Parameters.AddWithValue("@office_id", office_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    
    public SqlDataReader crmDepartment_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmDepartment_select";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }


    public int CRM_attendance_insert(string Serial_no, string strattstatus, string strReason, string strRemarks, DateTime dateTime, string strintime, string strouttime, char flag, string p)
    {
        throw new NotImplementedException();
    }
}

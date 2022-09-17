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
/// Summary description for testingclass
/// </summary>
public class testingclass
{
	public testingclass()
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

private string _closers;
    public string closers
    {
        get
        {
            return _closers;
        }
        set
        {
            _closers = value;
        }
    }
private string _yoke;
    public string yoke
    {
        get
        {
            return _yoke;
        }
        set
        {
            _yoke = value;
        }
    }

private string _sleeve1;
    public string sleeve1
    {
        get
        {
            return _sleeve1;
        }
        set
        {
            _sleeve1 = value;
        }
    }

private string _bottom;
    public string bottom
    {
        get
        {
            return _bottom;
        }
        set
        {
            _bottom = value;
        }
    }
private string _pocket;
    public string pocket
    {
        get
        {
            return _pocket;
        }
        set
        {
            _pocket = value;
        }
    }

private string _armhole;
    public string armhole
    {
        get
        {
            return _armhole;
        }
        set
        {
            _armhole = value;
        }
    }
 private string _side_seam;
    public string side_seam
    {
        get
        {
            return _side_seam;
        }
        set
        {
            _side_seam = value;
        }
    }
 private string _waist;
    public string waist
    {
        get
        {
            return _waist;
        }
        set
        {
            _waist = value;
        }
    }


    private string _cuff;
    public string cuff
    {
        get
        {
            return _cuff;
        }
        set
        {
            _cuff = value;
        }
    }

    private string _shoulder;
    public string shoulder
    {
        get
        {
            return _shoulder;
        }
        set
        {
            _shoulder = value;
        }
    }

    private string _sleeve;
    public string sleeve
    {
        get
        {
            return _sleeve;
        }
        set
        {
            _sleeve = value;
        }
    }

   private string _collar;
    public string collar
    {
        get
        {
            return _collar;
        }
        set
        {
            _collar = value;
        }
    }

private string _plkt;
    public string plkt
    {
        get
        {
            return _plkt;
        }
        set
        {
            _plkt = value;
        }
    }
 private string _back;
    public string back
    {
        get
        {
            return _back;
        }
        set
        {
            _back = value;
        }
    }
private string _front;
    public string front
    {
        get
        {
            return _front;
        }
        set
        {
            _front = value;
        }
    }

 private string _error_name;
    public string error_name
    {
        get
        {
            return _error_name;
        }
        set
        {
            _error_name = value;
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
    private string _error_id;
    public string error_id
    {
        get
        {
            return _error_id;
        }
        set
        {
            _error_id = value;
        }
    }
    public SqlDataReader qctable_daywise_update(string serial_no, int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "qctable_daywise_update";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);

        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public DataTable qctable_daywise_select(testingclass objtest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "qctable_daywise_select";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@error_id", error_id);
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


    //public SqlDataReader qctable_daywise_select(testingclass objtest)
    //{
    //    objConnection = new SqlConnection(con_str);
    //    objConnection.ConnectionString = con_str;
    //    objConnection.Open();
    //    objCommand = new SqlCommand();
    //    objCommand.CommandType = CommandType.StoredProcedure;
    //    objCommand.CommandTimeout = 0;
    //    objCommand.CommandText = "qctable_daywise_select";
    //    objCommand.Parameters.AddWithValue("@from_date", from_date);
    //    objCommand.Parameters.AddWithValue("@error_id", error_id);
    //    objCommand.Connection = objConnection;
    //    dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
    //    objCommand.Dispose();
    //    objCommand = null;
    //    objConnection = null;
    //    return dataReader;
    //}
    public SqlDataReader errortable_dropdown( int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "errortable_dropdown";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
   
    public string qctable_daywise_insert(testingclass objtest)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "qctable_daywise_insert";
            objCommand.Parameters.AddWithValue("@serial_no", serial_no);
            objCommand.Parameters.AddWithValue("@error_id", error_id);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@front", front);
            //objCommand.Parameters.AddWithValue("@from_date ", from_date);
            objCommand.Parameters.AddWithValue("@closers ", closers);
            objCommand.Parameters.AddWithValue("@yoke", yoke);
            objCommand.Parameters.AddWithValue("@sleeve1", sleeve1);
            objCommand.Parameters.AddWithValue("@bottom", bottom);
            objCommand.Parameters.AddWithValue("@pocket", pocket);
            objCommand.Parameters.AddWithValue("@armhole", armhole);
            objCommand.Parameters.AddWithValue("@side_seam", side_seam);
            objCommand.Parameters.AddWithValue("@waist", waist);
            objCommand.Parameters.AddWithValue("@cuff", cuff);
            objCommand.Parameters.AddWithValue("@shoulder", shoulder);
            objCommand.Parameters.AddWithValue("@sleeve", sleeve);
            objCommand.Parameters.AddWithValue("@collar", collar);
            objCommand.Parameters.AddWithValue("@back", back);
            objCommand.Parameters.AddWithValue("@plkt", plkt);
            objCommand.Parameters.AddWithValue("@flag",flag);
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
  
}
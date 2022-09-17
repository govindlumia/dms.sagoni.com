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

public class maincode
{
    string con_str = ConfigurationManager.ConnectionStrings["SlickTicket"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;

    public maincode()
    {

    }
    private DateTime _birth;
    public DateTime birth
    {
        get
        {
            return _birth;
        }
        set
        {
            _birth = value;
        }
    }

    private string _STATUS;
    public string STATUS
    {
        get
        {
            return _STATUS;
        }
        set
        {
            _STATUS = value;
        }
    }
    private string _CIN;
    public string CIN
    {
        get
        {
            return _CIN;
        }
        set
        {
            _CIN = value;
        }
    }
    private string _registrationno;
    public string registrationno
    {
        get
        {
            return _registrationno;
        }
        set
        {
            _registrationno = value;
        }
    }
    private string _Time;
    public string Time
    {
        get
        {
            return _Time;
        }
        set
        {
            _Time = value;
        }
    }
    private string _patient_Name;
    public string patient_Name
    {
        get
        {
            return _patient_Name;
        }
        set
        {
            _patient_Name = value;
        }
    }
    private string _patient_Age;
    public string patient_Age
    {
        get
        {
            return _patient_Age;
        }
        set
        {
            _patient_Age = value;
        }
    }
    private string _patient_Contact;
    public string patient_Contact
    {
        get
        {
            return _patient_Contact;
        }
        set
        {
            _patient_Contact = value;
        }
    }
    private string _patient_Add;
    public string patient_Add
    {
        get
        {
            return _patient_Add;
        }
        set
        {
            _patient_Add = value;
        }
    }
    private string _patient_Gur;
    public string patient_Gur
    {
        get
        {
            return _patient_Gur;
        }
        set
        {
            _patient_Gur = value;
        }
    }
    private string _patient_Fee;
    public string patient_Fee
    {
        get
        {
            return _patient_Fee;
        }
        set
        {
            _patient_Fee = value;
        }
    }

    private DateTime _patient_date;
    public DateTime patient_date
    {
        get
        {
            return _patient_date;
        }
        set
        {
            _patient_date = value;
        }
    }
    private string _t_leave;
    public string t_leave
    {
        get
        {
            return _t_leave;
        }
        set
        {
            _t_leave = value;
        }
    }

    private string _Emailsub;
    public string Emailsub
    {
        get
        {
            return _Emailsub;
        }
        set
        {
            _Emailsub = value;
        }
    }
    private string _Expense_type;
    public string Expense_type
    {
        get
        {
            return _Expense_type;
        }
        set
        {
            _Expense_type = value;
        }
    }
    private string _t_absent;
    public string t_absent
    {
        get
        {
            return _t_absent;
        }
        set
        {
            _t_absent = value;
        }
    }
    private string _t_pesent;
    public string t_pesent
    {
        get
        {
            return _t_pesent;
        }
        set
        {
            _t_pesent = value;
        }
    }
    private string _quantity;
    public string quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            _quantity = value;
        }
    }
    private string _unitsell;
    public string unitsell
    {
        get
        {
            return _unitsell;
        }
        set
        {
            _unitsell = value;
        }
    }
    private string _subject;
    public string subject
    {
        get
        {
            return _subject;
        }
        set
        {
            _subject = value;
        }
    }
    private string _enq_sta;
    public string enq_sta
    {
        get
        {
            return _enq_sta;
        }
        set
        {
            _enq_sta = value;
        }
    }
    private string _pan;
    public string pan
    {
        get
        {
            return _pan;
        }
        set
        {
            _pan = value;
        }
    }
    private string _ta_n;
    public string ta_n
    {
        get
        {
            return _ta_n;
        }
        set
        {
            _ta_n = value;
        }
    }
    private string _other_detail;
    public string other_detail
    {
        get
        {
            return _other_detail;
        }
        set
        {
            _other_detail = value;
        }
    }
    private string _Associate_company;
    public string Associate_company
    {
        get
        {
            return _Associate_company;
        }
        set
        {
            _Associate_company = value;
        }
    }
    private string _Authorised_person;
    public string Authorised_person
    {
        get
        {
            return _Authorised_person;
        }
        set
        {
            _Authorised_person = value;
        }
    }
    private string _business_type;
    public string business_type
    {
        get
        {
            return _business_type;
        }
        set
        {
            _business_type = value;
        }
    }
    private string _bu_service;
    public string bu_service
    {
        get
        {
            return _bu_service;
        }
        set
        {
            _bu_service = value;
        }
    }
    /// <summary>
    /// //////////////
    /// </summary>

    private string _specialize;
    public string specialize
    {
        get
        {
            return _specialize;
        }
        set
        {
            _specialize = value;
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
    private string _payment_type;
    public string payment_type
    {
        get
        {
            return _payment_type;
        }
        set
        {
            _payment_type = value;
        }
    }
    private string _area;
    public string area
    {
        get
        {
            return _area;
        }
        set
        {
            _area = value;
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

    private string _fileName;
    public string fileName
    {
        get
        {
            return _fileName;
        }
        set
        {
            _fileName = value;
        }
    }
    private string _discussiontype;
    public string discussiontype
    {
        get
        {
            return _discussiontype;
        }
        set
        {
            _discussiontype = value;
        }
    }
    private string _discountitem;
    public string discountitem
    {
        get
        {
            return _discountitem;
        }
        set
        {
            _discountitem = value;
        }
    }
    private string _b_name;
    public string b_name
    {
        get
        {
            return _b_name;
        }
        set
        {
            _b_name = value;
        }
    }
    private string _username;
    public string username
    {
        get
        {
            return _username;
        }
        set
        {
            _username = value;
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
    private string _tin;
    public string tin
    {
        get
        {
            return _tin;
        }
        set
        {
            _tin = value;
        }
    }

    private string _servicetaxno;
    public string servicetaxno
    {
        get
        {
            return _servicetaxno;
        }
        set
        {
            _servicetaxno = value;
        }
    }

    private string _invoice_no;
    public string invoice_no
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
    private string _Quotation_No;
    public string Quotation_No
    {
        get
        {
            return _Quotation_No;
        }
        set
        {
            _Quotation_No = value;
        }
    }
    private string _dp_name;
    public string dp_name
    {
        get
        {
            return _dp_name;
        }
        set
        {
            _dp_name = value;
        }
    }
    private string _DoFeel;
    public string DoFeel
    {
        get
        {
            return _DoFeel;
        }
        set
        {
            _DoFeel = value;
        }
    }
    private string _prblm_face;
    public string prblm_face
    {
        get
        {
            return _prblm_face;
        }
        set
        {
            _prblm_face = value;
        }
    }
    private string _imprv;
    public string imprv
    {
        get
        {
            return _imprv;
        }
        set
        {
            _imprv = value;
        }
    }
    private string _working_details;
    public string working_details
    {
        get
        {
            return _working_details;
        }
        set
        {
            _working_details = value;
        }
    }
    private string _discount;
    public string discount
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
    private string _reg_emailID;
    public string reg_emailID
    {
        get
        {
            return _reg_emailID;
        }
        set
        {
            _reg_emailID = value;
        }
    }

    private string _sp_name;
    public string sp_name
    {
        get
        {
            return _sp_name;
        }
        set
        {
            _sp_name = value;
        }
    }
    private string _renewalamount;
    public string renewalamount
    {
        get
        {
            return _renewalamount;
        }
        set
        {
            _renewalamount = value;
        }
    }
    private string _fileupload;
    public string fileupload
    {
        get
        {
            return _fileupload;
        }
        set
        {
            _fileupload = value;
        }
    }
    private string _financial_year;
    public string financial_year
    {
        get
        {
            return _financial_year;
        }
        set
        {
            _financial_year = value;
        }
    }

    private string _swtware;
    public string swtware
    {
        get
        {
            return _swtware;
        }
        set
        {
            _swtware = value;
        }
    }

    private string _other_dominlist;
    public string other_dominlist
    {
        get
        {
            return _other_dominlist;
        }
        set
        {
            _other_dominlist = value;
        }
    }

    private DateTime _other_bookeddate;
    public DateTime other_bookeddate
    {
        get
        {
            return _other_bookeddate;
        }
        set
        {
            _other_bookeddate = value;
        }
    }

    private string _other_password;
    public string other_password
    {
        get
        {
            return _other_password;
        }
        set
        {
            _other_password = value;
        }
    }

    private string _other_regEmail;
    public string other_regEmail
    {
        get
        {
            return _other_regEmail;
        }
        set
        {
            _other_regEmail = value;
        }
    }

    private string _other_name;
    public string other_name
    {
        get
        {
            return _other_name;
        }
        set
        {
            _other_name = value;
        }
    }
    private string _znet_dominlist;
    public string znet_dominlist
    {
        get
        {
            return _znet_dominlist;
        }
        set
        {
            _znet_dominlist = value;
        }
    }

    private DateTime _znet_bookeddate;
    public DateTime znet_bookeddate
    {
        get
        {
            return _znet_bookeddate;
        }
        set
        {
            _znet_bookeddate = value;
        }
    }

    private string _znet_password;
    public string znet_password
    {
        get
        {
            return _znet_password;
        }
        set
        {
            _znet_password = value;
        }
    }

    private string _znet_regEmail;
    public string znet_regEmail
    {
        get
        {
            return _znet_regEmail;
        }
        set
        {
            _znet_regEmail = value;
        }
    }

    private string _znet_name;
    public string znet_name
    {
        get
        {
            return _znet_name;
        }
        set
        {
            _znet_name = value;
        }
    }
    private byte _size;
    public byte size
    {
        get
        {
            return _size;
        }
        set
        {
            _size = value;
        }
    }
    private string _net4_dominlist;
    public string net4_dominlist
    {
        get
        {
            return _net4_dominlist;
        }
        set
        {
            _net4_dominlist = value;
        }
    }

    private DateTime _net4_bookeddate;
    public DateTime net4_bookeddate
    {
        get
        {
            return _net4_bookeddate;
        }
        set
        {
            _net4_bookeddate = value;
        }
    }

    private string _net4_password;
    public string net4_password
    {
        get
        {
            return _net4_password;
        }
        set
        {
            _net4_password = value;
        }
    }

    private string _net4_regEmail;
    public string net4_regEmail
    {
        get
        {
            return _net4_regEmail;
        }
        set
        {
            _net4_regEmail = value;
        }
    }

    private string _net4_name;
    public string net4_name
    {
        get
        {
            return _net4_name;
        }
        set
        {
            _net4_name = value;
        }
    }

    private string _bigrk_dominlist;
    public string bigrk_dominlist
    {
        get
        {
            return _bigrk_dominlist;
        }
        set
        {
            _bigrk_dominlist = value;
        }
    }

    private DateTime _bigrk_bookeddate;
    public DateTime bigrk_bookeddate
    {
        get
        {
            return _bigrk_bookeddate;
        }
        set
        {
            _bigrk_bookeddate = value;
        }
    }


    private string _bigrk_password;
    public string bigrk_password
    {
        get
        {
            return _bigrk_password;
        }
        set
        {
            _bigrk_password = value;
        }
    }

    private string _bigrk_regEmail;
    public string bigrk_regEmail
    {
        get
        {
            return _bigrk_regEmail;
        }
        set
        {
            _bigrk_regEmail = value;
        }
    }

    private string _bigrk_name;
    public string bigrk_name
    {
        get
        {
            return _bigrk_name;
        }
        set
        {
            _bigrk_name = value;
        }
    }


    private string _goday_dominlist;
    public string goday_dominlist
    {
        get
        {
            return _goday_dominlist;
        }
        set
        {
            _goday_dominlist = value;
        }
    }

    private DateTime _goday_bookeddate;
    public DateTime goday_bookeddate
    {
        get
        {
            return _goday_bookeddate;
        }
        set
        {
            _goday_bookeddate = value;
        }
    }


    private string _goday_password;
    public string goday_password
    {
        get
        {
            return _goday_password;
        }
        set
        {
            _goday_password = value;
        }
    }

    private string _goday_regEmail;
    public string goday_regEmail
    {
        get
        {
            return _goday_regEmail;
        }
        set
        {
            _goday_regEmail = value;
        }
    }


    private string _goday_name;
    public string goday_name
    {
        get
        {
            return _goday_name;
        }
        set
        {
            _goday_name = value;
        }
    }

    private string _domin_dominlist;
    public string domin_dominlist
    {
        get
        {
            return _domin_dominlist;
        }
        set
        {
            _domin_dominlist = value;
        }
    }

    private DateTime _domin_bookeddate;
    public DateTime domin_bookeddate
    {
        get
        {
            return _domin_bookeddate;
        }
        set
        {
            _domin_bookeddate = value;
        }
    }

    private string _domin_password;
    public string domin_password
    {
        get
        {
            return _domin_password;
        }
        set
        {
            _domin_password = value;
        }
    }

    private string _domin_regEmail;
    public string domin_regEmail
    {
        get
        {
            return _domin_regEmail;
        }
        set
        {
            _domin_regEmail = value;
        }
    }

    private string _domin_name;
    public string domin_name
    {
        get
        {
            return _domin_name;
        }
        set
        {
            _domin_name = value;
        }
    }
    private string _remark;
    public string remark
    {
        get
        {
            return _remark;
        }
        set
        {
            _remark = value;
        }
    }
    private string _other_contact;
    public string other_contact
    {
        get
        {
            return _other_contact;
        }
        set
        {
            _other_contact = value;
        }
    }

    private DateTime _start_date;
    public DateTime start_date
    {
        get
        {
            return _start_date;
        }
        set
        {
            _start_date = value;
        }
    }
    private string _f_id;
    public string f_id
    {
        get
        {
            return _f_id;
        }
        set
        {
            _f_id = value;
        }
    }
    private string _other_cer;
    public string other_cer
    {
        get
        {
            return _other_cer;
        }
        set
        {
            _other_cer = value;
        }
    }

    private string _gad_cer;
    public string gad_cer
    {
        get
        {
            return _gad_cer;
        }
        set
        {
            _gad_cer = value;
        }
    }
    private string _twelve_cer;
    public string twelve_cer
    {
        get
        {
            return _twelve_cer;
        }
        set
        {
            _twelve_cer = value;
        }
    }

    private string _ten_cer;
    public string ten_cer
    {
        get
        {
            return _ten_cer;
        }
        set
        {
            _ten_cer = value;
        }
    }


    private string _passport;
    public string passport
    {
        get
        {
            return _passport;
        }
        set
        {
            _passport = value;
        }
    }

    private string _driving_licence;
    public string driving_licence
    {
        get
        {
            return _driving_licence;
        }
        set
        {
            _driving_licence = value;
        }
    }

    private string _voter_card;
    public string voter_card
    {
        get
        {
            return _voter_card;
        }
        set
        {
            _voter_card = value;
        }
    }


    private string _status;
    public string status
    {
        get
        {
            return _status;
        }
        set
        {
            _status = value;
        }
    }


    private string _pen_card;
    public string pen_card
    {
        get
        {
            return _pen_card;
        }
        set
        {
            _pen_card = value;
        }
    }


    private DateTime _Expence_date;
    public DateTime Expence_date
    {
        get
        {
            return _Expence_date;
        }
        set
        {
            _Expence_date = value;
        }
    }

    private DateTime _p_Relieving_date;
    public DateTime p_Relieving_date
    {
        get
        {
            return _p_Relieving_date;
        }
        set
        {
            _p_Relieving_date = value;
        }
    }



    private DateTime _p_joining_date;
    public DateTime p_joining_date
    {
        get
        {
            return _p_joining_date;
        }
        set
        {
            _p_joining_date = value;
        }
    }



    private string _p_job_profile;
    public string p_job_profile
    {
        get
        {
            return _p_job_profile;
        }
        set
        {
            _p_job_profile = value;
        }
    }



    private string _p_company_name;
    public string p_company_name
    {
        get
        {
            return _p_company_name;
        }
        set
        {
            _p_company_name = value;
        }
    }


    private string _post_grad_mark;
    public string post_grad_mark
    {
        get
        {
            return _post_grad_mark;
        }
        set
        {
            _post_grad_mark = value;
        }
    }


    private string _post_grad_yr;
    public string post_grad_yr
    {
        get
        {
            return _post_grad_yr;
        }
        set
        {
            _post_grad_yr = value;
        }
    }

    private string _post_grad_board;
    public string post_grad_board
    {
        get
        {
            return _post_grad_board;
        }
        set
        {
            _post_grad_board = value;
        }
    }


    private string _grad_mark;
    public string grad_mark
    {
        get
        {
            return _grad_mark;
        }
        set
        {
            _grad_mark = value;
        }
    }


    private string _grad_yr;
    public string grad_yr
    {
        get
        {
            return _grad_yr;
        }
        set
        {
            _grad_yr = value;
        }
    }

    private string _grad_board;
    public string grad_board
    {
        get
        {
            return _grad_board;
        }
        set
        {
            _grad_board = value;
        }
    }

    private string _twelve_mark;
    public string twelve_mark
    {
        get
        {
            return _twelve_mark;
        }
        set
        {
            _twelve_mark = value;
        }
    }

    private string _twelve_yr;
    public string twelve_yr
    {
        get
        {
            return _twelve_yr;
        }
        set
        {
            _twelve_yr = value;
        }
    }

    private string _twelve_board;
    public string twelve_board
    {
        get
        {
            return _twelve_board;
        }
        set
        {
            _twelve_board = value;
        }
    }

    private string _ten_mark;
    public string ten_mark
    {
        get
        {
            return _ten_mark;
        }
        set
        {
            _ten_mark = value;
        }
    }

    private string _ten_yr;
    public string ten_yr
    {
        get
        {
            return _ten_yr;
        }
        set
        {
            _ten_yr = value;
        }
    }

    private string _ten_board;
    public string ten_board
    {
        get
        {
            return _ten_board;
        }
        set
        {
            _ten_board = value;
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
    private string _salary;
    public string salary
    {
        get
        {
            return _salary;
        }
        set
        {
            _salary = value;
        }
    }

    private string _gender;
    public string gender
    {
        get
        {
            return _gender;
        }
        set
        {
            _gender = value;
        }
    }

    private DateTime _dob;
    public DateTime dob
    {
        get
        {
            return _dob;
        }
        set
        {
            _dob = value;
        }
    }

    private string _Father_name;
    public string Father_name
    {
        get
        {
            return _Father_name;
        }
        set
        {
            _Father_name = value;
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

    private string _total_amount;
    public string total_amount
    {
        get
        {
            return _total_amount;
        }
        set
        {
            _total_amount = value;
        }
    }
    private string _feedback;
    public string feedback
    {
        get
        {
            return _feedback;
        }
        set
        {
            _feedback = value;
        }
    }


    private string _contact_person;
    public string contact_person
    {
        get
        {
            return _contact_person;
        }
        set
        {
            _contact_person = value;
        }
    }
    private string _financial;
    public string financial
    {
        get
        {
            return _financial;
        }
        set
        {
            _financial = value;
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
    private string _no_of_plots;
    public string no_of_plots
    {
        get
        {
            return _no_of_plots;
        }
        set
        {
            _no_of_plots = value;
        }
    }



    private DateTime _join_date;
    public DateTime join_date
    {
        get
        {
            return _join_date;
        }
        set
        {
            _join_date = value;
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
    private string _regd_email;
    public string regd_email
    {
        get
        {
            return _regd_email;
        }
        set
        {
            _regd_email = value;
        }
    }
    private string _due_amount;
    public string due_amount
    {
        get
        {
            return _due_amount;
        }
        set
        {
            _due_amount = value;
        }
    }


    private string _customer_name;
    public string customer_name
    {
        get
        {
            return _customer_name;
        }
        set
        {
            _customer_name = value;
        }
    }



    private string _modified_by;
    public string modified_by
    {
        get
        {
            return _modified_by;
        }
        set
        {
            _modified_by = value;
        }
    }


    private string _hosting_desc;
    public string hosting_desc
    {
        get
        {
            return _hosting_desc;
        }
        set
        {
            _hosting_desc = value;
        }
    }


    private string _hosting_password;
    public string hosting_password
    {
        get
        {
            return _hosting_password;
        }
        set
        {
            _hosting_password = value;
        }
    }



    private string _hosting_user_name;
    public string hosting_user_name
    {
        get
        {
            return _hosting_user_name;
        }
        set
        {
            _hosting_user_name = value;
        }
    }


    private string _hosting_sub_name;
    public string hosting_sub_name
    {
        get
        {
            return _hosting_sub_name;
        }
        set
        {
            _hosting_sub_name = value;
        }
    }

    private DateTime _hosting_date;
    public DateTime hosting_date
    {
        get
        {
            return _hosting_date;
        }
        set
        {
            _hosting_date = value;
        }
    }


    private string _domain_des;
    public string domain_des
    {
        get
        {
            return _domain_des;
        }
        set
        {
            _domain_des = value;
        }
    }

    private string _domain_reg_email_id;
    public string domain_reg_email_id
    {
        get
        {
            return _domain_reg_email_id;
        }
        set
        {
            _domain_reg_email_id = value;
        }
    }

    private string _domain_password;
    public string domain_password
    {
        get
        {
            return _domain_password;
        }
        set
        {
            _domain_password = value;
        }
    }



    private string _domain_username;
    public string domain_username
    {
        get
        {
            return _domain_username;
        }
        set
        {
            _domain_username = value;
        }
    }


    private DateTime _domain_booking_date;
    public DateTime domain_booking_date
    {
        get
        {
            return _domain_booking_date;
        }
        set
        {
            _domain_booking_date = value;
        }
    }


    private string _service_desc;
    public string service_desc
    {
        get
        {
            return _service_desc;
        }
        set
        {
            _service_desc = value;
        }
    }

    private string _no_of_mails;
    public string no_of_mails
    {
        get
        {
            return _no_of_mails;
        }
        set
        {
            _no_of_mails = value;
        }
    }

    private string _no_of_pages;
    public string no_of_pages
    {
        get
        {
            return _no_of_pages;
        }
        set
        {
            _no_of_pages = value;
        }
    }

    private string _service_amount;
    public string service_amount
    {
        get
        {
            return _service_amount;
        }
        set
        {
            _service_amount = value;
        }
    }

    private string _email_id;
    public string email_id
    {
        get
        {
            return _email_id;
        }
        set
        {
            _email_id = value;
        }
    }

    private string _domain_reg_emailid;
    public string domain_reg_emailid
    {
        get
        {
            return _domain_reg_emailid;
        }
        set
        {
            _domain_reg_emailid = value;
        }
    }
    private string _invoice_id;
    public string invoice_id
    {
        get
        {
            return _invoice_id;
        }
        set
        {
            _invoice_id = value;
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
    private string _through;
    public string through
    {
        get
        {
            return _through;
        }
        set
        {
            _through = value;
        }
    }
    private string _Invoice_no;
    public string Invoice_no
    {
        get
        {
            return _Invoice_no;
        }
        set
        {
            _Invoice_no = value;
        }
    }

    private string _emi_Invoice_no;
    public string emi_Invoice_no
    {
        get
        {
            return _emi_Invoice_no;
        }
        set
        {
            _emi_Invoice_no = value;
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
    private DateTime _due_date;
    public DateTime due_date
    {
        get
        {
            return _due_date;
        }
        set
        {
            _due_date = value;
        }
    }
    private DateTime _nxt_remind_date;
    public DateTime nxt_remind_date
    {
        get
        {
            return _nxt_remind_date;
        }
        set
        {
            _nxt_remind_date = value;
        }
    }

    private string _project;
    public string project
    {
        get
        {
            return _project;
        }
        set
        {
            _project = value;
        }
    }

    private string _purchaser_name;
    public string purchaser_name
    {
        get
        {
            return _purchaser_name;
        }
        set
        {
            _purchaser_name = value;
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
    private string _Feedback;
    public string Feedback
    {
        get
        {
            return _Feedback;
        }
        set
        {
            _Feedback = value;
        }
    }

    private string _discount_amount;
    public string discount_amount
    {
        get
        {
            return _discount_amount;
        }
        set
        {
            _discount_amount = value;
        }
    }
    private string _four_vehicle_reg_no;
    public string four_vehicle_reg_no
    {
        get
        {
            return _four_vehicle_reg_no;
        }
        set
        {
            _four_vehicle_reg_no = value;
        }
    }

    private string _four_vehicle_name;
    public string four_vehicle_name
    {
        get
        {
            return _four_vehicle_name;
        }
        set
        {
            _four_vehicle_name = value;
        }
    }



    private string _business_catogary;
    public string business_catogary
    {
        get
        {
            return _business_catogary;
        }
        set
        {
            _business_catogary = value;
        }
    }

    private string _feedback_id;
    public string feedback_id
    {
        get
        {
            return _feedback_id;
        }
        set
        {
            _feedback_id = value;
        }
    }


    private string _four_no_of_wheelers;
    public string four_no_of_wheelers
    {
        get
        {
            return _four_no_of_wheelers;
        }
        set
        {
            _four_no_of_wheelers = value;
        }
    }

    private string _two_vehicle_reg_no;
    public string two_vehicle_reg_no
    {
        get
        {
            return _two_vehicle_reg_no;
        }
        set
        {
            _two_vehicle_reg_no = value;
        }
    }

    private string _two_vehicle_name;
    public string two_vehicle_name
    {
        get
        {
            return _two_vehicle_name;
        }
        set
        {
            _two_vehicle_name = value;
        }
    }


    private string _two_wheelers;
    public string two_wheelers
    {
        get
        {
            return _two_wheelers;
        }
        set
        {
            _two_wheelers = value;
        }
    }


    private string _Computer_Table;
    public string Computer_Table
    {
        get
        {
            return _Computer_Table;
        }
        set
        {
            _Computer_Table = value;
        }
    }

    private string _Teapoy;
    public string Teapoy
    {
        get
        {
            return _Teapoy;
        }
        set
        {
            _Teapoy = value;
        }
    }
    private string _Almari;
    public string Almari
    {
        get
        {
            return _Almari;
        }
        set
        {
            _Almari = value;
        }
    }
    private string _Tables;
    public string Tables
    {
        get
        {
            return _Tables;
        }
        set
        {
            _Tables = value;
        }
    }
    private string _Chairs;
    public string Chairs
    {
        get
        {
            return _Chairs;
        }
        set
        {
            _Chairs = value;
        }
    }


    private string _Calculators;
    public string Calculators
    {
        get
        {
            return _Calculators;
        }
        set
        {
            _Calculators = value;
        }
    }

    private string _Landline_Phones;
    public string Landline_Phones
    {
        get
        {
            return _Landline_Phones;
        }
        set
        {
            _Landline_Phones = value;
        }
    }

    private string _Cell_Phones;
    public string Cell_Phones
    {
        get
        {
            return _Cell_Phones;
        }
        set
        {
            _Cell_Phones = value;
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

    private string _projectors;
    public string projectors
    {
        get
        {
            return _projectors;
        }
        set
        {
            _projectors = value;
        }
    }
    private string _laptops;
    public string laptops
    {
        get
        {
            return _laptops;
        }
        set
        {
            _laptops = value;
        }
    }

    private string _computers;
    public string computers
    {
        get
        {
            return _computers;
        }
        set
        {
            _computers = value;
        }
    }
    private string _employee;
    public string employee
    {
        get
        {
            return _employee;
        }
        set
        {
            _employee = value;
        }
    }
    private string _Customer_name;
    public string Customer_name
    {
        get
        {
            return _Customer_name;
        }
        set
        {
            _Customer_name = value;
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


    private string _call_log;
    public string call_log
    {
        get
        {
            return _call_log;
        }
        set
        {
            _call_log = value;
        }
    }


    private string _mode_pay;
    public string mode_pay
    {
        get
        {
            return _mode_pay;
        }
        set
        {
            _mode_pay = value;
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

    private string _agent_name;
    public string agent_name
    {
        get
        {
            return _agent_name;
        }
        set
        {
            _agent_name = value;
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

    private DateTime _doj;
    public DateTime doj
    {
        get
        {
            return _doj;
        }
        set
        {
            _doj = value;
        }
    }

    private string _commision;
    public string commision
    {
        get
        {
            return _commision;
        }
        set
        {
            _commision = value;
        }
    }

    private string _project_id;
    public string project_id
    {
        get
        {
            return _project_id;
        }
        set
        {
            _project_id = value;
        }
    }


    private string _project_name;
    public string project_name
    {
        get
        {
            return _project_name;
        }
        set
        {
            _project_name = value;
        }
    }

    private string _project_location;
    public string project_location
    {
        get
        {
            return _project_location;
        }
        set
        {
            _project_location = value;
        }
    }


    private string _no_of_plot;
    public string no_of_plot
    {
        get
        {
            return _no_of_plot;
        }
        set
        {
            _no_of_plot = value;
        }
    }


    private string _Company;
    public string Company
    {
        get
        {
            return _Company;
        }
        set
        {
            _Company = value;
        }
    }

    private string _project_status;
    public string project_status
    {
        get
        {
            return _project_status;
        }
        set
        {
            _project_status = value;
        }
    }

    private string _contactno;
    public string contactno
    {
        get
        {
            return _contactno;
        }
        set
        {
            _contactno = value;
        }
    }
    private string _logged_by;
    public string logged_by
    {
        get
        {
            return _logged_by;
        }
        set
        {
            _logged_by = value;
        }
    }

    private string _Issue_name;
    public string Issue_name
    {
        get
        {
            return _Issue_name;
        }
        set
        {
            _Issue_name = value;
        }
    }
    private string _agent_status;
    public string agent_status
    {
        get
        {
            return _agent_status;
        }
        set
        {
            _agent_status = value;
        }
    }

    private string _s_no;
    public string s_no
    {
        get
        {
            return _s_no;
        }
        set
        {
            _s_no = value;
        }
    }


    private string _chequeno;
    public string chequeno
    {
        get
        {
            return _chequeno;
        }
        set
        {
            _chequeno = value;
        }
    }
    private string _bank_branch;
    public string bank_branch
    {
        get
        {
            return _bank_branch;
        }
        set
        {
            _bank_branch = value;
        }
    }


    private DateTime _sale_date;
    public DateTime sale_date
    {
        get
        {
            return _sale_date;
        }
        set
        {
            _sale_date = value;
        }
    }


    private string _mode_of_payment;
    public string mode_of_payment
    {
        get
        {
            return _mode_of_payment;
        }
        set
        {
            _mode_of_payment = value;
        }
    }




    private string _Purpose;
    public string Purpose
    {
        get
        {
            return _Purpose;
        }
        set
        {
            _Purpose = value;
        }
    }
    private string _Receiver_Name;
    public string Receiver_Name
    {
        get
        {
            return _Receiver_Name;
        }
        set
        {
            _Receiver_Name = value;
        }
    }
    private string _cheque_no;
    public string cheque_no
    {
        get
        {
            return _cheque_no;
        }
        set
        {
            _cheque_no = value;
        }
    }


    private string _bank_and_branch;
    public string bank_and_branch
    {
        get
        {
            return _bank_and_branch;
        }
        set
        {
            _bank_and_branch = value;
        }
    }


    private string _registrant_name;
    public string registrant_name
    {
        get
        {
            return _registrant_name;
        }
        set
        {
            _registrant_name = value;
        }
    }

    private DateTime _assign_date;
    public DateTime assign_date
    {
        get
        {
            return _assign_date;
        }
        set
        {
            _assign_date = value;
        }
    }

    private string _father_name;
    public string father_name
    {
        get
        {
            return _father_name;
        }
        set
        {
            _father_name = value;
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

    private string _amount;
    public string amount
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


    private string _m_salary;
    public string m_salary
    {
        get
        {
            return _m_salary;
        }
        set
        {
            _m_salary = value;
        }
    }


    private string _t_salary;
    public string t_salary
    {
        get
        {
            return _t_salary;
        }
        set
        {
            _t_salary = value;
        }
    }


    private string _mode_of_pay;
    public string mode_of_pay
    {
        get
        {
            return _mode_of_pay;
        }
        set
        {
            _mode_of_pay = value;
        }
    }


    private string _Bank_Branch;
    public string Bank_Branch
    {
        get
        {
            return _Bank_Branch;
        }
        set
        {
            _Bank_Branch = value;
        }
    }

    private string _Lead_no;
    public string Lead_no
    {
        get
        {
            return _Lead_no;
        }
        set
        {
            _Lead_no = value;
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

    private string _Product_Cost;
    public string Product_Cost
    {
        get
        {
            return _Product_Cost;
        }
        set
        {
            _Product_Cost = value;
        }
    }

    private string _Product_Name;
    public string Product_Name
    {
        get
        {
            return _Product_Name;
        }
        set
        {
            _Product_Name = value;
        }
    }


    private string _Absent;
    public string Absent
    {
        get
        {
            return _Absent;
        }
        set
        {
            _Absent = value;
        }
    }


    private string _Leave;
    public string Leave
    {
        get
        {
            return _Leave;
        }
        set
        {
            _Leave = value;
        }
    }

    private string _L_Without_Pay;
    public string L_Without_Pay
    {
        get
        {
            return _L_Without_Pay;
        }
        set
        {
            _L_Without_Pay = value;
        }
    }

    private string _T_Working_Day;
    public string T_Working_Day
    {
        get
        {
            return _T_Working_Day;
        }
        set
        {
            _T_Working_Day = value;
        }
    }


    private string _cheque;
    public string cheque
    {
        get
        {
            return _cheque;
        }
        set
        {
            _cheque = value;
        }
    }

    private string _cash;
    public string cash
    {
        get
        {
            return _cash;
        }
        set
        {
            _cash = value;
        }
    }

    private string _domain_name;
    public string domain_name
    {
        get
        {
            return _domain_name;
        }
        set
        {
            _domain_name = value;
        }
    }




    private string _issue_desc;
    public string issue_desc
    {
        get
        {
            return _issue_desc;
        }
        set
        {
            _issue_desc = value;
        }
    }


    private string _issue;
    public string issue
    {
        get
        {
            return _issue;
        }
        set
        {
            _issue = value;
        }
    }


    private string _issue_type;
    public string issue_type
    {
        get
        {
            return _issue_type;
        }
        set
        {
            _issue_type = value;
        }
    }


    private DateTime _Schedule_date;
    public DateTime Schedule_date
    {
        get
        {
            return _Schedule_date;
        }
        set
        {
            _Schedule_date = value;
        }
    }

    private string _customer_id;
    public string customer_id
    {
        get
        {
            return _customer_id;
        }
        set
        {
            _customer_id = value;
        }
    }
    private string _company_id;
    public string company_id
    {
        get
        {
            return _company_id;
        }
        set
        {
            _company_id = value;
        }
    }
    private string _sno;
    public string sno
    {
        get
        {
            return _sno;
        }
        set
        {
            _sno = value;
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

    private string _pincode;
    public string pincode
    {
        get
        {
            return _pincode;
        }
        set
        {
            _pincode = value;
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

    private string _document_type;
    public string document_type
    {
        get
        {
            return _document_type;
        }
        set
        {
            _document_type = value;
        }
    }

    private string _company_name;
    public string company_name
    {
        get
        {
            return _company_name;
        }
        set
        {
            _company_name = value;
        }
    }



    private string _txt_Mr;
    public string txt_Mr
    {
        get
        {
            return _txt_Mr;
        }
        set
        {
            _txt_Mr = value;
        }
    }

    private string _software;
    public string software
    {
        get
        {
            return _software;
        }
        set
        {
            _software = value;
        }
    }


    private string _trade;
    public string trade
    {
        get
        {
            return _trade;
        }
        set
        {
            _trade = value;
        }
    }

    private string _website;
    public string website
    {
        get
        {
            return _website;
        }
        set
        {
            _website = value;
        }
    }


    private string _domain;
    public string domain
    {
        get
        {
            return _domain;
        }
        set
        {
            _domain = value;
        }
    }

    private string _logo;
    public string logo
    {
        get
        {
            return _logo;
        }
        set
        {
            _logo = value;
        }
    }

    private string _no_of_page;
    public string no_of_page
    {
        get
        {
            return _no_of_page;
        }
        set
        {
            _no_of_page = value;
        }
    }
    private string _no_of_mail;
    public string no_of_mail
    {
        get
        {
            return _no_of_mail;
        }
        set
        {
            _no_of_mail = value;
        }
    }
    private string _Schedule_Time;
    public string Schedule_Time
    {
        get
        {
            return _Schedule_Time;
        }
        set
        {
            _Schedule_Time = value;
        }
    }

    private string _quotation_amount;
    public string quotation_amount
    {
        get
        {
            return _quotation_amount;
        }
        set
        {
            _quotation_amount = value;
        }
    }

    private string _hosting_yr;
    public string hosting_yr
    {
        get
        {
            return _hosting_yr;
        }
        set
        {
            _hosting_yr = value;
        }
    }
    private string _no_of_domain;
    public string no_of_domain
    {
        get
        {
            return _no_of_domain;
        }
        set
        {
            _no_of_domain = value;
        }
    }

    private string _service_from;
    public string service_from
    {
        get
        {
            return _service_from;
        }
        set
        {
            _service_from = value;
        }
    }

    private string _existing_service;
    public string existing_service
    {
        get
        {
            return _existing_service;
        }
        set
        {
            _existing_service = value;
        }
    }
    private string _website_type;
    public string website_type
    {
        get
        {
            return _website_type;
        }
        set
        {
            _website_type = value;
        }
    }
    private string _service_type;
    public string service_type
    {
        get
        {
            return _service_type;
        }
        set
        {
            _service_type = value;
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

    private string _email;
    public string email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value;
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



    private string _name;
    public string name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    private string _requirement;
    public string requirement
    {
        get
        {
            return _requirement;
        }
        set
        {
            _requirement = value;
        }
    }

    private string _order_id;
    public string order_id
    {
        get
        {
            return _order_id;
        }
        set
        {
            _order_id = value;
        }
    }

    private string _vendor;
    public string vendor
    {
        get
        {
            return _vendor;
        }
        set
        {
            _vendor = value;
        }
    }
    private string _specilist;
    public string specilist
    {
        get
        {
            return _specilist;
        }
        set
        {
            _specilist = value;
        }
    }

    private string _service;
    public string service
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

    private DateTime _purchase_order_date;
    public DateTime purchase_order_date
    {
        get
        {
            return _purchase_order_date;
        }
        set
        {
            _purchase_order_date = value;
        }
    }


    private string _amt;
    public string amt
    {
        get
        {
            return _amt;
        }
        set
        {
            _amt = value;
        }
    }


    private string _agreement_peroid;
    public string agreement_peroid
    {
        get
        {
            return _agreement_peroid;
        }
        set
        {
            _agreement_peroid = value;
        }
    }
    private int _Month;
    public int Month
    {
        get
        {
            return _Month;
        }
        set
        {
            _Month = value;
        }
    }

    public SqlDataReader PrintInvoice_select_PRINT(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "PrintInvoice_select_PRINT";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Patient_Select(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Patient_Select";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@search_value", search_value);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public string purchase_order_insert()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "purchase_order_insert";

            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@contact_person", contact_person);
            objCommand.Parameters.AddWithValue("@unitsell", unitsell);
            objCommand.Parameters.AddWithValue("@quantity", quantity);

            objCommand.Parameters.AddWithValue("@order_id", order_id);
            objCommand.Parameters.AddWithValue("@project", project);
            objCommand.Parameters.AddWithValue("@area", area);
            objCommand.Parameters.AddWithValue("@vendor", vendor);
            objCommand.Parameters.AddWithValue("@specilist", specilist);
            objCommand.Parameters.AddWithValue("@service", service);
            objCommand.Parameters.AddWithValue("@description", description);
            objCommand.Parameters.AddWithValue("@purchase_order_date", purchase_order_date);
            objCommand.Parameters.AddWithValue("@Remarks", Remarks);
            objCommand.Parameters.AddWithValue("@agreement_peroid", agreement_peroid);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
            //objCommand.Parameters.AddWithValue("@address", objUser.address);
            objCommand.Parameters.AddWithValue("@active", objUser.active);

            // objCommand.Parameters.AddWithValue("@Branch_Name", objUser.Branch_Name);
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



    public string PatientEntry_Insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "PatientEntry_Insert";
            objCommand.Parameters.AddWithValue("@s_no", s_no);
            objCommand.Parameters.AddWithValue("@Time", Time);
            objCommand.Parameters.AddWithValue("@patient_age", patient_Age);
            objCommand.Parameters.AddWithValue("@patient_name", patient_Name);
            objCommand.Parameters.AddWithValue("@patient_contact", patient_Contact);
            objCommand.Parameters.AddWithValue("@patient_Gurdian", patient_Gur);
            objCommand.Parameters.AddWithValue("@patient_Address", patient_Add);
            objCommand.Parameters.AddWithValue("@patient_AdmitDate", patient_date);
            objCommand.Parameters.AddWithValue("@patient_Fee", patient_Fee);
            objCommand.Parameters.AddWithValue("@Created_By", created_by);
            //objCommand.Parameters.AddWithValue("@Remarks", Remarks);
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






    public string enquery_insert()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "enquery_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@name", name);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@email_id", email_id);
            objCommand.Parameters.AddWithValue("@project", project);
            objCommand.Parameters.AddWithValue("@area", area);
            objCommand.Parameters.AddWithValue("@requirement", requirement);
            objCommand.Parameters.AddWithValue("@enq_sta", enq_sta);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@Emailsub", Emailsub);
            objCommand.Parameters.AddWithValue("@Company", Company);
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

    public SqlDataReader Vendor_details_dd(string Vendor_Name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Vendor_details_dd";
        objCommand.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Vendor_specialize_dd(string specialize)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Vendor_specialize_dd";
        objCommand.Parameters.AddWithValue("@specialize", specialize);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader specialize_dd()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "specialize_dd";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Vendor_name_dd()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Vendor_name_dd";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader dd_document(string UserName, string CompanyId)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "dd_document";
        objCommand.Parameters.AddWithValue("@UserName", UserName);
        objCommand.Parameters.AddWithValue("@CompanyId", CompanyId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader financial_select(string UserName, string CompanyId)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "financial_select";
        objCommand.Parameters.AddWithValue("@UserName", UserName);
        objCommand.Parameters.AddWithValue("@CompanyId", CompanyId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader dd_Associate_company(string CompanyId)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "dd_Associate_company";
        objCommand.Parameters.AddWithValue("@CompanyID", CompanyId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader client_id()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "client_id";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader ddstatu_s()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "ddstatu_s";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader ddrol_e()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "ddrol_e";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader dd_company()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "dd_company";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader inq_status_dd()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "inq_status_dd";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader project_name_dd()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "project_name_dd";
        // objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public string Request_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Request_delete";
            objCommand.Parameters.AddWithValue("@sno", sno);
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
    public SqlDataReader financial_select_view_update(string f_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "financial_select_view_update";
        objCommand.Parameters.AddWithValue("@f_id", f_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader document_select_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "document_select_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader user_login_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "user_login_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader customer_select_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "customer_select_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Request_select_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Request_select_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader document_detail_select_views(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "document_detail_select_views";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader company_select_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "company_select_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader enquery_select_filetr(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "enquery_select_filetr";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Invoice_select_filetr(string project_name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_select_filetr";
        objCommand.Parameters.AddWithValue("@project_name", project_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public string Branch_deactive(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Branch_deactive";
            objCommand.Parameters.AddWithValue("@emp_id", emp_id);
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
    public SqlDataReader Invoice_Product_po_filter(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_Product_po_filter";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public string m_crm_temp_employee_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crm_temp_employee_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@join_date", join_date);
            objCommand.Parameters.AddWithValue("@emp_name", emp_name);
            objCommand.Parameters.AddWithValue("@Father_name", Father_name);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@gender", gender);
            objCommand.Parameters.AddWithValue("@salary", salary);
            objCommand.Parameters.AddWithValue("@designation", designation);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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



    public DataTable Expense_Entry_Select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_Select";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public string marketing_feedback_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            //s_no,feedback_id,company_name,customer_name,mobile_no,address,email_id,business_catogary,status
            //,remarks,created_on,modified_on,created_by,modified_by


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "marketing_feedback_insert";

            objCommand.Parameters.AddWithValue("@s_no", s_no);
            // objCommand.Parameters.AddWithValue("@emp_id", emp_id);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@customer_name", customer_name);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@email_id", email_id);
            objCommand.Parameters.AddWithValue("@business_catogary", business_catogary);
            objCommand.Parameters.AddWithValue("@status", status);
            objCommand.Parameters.AddWithValue("@remarks", Remarks);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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


    public string m_crmemployee_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crmemployee_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            // objCommand.Parameters.AddWithValue("@emp_id", emp_id);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@doj", doj);
            objCommand.Parameters.AddWithValue("@emp_name", emp_name);
            objCommand.Parameters.AddWithValue("@Father_name", Father_name);
            objCommand.Parameters.AddWithValue("@email", email);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@dob", dob);
            objCommand.Parameters.AddWithValue("@gender", gender);
            objCommand.Parameters.AddWithValue("@salary", salary);
            objCommand.Parameters.AddWithValue("@designation", designation);
            objCommand.Parameters.AddWithValue("@ten_board", ten_board);
            objCommand.Parameters.AddWithValue("@ten_yr", ten_yr);
            objCommand.Parameters.AddWithValue("@ten_mark", ten_mark);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@twelve_board", twelve_board);
            objCommand.Parameters.AddWithValue("@twelve_yr", twelve_yr);
            objCommand.Parameters.AddWithValue("@twelve_mark", twelve_mark);
            objCommand.Parameters.AddWithValue("@grad_board", grad_board);
            objCommand.Parameters.AddWithValue("@grad_yr", grad_yr);
            objCommand.Parameters.AddWithValue("@grad_mark", grad_mark);
            objCommand.Parameters.AddWithValue("@post_grad_board", post_grad_board);
            objCommand.Parameters.AddWithValue("@post_grad_yr", post_grad_yr);
            objCommand.Parameters.AddWithValue("@post_grad_mark", post_grad_mark);
            objCommand.Parameters.AddWithValue("@p_company_name", p_company_name);
            objCommand.Parameters.AddWithValue("@p_job_profile", p_job_profile);
            objCommand.Parameters.AddWithValue("@p_joining_date", p_joining_date);
            objCommand.Parameters.AddWithValue("@p_Relieving_date", p_Relieving_date);
            objCommand.Parameters.AddWithValue("@pen_card", pen_card);
            objCommand.Parameters.AddWithValue("@voter_card", voter_card);
            objCommand.Parameters.AddWithValue("@driving_licence", driving_licence);
            objCommand.Parameters.AddWithValue("@passport", passport);
            objCommand.Parameters.AddWithValue("@ten_cer", ten_cer);
            objCommand.Parameters.AddWithValue("@twelve_cer", twelve_cer);
            objCommand.Parameters.AddWithValue("@gad_cer", gad_cer);
            objCommand.Parameters.AddWithValue("@other_cer", other_cer);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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

    public SqlDataReader payment_print(string sno, string flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "payment_print";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader monthly_Attendance_Report(DateTime from_date, DateTime to_date, string flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "monthly_Attendance_Report";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader vender_payment_select_PRINT(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "vender_payment_select_PRINT";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader CheckExistingclient(string company_name, string Associate_company)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingclient";
        objCommand.Parameters.AddWithValue("@company_name", company_name);
        objCommand.Parameters.AddWithValue("@Associate_company", Associate_company);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader CheckExistingfinyr(string f_name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingfinyr";
        objCommand.Parameters.AddWithValue("@f_name", f_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader customer_login_create_view(string customer_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "customer_login_create_view";
        objCommand.Parameters.AddWithValue("@customer_id ", customer_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader CheckExistinglogin(string customer_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistinglogin";
        objCommand.Parameters.AddWithValue("@customer_id ", customer_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader fileupload_check(string fileupload, string Customer_Id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "fileupload_check";

        objCommand.Parameters.AddWithValue("@Customer_Id", Customer_Id);
        objCommand.Parameters.AddWithValue("@fileupload", fileupload);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    #region Investment Documents
    //drop down document fill
    public SqlDataReader Investmentdd_document(string UserName, string CompanyId)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "SP_Investmentdd_document";
        objCommand.Parameters.AddWithValue("@UserName", UserName);
        objCommand.Parameters.AddWithValue("@CompanyId", CompanyId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    //dropdown Financial year fill
    public SqlDataReader Investmentfinancial_select(string UserName, string CompanyId)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "SP_Investmentfinancial_select";
        objCommand.Parameters.AddWithValue("@UserName", UserName);
        objCommand.Parameters.AddWithValue("@CompanyId", CompanyId);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    //Investment File Upload method
    public SqlDataReader Investmentfileupload_check(string fileupload, string Customer_Id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "SP_Investmentfileupload_check";

        objCommand.Parameters.AddWithValue("@Customer_Id", Customer_Id);
        objCommand.Parameters.AddWithValue("@fileupload", fileupload);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    #endregion
    public SqlDataReader CheckExistingdoctype(string document_type)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingdoctype";
        objCommand.Parameters.AddWithValue("@document_type", document_type);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader CheckExistingcomp(string company_name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CheckExistingcomp";
        objCommand.Parameters.AddWithValue("@company_name", company_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader purchase_order_select_PRINT(string order_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "purchase_order_select_PRINT";
        objCommand.Parameters.AddWithValue("@order_id", order_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader ticket_payment_print(string sno, string flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "ticket_payment_print";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader m_domaindetails_renewal_Payment_update(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_domaindetails_renewal_Payment_update";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader m_domaindetails_renewal_Payment_View(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_domaindetails_renewal_Payment_View";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader m_payment_view_select(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_payment_view_select";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader m_payment_view(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_payment_view";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader m_crmlead_payment_view(string search_value)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmlead_payment_view";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader m_crmlead_ticket_view(string Lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmlead_ticket_view";
        objCommand.Parameters.AddWithValue("@Lead_no", Lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public string customer_feedback_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "customer_feedback_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@contact_person", contact_person);
            objCommand.Parameters.AddWithValue("@feedback", feedback);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@customer_id", customer_id);
            objCommand.Parameters.AddWithValue("@domain_name", domain_name);
            objCommand.Parameters.AddWithValue("@flag", flag);
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


    public SqlDataReader m_crmlead_ticket_updateview(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmlead_ticket_updateview";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader m_crmlead_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmlead_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader m_crm_temp_employee_select_print(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crm_temp_employee_select_print";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }


    public SqlDataReader duepayment_Delete(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "duepayment_Delete";
        objCommand.Parameters.AddWithValue("@sno", sno);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }





    public SqlDataReader m_crmemployee_select_print(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmemployee_select_print";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader m_crmpaymentdetails_printview(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmpaymentdetails_printview";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader m_crmlead_pdf_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmlead_pdf_view";
        objCommand.Parameters.AddWithValue("@sno", sno);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public DataTable crmservicerequest_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crmservicerequest_select";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public SqlDataReader crmservicerequest_log_select(string customer_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmservicerequest_log_select";
        objCommand.Parameters.AddWithValue("@customer_id", customer_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public DataTable Daily_feedback_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Daily_feedback_Report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);

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
    public SqlDataReader customer_feedback_select(string customer_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "customer_feedback_select";
        objCommand.Parameters.AddWithValue("@customer_id", customer_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public DataTable m_crmlead_followup_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmlead_followup_view";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);

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
    public DataTable m_crmlead_finalized_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmlead_finalized_view";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);

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
    public SqlDataReader m_domaindetails_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_domaindetails_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public DataTable m_crmlead_scheduled_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmlead_scheduled_view";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);

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

    public DataTable m_crmlead_ticket_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmlead_ticket_view";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
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


    public DataTable enquery_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "enquery_select";
            // objCommand.Parameters.AddWithValue("@search_value", search_value);
            // objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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


    public DataTable m_crmticket_select_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmticket_select_Report";
            // objCommand.Parameters.AddWithValue("@search_value", search_value);
            // objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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


    public SqlDataReader m_business_catogary_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_business_catogary_select";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }


    public SqlDataReader m_status_select()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_status_select";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }

    public SqlDataReader Quotationupdate_formail(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotationupdate_formail";
        objCommand.Parameters.AddWithValue("@s_no", s_no);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Quotation_Delete(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_Delete";
        objCommand.Parameters.AddWithValue("@s_no", s_no);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public DataTable marketing_feedback_select_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "marketing_feedback_select_view";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            objCommand.Parameters.AddWithValue("@status", status);
            objCommand.Parameters.AddWithValue("@business_catogary", business_catogary);
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



    public DataTable m_crmlead_view_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmlead_view_Report";
            // objCommand.Parameters.AddWithValue("@search_value", search_value);
            objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public DataTable dailyworking_sheet_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "dailyworking_sheet_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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





    public DataTable m_lead_filter(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_lead_filter";

            objCommand.Parameters.AddWithValue("@search_value", search_value);
            objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@service_type", service_type);

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



    public DataTable m_crmlead_selectall_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmlead_selectall_view";

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
    public DataTable m_crmlead_select_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmlead_select_view";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
            //objCommand.Parameters.AddWithValue("@service_type", service_type);
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
    public string dailyworking_sheet_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "dailyworking_sheet_insert";
            objCommand.Parameters.AddWithValue("@working_details", working_details);
            objCommand.Parameters.AddWithValue("@imprv", imprv);
            objCommand.Parameters.AddWithValue("@prblm_face", prblm_face);
            objCommand.Parameters.AddWithValue("@DoFeel", DoFeel);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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

    public string lead_call_log_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "lead_call_log_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@lead_no", lead_no);
            objCommand.Parameters.AddWithValue("@call_log", call_log);

            objCommand.Parameters.AddWithValue("@created_by", created_by);


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


    public string m_crmlead_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crmlead_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@other_contact", other_contact);
            objCommand.Parameters.AddWithValue("@first_name", first_name);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@email", email);
            objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@description", description);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@service_type", service_type);
            objCommand.Parameters.AddWithValue("@Remarks", Remarks);
            objCommand.Parameters.AddWithValue("@state", state);
            objCommand.Parameters.AddWithValue("@area", area);
            //   objCommand.Parameters.AddWithValue("@discussiontype", discussiontype);
            objCommand.Parameters.AddWithValue("@discountitem", discountitem);
            // objCommand.Parameters.AddWithValue("@country", country);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@quotation_amount", quotation_amount);
            objCommand.Parameters.AddWithValue("@Schedule_date", Schedule_date);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@discount", discount);

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
    public string c_issue_support_insert()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "c_issue_support_insert";

            objCommand.Parameters.AddWithValue("@issue_type", issue_type);
            objCommand.Parameters.AddWithValue("@issue", issue);
            objCommand.Parameters.AddWithValue("@issue_desc", sno);
            objCommand.Parameters.AddWithValue("@customer_id", customer_id);
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@created_on", created_on);
            objCommand.Parameters.AddWithValue("@modify_by", modify_by);
            objCommand.Parameters.AddWithValue("@flag", flag);
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
    public string crm_customer_insert()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crm_customer_insert";
            objCommand.Parameters.AddWithValue("@customer_id", customer_id);
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@issue", issue);
            objCommand.Parameters.AddWithValue("@issue_desc", issue_desc);
            objCommand.Parameters.AddWithValue("@issue_type", issue_type);

            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@created_on", created_on);
            objCommand.Parameters.AddWithValue("@modify_by", modify_by);
            objCommand.Parameters.AddWithValue("@flag", flag);
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
    public string Agent_Attendance_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Agent_Attendance_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);

            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
            objCommand.Parameters.AddWithValue("@S_Date", doj);
            objCommand.Parameters.AddWithValue("@Agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@T_Working_Day", T_Working_Day);
            objCommand.Parameters.AddWithValue("@Leave", Leave);
            objCommand.Parameters.AddWithValue("@L_Without_Pay", L_Without_Pay);
            objCommand.Parameters.AddWithValue("@Absent", Absent);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@created_by", created_by);

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
    public string financial_Insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "financial_Insert";
            objCommand.Parameters.AddWithValue("@f_id", f_id);
            objCommand.Parameters.AddWithValue("@f_name", financial);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
    public string document_Insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "document_Insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@document_type", document_type);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
    public string document_detail_Insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "document_detail_Insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Customer_Id", Customer_id);
            objCommand.Parameters.AddWithValue("@document_type", document_type);
            objCommand.Parameters.AddWithValue("@financial_year", financial_year);
            objCommand.Parameters.AddWithValue("@fileupload", fileupload);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@size", size);
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


    public string Customer_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Customer_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@CIN", CIN);
            objCommand.Parameters.AddWithValue("@registrationno", registrationno);
            objCommand.Parameters.AddWithValue("@birth", birth);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@Associate_company", Associate_company);
            objCommand.Parameters.AddWithValue("@Authorised_person", Authorised_person);
            objCommand.Parameters.AddWithValue("@contact", Contact_Person);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@other_contact", other_contact);
            objCommand.Parameters.AddWithValue("@email", email);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@business_type", business_type);
            objCommand.Parameters.AddWithValue("@bu_service", bu_service);
            objCommand.Parameters.AddWithValue("@pan", pan);
            objCommand.Parameters.AddWithValue("@ta_n", ta_n);
            objCommand.Parameters.AddWithValue("@remarks", remark);
            objCommand.Parameters.AddWithValue("@other_detail", other_detail);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
    public string company_Insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "company_Insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
    public string Request_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Request_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@STATUS", STATUS);
            objCommand.Parameters.AddWithValue("@subject", subject);
            objCommand.Parameters.AddWithValue("@desription", description);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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

    public string Expense_Entry_Insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Expense_Entry_Insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Expence_date", Expence_date);
            objCommand.Parameters.AddWithValue("@Receiver_Name", Receiver_Name);
            objCommand.Parameters.AddWithValue("@Purpose", Purpose);
            objCommand.Parameters.AddWithValue("@Remarks", Remarks);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@bank_and_branch", bank_and_branch);
            objCommand.Parameters.AddWithValue("@amount", amount);
            objCommand.Parameters.AddWithValue("@cheque_no", cheque_no);
            objCommand.Parameters.AddWithValue("@mode_of_payment", mode_of_payment);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@Expense_type", Expense_type);
            objCommand.Parameters.AddWithValue("@collected_amount", collected_amount);
            objCommand.Parameters.AddWithValue("@due_amount", due_amount);



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

    public SqlDataReader crmservicerequest_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmservicerequest_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader m_ticket_customer_view(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_ticket_customer_view";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader marketing_feedback_update_view(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "marketing_feedback_update_view";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    public SqlDataReader m_crmemployee_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmemployee_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader Expense_Entry_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Expense_Entry_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader m_crmpaymentdetails_update_view(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmpaymentdetails_update_view";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader m_crm_tempemployee_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crm_tempemployee_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader m_crm_customer_update_view(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crm_customer_update_view";
        objCommand.Parameters.AddWithValue("@sno", sno);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader crm_user_Detail_update(string emp_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crm_user_Detail_update";
        objCommand.Parameters.AddWithValue("@emp_id", emp_id);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Expense_Entry_UPDATE(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Expense_Entry_UPDATE";
        objCommand.Parameters.AddWithValue("@sno", sno);

        // objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public string user_login_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "user_login_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@customer_id", customer_id);
            objCommand.Parameters.AddWithValue("@roles", role);
            objCommand.Parameters.AddWithValue("@status_s", status);
            objCommand.Parameters.AddWithValue("@username", username);
            objCommand.Parameters.AddWithValue("@Authorised_person", Authorised_person);
            objCommand.Parameters.AddWithValue("@password", password);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
    public SqlDataReader document_detail_image_filter()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "document_detail_image_filter";
        objCommand.Parameters.AddWithValue("@sno", sno);
        // objCommand.Parameters.AddWithValue("@emp_name", emp_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader user_login_check(string username)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "user_login_check";
        objCommand.Parameters.AddWithValue("@username", username);
        // objCommand.Parameters.AddWithValue("@customer_id", customer_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader client_login_check(string customer_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "client_login_check";
        objCommand.Parameters.AddWithValue("@customer_id", customer_id);
        // objCommand.Parameters.AddWithValue("@customer_id", customer_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public string user_login_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "user_login_delete";
            objCommand.Parameters.AddWithValue("@sno", sno);
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
    public string financial_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "financial_delete";
            objCommand.Parameters.AddWithValue("@f_id", f_id);
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
    public string document_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "document_delete";
            objCommand.Parameters.AddWithValue("@sno", sno);
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
    public string company_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "company_delete";
            objCommand.Parameters.AddWithValue("@sno", sno);
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
    public string customer_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "customer_delete";
            objCommand.Parameters.AddWithValue("@sno", sno);
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
    public string document_detail_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "document_detail_delete";
            objCommand.Parameters.AddWithValue("@sno", sno);
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

   

    public string m_crmduepaymentdetails_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crmduepaymentdetails_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Lead_no", Lead_no);
            objCommand.Parameters.AddWithValue("@due_amount", due_amount);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@domain_name", domain_name);
            objCommand.Parameters.AddWithValue("@regd_email", regd_email);
            objCommand.Parameters.AddWithValue("@collected_amount", collected_amount);
            objCommand.Parameters.AddWithValue("@remark", Remarks);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@mode_of_payment", mode_of_payment);
            objCommand.Parameters.AddWithValue("@cheque_no", cheque_no);
            objCommand.Parameters.AddWithValue("@bank_branch", bank_branch);
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
    public string m_crmpaymentdetails_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {



            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crmpaymentdetails_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Lead_no", Lead_no);
            objCommand.Parameters.AddWithValue("@tin", tin);
            objCommand.Parameters.AddWithValue("@b_name", b_name);
            objCommand.Parameters.AddWithValue("@description", description);
            objCommand.Parameters.AddWithValue("@servicetaxno", servicetaxno);
            objCommand.Parameters.AddWithValue("@due_amount", due_amount);
            objCommand.Parameters.AddWithValue("@total_amount", total_amount);
            objCommand.Parameters.AddWithValue("@customer_name", customer_name);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            // objCommand.Parameters.AddWithValue("@quotation_amount", quotation_amount);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@email_id", email_id);
            // objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@collected_amount", collected_amount);
            objCommand.Parameters.AddWithValue("@service_type", service_type);
            objCommand.Parameters.AddWithValue("@remark", remark);
            objCommand.Parameters.AddWithValue("@domain_name", domain_name);
            objCommand.Parameters.AddWithValue("@Remarks", Remarks);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@mode_of_payment", mode_of_payment);
            objCommand.Parameters.AddWithValue("@cheque_no", cheque_no);
            objCommand.Parameters.AddWithValue("@bank_branch", bank_branch);
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

    public string m_crmticket_update(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crmticket_update";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Schedule_date", Schedule_date);
            objCommand.Parameters.AddWithValue("@customer_name", customer_name);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@service_type", service_type);
            objCommand.Parameters.AddWithValue("@regd_email", regd_email);
            objCommand.Parameters.AddWithValue("@remark", remark);
            objCommand.Parameters.AddWithValue("@project_status", project_status);
            objCommand.Parameters.AddWithValue("@start_date", start_date);

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
    public string m_domaindetails_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {



            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_domaindetails_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@lead_no", lead_no);
            objCommand.Parameters.AddWithValue("@customer_name", customer_name);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@reg_emailID", reg_emailID);
            objCommand.Parameters.AddWithValue("@domin_name", domin_name);
            objCommand.Parameters.AddWithValue("@domin_regEmail", domin_regEmail);
            objCommand.Parameters.AddWithValue("@domin_password", domin_password);
            objCommand.Parameters.AddWithValue("@domin_bookeddate", domin_bookeddate);
            objCommand.Parameters.AddWithValue("@domin_dominlist", domin_dominlist);
            objCommand.Parameters.AddWithValue("@dp_name", dp_name);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@renewalamount", renewalamount);
            objCommand.Parameters.AddWithValue("@sp_name", sp_name);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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

    public DataTable m_domaindetails_renewal_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_domaindetails_renewal_view";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable m_domaindetails_select_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_domaindetails_select_view";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public SqlDataReader m_crmcustomer_searchview(string lead_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "m_crmcustomer_searchview";
        objCommand.Parameters.AddWithValue("@lead_no", lead_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public string m_crmticket_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crmticket_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@lead_no", lead_no);
            objCommand.Parameters.AddWithValue("@tin", tin);
            objCommand.Parameters.AddWithValue("@b_name", b_name);
            objCommand.Parameters.AddWithValue("@discountitem", discountitem);
            objCommand.Parameters.AddWithValue("@discount", discount);
            objCommand.Parameters.AddWithValue("@renewalamount", renewalamount);
            objCommand.Parameters.AddWithValue("@servicetaxno", servicetaxno);
            objCommand.Parameters.AddWithValue("@Schedule_date", Schedule_date);
            objCommand.Parameters.AddWithValue("@total_amount", total_amount);
            objCommand.Parameters.AddWithValue("@customer_name", customer_name);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@quotation_amount", quotation_amount);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@email_id", email_id);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@collected_amount", collected_amount);
            objCommand.Parameters.AddWithValue("@service_type", service_type);
            objCommand.Parameters.AddWithValue("@Description", Description);
            objCommand.Parameters.AddWithValue("@domain_name", domain_name);
            // objCommand.Parameters.AddWithValue("@regd_email", regd_email);
            objCommand.Parameters.AddWithValue("@remark", remark);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@mode_of_payment", mode_of_payment);
            objCommand.Parameters.AddWithValue("@cheque_no", cheque_no);
            objCommand.Parameters.AddWithValue("@bank_branch", bank_branch);
            objCommand.Parameters.AddWithValue("@assign_date", assign_date);

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

    public string crmservicerequest_log_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "crmservicerequest_log_insert";
            objCommand.Parameters.AddWithValue("@customer_id", customer_id);
            objCommand.Parameters.AddWithValue("@status", status);
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Issue_name", Issue_name);
            objCommand.Parameters.AddWithValue("@description", description);
            objCommand.Parameters.AddWithValue("@logged_by", logged_by);
            objCommand.Parameters.AddWithValue("@contactno", contactno);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
    public string m_crm_customer_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {



            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "m_crm_customer_insert";


            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@lead_no", lead_no);
            objCommand.Parameters.AddWithValue("@due_amount", due_amount);
            objCommand.Parameters.AddWithValue("@Schedule_date", Schedule_date);
            objCommand.Parameters.AddWithValue("@domain_reg_emailid", domain_reg_emailid);
            objCommand.Parameters.AddWithValue("@customer_name", customer_name);
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@email_id", email_id);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@service_amount", service_amount);
            objCommand.Parameters.AddWithValue("@service_type", service_type);
            objCommand.Parameters.AddWithValue("@website_type", website_type);

            objCommand.Parameters.AddWithValue("@domain_name", domain_name);
            objCommand.Parameters.AddWithValue("@regd_email", regd_email);
            objCommand.Parameters.AddWithValue("@no_of_pages", no_of_pages);
            objCommand.Parameters.AddWithValue("@no_of_mails", no_of_mails);
            objCommand.Parameters.AddWithValue("@service_desc", service_desc);
            objCommand.Parameters.AddWithValue("@domain_booking_date", domain_booking_date);
            objCommand.Parameters.AddWithValue("@domain_username", domain_username);
            objCommand.Parameters.AddWithValue("@domain_password", domain_password);
            objCommand.Parameters.AddWithValue("@domain_reg_email_id", domain_reg_email_id);
            objCommand.Parameters.AddWithValue("@domain_des", domain_des);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@hosting_date", hosting_date);
            objCommand.Parameters.AddWithValue("@hosting_sub_name", hosting_sub_name);
            objCommand.Parameters.AddWithValue("@hosting_user_name", hosting_user_name);
            objCommand.Parameters.AddWithValue("@hosting_password", hosting_password);
            objCommand.Parameters.AddWithValue("@hosting_desc", hosting_desc);



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

    public DataTable m_crmpaymentdetails_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmpaymentdetails_view";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
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

    public DataTable Completedproject_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Completedproject_view";
            //.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable m_crmticket_pendind_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmticket_pendind_view";
            //.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public SqlDataReader invoice_select_print(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "invoice_select_print";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader quotation_select_print(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "quotation_select_print";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader invoice_Product_print(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "invoice_Product_print";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Quotation_Product_print(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_Product_print";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader invoice_Product_total_price(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "invoice_Product_total_price";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Quotation_Product_total_price(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_Product_total_price";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader Quotation_sendmail(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_sendmail";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader Quotation_Product_print_price(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_Product_print_price";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //  objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public DataTable Quotation_Select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Quotation_Select";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public SqlDataReader Quotation_Product_Delete(string s_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_Product_Delete";
        objCommand.Parameters.AddWithValue("@s_id", s_id);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public DataTable m_crmticket_select_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmticket_select_view";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
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

    public DataTable m_crmcustomer_supportview(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmcustomer_supportview";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
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

    public DataTable m_crmcustomer_feedbackview(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmcustomer_feedbackview";
            //objCommand.Parameters.AddWithValue("@search_value", search_value);
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

    public DataTable m_crmduepaymentdetails_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmduepaymentdetails_view";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable m_crm_customer_dueamount_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crm_customer_dueamount_view";
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public DataTable employee_Ledger_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "employee_Ledger_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable vendor_Ledger_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "vendor_Ledger_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable purchase_Ledger_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "purchase_Ledger_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable Invoice_Ledger_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Invoice_Ledger_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable quotation_Ledger_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "quotation_Ledger_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable enquery_Ledger_report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "enquery_Ledger_report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable m_crm_temp_employee_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crm_temp_employee_select";
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

    public SqlDataReader Quotation_product_filter(string s_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_product_filter";
        objCommand.Parameters.AddWithValue("@s_id", s_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader vendor_Payment_filter(string project_name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "vendor_Payment_filter";
        objCommand.Parameters.AddWithValue("@project_name", project_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader invoice_payment_filter(string project_name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "invoice_payment_filter";
        objCommand.Parameters.AddWithValue("@project_name", project_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader employee_details(string EMP_ID)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "employee_details";
        objCommand.Parameters.AddWithValue("@EMP_ID", EMP_ID);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Customer_search(string Customer_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Customer_search";
        objCommand.Parameters.AddWithValue("@Customer_Id", Customer_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader Quotation_filter(string Quotation_No)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Quotation_filter";
        objCommand.Parameters.AddWithValue("@Quotation_No", Quotation_No);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public DataTable m_crmemployee_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crmemployee_select";
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

    public DataTable m_crm_customer_select_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crm_customer_select_Report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable m_crm_customer_select_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "m_crm_customer_select_view";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable crm_user_Detail_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "crm_user_Detail_Report";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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

    public DataTable Expense_Entry_SELECT_delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_SELECT_delete";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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
    public DataTable Expense_Entry_SELECT_view(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_SELECT_view";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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
    public SqlDataReader total_Expense_Select(DateTime from_date, DateTime to_date)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "total_Expense_Select";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public string Expense_Entry_Delete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Expense_Entry_Delete";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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

    public DataTable Expense_Entry_SELECT(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Expense_Entry_SELECT";
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
            // objCommand.Parameters.AddWithValue("@agent_name", agent_name);
            //objCommand.Parameters.AddWithValue("@Branch_Name", Branch_Name);
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

    public SqlDataReader Branch_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Branch_select";
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader add_agent_dd_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "add_agent_dd_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader agentdetails_dd_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "agentdetails_dd_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader EMPLOYEE_name_dd(string Branch_name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "EMPLOYEE_name_dd";
        objCommand.Parameters.AddWithValue("@Branch_name", Branch_name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader search_count_select(string search_value, string Flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "search_count_select";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Parameters.AddWithValue("@Flag", Flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader Master_Payment_View(string payment_type, string search_value, string Flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Master_Payment_View";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Parameters.AddWithValue("@payment_type", payment_type);
        objCommand.Parameters.AddWithValue("@Flag", Flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }


    public SqlDataReader lead_call_log_select(string sno)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "lead_call_log_select";
        objCommand.Parameters.AddWithValue("@sno", sno);

        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }


    public SqlDataReader search_report_select(string search_value, string Flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "search_report_select";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Parameters.AddWithValue("@Flag", Flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }
    public SqlDataReader BookingDue_Select(string search_value)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "BookingDue_Select";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader PaymentDue_Select(string search_value)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "PaymentDue_Select";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Renewal_Select(string search_value)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Renewal_Select";
        objCommand.Parameters.AddWithValue("@search_value", search_value);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }


    //---------------------------------- BHAGWANT SINGH CODED --------------------------------------------------


    private string _rtgs_code;
    public string rtgs_code
    {
        get
        {
            return _rtgs_code;
        }
        set
        {
            _rtgs_code = value;
        }

    }


    private string _Insurance;
    public string Insurance
    {
        get
        {
            return _Insurance;
        }
        set
        {
            _Insurance = value;
        }

    }


    private string _VAT;
    public string VAT
    {
        get
        {
            return _VAT;
        }
        set
        {
            _VAT = value;
        }

    }

    private string _CST;
    public string CST
    {
        get
        {
            return _CST;
        }
        set
        {
            _CST = value;
        }

    }

    private string _TAX;
    public string TAX
    {
        get
        {
            return _TAX;
        }
        set
        {
            _TAX = value;
        }

    }
    private string _Shipping_Address;
    public string Shipping_Address
    {
        get
        {
            return _Shipping_Address;
        }
        set
        {
            _Shipping_Address = value;
        }
    }

    private string _Ship_To;
    public string Ship_To
    {
        get
        {
            return _Ship_To;
        }
        set
        {
            _Ship_To = value;
        }
    }


    private string _Ec_Amount;
    public string Ec_Amount
    {
        get
        {
            return _Ec_Amount;
        }
        set
        {
            _Ec_Amount = value;
        }
    }



    private string _Extra_Charge;
    public string Extra_Charge
    {
        get
        {
            return _Extra_Charge;
        }
        set
        {
            _Extra_Charge = value;
        }
    }



    private string _Adv;
    public string Adv
    {
        get
        {
            return _Adv;
        }
        set
        {
            _Adv = value;
        }
    }


    private string _account_no;
    public string account_no
    {
        get
        {
            return _account_no;
        }
        set
        {
            _account_no = value;
        }
    }


    private string _branch_name;
    public string branch_name
    {
        get
        {
            return _branch_name;
        }
        set
        {
            _branch_name = value;
        }
    }


    private string _bank_name;
    public string bank_name
    {
        get
        {
            return _bank_name;
        }
        set
        {
            _bank_name = value;
        }
    }


    private string _Customer_Address;
    public string Customer_Address
    {
        get
        {
            return _Customer_Address;
        }
        set
        {
            _Customer_Address = value;
        }
    }


    private string _Customer_Name;
    public string Customer_Name
    {
        get
        {
            return _Customer_Name;
        }
        set
        {
            _Customer_Name = value;
        }
    }


    private string _Terms;
    public string Terms
    {
        get
        {
            return _Terms;
        }
        set
        {
            _Terms = value;
        }
    }



    private string _Cust_Ref;
    public string Cust_Ref
    {
        get
        {
            return _Cust_Ref;
        }
        set
        {
            _Cust_Ref = value;
        }
    }



    private string _Our_Ref;
    public string Our_Ref
    {
        get
        {
            return _Our_Ref;
        }
        set
        {
            _Our_Ref = value;
        }
    }



    private DateTime _Date_Of_Quotation;
    public DateTime Date_Of_Quotation
    {
        get
        {
            return _Date_Of_Quotation;
        }
        set
        {
            _Date_Of_Quotation = value;
        }
    }


    private string _Customer_id;
    public string Customer_id
    {
        get
        {
            return _Customer_id;
        }
        set
        {
            _Customer_id = value;
        }
    }


    private string _tin_no;
    public string tin_no
    {
        get
        {
            return _tin_no;
        }
        set
        {
            _tin_no = value;
        }
    }



    private string _cstno;
    public string cstno
    {
        get
        {
            return _cstno;
        }
        set
        {
            _cstno = value;
        }
    }



    private string _Email;
    public string Email
    {
        get
        {
            return _Email;
        }
        set
        {
            _Email = value;
        }
    }




    private string _Mobile_No;
    public string Mobile_No
    {
        get
        {
            return _Mobile_No;
        }
        set
        {
            _Mobile_No = value;
        }
    }




    private string _Fax_No;
    public string Fax_No
    {
        get
        {
            return _Fax_No;
        }
        set
        {
            _Fax_No = value;
        }
    }



    private string _Telephone_No;
    public string Telephone_No
    {
        get
        {
            return _Telephone_No;
        }
        set
        {
            _Telephone_No = value;
        }
    }

    //,,,,,,,,

    private string _Mobile;
    public string Mobile
    {
        get
        {
            return _Mobile;
        }
        set
        {
            _Mobile = value;
        }
    }



    private string _Rest_Amount;
    public string Rest_Amount
    {
        get
        {
            return _Rest_Amount;
        }
        set
        {
            _Rest_Amount = value;
        }
    }



    private string _Amount_Paid;
    public string Amount_Paid
    {
        get
        {
            return _Amount_Paid;
        }
        set
        {
            _Amount_Paid = value;
        }
    }


    private string _Total_Amount;
    public string Total_Amount
    {
        get
        {
            return _Total_Amount;
        }
        set
        {
            _Total_Amount = value;
        }
    }



    private string _Extra_Charge_Amount;
    public string Extra_Charge_Amount
    {
        get
        {
            return _Extra_Charge_Amount;
        }
        set
        {
            _Extra_Charge_Amount = value;
        }
    }

    private string _Customer_Ref;
    public string Customer_Ref
    {
        get
        {
            return _Customer_Ref;
        }
        set
        {
            _Customer_Ref = value;
        }
    }


    private string _Purchaser_Address;
    public string Purchaser_Address
    {
        get
        {
            return _Purchaser_Address;
        }
        set
        {
            _Purchaser_Address = value;
        }
    }



    private string _Purchaser_Name;
    public string Purchaser_Name
    {
        get
        {
            return _Purchaser_Name;
        }
        set
        {
            _Purchaser_Name = value;
        }
    }


    private DateTime _Invoice_Date;
    public DateTime Invoice_Date
    {
        get
        {
            return _Invoice_Date;
        }
        set
        {
            _Invoice_Date = value;
        }
    }





    private string _Contact_Person;
    public string Contact_Person
    {
        get
        {
            return _Contact_Person;
        }
        set
        {
            _Contact_Person = value;
        }
    }




    private string _Vendor_Address;
    public string Vendor_Address
    {
        get
        {
            return _Vendor_Address;
        }
        set
        {
            _Vendor_Address = value;
        }
    }


    private string _Vendor_Name;
    public string Vendor_Name
    {
        get
        {
            return _Vendor_Name;
        }
        set
        {
            _Vendor_Name = value;
        }
    }


    public string Vendor_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Vendor_insert ";
            objCommand.Parameters.AddWithValue("@s_no", s_no);
            objCommand.Parameters.AddWithValue("@location", location);
            objCommand.Parameters.AddWithValue("@specialize", specialize);
            objCommand.Parameters.AddWithValue("@Vendor_Name", Vendor_Name);
            objCommand.Parameters.AddWithValue("@Vendor_Address", Vendor_Address);
            objCommand.Parameters.AddWithValue("@Contact_Person", Contact_Person);
            objCommand.Parameters.AddWithValue("@Telephone_No", Telephone_No);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@Fax_No", Fax_No);
            objCommand.Parameters.AddWithValue("@Mobile_No", Mobile_No);
            objCommand.Parameters.AddWithValue("@Email", Email);
            objCommand.Parameters.AddWithValue("@Remarks", Remarks);
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
    public SqlDataReader Vendors_Update(string s_no)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Vendors_Update";
        objCommand.Parameters.AddWithValue("@s_no", s_no);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader view_vendors_payment()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "view_vendors_payment";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        //objCommand.Parameters.AddWithValue("@party_type", party_type);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public DataTable employee_payment_details_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "employee_payment_details_select";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public DataTable Payment_Select_View_filter(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Payment_Select_View_filter";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public SqlDataReader document_detail_select_view(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "document_detail_select_view";
        objCommand.Parameters.AddWithValue("@company_name", company_name);
        objCommand.Parameters.AddWithValue("@Associate_company", Associate_company);
        objCommand.Parameters.AddWithValue("@financial_year", financial_year);
        objCommand.Parameters.AddWithValue("@document_type", document_type);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader document_detail_select_client(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "document_detail_select_client";
        objCommand.Parameters.AddWithValue("@financial_year", financial_year);
        objCommand.Parameters.AddWithValue("@document_type", document_type);
        objCommand.Parameters.AddWithValue("@Customer_Id", customer_id);
        objCommand.Parameters.AddWithValue("@Month", Month);
        objCommand.Parameters.AddWithValue("@CompanyId", company_id);
        // objCommand.Parameters.AddWithValue("@Company", branch_name);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    //delete investment document
    public string InvestmentDocumentDelete(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "InvestmentDocumentDelete";
            objCommand.Parameters.AddWithValue("@sno", sno);
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

    //investment document view
    public SqlDataReader GetInvestmentdocument(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "SP_Investmentdocument";
        objCommand.Parameters.AddWithValue("@financial_year", financial_year);
        objCommand.Parameters.AddWithValue("@document_type", document_type);
        objCommand.Parameters.AddWithValue("@Customer_Id", customer_id);
        objCommand.Parameters.AddWithValue("@Month", Month);
        objCommand.Parameters.AddWithValue("@CompanyId", company_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public SqlDataReader Proc_Resetdata()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Proc_Resetdata";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader document_detail_select(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "document_detail_select";
        objCommand.Parameters.AddWithValue("@company_name", company_name);
        objCommand.Parameters.AddWithValue("@Associate_company", Associate_company);
        objCommand.Parameters.AddWithValue("@document_type", document_type);
        objCommand.Parameters.AddWithValue("@financial_year", financial_year);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader user_login_select(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "user_login_select";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@search_value", search_value);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Request_select_Admin(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Request_select_Admin";
        objCommand.Parameters.AddWithValue("@from_date", from_date);
        objCommand.Parameters.AddWithValue("@to_date", to_date);
        //objCommand.Parameters.AddWithValue("@created_by", created_by);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Request_select(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Request_select";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@created_by", created_by);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader customer_select(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "customer_select";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@search_value", search_value);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader Invoice_Product_Select(maincode obj_main)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Invoice_Product_Select";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        objCommand.Parameters.AddWithValue("@search_value", search_value);

        //  objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public string Invoice_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Invoice_insert ";

            objCommand.Parameters.AddWithValue("@s_no", s_no);
            objCommand.Parameters.AddWithValue("@Contact_Person", Contact_Person);
            objCommand.Parameters.AddWithValue("@location", location);
            objCommand.Parameters.AddWithValue("@area", area);
            objCommand.Parameters.AddWithValue("@project_name", project_name);
            objCommand.Parameters.AddWithValue("@other_contact", other_contact);
            objCommand.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            objCommand.Parameters.AddWithValue("@Customer_Address", Customer_Address);
            objCommand.Parameters.AddWithValue("@Remarks", Remarks);
            objCommand.Parameters.AddWithValue("@Email", Email);
            objCommand.Parameters.AddWithValue("@Mobile_No", Mobile_No);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@Quotation_No", Quotation_No);
            objCommand.Parameters.AddWithValue("@amount", amount);
            objCommand.Parameters.AddWithValue("@Amount_Paid", Amount_Paid);
            objCommand.Parameters.AddWithValue("@Rest_Amount", Rest_Amount);

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
    public DataTable Vendors_Select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Vendors_Select";
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
    public SqlDataReader view_vendors()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "view_vendors";
        //objCommand.Parameters.AddWithValue("@from_date", from_date);
        //objCommand.Parameters.AddWithValue("@to_date", to_date);
        //objCommand.Parameters.AddWithValue("@party_type", party_type);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }

    public DataTable Vendors_Select_View_filter(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Vendors_Select_View_filter";
            objCommand.Parameters.AddWithValue("@search_value", search_value);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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

    public SqlDataReader Customer_Select(string Customer_Id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "Customer_Select";
        objCommand.Parameters.AddWithValue("@Customer_Id", Customer_Id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }



    public string Quotation_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "Quotation_insert ";
            objCommand.Parameters.AddWithValue("@s_no", s_no);
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@Contact_Person", Contact_Person);
            objCommand.Parameters.AddWithValue("@location", location);
            objCommand.Parameters.AddWithValue("@area", area);
            objCommand.Parameters.AddWithValue("@project_name", project_name);
            objCommand.Parameters.AddWithValue("@other_contact", other_contact);
            objCommand.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            objCommand.Parameters.AddWithValue("@Customer_Address", Customer_Address);
            objCommand.Parameters.AddWithValue("@Remarks", Remarks);
            objCommand.Parameters.AddWithValue("@Email", Email);
            objCommand.Parameters.AddWithValue("@Mobile_No", Mobile_No);
            objCommand.Parameters.AddWithValue("@flag", flag);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@Emailsub", Emailsub);

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

    public string employee_payment_details_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "employee_payment_details_insert";
            objCommand.Parameters.AddWithValue("@sno", sno);
            objCommand.Parameters.AddWithValue("@emp_id", emp_id);
            objCommand.Parameters.AddWithValue("@designation", designation);
            objCommand.Parameters.AddWithValue("@emp_name", emp_name);
            objCommand.Parameters.AddWithValue("@father_name", father_name);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@mobile", mobile);
            objCommand.Parameters.AddWithValue("@salary", salary);
            objCommand.Parameters.AddWithValue("@mode_of_payment", mode_of_payment);
            objCommand.Parameters.AddWithValue("@t_pesent", t_pesent);
            objCommand.Parameters.AddWithValue("@t_absent", t_absent);
            objCommand.Parameters.AddWithValue("@t_leave", t_leave);
            objCommand.Parameters.AddWithValue("@T_Working_Day", T_Working_Day);
            objCommand.Parameters.AddWithValue("@cheque_no", cheque_no);
            objCommand.Parameters.AddWithValue("@bank_branch", bank_branch);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
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
    public string vendor_Payment_insert(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {


            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "vendor_Payment_insert";
            objCommand.Parameters.AddWithValue("@s_no", s_no);
            objCommand.Parameters.AddWithValue("@area", area);
            objCommand.Parameters.AddWithValue("@project_name", project_name);
            objCommand.Parameters.AddWithValue("@vendor_name", Vendor_Name);
            objCommand.Parameters.AddWithValue("@mobile_no", mobile_no);
            objCommand.Parameters.AddWithValue("@specialize", specialize);
            objCommand.Parameters.AddWithValue("@address", address);
            objCommand.Parameters.AddWithValue("@created_by", created_by);
            objCommand.Parameters.AddWithValue("@remarks", Remarks);
            objCommand.Parameters.AddWithValue("@mode_of_payment", mode_of_payment);
            objCommand.Parameters.AddWithValue("@amount", amount);
            objCommand.Parameters.AddWithValue("@cheque_no", cheque_no);
            objCommand.Parameters.AddWithValue("@bank_branch", bank_and_branch);
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
    public SqlDataReader dd_select_vendor(string Vendor_Name)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "dd_select_vendor";
        objCommand.Parameters.AddWithValue("@dd_vendor", Vendor_Name);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

    public SqlDataReader select_vendors()
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "select_vendors";
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public DataTable financial_select_view()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "financial_select_view";
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
    public DataTable document_select()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "document_select";
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
    public DataTable company_select()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "company_select";
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

    public DataTable purchase_order_select()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "purchase_order_select";
            // objCommand.Parameters.AddWithValue("@search_value", search_value);
            // objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable Customer1_select_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Customer1_select_Report";
            // objCommand.Parameters.AddWithValue("@search_value", search_value);
            // objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            //objCommand.Parameters.AddWithValue("@from_date", from_date);
            //objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable Customer_select_Report(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Customer_select_Report";
            // objCommand.Parameters.AddWithValue("@search_value", search_value);
            // objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable document_Report_select(maincode obj_main)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "document_Report_select";
            objCommand.Parameters.AddWithValue("@company_name", company_name);
            objCommand.Parameters.AddWithValue("@Associate_company", Associate_company);
            objCommand.Parameters.AddWithValue("@financial_year", financial_year);
            objCommand.Parameters.AddWithValue("@document_type", document_type);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
    public DataTable enquery_select()
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "enquery_select";
            // objCommand.Parameters.AddWithValue("@search_value", search_value);
            // objCommand.Parameters.AddWithValue("@lead_status", lead_status);
            objCommand.Parameters.AddWithValue("@from_date", from_date);
            objCommand.Parameters.AddWithValue("@to_date", to_date);
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
}
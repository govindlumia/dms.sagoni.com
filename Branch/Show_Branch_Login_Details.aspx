<%@ Page Title="::Rajesh Raj Gupta & Associates::" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Show_Branch_Login_Details.aspx.cs" Inherits="Show_Branch_Login_Details" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <%--   <link rel="stylesheet" type="text/css"  href="../themes/softed/style.css">--%>

<script type ="text/ecmascript" >
    var _Page = '0';
    var _StartsWith = 'All';

    var _SearchText = '';

    function NavigateToLetter(ltr) {

        _Page = 0;
        _StartsWith = ltr;

        DoNavigate();

        //        alert(url);
        //        return;
    }
    function DoNavigate() {
        var url = 'leadReport.aspx'

        url = url + '?firstname=' + _StartsWith;

        location.href = url;
    }

    </script>
   
  <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
  <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>

<div class="detailedViewHeader">
  <p class="lvtHeaderText">User Login Details</p>
  </div>

    <center>
<div class="dvtContentSpace" style="padding:10px 10px 10px 0px;width:99.7%;">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
     


  

   <tr>
   <td colspan="4" style="padding-top:0px">
  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
   <tr>
 <td valign="middle" class="dvtCellLabeltop">
 <div class="mGrid1"  Width="100%" id="gridCustomers" style="width:100%;border-collapse:collapse; padding-top:0px; text-align:left">
        <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                  AllowPaging ="false" Width="100%" 
            EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" 
            PagerStyle-CssClass="pgr" onrowcommand="grdLead_RowCommand"> 
                                
                         <Columns >
                         <asp:TemplateField  HeaderText ="Action">
                             
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/quotation-icon.jpg" runat="server" CommandName ="edit" ToolTip ="Click to edit" CausesValidation ="false"   /> 
                                                     
                                                   
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                      
                           <asp:TemplateField HeaderText="emp_id" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblemp_id" runat="server" Text ='<%#Eval("emp_id") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                         
                        
                        
                          <asp:BoundField DataField ="Branch_Name" HeaderText ="Name"/>
                          <asp:BoundField DataField ="emp_name" HeaderText ="Authorised Person"/>
                            <asp:BoundField DataField ="emp_code" HeaderText ="User Name"/>
                          <asp:BoundField DataField ="password" HeaderText ="Password"/>
                          <asp:BoundField DataField ="mobile_no" HeaderText ="Mobile No"/>
                          <asp:BoundField DataField ="address" HeaderText ="Address"/>
                          <asp:BoundField DataField ="active" HeaderText ="Status"/>
                 
                           <asp:BoundField DataField ="created_on" HeaderText ="Created Date" />
                                                       
                         </Columns>
                            


                         </asp:GridView>
        		           
			           </div>
 </td>
  
   </tr>

    

</table>
   </td>
   </tr>

    </table>

    

   </div>
   </center>  
   <br />
   
 
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Document_Report.aspx.cs" Inherits="Report_Document_Report" Culture="en-GB" UICulture="en-GB" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css" />

   
  
<div class="detailedViewHeader">
<table width="100%">
<tr>
<td valign="middle" style="width:50%"><p class="lvtHeaderText"> Document Report </p></td>
<td valign="middle" style="text-align:right">
<asp:Button ID="btnExcell" runat="server" Text ="Export as Excel"  
        align="absmiddle" Font-Bold="True" style="margin-top:-10px; color:Maroon " onclick="btnExcell_Click" 
        /></p>

</td>
</tr>
</table>
</div>

<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">

<tr style="border-top:1px solid #dedede;">
   <td valign="middle" class="dvtCellLabeltop" style="width:150px" > From : </td>
     <td valign="middle" class="cellInfo" style="width:150px">
   <asp:TextBox ID="txtfromdate" runat="server" Cssclass="date_textbox"  style="width:150px"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" SetFocusOnError="true"
                            ControlToValidate="txtfromdate" Display="Dynamic" ErrorMessage="Enter From Date"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmv_fromdate" ControlToValidate="txtfromdate" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:calendarextender ID="calendarextender3" runat="server" TargetControlID="txtfromdate"
                            Format="dd/MM/yyyy" PopupButtonID="txtfromdate" />

   </td>
     <td valign="middle" class="dvtCellLabeltop" style="width:150px"> To : </td>
   <td valign="middle" class="cellInfo">
      <asp:TextBox ID="txttodate" runat="server" CssClass="date_textbox" style="width:150px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfv_todate" runat="server" ControlToValidate="txttodate"
                            Display="Dynamic" ErrorMessage="Enter To Date" SetFocusOnError="true"></asp:RequiredFieldValidator>
                         <asp:CompareValidator ID="cmv_todate2" ControlToValidate="txttodate" ControlToCompare="txtfromdate"
                            Type="Date" Operator="GreaterThanEqual" Display="Dynamic" ErrorMessage="This Date cannot be less than from date"
                            runat="server" SetFocusOnError="true"></asp:CompareValidator>
                        <ajaxtoolkit:calendarextender ID="calendarextender2" runat="server" TargetControlID="txttodate"
                            Format="dd/MM/yyyy" PopupButtonID="txttodate" />
 </td>
 </tr>
 <tr style="border-top:1px solid #dedede;">
   <td valign="middle" class="dvtCellLabeltop" style="width:150px" > Company Name : </td>
     <td valign="middle" class="cellInfo" style="width:150px">
        <asp:DropDownList ID="ddcompany" runat="server" CssClass="textbox"  Height="30px" Width="249px">
       </asp:DropDownList>
   </td>
     <td valign="middle" class="dvtCellLabeltop" style="width:150px"> Associate Company : </td>
   <td valign="middle" class="cellInfo">
       <asp:DropDownList ID="dd_Associate" runat="server" CssClass="textbox" Height="30px" Width="249px">
       </asp:DropDownList>
 </td>
 </tr>
 <tr style="border-top:1px solid #dedede;">
   <td valign="middle" class="dvtCellLabeltop" style="width:150px" > Financial Year : </td>
     <td valign="middle" class="cellInfo" style="width:150px">
  <asp:DropDownList ID="ddfinancial" runat="server" CssClass="textbox" Height="30px" Width="249px">
       </asp:DropDownList>

   </td>
     <td valign="middle" class="dvtCellLabeltop" style="width:150px"> Document Type : </td>
   <td valign="middle" class="cellInfo">
     <asp:DropDownList ID="dd_document" runat="server" CssClass="textbox" Height="30px" Width="249px">
       </asp:DropDownList>
 </td>
 </tr>
   <tr>
   <td valign="middle" class="dvtCellLabel" colspan="4" style="padding-bottom:10px; text-align:center; padding-top:10px;">
   <asp:ImageButton ID="ImageButton1" runat="server" 
           ImageUrl="~/images/submitButton.png" onclick="ImageButton1_Click"  />&nbsp;&nbsp;
 
   </td>
   </tr>
 
  <tr>
 <td colspan="4" style="padding-top:20px">
  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
 <tr>
 <td valign="middle" class="dvtCell" >
 
 <div class="mGrid1"  Width="100%" id="gridCustomers" style="border-collapse:collapse; padding-top:0px; text-align:left">
 
        		           
		
        <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%" 
         EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid" ShowFooter= "true"
         PagerStyle-CssClass="pgr"> 
                            
                         <Columns >
                         <asp:BoundField DataField ="sno" HeaderText ="S.No"/>
                          <asp:BoundField DataField ="Customer_Id" HeaderText ="Customer ID"/>
                             <asp:BoundField DataField ="company_name" HeaderText ="Company Name"/>
                             <asp:BoundField DataField ="Associate_company" HeaderText ="Associate Company"/>
                                <asp:BoundField DataField ="Authorised_person" HeaderText ="Authorised Person"/>
                                 <asp:BoundField DataField ="document_type" HeaderText ="Contact"/>
                              <asp:BoundField DataField ="financial_year" HeaderText ="Mobile"/>
                             <asp:BoundField DataField ="fileupload" HeaderText ="Other Contact."/>

                                    
                                 <asp:BoundField DataField ="created_on" HeaderText ="Date"/>                     
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
  
   


 
 
</asp:Content>


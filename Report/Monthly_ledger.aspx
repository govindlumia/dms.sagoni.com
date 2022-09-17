<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Monthly_ledger.aspx.cs" Inherits="Report_Monthly_ledger" Culture ="en-GB" UICulture ="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>::SAGONI INDIA PRIVATE LIMITED - HELPDESK | Monthly Lead Report::</title>
<link href ="../css/crm_style.css" rel="stylesheet" type="text/css"/>
<%-- <script type="text/javascript" src="Jscript/Menu.js"></script>--%>
<%--<link href="http://fonts.googleapis.com/css?family=Armata" rel='stylesheet' type='text/css'>--%>

<link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
<script type="text/javascript" src="../Jscript/mtmv.js"></script>
<link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
   
</head>
<body style="margin:0px 0px 0px 0px">
 
<form id="form1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" ScriptMode="Release">
</asp:ScriptManager>

<div style="width:100%; background-color:white">
<div style="text-align:center; width:300px">
   <img alt="" src="http://bms.sagoni.com/images/CLOGO.png" Width="300px" Height="96px"/>
 
</div>
</div>

<div class="detailedViewHeader">
<table width="100%" cellpadding="1" cellspacing="2">
<tr>
<td valign="middle"><p class="lvtHeaderText">Monthly Report</p></td>
<td valign="middle" style="text-align:right"><asp:Button ID="back_buton" runat="server" Text="Back" Width="60px" OnClick="back_buton_Click1" /></td>
</tr>
</table>

</div>

<div>
<table width="100%">
<tr style="border-top:1px solid #dedede;">
<td valign="middle" class="dvtCellLabeltop" style="width:150px" >From : </td>
<td valign="middle" class="cellInfo" style="width:150px">
<asp:TextBox ID="txtfromdate" runat="server" Cssclass="date_textbox" style="width:150px"></asp:TextBox>

<asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" SetFocusOnError="true" ControlToValidate="txtfromdate" Display="Dynamic" ErrorMessage="Enter From Date"></asp:RequiredFieldValidator>
<asp:CompareValidator ID="cmv_fromdate" ControlToValidate="txtfromdate" Operator="DataTypeCheck"
     Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server" SetFocusOnError="true"></asp:CompareValidator>
<ajaxtoolkit:calendarextender ID="calendarextender3" runat="server" TargetControlID="txtfromdate" Format="dd/MM/yyyy" PopupButtonID="txtfromdate" />
</td>

<td valign="middle" class="dvtCellLabeltop" style="width:150px">To : </td>

<td valign="middle" class="cellInfo">
<asp:TextBox ID="txttodate" runat="server" CssClass="date_textbox" style="width:150px"></asp:TextBox><br />
<asp:RequiredFieldValidator ID="rfv_todate" runat="server" ControlToValidate="txttodate" Display="Dynamic" ErrorMessage="Enter To Date" SetFocusOnError="true"></asp:RequiredFieldValidator>

<asp:CompareValidator ID="cmv_todate2" ControlToValidate="txttodate" ControlToCompare="txtfromdate"
Type="Date" Operator="GreaterThanEqual" Display="Dynamic" ErrorMessage="This Date cannot be less than from date"
            runat="server" SetFocusOnError="true"></asp:CompareValidator>
 <ajaxtoolkit:calendarextender ID="calendarextender2" runat="server" TargetControlID="txttodate"
  Format="dd/MM/yyyy" PopupButtonID="txttodate" />

</td>
</tr>

<tr>
<td valign="middle" class="dvtCellLabel" colspan="4" style="padding-bottom:0px; text-align:center; padding-top:4px;">
<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/submitButton.png" OnClick="ImageButton1_Click"/>&nbsp;&nbsp;
 
</td>
</tr>
</table>
</div>

<%-- LEAD SECTION --%>

<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<div class="big" style=" border:1px solid #8C8C8C; background-color:#F7F7F7">

<div style="width:100%; padding-bottom:10px; padding-top:10px; text-align:left; text-align:center;border-bottom:1px solid #8C8C8C ">
 <label style=" font-family:Arial;font-weight:bold; color:Black ; font-size:17px; text-align:center">ENQUERY SECTION</label>
</div>

<!-----------# Qualified Lead #------------>

<div style="padding:0px 10px 10px 10px">
<div class="mGrid1"  cellspacing="0" rules="cols" border="1" id="Div2" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grden" runat ="server" AutoGenerateColumns ="False" GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" PagerStyle-CssClass="pgr"> 
                                
 <Columns >
 <asp:TemplateField HeaderText="Sno.">
 <ItemTemplate><%#Container.DataItemIndex+1 %></ItemTemplate>
 </asp:TemplateField> 
               
    
                              <asp:BoundField DataField ="name" HeaderText ="Name"/>
                             <asp:BoundField DataField ="mobile_no" HeaderText ="Mobile No"/>
                             <asp:BoundField DataField ="address" HeaderText ="Addres"/>
                             <asp:BoundField DataField ="email_id" HeaderText ="Email"/>
                              <asp:BoundField DataField ="project" HeaderText ="Project"/>
                             <asp:BoundField DataField ="area" HeaderText ="Area"/>
                             <asp:BoundField DataField ="requirement" HeaderText ="Requirement"/>
                            <asp:BoundField DataField ="enq_sta" HeaderText ="Status"/>
                             <asp:BoundField DataField ="created_on" HeaderText ="Created Date" />
                              
       </Columns>
       <PagerStyle CssClass="pgr" />
       </asp:GridView>
        		           
</div>
</div>

</div>
</div>

<%-- LEAD SECTION END --%>
<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<div class="big" style=" border:1px solid #8C8C8C; background-color:#F7F7F7">

<div style="width:100%; padding-bottom:10px; padding-top:10px; text-align:left; text-align:center;border-bottom:1px solid #8C8C8C ">
 <label style=" font-family:Arial;font-weight:bold; color:Black ; font-size:17px; text-align:center">QUOTATION SECTION</label>
</div>



<div style="padding:0px 10px 10px 10px">
<div class="mGrid1"  cellspacing="0" rules="cols" border="1" id="Div4" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdquo" runat ="server" AutoGenerateColumns ="False" GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" PagerStyle-CssClass="pgr"> 
                                
 <Columns >
 <asp:TemplateField HeaderText="Sno.">
 <ItemTemplate><%#Container.DataItemIndex+1 %></ItemTemplate>
 </asp:TemplateField> 
               
        <asp:BoundField DataField ="Quotation_No" HeaderText ="Quotation No"/>
                          <asp:BoundField DataField ="project_name" HeaderText ="Project"/>
                          <asp:BoundField DataField ="Customer_Name" HeaderText ="Customer Name"/>
                          <asp:BoundField DataField ="Mobile_No" HeaderText =" Mobile No"/> 
                          <asp:BoundField DataField ="Remarks" HeaderText ="Remarks"/>
                          <asp:BoundField DataField ="q_status" HeaderText ="Status"/>  
      <asp:BoundField DataField ="created_on" HeaderText ="Date"/>  
                              
       </Columns>
       <PagerStyle CssClass="pgr" />
       </asp:GridView>
        		           
</div>
</div>

</div>
</div>


<%-- PAYMENT SECTION --%>

<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<div class="big" style=" border:1px solid #8C8C8C; background-color:#F7F7F7">

<div style="width:100%; padding-bottom:10px; padding-top:10px; text-align:left; text-align:center;border-bottom:1px solid #8C8C8C ">
 <label style=" font-family:Arial;font-weight:bold; color:Black ; font-size:17px; text-align:center">INVOICE SECTION</label><br /> 


</div>

<!-----------# INVOICE  #------------>

<div style="border:1px solid #8C8C8C; width:19.6%; margin:10px 10px 0px 10px;text-align:center; background-color:#E7E6E6">
<p style="margin-top:5px; margin-bottom:5px"><label style=" font-family:Arial;font-weight:bold; color:Maroon ; font-size:15px;margin-top:10px">Invoice</label></p>

</div>

<div style="padding:0px 10px 10px 10px">
<div class="mGrid1"  cellspacing="0" rules="cols" border="1" id="Div1" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdinv" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" ShowFooter="true" 
         PagerStyle-CssClass="pgr"> 
            <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" Font-Bold ="true" />                        
      <Columns>
           <asp:TemplateField HeaderText="Sno.">
 <ItemTemplate>
 <%#Container.DataItemIndex+1 %>
 </ItemTemplate>
 </asp:TemplateField> 
        <asp:BoundField DataField ="Quotation_No" HeaderText ="Quotation_No"/> 
                                 <asp:BoundField DataField ="Invoice_No" HeaderText ="Invoice"/> 
                                
                                 
                                  <asp:BoundField DataField ="project_name" HeaderText ="Project "/> 
                                   <asp:BoundField DataField ="Customer_Name" HeaderText ="Comp/Firm "/> 
                                    <asp:BoundField DataField ="Contact_Person" HeaderText ="Cont. Person "/> 
                                   <asp:BoundField DataField ="Mobile_No" HeaderText ="Mobile"/> 
                                  
                                    <asp:BoundField DataField ="Remarks" HeaderText ="Remarks "/> 
                                     <asp:BoundField DataField ="Quotation_No" HeaderText ="Quo.NO "/>
                                    <asp:BoundField DataField ="created_on" HeaderText ="Date"/> 
                         
      </Columns>
      <PagerStyle CssClass="pgr" />
               
      </asp:GridView>
        		           
</div>
</div>


<br />
    


</div>
</div>
<div class="big" style=" border:1px solid #8C8C8C; background-color:#F7F7F7">

<div style="width:100%; padding-bottom:10px; padding-top:10px; text-align:left; text-align:center;border-bottom:1px solid #8C8C8C ">
 <label style=" font-family:Arial;font-weight:bold; color:Black ; font-size:17px; text-align:center">PO SECTION</label><br /> 


</div>


<div style="border:1px solid #8C8C8C; width:19.6%; margin:10px 10px 0px 10px;text-align:center; background-color:#E7E6E6">
<p style="margin-top:5px; margin-bottom:5px"><label style=" font-family:Arial;font-weight:bold; color:Maroon ; font-size:15px;margin-top:10px">Purchase Order</label></p>

</div>

<div style="padding:0px 10px 10px 10px">
<div class="mGrid1"  cellspacing="0" rules="cols" border="1" id="Div6" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdpo" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" ShowFooter="true" 
         PagerStyle-CssClass="pgr"> 
            <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" Font-Bold ="true" />                        
      <Columns>
           <asp:TemplateField HeaderText="Sno.">
 <ItemTemplate>
 <%#Container.DataItemIndex+1 %>
 </ItemTemplate>
 </asp:TemplateField> 
         <asp:BoundField DataField ="po_no" HeaderText ="PO NO"/>
                              <asp:BoundField DataField ="project" HeaderText ="Project"/>
                              <asp:BoundField DataField ="vendor" HeaderText ="Vendor"/>
                              <asp:BoundField DataField ="specilist" HeaderText ="Specilist"/>
                              <asp:BoundField DataField ="service" HeaderText ="Service"/>
                              <asp:BoundField DataField ="description" HeaderText ="Description"/>
                              <asp:BoundField DataField ="amt" HeaderText ="Amount"/>
                              <asp:BoundField DataField ="agreement_peroid" HeaderText ="Agr Prd"/>
                              <asp:BoundField DataField ="purchase_order_date" HeaderText ="PO Date"/>
                              <asp:BoundField DataField ="created_on" HeaderText ="Date" />
                         
      </Columns>
      <PagerStyle CssClass="pgr" />
               
      </asp:GridView>
        		           
</div>
</div>

<br />

</div>


<%-- EXPENSE SECTION --%>

<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<div class="big" style=" border:1px solid #8C8C8C; background-color:#F7F7F7">

<div style="width:100%; padding-bottom:10px; padding-top:10px; text-align:left; text-align:center;border-bottom:1px solid #8C8C8C ; height:30px ">
 <label style=" font-family:Arial;font-weight:bold; color:Black ; font-size:17px; text-align:center">EXPENSE SECTION</label><br />

</div>





<div style="border:1px solid #8C8C8C; width:19.6%; margin:10px 10px 0px 10px;text-align:center; background-color:#E7E6E6">
<p style="margin-top:5px; margin-bottom:5px"><label style=" font-family:Arial;font-weight:bold; color:Maroon ; font-size:15px;margin-top:10px"> Vendor Payment </label></p>

</div>

<div style="padding:0px 10px 10px 10px">
<div class="mGrid1"  cellspacing="0" rules="cols" border="1" id="Div3" style="width:100%;border-collapse:collapse; text-align:center">
 
<asp:GridView ID="grdvendor" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" ShowFooter="true" 
         PagerStyle-CssClass="pgr"> 
          <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" Font-Bold ="true" />                              
      <Columns>
    <asp:BoundField DataField ="Receiver_Name" HeaderText ="Name"/>
                                 <asp:BoundField DataField ="Purpose" HeaderText ="Purpose"/>
                               
                                <asp:BoundField DataField ="amount" HeaderText ="Total Amt"/>
                              <asp:BoundField DataField ="collected_amount" HeaderText ="Given Amt"/>
                              <asp:BoundField DataField ="due_amount" HeaderText ="Dues Amt"/>
                                 <asp:BoundField DataField ="mode_of_payment" HeaderText ="Pay Mode"/>
                                 <asp:BoundField DataField ="Expence_date" HeaderText =" Expence Date"/>    
                               
      </Columns>
      <PagerStyle CssClass="pgr" />
               
      </asp:GridView>
        		           
</div>
</div>


<br />
<div style="border:1px solid #8C8C8C; width:19.6%; margin:10px 10px 0px 10px;text-align:center; background-color:#E7E6E6">
<p style="margin-top:5px; margin-bottom:5px"><label style=" font-family:Arial;font-weight:bold; color:Maroon ; font-size:15px;margin-top:10px"> Staff Payment </label></p>

</div>

<div style="padding:0px 10px 10px 10px">
<div class="mGrid1"  cellspacing="0" rules="cols" border="1" id="Div7" style="width:100%;border-collapse:collapse; text-align:center">
 
<asp:GridView ID="grdstaff" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" ShowFooter="true" 
         PagerStyle-CssClass="pgr"> 
          <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" Font-Bold ="true" />                              
      <Columns>
    <asp:BoundField DataField ="Receiver_Name" HeaderText ="Name"/>
                                 <asp:BoundField DataField ="Purpose" HeaderText ="Purpose"/>
                               
                                <asp:BoundField DataField ="amount" HeaderText ="Total Amt"/>
                              <asp:BoundField DataField ="collected_amount" HeaderText ="Given Amt"/>
                              <asp:BoundField DataField ="due_amount" HeaderText ="Dues Amt"/>
                                 <asp:BoundField DataField ="mode_of_payment" HeaderText ="Pay Mode"/>
                                 <asp:BoundField DataField ="Expence_date" HeaderText =" Expence Date"/>    
                               
      </Columns>
      <PagerStyle CssClass="pgr" />
               
      </asp:GridView>
        		           
</div>
</div>

<br />

<div style="border:1px solid #8C8C8C; width:19.6%; margin:10px 10px 0px 10px;text-align:center; background-color:#E7E6E6">
<p style="margin-top:5px; margin-bottom:5px"><label style=" font-family:Arial;font-weight:bold; color:Maroon ; font-size:15px;margin-top:10px"> Office Expense </label></p>
</div>

<div style="padding:0px 10px 10px 10px">
<div class="mGrid1"  cellspacing="0" rules="cols" border="1" id="Div5" style="width:100%;border-collapse:collapse; text-align:center">

<asp:GridView ID="grdofficeex" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" ShowFooter="true"         
         PagerStyle-CssClass="pgr"> 
            <FooterStyle BackColor="#CCCC99" HorizontalAlign="left" Font-Bold ="true" />                    
      <Columns>
                                     <asp:BoundField DataField ="Receiver_Name" HeaderText ="Name"/>
                                   <asp:BoundField DataField ="Purpose" HeaderText ="Purpose"/>
                               
                                   <asp:BoundField DataField ="amount" HeaderText ="Total Amt"/>
                                 <asp:BoundField DataField ="collected_amount" HeaderText ="Given Amt"/>
                              <asp:BoundField DataField ="due_amount" HeaderText ="Dues Amt"/>
                                 <asp:BoundField DataField ="mode_of_payment" HeaderText ="Pay Mode"/>
                                 <asp:BoundField DataField ="Expence_date" HeaderText =" Expence Date"/>    
                                 
      </Columns>
      <PagerStyle CssClass="pgr" />
               
      </asp:GridView> 
        		           
</div>
</div>

</div>
</div>

 </form>
</body>
</html>



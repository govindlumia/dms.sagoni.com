<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Customer_Entry.aspx.cs" Inherits="Customer_Customer_Entry" Culture="en-GB" UICulture="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
  <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css" />

<div class="rightside">
                 <div class="detailedViewHeader">
  <p  class="lvtHeaderText">Add Employee Details</p>
  </div>

                <div class="content">
                    
                 <div>

                 <center>
<div class="dvtContentSpace" style="padding:5px 5px 5px 5px;width:100%">
<table width="100%" cellpadding="0" cellspacing="0" class="big">
  
 <tr>
 <td colspan="4" style="background-color:#DDDCDD; height:30px; padding-left:10px; font-size:13px; border:1px solid #dedede">
 Company Details
 </td>
 </tr>

 
 <tr>
   <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> Company Name:</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:DropDownList ID="ddcompany" CssClass="dropdown" runat="server">
       </asp:DropDownList>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="0" 
           ErrorMessage="Please Select Company" ControlToValidate="ddcompany" 
           SetFocusOnError="True"></asp:RequiredFieldValidator>   
         </td>
   <td valign="middle" style="display:none" class="dvtCellLabel col-sm-2 control-label ">
       Associate Company Name <br />(Enter Company Name if Associate Company Not Exist):
    </td>
   <td valign="middle" style="display:none" class="cellInfo1 ">
      
       <asp:TextBox ID="Txt_associatecompany" CssClass="textbox" runat="server"></asp:TextBox>
       <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_associatecompany" ErrorMessage="Please Enter Associate Company Name"></asp:RequiredFieldValidator>--%>
      </td>
   </tr>
 
    <tr>
 <td colspan="4" style="background-color:#DDDCDD; height:30px; padding-left:10px; font-size:13px; border:1px solid #dedede">
Employee Details  <asp:Label ID="lblduplicacy" runat="server" Text="" style=" color:Red"
         ></asp:Label> 
 </td>
 </tr>
 <tr>
  
    <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Authorised Person :</td>   
   <td valign="middle" class="cellInfo1 "> 
     <asp:TextBox ID="Txt_Authorised" runat="server" CssClass="textbox"></asp:TextBox>
         
        </td>
 <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 
Contact No:
</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_Contact" CssClass="textbox" runat="server"></asp:TextBox>
         </td>

   </tr>
    <tr>
  
    <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Mobile :</td>   
   <td valign="middle" class="cellInfo1 "> 
     <asp:TextBox ID="Txt_Mobile" runat="server" MaxLength="10" CssClass="textbox"></asp:TextBox>
         
        </td>
 <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 
Other Contact :
</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_othercontact" CssClass="textbox" runat="server"></asp:TextBox>
         </td>

   </tr>
   <tr>
  
    <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Email :</td>   
   <td valign="middle" class="cellInfo1 "> 
     <asp:TextBox ID="Txt_Email" runat="server"  CssClass="textbox"></asp:TextBox>
         
        </td>
 <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 
Address :
</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_Address" TextMode="MultiLine" Height="50px" CssClass="textbox" runat="server"></asp:TextBox>
         </td>

   </tr>
   <tr style="display:none">
  
    <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Business Type :</td>   
   <td valign="middle" class="cellInfo1 "> 
     <asp:TextBox ID="Txt_Businesstype" runat="server"  CssClass="textbox" Height="50px"
           TextMode="MultiLine"></asp:TextBox>
          
        </td>
 <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 
Services :
</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_services" CssClass="textbox" runat="server" Height="50px"
           TextMode="MultiLine"></asp:TextBox>

     
         </td>

   </tr>
   
   <tr style="display:none">
  
    <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">PAN :</td>   
   <td valign="middle" class="cellInfo1 "> 
     <asp:TextBox ID="Txt_pan" runat="server"  CssClass="textbox"></asp:TextBox>
         
        </td>
 <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 
TAN :
</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_tan" CssClass="textbox" runat="server"></asp:TextBox>
         </td>

   </tr>
    <tr style="display:none">
  
    <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">CIN No :</td>   
   <td valign="middle" class="cellInfo1 "> 
     <asp:TextBox ID="Txt_Cin" runat="server"  CssClass="textbox"></asp:TextBox>
         
        </td>
 <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 
Date Of Incorporation/Birth :
</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_Birth" CssClass="textbox" runat="server"></asp:TextBox>
            <ajaxtoolkit:calendarextender ID="calendarextender4" runat="server" Format="dd/MM/yyyy" PopupButtonID="Txt_Birth" TargetControlID="Txt_Birth" />                                 

         </td>

   </tr>
   <tr>
   <td valign="middle" style="display:none" class="dvtCellLabel col-sm-2 control-label "> 
Service Tax Regd.No :
</td>
   <td valign="middle" style="display:none" class="cellInfo1 ">
       <asp:TextBox ID="Txt_Reg" CssClass="textbox" runat="server"></asp:TextBox>
         </td>
    <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Remarks :</td>   
   <td valign="middle" class="cellInfo1 "> 
     <asp:TextBox ID="Txt_remarks" TextMode="MultiLine" Height="50px" runat="server"  CssClass="textbox"></asp:TextBox>
         
        </td>
        </tr>
        <tr style="display:none">
 <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 
Other Details :
</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_otherdetails" TextMode="MultiLine" Height="50px" CssClass="textbox" runat="server"></asp:TextBox>
         </td>
<td valign="middle" class="dvtCellLabel col-sm-2 control-label "> 

</td>
<td valign="middle" class="cellInfo1 "></td>
   </tr>
    <tr>
 <td colspan="4" style="background-color:#DDDCDD; height:30px; padding-left:496px; font-size:13px; border:1px solid #dedede">
     <asp:Button ID="Btn_Submit" runat="server" Text="Submit" 
         onclick="Btn_Submit_Click" />
         <asp:Button ID="Btn_reset" runat="server" Text="Reset" style="margin-left:10px"/>
 </td>
 </tr>
   </table>
     
   
   
</div>

</center> 
   </div>    
   </div>
   </div>
</asp:Content>


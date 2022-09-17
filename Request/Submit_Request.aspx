<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="Submit_Request.aspx.cs" Inherits="Request_Submit_Request" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css" />

<div class="rightside">
                 <div class="detailedViewHeader">
  <p  class="lvtHeaderText">Submit Request</p>
  </div>

                <div class="content">
                    
                 <div>

                 <center>
<div class="dvtContentSpace" style="padding:5px 5px 5px 5px;width:100%">
<table width="100%" cellpadding="0" cellspacing="0" class="big">

 <tr>
   <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> Subject :</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_subject" runat="server"  Height="30px"  Width="500PX" CssClass="textbox"></asp:TextBox>
           
         </td>
  
   </tr>
 
  <tr>
  <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
      Description
      </td>
   <td valign="middle" class="cellInfo1 ">    
      <asp:TextBox ID="Txt_discription" runat="server" TextMode="MultiLine" Height="100px"  Width="500PX" CssClass="textbox"></asp:TextBox>  
      </td>
   </tr>
	<asp:Panel ID="pnlreq" runat="server" Visible="false">
   <tr>
  <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
      Status
      </td>
   <td valign="left" class="cellInfo1 ">    
      <asp:DropDownList ID="ddstatus" CssClass="dropdown" runat="server">
       <asp:ListItem>Re-Open</asp:ListItem> 
       </asp:DropDownList>  
      </td>
   </tr>
   </asp:Panel>
      <tr>
    <td valign="middle" class="cellInfo1 " colspan="2" align="center">
       <asp:Button ID="Btn_Submit" runat="server" Text="Send Request" 
        onclick="Btn_Submit_Click" ForeColor="#FF3300" Font-Bold="True" />
         <asp:Button ID="Button1" runat="server" Text="Cancel" style="margin-left:10px" 
            onclick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
         </td>
   </tr>

   </table>
</div>

</center> 
   </div>    
   </div>
   </div>
</asp:Content>


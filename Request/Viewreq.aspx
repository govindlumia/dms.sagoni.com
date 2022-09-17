<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Viewreq.aspx.cs" Inherits="Request_Viewreq" Culture="en-GB" UICulture="en-GB"%>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxtoolkit" %>
<%@ Register TagPrefix="Ajaxified" Assembly="Ajaxified" Namespace="Ajaxified" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css" />

<div class="rightside">
                <div class="detailedViewHeader">
  <p class="lvtHeaderText">View Request Details </p>
  </div>

             
                    
              

 <center>
 
 
 <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   <tr>
   <td valign="middle" class="dvtCellLabel col-sm-2 control-label "> From :</td>
   <td valign="middle" class="cellInfo1 ">
       <asp:TextBox ID="Txt_From" runat="server" CssClass="textbox"></asp:TextBox>
<ajaxtoolkit:calendarextender ID="calendarextender4" runat="server" Format="dd/MM/yyyy" PopupButtonID="Txt_From" TargetControlID="Txt_From" />                                 
       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Txt_From" ErrorMessage="Enter From Date"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="cmv_fromdate" ControlToValidate="Txt_From" Operator="DataTypeCheck"
                            Type="Date" ErrorMessage="Enter Valid Date" Display="Dynamic" runat="server"
                            SetFocusOnError="true"></asp:CompareValidator>  </td>
   <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
      To :</td>
   <td valign="middle" class="cellInfo1 ">       <asp:TextBox ID="Txt_to" runat="server"  CssClass="textbox"></asp:TextBox>  
   <ajaxtoolkit:calendarextender ID="calendarextender1" runat="server" Format="dd/MM/yyyy" PopupButtonID="Txt_to" TargetControlID="Txt_to" /> 
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Txt_to" ErrorMessage="Enter To Date"></asp:RequiredFieldValidator>
<asp:CompareValidator ID="cmv_todate2" ControlToValidate="Txt_to" ControlToCompare="Txt_From"
                            Type="Date" Operator="GreaterThanEqual" Display="Dynamic" ErrorMessage="This Date cannot be less than from date"
                            runat="server" SetFocusOnError="true"></asp:CompareValidator>
      </td>
   </tr>
   </table>
     <asp:Button ID="Button1" runat="server" Text="View" onclick="Button1_Click" />
   <table width="100%" cellpadding="0" cellspacing="0" class="big" >
    <tr>
 <td valign="middle" class="dvtCellLabeltop">
 <div class="mGrid1"    id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px"">


                        <asp:GridView ID="GridView1" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                         AllowPaging ="false" Width="100%"

                                EmptyDataText ="No lead found for the criteria you selected." 
                            
                           
                             CssClass="mGrid"
            PagerStyle-CssClass="pgr" onrowcommand="GridView1_RowCommand"
                           > 
                                
                         <Columns >
                          <asp:TemplateField  HeaderText ="Open Request" >
                                                <ItemTemplate>
            <asp:ImageButton ID="imgInvoice" ImageUrl ="~/images/edit.png" runat="server" CommandName ="Edit" ToolTip ="Click to Open" CausesValidation ="false"   /> 
                                                     
                                                </ItemTemplate>

                         </asp:TemplateField>
                       
                      
                           <asp:TemplateField HeaderText="sno" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("sno") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:BoundField DataField ="subject" HeaderText ="Subject"/>
                                 <asp:BoundField DataField ="desription" HeaderText ="Description"/> 
                                   <asp:BoundField DataField ="Authorised_person" HeaderText ="Sent By"/>
                               <asp:BoundField DataField ="status" HeaderText ="Status"/>
                                       <asp:BoundField DataField ="created_on" HeaderText ="Date"/> 
																								   <asp:TemplateField HeaderText="Delete" >
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ImageDelete" runat="server" ImageUrl="~/images/Delete.png" OnClientClick="return confirm('Are you sure you want to delete this event?');" CommandName="Delete" ToolTip ="Click to Delete" CausesValidation ="false" Height="25px" Width="25px"  />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>  
																								 
                         </Columns>
                            


                         </asp:GridView>
        		           
			           </div>

 </td>
  
 </tr>

  </table>   


</asp:Content>


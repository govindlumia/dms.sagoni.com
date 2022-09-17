<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="View_request.aspx.cs" Inherits="Request_View_request" %>

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
 <td valign="middle" class="dvtCellLabeltop">
 <div class="mGrid1"    id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px"">


                        <asp:GridView ID="GridView1" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                         AllowPaging ="false" Width="100%"

                                EmptyDataText ="No lead found for the criteria you selected." 
                            
                           
                             CssClass="mGrid"
            PagerStyle-CssClass="pgr" onrowcommand="GridView1_RowCommand1" 
                           > 
                                
                         <Columns >
                          <asp:TemplateField  HeaderText ="Re-Open" >
                                                <ItemTemplate>
            <asp:ImageButton ID="imgInvoice" ImageUrl ="~/images/edit.png" runat="server" CommandName ="reopen" ToolTip ="Click to Edit" CausesValidation ="false"   /> 
                                                     
                                                </ItemTemplate>

                         </asp:TemplateField>
                       
                      
                           <asp:TemplateField HeaderText="sno" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("sno") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:BoundField DataField ="subject" HeaderText ="Subject"/>
                                 <asp:BoundField DataField ="desription" HeaderText ="Description"/> 
                                    <asp:BoundField DataField ="STATUS" HeaderText ="Status"/> 
                                       <asp:BoundField DataField ="created_on" HeaderText ="Date"/> 
                         </Columns>
                            


                         </asp:GridView>
        		           
			           </div>

 </td>
  
 </tr>

  </table>   


</asp:Content>


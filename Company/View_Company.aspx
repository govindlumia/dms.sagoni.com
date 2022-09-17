<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View_Company.aspx.cs" Inherits="Company_View_Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css" />

     <div class="detailedViewHeader">
  <p  class="lvtHeaderText">View Company </p>
  </div>
<div class="dvtContentSpace" style="padding:0px 10px 10px 0px;width:99.7% ">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
<tr>
   <td colspan="4" style="padding-top:20px">
  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
   <tr>
 <td valign="middle" class="dvtCellLabeltop">
 
 <div class="mGrid1"  Width="100%" id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px; text-align:center">
                         <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                         AllowPaging ="false" Width="100%" 

                                EmptyDataText ="No Data found for the criteria you selected." 
                            
                           
                             CssClass="mGrid1"
            PagerStyle-CssClass="pgr" onrowcommand="grdLead_RowCommand"> 
                                  <Columns >
                 <asp:TemplateField  HeaderText ="Edit" >
                                                <ItemTemplate>
            <asp:ImageButton ID="imgInvoice" ImageUrl ="../images/edit.png" runat="server" CommandName ="Edit" ToolTip ="Click to Edit" CausesValidation ="false"   /> 
                                                     
                                                </ItemTemplate>

  </asp:TemplateField>
                <asp:TemplateField HeaderText="order_id" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("sno") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField ="sno" HeaderText ="Sno"/>
                                       <asp:BoundField DataField ="CompanyId" HeaderText ="Company Id"/>
                              <asp:BoundField DataField ="company_name" HeaderText ="Company Name"/>
                              <asp:BoundField DataField ="created_by" HeaderText ="Created By"/>
                             <asp:BoundField DataField ="created_on" HeaderText ="Date" />
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
   </td>
   </tr>

   </table>
</div>
</asp:Content>


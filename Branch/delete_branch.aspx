<%@ Page Title="::Sagoni India Private Limited::" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="delete_branch.aspx.cs" Inherits="delete_branch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>

<div class="detailedViewHeader">
  <p class="lvtHeaderText">Deactivate Branch Details</p>
  </div>

    <center>
<div class="dvtContentSpace" style="padding:10px 10px 10px 0px;width:99.7%;">
<table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
   <tr>
 <td valign="middle" class="dvtCellLabeltop">BRANCH NAME : </td>
   <td valign="middle" class="cellInfo" style="width:350px">
   <asp:DropDownList ID="Ddlbranchname" runat="server" Width="220px" BorderWidth="1px" BorderStyle="Solid" BorderColor="#dddddd" CssClass="dropdown"></asp:DropDownList>
   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" SetFocusOnError="true" InitialValue="0"
                            ControlToValidate="Ddlbranchname" Display="Dynamic" ErrorMessage="Please Select a Branch Name"></asp:RequiredFieldValidator>
    
   </td>
   <td valign="middle" class="dvtCellLabeltop"> </td>
   <td valign="middle" class="cellInfo" style="width:350px;">
   <%--<asp:DropDownList ID="Ddlbranchname" runat="server" Width="250px" BorderWidth="1px" BorderStyle="Solid" BorderColor="#dddddd" style=" border-width:1px;height:26px;padding: 2px 2px 2px 5px; color:black; font-size:12px; border-radius:5px">
    
    </asp:DropDownList>--%> </td>
   </tr>

    

   <tr>
   <td valign="middle"  colspan="4" style=" text-align:center; background-color:#DDDCDD; height:55px; padding-top:10px">
   <asp:ImageButton ID="submit" runat="server" ImageUrl="~/images/delete.png" 
           onclick="submit_Click"/>
   &nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/reset.png" 
           onclick="reset_Click"/>

   </td>
   </tr>


   <tr>
   <td colspan="4" style="padding-top:20px">
  <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
   <tr>
 <td valign="middle" class="dvtCellLabeltop">
 <%--<div class="mGrid1"  Width="100%" id="gridCustomers" style="width:100%;border-collapse:collapse; padding-top:0px; text-align:center">
        <asp:GridView ID="grdLead" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
                  AllowPaging ="false" Width="100%" EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" PagerStyle-CssClass="pgr" onrowcommand="grdLead_RowCommand"> 
                                
                         <Columns >
                         <asp:TemplateField  HeaderText ="Action">
                             
                                                <ItemTemplate>
               <asp:ImageButton ID="imgEdit" ImageUrl ="~/images/quotation-icon.jpg" runat="server" CommandName ="Delete" ToolTip ="Click to Delete" CausesValidation ="false"   /> 
                                                     
                                                   
                                                </ItemTemplate>
                          </asp:TemplateField>
                          
                      
                           <asp:TemplateField HeaderText="emp_id" Visible= "false">
                                    <ItemTemplate>
                                     <asp:Label ID="lblemp_id" runat="server" Text ='<%#Eval("emp_id") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>
                          <asp:BoundField DataField ="emp_code" HeaderText ="Branch Code"/>
                          <asp:BoundField DataField ="Branch_Name" HeaderText ="Branch Name"/>
                          <asp:BoundField DataField ="emp_name" HeaderText ="Authorised Name"/>
                          <asp:BoundField DataField ="password" HeaderText ="Password"/>
                          <asp:BoundField DataField ="mobile_no" HeaderText ="Mobile No"/>
                          <asp:BoundField DataField ="address" HeaderText ="Address"/>
                          <asp:BoundField DataField ="active" HeaderText ="Status"/>
                 
                           <asp:BoundField DataField ="created_on" HeaderText ="Created Date" />
                                                       
                         </Columns>
                            


                         </asp:GridView>
        		           
			           </div>--%>
 </td>
  
   </tr>

    

</table>
   </td>
   </tr>

</table>
</div>

<br />


</center>

</asp:Content>


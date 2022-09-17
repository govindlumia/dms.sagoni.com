<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search_value.aspx.cs" Inherits="search_value" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
     <script type="text/javascript" src="../Jscript/mtmv.js"></script>
     <link href ="../css/doplus_style.css" rel="stylesheet" type="text/css"/>
     <div class="detailedViewHeader">
  <p class="lvtHeaderText">Search Result</p>
  </div>

<div class="dvtContentSpace" style="padding:5px 5px 5px 5px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">
 
 
 <tr style="background-color:#E7E6E6">
 <td  valign="top"  style="width: 100%; padding-bottom:10px; padding-top:10px; text-align:left; border-left:1px solid #8C8C8C;; border-top:1px solid #8C8C8C;; border-right:1px solid #8C8C8C; "  >
   <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:17px;padding-left:20px">Client Details</label>
        </td>
             
 </tr>

 <tr>
 <td colspan="4">
 <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
 <tr>
 <td valign="middle" class="dvtCell" >
 
 <div class="mGrid"  cellspacing="0" rules="cols" border="1" id="Div4" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdenquery" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" 
         PagerStyle-CssClass="pgr"> 
                                
            <Columns >
                <asp:TemplateField HeaderText="sno" Visible= "false">
                                    <ItemTemplate>

                                     <asp:Label ID="lblserial" runat="server" Text ='<%#Eval("sno") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField> 
                          <asp:TemplateField HeaderText="Client ID">
                                    <ItemTemplate>
                                       <asp:LinkButton ID="lblLeadNo" Text ='<%#Eval("Customer_Id") %>' runat="server" 
                                            CommandName ="lblLeadNo_Click" ToolTip ="Click to see Client Detail" 
                                            ForeColor ="Black" onclick="lblLeadNo_Click"  
                                            />
                                    </ItemTemplate>
                                </asp:TemplateField>
                          <%--     <asp:BoundField DataField ="Customer_Id" HeaderText ="Client ID"/>--%>
                                 <asp:BoundField DataField ="company_name" HeaderText ="Comp Name"/>
                                 <asp:BoundField DataField ="Associate_company" HeaderText ="Asstd Comp"/>
                                  <asp:BoundField DataField ="Authorised_person" HeaderText ="Auth Person"/>  
                                   <asp:BoundField DataField ="mobile" HeaderText ="Mobile"/>     
                                   <asp:BoundField DataField ="email" HeaderText ="Email"/>
                                       <asp:BoundField DataField ="created_on" HeaderText ="Date"/> 
                  </Columns>
                 <PagerStyle CssClass="pgr" />
               
                 </asp:GridView>
        		           
			      </div>

 </td>
  
 </tr>

 </table>
 </td>
 </tr>

 </table>


   </div>
<div class="dvtContentSpace" style="padding:10px 10px 10px 10px">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="big">
 
 
 <tr style="background-color:#E7E6E6">
 <td  valign="top"  style="width: 100%; padding-bottom:10px; padding-top:10px; text-align:left; border-left:1px solid #8C8C8C;; border-top:1px solid #8C8C8C;; border-right:1px solid #8C8C8C; "  >
   <label style=" font-family:Arial; font-style:normal; font-weight:bold; color:Black ; font-size:17px;padding-left:20px">Document Details</label>
        </td>
             
 </tr>

 <tr>
 <td colspan="4">
 <table width="100%" cellpadding="0" cellspacing="0" class="big" >
   
 <tr>
 <td valign="middle" class="dvtCell" >
 
 <div class="mGrid"  cellspacing="0" rules="cols" border="1" id="Div1" style="width:100%;border-collapse:collapse; text-align:center">
 <asp:GridView ID="grdquotation" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  
 AllowPaging ="false" Width="100%"  EmptyDataText ="No Data found for the criteria you selected." CssClass="mGrid1" 
         PagerStyle-CssClass="pgr"> 
                                
            <Columns >
              <asp:TemplateField HeaderText="sno" Visible= "false">
                                    <ItemTemplate>

                                     <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("sno") %>' />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField> 
                              
                          <asp:BoundField DataField ="Customer_Id" HeaderText ="Client ID"/>
                         <%-- <asp:BoundField DataField ="sno" HeaderText ="Serial No"/>--%>
                                 <%-- <asp:BoundField DataField ="Customer_Id" HeaderText ="Customer ID"/>--%>
                                 <asp:BoundField DataField ="company_name" HeaderText ="Comp Name"/>
                                  <asp:BoundField DataField ="Associate_company" HeaderText ="Associate Comp"/>
                                   <asp:BoundField DataField ="document_type" HeaderText ="Document Type"/>
                                 <asp:BoundField DataField ="financial_year" HeaderText ="Fin Yr"/>
                                  <asp:BoundField DataField ="fileupload" HeaderText ="File Name"/>  
                                   <asp:BoundField DataField ="created_on" HeaderText ="Upload Date"/> 
                  </Columns>
                 <PagerStyle CssClass="pgr" />
               
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


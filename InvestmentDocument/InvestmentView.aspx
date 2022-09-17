<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="InvestmentView.aspx.cs" Inherits="InvestmentDocument_InvestmentView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href="../css/doplus_style.css" rel="stylesheet" type="text/css" />
    <div class="rightside">
        <div class="detailedViewHeader">
            <p class="lvtHeaderText">View Your Files  </p>
        </div>
        <div class="dvtContentSpace" style="padding:10px 10px 10px 5px;width:98.5%; margin-left:8px;margin-top:30px;margin-top:-40">
    <table width="100%" cellpadding="0" cellspacing="0" class="big">
        <tr>
            <td colspan="4" style="background-color:#DDDCDD; height:30px; padding-left:10px; font-size:13px; border:1px solid #dedede">
                Files
            </td>
         </tr>
        <tr>
            <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Financial Year :</td>
            <td valign="middle" class="cellInfo1 "> 
               <asp:DropDownList ID="ddfinancial" runat="server" CssClass="textbox" Height="30px" Width="249px"></asp:DropDownList>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true"
                                ControlToValidate="ddfinancial" Display="Dynamic" ErrorMessage="Select Financial Year">
               </asp:RequiredFieldValidator>
            </td>
            <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Document Type :</td>
            <td valign="middle" class="cellInfo1 "> 
                <asp:DropDownList ID="dd_document" runat="server" CssClass="textbox" Height="30px" Width="249px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true"
                                ControlToValidate="dd_document" Display="Dynamic" ErrorMessage="Select Document Type">
                </asp:RequiredFieldValidator>
            </td>
        </tr>
      
    </table>
</div>

        <asp:Button ID="Submit_Btn"  runat="server" Text="View"
        CssClass="btn btn-info" style="margin-top:7px;margin-bottom:-10" onclick="Submit_Btn_Click" />
        <asp:Label ID="Label1" runat="server" Text="" ></asp:Label>
    </div> 
 
        <table width="100%" cellpadding="0" cellspacing="0" class="big" >
            <tr>
                <td valign="middle" class="dvtCellLabeltop">
                    <div class="mGrid1" id="Div1" style="width:100%;border-collapse:collapse; padding-top:0px"">
                          <asp:GridView ID="GridView1" runat ="server" AutoGenerateColumns ="False"   GridLines ="None"  AllowPaging ="false" Width="100%" DataKeyNames="sno" EmptyDataText ="No Record found for the criteria you selected." CssClass="mGrid" PagerStyle-CssClass="pgr" OnRowCommand="GridView1_RowCommand"> 
                               <Columns >
                                   <asp:TemplateField HeaderText="sno" Visible= "false">
                                          <ItemTemplate>
                                           <asp:Label ID="lblserialno" runat="server" Text ='<%#Eval("sno") %>' />                                      
                                          </ItemTemplate>
                                      </asp:TemplateField>
                                       <asp:BoundField DataField ="CREATEDBY" HeaderText ="Employee Id"/>
                                        <asp:BoundField DataField ="DocumentType" HeaderText ="Document Type"/>                               
                                       <asp:BoundField DataField ="FinancialYear" HeaderText ="Financial Year"/>
                                       <asp:BoundField DataField ="FileUpload" HeaderText ="File"/>
                                        <asp:BoundField DataField ="filepath" HeaderText ="Path"/>  
                                         <asp:BoundField DataField ="CREATEDDATE" HeaderText ="Upload Date"/> 
                                        <asp:TemplateField HeaderText="File Download">
                                      <ItemTemplate>
                                          <asp:Image ID="img" ImageUrl="~/images/1.png" runat="server" Height="25px" Width="25px" />
                                          <asp:Image ID="Image1" ImageUrl="~/images/download.png" runat="server" Height="25px" Width="25px" style="margin-left:22px" /><br />
                                          
                                          <asp:HyperLink ID="HyperLink1" runat="server" Text="View" Target="_blank" NavigateUrl='<%# Eval("filepath") %>' />
                                          <asp:LinkButton ID="lnkDownload" Text="Download" CommandArgument='<%# Eval("filepath") %>' runat="server" OnClick="FilesDownload" Style="margin-left: 10px"></asp:LinkButton>
                                      </ItemTemplate>
                                  </asp:TemplateField>   
                                    <asp:TemplateField HeaderText="Delete" >
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ImageDelete" runat="server" OnClientClick="return confirm('Are you sure you want to delete this event?');" ImageUrl="~/images/Delete.png" CommandName="Delete" ToolTip ="Click to Delete" CausesValidation ="false" Height="25px" Width="25px"  />
                                      
                                    </ItemTemplate>
                                </asp:TemplateField>   
                               </Columns>
                           </asp:GridView>
                    </div>
                </td>
            </tr>
        </table>   

</asp:Content>


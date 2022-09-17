<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add_com_document.aspx.cs" Inherits="Company_Add_com_document" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href="../css/doplus_style.css" rel="stylesheet" type="text/css" />

    <div class="rightside">
        <div class="detailedViewHeader">
            <p class="lvtHeaderText">Add Dropdown Value</p>
        </div>

        <div class="content">

            <div>

                <center>
                    <div class="dvtContentSpace" style="padding: 5px 5px 5px 5px; width: 100%">
                        <table width="100%" cellpadding="0" cellspacing="0" class="big">
                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">Company 
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Company Name:</td>
                               <%-- <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="CompanyId" runat="server" Placeholder="Company ID" CssClass="textbox"></asp:TextBox>
                                </td>--%>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_Company_Name" runat="server" Placeholder="Company Name" CssClass="textbox"></asp:TextBox>
                                </td>

                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="Btn_Comp" runat="server" Text="Add" CssClass="btn btn-info" OnClick="Btn_Comp_Click" />
                                </td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:Label ID="lbl_comperror" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">Document Type 
                                </td>
                            </tr>
                            <tr>

                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Document Type :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_document" runat="server" Placeholder="Document Type" CssClass="textbox"></asp:TextBox>

                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="Btn_document" runat="server" Text="Add" CssClass="btn btn-info"
                                        OnClick="Btn_document_Click" />
                                </td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:Label ID="lbl_document_error" runat="server" Text=""></asp:Label>
                                </td>
                                <td valign="middle" class="cellInfo1 "></td>
                            </tr>
                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">Financial Year
                                </td>
                            </tr>
                            <tr>

                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Financial Year :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_financial" runat="server" Placeholder="2014-2015" CssClass="textbox"></asp:TextBox>

                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="Btn_Financial" runat="server" Text="Add"
                                        CssClass="btn btn-info" OnClick="Btn_Financial_Click" />
                                </td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:Label ID="lblfinancial" runat="server" Text=""></asp:Label>
                                </td>
                                <td valign="middle" class="cellInfo1 "></td>

                            </tr>






                        </table>



                    </div>

                </center>
            </div>
        </div>
    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Document_upload.aspx.cs" Inherits="Document_Document_upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href="../css/doplus_style.css" rel="stylesheet" type="text/css" />

    <div class="rightside">
        <div class="detailedViewHeader">
            <p class="lvtHeaderText">Add Document Details</p>
        </div>

        <div class="content">

            <div>

                <center>
                    <div class="dvtContentSpace" style="padding: 5px 5px 5px 5px; width: 100%">
                        <table width="100%" cellpadding="0" cellspacing="0" class="big">

                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">Add Document
                                </td>
                            </tr>


                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Client ID:</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:DropDownList ID="ddclient" CssClass="dropdown" runat="server"
                                        OnSelectedIndexChanged="ddclient_SelectedIndexChanged" AutoPostBack="true">
                                    </asp:DropDownList>

                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label "></td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:Label ID="lbl_error" runat="server" Text="" Style="color: Red"></asp:Label>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">Customer Details
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Company Name :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_Company" runat="server" CssClass="textbox"></asp:TextBox>

                                </td>
                                <td style="display: none" valign="middle" class="dvtCellLabel col-sm-2 control-label ">Associate Company :</td>
                                <td style="display: none" valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_Associate" runat="server" CssClass="textbox"></asp:TextBox>

                                </td>


                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Authorised Person :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_Authorised" runat="server" CssClass="textbox"></asp:TextBox>

                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Mobile :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_Mobile" runat="server" MaxLength="10" CssClass="textbox"></asp:TextBox>

                                </td>


                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Email :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_Email" runat="server" CssClass="textbox"></asp:TextBox>

                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Address :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:TextBox ID="Txt_Address" TextMode="MultiLine" Height="30px" runat="server" CssClass="textbox"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">Add Document
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Document Type :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:DropDownList ID="dd_document" CssClass="dropdown" runat="server">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="0"
                                        ErrorMessage="Please Select Document" ControlToValidate="dd_document"
                                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Financial Year :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:DropDownList ID="ddfinancial" CssClass="dropdown" runat="server">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" InitialValue="0"
                                        ErrorMessage="Please Select Financial Yr" ControlToValidate="ddfinancial"
                                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Browse File  (UPTO 5MB):</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:FileUpload ID="fupload" runat="server" />
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="Btn_Add" runat="server" Text="Attach" OnClick="Btn_Add_Click" /></td>
                                <td valign="middle" class="cellInfo1 ">

                                    <asp:Label ID="Lblfileerror" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>

                        </table>
                    </div>

                </center>
            </div>
        </div>
    </div>
</asp:Content>


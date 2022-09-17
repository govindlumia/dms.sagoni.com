<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ExcelImport.aspx.cs" Inherits="ExcelImport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href="../css/doplus_style.css" rel="stylesheet" type="text/css" />

    <div class="rightside">
        <div class="detailedViewHeader">
            <p class="lvtHeaderText">Excel Import </p>
        </div>

        <div class="content">

            <div>

                <center>
                    <div class="dvtContentSpace" style="padding: 10px 10px 10px 5px; width: 94.3%; margin-left: 32px; margin-top: 30px; margin-top: -40">
                        <table width="100%" cellpadding="0" cellspacing="0" class="big">

                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">Employee Login Details
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px; border: 1px solid #dedede">
                                    <asp:Label ID="lblMsg" runat="server" CssClass="message"></asp:Label>
                                </td>
                            </tr>
                             <%--Import ClientDetails--%>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Select File Location For Employee Detail:</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:FileUpload ID="FileUploadClientDetail" runat="server" CssClass="text_box" Width="150px" /></td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="ButtonClientDetail" runat="server" Text="Submit"
                                        CssClass="btn btn-info" Style="margin-top: 7px; margin-bottom: -10" OnClick="SubmitClientDetail_Btn_Click" />
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <a href="http://rrgapayroll.sagoni.com/DownloadExcel/ClientDetailsImport.xls">Download Excel</a>
                                </td>
                                <td valign="middle" class="cellInfo1 "></td>
                            </tr>
                            <%--Import Clientlogin--%>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Select File Location For Employee Login:</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:FileUpload ID="fuExcel" runat="server" CssClass="text_box" Width="150px" /></td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="Submit_Btn" runat="server" Text="Submit"
                                        CssClass="btn btn-info" Style="margin-top: 7px; margin-bottom: -10" OnClick="Submit_Btn_Click" />
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <a href="http://rrgapayroll.sagoni.com/DownloadExcel/UserLoginImport.xls">Download Excel</a>
                                </td>
                                <td valign="middle" class="cellInfo1 "></td>
                            </tr>

                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Select File Location For Document Master:</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="text_box" Width="150px" /></td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="Button1" runat="server" Text="Submit"
                                        CssClass="btn btn-info" Style="margin-top: 7px; margin-bottom: -10" OnClick="Button1_Click" />
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <a href="http://rrgapayroll.sagoni.com/DownloadExcel/DocumentMasterImport.xls">Download Excel</a>
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

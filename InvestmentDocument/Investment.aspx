<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMaster.master" AutoEventWireup="true" CodeFile="Investment.aspx.cs" Inherits="InvestmentDocument_Investment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href="../css/doplus_style.css" rel="stylesheet" type="text/css" />

    <div class="rightside">
        <div class="detailedViewHeader">
            <p class="lvtHeaderText">Submit Document</p>
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
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Document Type :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:DropDownList ID="DropDownList1" CssClass="dropdown" runat="server"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="0"
                                        ErrorMessage="Please Select Document" ControlToValidate="DropDownList1"
                                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Financial Year :</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:DropDownList ID="DropDownList2" CssClass="dropdown" runat="server"></asp:DropDownList>

                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" InitialValue="0"
                                        ErrorMessage="Please Select Financial Yr" ControlToValidate="DropDownList2"
                                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Browse File  (UPTO 5MB):</td>
                                <td valign="middle" class="cellInfo1 ">
                                    <asp:FileUpload ID="fupload" runat="server" />
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Label ID="Lblfileerror" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Remark</td>
                                <td valign="middle" class="cellInfo1 " colspan="2">
                                    <asp:TextBox ID="txtRemark" runat="server" Width="100%" class="textbox" Style="padding: 2px 2px 2px 0px" />
                                </td>
                                <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">
                                    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
                                </td>
                            </tr>

                        </table>

                    </div>


                </center>
            </div>
        </div>
    </div>

    <script>
        $("#Button1").on("submit", function (event) {
            var $this = $(this);
            var frmValues = $this.serialize();
            $.ajax({
                type: $this.attr('method'),
                url: $this.attr('action'),
                data: frmValues
            })
                .done(function () {
                    $("#para").text("Serialized! Input String is " + frmValues);
                })
                .fail(function () {
                    $("#para").text("An error occured");
                });
            event.preventDefault();
        });
    </script>
</asp:Content>


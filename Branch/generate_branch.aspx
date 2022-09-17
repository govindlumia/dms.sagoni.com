<%@ Page Title="::Rajesh Raj Gupta & Associates::" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="generate_branch.aspx.cs" Inherits="generate_branch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href="../css/doplus_style.css" rel="stylesheet" type="text/css" />

    <div class="detailedViewHeader">
        <p class="lvtHeaderText">Create User Login </p>
    </div>

    <center>
        <div class="dvtContentSpace" style="padding: 10px 10px 10px 0px; width: 99.7%;">
            <table width="100%" cellpadding="0" cellspacing="0" class="big">

                <tr>
                    <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px">User Details 
    <asp:Label ID="lblmsg" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td valign="middle" class="dvtCellLabeltop">Name :</td>
                    <td valign="middle" class="cellInfo">
                        <asp:TextBox ID="Txtbranchname" runat="server" CssClass="textbox" onBlur="camelcase(this.value, this.id)"></asp:TextBox>
                        <asp:DropDownList ID="ddcompany" runat="server" CssClass="dropdown"></asp:DropDownList>
                    </td>
                    <td valign="middle" class="dvtCellLabeltop">Address </td>
                    <td valign="middle" class="cellInfo">
                        <asp:TextBox ID="txtadd" runat="server" CssClass="textbox" onBlur="camelcase(this.value, this.id)"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td valign="middle" class="dvtCellLabel">Authorized Person :</td>
                    <td valign="middle" class="cellInfo1">
                        <asp:TextBox ID="Txtauthperson" runat="server" CssClass="textbox" onBlur="camelcase(this.value, this.id)"></asp:TextBox></td>

                    <td valign="middle" class="dvtCellLabel">Mobile No. :</td>
                    <td valign="middle" class="cellInfo1">
                        <asp:TextBox ID="Txtauthmob" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txtauthmob"
                            ErrorMessage="Please enter a 10 digit number(without std. code)" ValidationExpression="^[0-9]{10}"></asp:RegularExpressionValidator>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="Txtauthmob" Display="Dynamic" ErrorMessage="Enter value"></asp:RequiredFieldValidator>

                    </td>
                </tr>


                <tr>
                    <td valign="middle" class="dvtCellLabel">User Name :</td>
                    <td valign="middle" class="cellInfo1">
                        <asp:TextBox ID="txtBranchuser" runat="server" CssClass="textbox"></asp:TextBox></td>

                    <td valign="middle" class="dvtCellLabel">Password :</td>
                    <td valign="middle" class="cellInfo1">
                        <asp:TextBox ID="Txtpasscode" runat="server" CssClass="textbox"></asp:TextBox></td>
                </tr>
                <tr>
                    <td valign="middle" class="dvtCellLabel">Role :</td>
                    <td valign="middle" class="cellInfo1">
                        <asp:DropDownList ID="ddrole" runat="server" CssClass="dropdown" AutoPostBack="true" OnSelectedIndexChanged="ddrole_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                     <td valign="middle" class="dvtCellLabel">Status :</td>
                    <td valign="middle" class="cellInfo1">
                        <asp:DropDownList ID="ddstatus" runat="server" CssClass="dropdown">
                        </asp:DropDownList></td>

                </tr>
              
            </table>

            <table width="100%" cellpadding="0" cellspacing="0" class="big">


                <tr>
                    <td valign="middle" colspan="4" style="padding-bottom: 0px; text-align: center; background-color: #DDDCDD; height: 55px">
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/submitbutton.png" OnClick="submit_Click" />&nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/reset.png" OnClick="reset_Click" />
                    </td>
                </tr>

            </table>
        </div>
    </center>
</asp:Content>


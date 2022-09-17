<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Client_insert.aspx.cs" Inherits="ClientLogin_Client_insert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <link rel="stylesheet" type="text/css" href="../css/menu_style.css" />
    <script type="text/javascript" src="../Jscript/mtmv.js"></script>
    <link href="../css/doplus_style.css" rel="stylesheet" type="text/css" />

    <div class="detailedViewHeader">
        <p class="lvtHeaderText">Create Employee Login </p>
    </div>

    <center>
        <div class="dvtContentSpace" style="padding: 10px 10px 10px 0px; width: 99.7%;">
            <table width="100%" cellpadding="0" cellspacing="0" class="big">

                <tr>
                    <td colspan="4" style="background-color: #DDDCDD; height: 30px; padding-left: 10px; font-size: 13px">Employee Details 
    <asp:Label ID="lblmsg" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

                <%--<tr>
    <td valign="middle" class="dvtCellLabeltop">Associated Company Name :</td>
    <td valign="middle" class="cellInfo">
        <asp:DropDownList ID="ddclientid" CssClass="dropdown" runat="server" 
            AutoPostBack="True" onselectedindexchanged="ddclientid_SelectedIndexChanged" >
        </asp:DropDownList>
    </td>
   <td valign="middle" class="dvtCellLabel"> Company Name :</td>
    <td valign="middle" class="cellInfo1">
          <asp:Label ID="ddcompany" runat="server"></asp:Label>            
    </td>
  
   </tr>--%>
                <asp:UpdatePanel ID="upd" runat="server">
                    <ContentTemplate>

                        <tr>
                            <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Company Name :</td>
                            <td valign="middle" class="cellInfo1 ">
                                <asp:DropDownList ID="ddcompany" runat="server" CssClass="textbox" Height="30px" Width="249px" OnSelectedIndexChanged="ddcompany_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfv_fromdate" runat="server" SetFocusOnError="true"
                                    ControlToValidate="ddcompany" Display="Dynamic" ErrorMessage="Select Company"></asp:RequiredFieldValidator>
                            </td>
                            <td valign="middle" class="dvtCellLabel col-sm-2 control-label ">Employee Name :</td>
                            <td valign="middle" class="cellInfo1 ">
                                <asp:DropDownList ID="dd_Associate" runat="server" CssClass="textbox" Height="30px" Width="249px">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfv_todate" runat="server" ControlToValidate="dd_Associate"
                                    Display="Dynamic" ErrorMessage="Select Associate Company " SetFocusOnError="true"></asp:RequiredFieldValidator>
                            </td>

                        </tr>

                        <tr>
                            <td valign="middle" class="dvtCellLabeltop">User Name : </td>
                            <td valign="middle" class="cellInfo">
                                <asp:TextBox ID="Txt_username" runat="server" CssClass="textbox"></asp:TextBox>
                            </td>
                            <td valign="middle" class="dvtCellLabel">Password :</td>
                            <td valign="middle" class="cellInfo1">
                                <asp:TextBox ID="Txt_pass" runat="server" CssClass="textbox"></asp:TextBox></td>


                        </tr>
                        <tr>
                            <td valign="middle" class="dvtCellLabeltop">Login Status  : </td>
                            <td valign="middle" class="cellInfo">
                                <asp:DropDownList ID="ddstatus" CssClass="dropdown" runat="server">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="0" ControlToValidate="ddstatus" ErrorMessage="Please Select Status"></asp:RequiredFieldValidator>
                            </td>
                            <td valign="middle" class="dvtCellLabel"></td>
                            <td valign="middle" class="cellInfo1"></td>


                        </tr>
                    </ContentTemplate>
                </asp:UpdatePanel>


            </table>

            <table width="100%" cellpadding="0" cellspacing="0" class="big">


                <tr>
                    <td valign="middle" colspan="4" style="padding-bottom: 0px; text-align: center; background-color: #DDDCDD; height: 55px">
                        <asp:ImageButton ID="ImageButton1" runat="server"
                            ImageUrl="~/images/submitbutton.png" OnClick="ImageButton1_Click" />&nbsp;&nbsp;
   <asp:ImageButton ID="reset" runat="server" ImageUrl="~/images/reset.png"
       OnClick="reset_Click" />
                    </td>
                </tr>



            </table>




        </div>
    </center>
</asp:Content>


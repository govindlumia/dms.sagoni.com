<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="changePassword.aspx.cs" Inherits="changePassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <link rel="stylesheet" type="text/css" href="css/style.css">
  <div class="dvtContentSpace">
 <table width ="100%" >
 <tr>
           <td class="dvtTabCache"  colspan=2>
               <span class="lvtHeaderText"> Change Password</span>
          </td>         
        </tr>
        <tr>
          <td align =right >
              Current Password:
          </td>
           <td>
              <asp:TextBox ID="txtCuurentPass" runat =server TextMode =Password ></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvOldPass" runat =server ErrorMessage ="Enter current password" Display =Dynamic ControlToValidate ="txtCuurentPass"></asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td align =right >
              New Password:
          </td>
           <td>
              <asp:TextBox ID="txtNewPass" runat =server TextMode =Password  ></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvNewPass" runat =server ErrorMessage ="Enter new password" Display =Dynamic ControlToValidate ="txtNewPass"></asp:RequiredFieldValidator>
          </td>
        </tr>
        <tr>
          <td align =right >
              Confirm Password:
          </td>
           <td>
              <asp:TextBox ID="txtConfPass" runat =server TextMode =Password ></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat =server ErrorMessage ="Enter confirm password" Display =Dynamic ControlToValidate ="txtConfPass"></asp:RequiredFieldValidator>
               <asp:CompareValidator ID="cmpConfPass" runat =server ErrorMessage ="Password does'nt match" ControlToCompare ="txtNewPass" ControlToValidate ="txtConfPass" Display =Dynamic ></asp:CompareValidator>
          </td>
        </tr>
        <tr>
          <td align =center colspan =2 >
              <asp:Button ID="btnSubmitt" runat =server Text ="Submit" 
                  onclick="btnSubmitt_Click" />
              <asp:Label ID="lblMsg" runat =server ForeColor =Red Visible =false ></asp:Label>
          </td>
           
        </tr>
    </table>
    </div>
</asp:Content>


﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AspRevisionPhase2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <div style="font-family:Arial">
      <form id="form1" runat="server">
<table style="border: 1px solid black">
    <tr>
        <td colspan="2">
            <b>Login</b>
        </td>
    </tr>
    <tr>
        <td>
            User Name
        </td>    
        <td>
            :<asp:TextBox ID="txtUserName" runat="server">
            </asp:TextBox>
        </td>    
    </tr>
    <tr>
        <td>
            Password
        </td>    
        <td>
            :<asp:TextBox ID="txtPassword" TextMode="Password" runat="server">
            </asp:TextBox>
        </td>    
    </tr>
    <tr>
        <td>
                    
            <asp:CheckBox ID="chkBoxRememberMe" runat="server" Text="Remember Me" />
                    
        </td>    
        <td>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </td>    
    </tr>
     <tr>
        <td>
                    
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
                    
        </td> 
         </tr>   
</table>
<br />
<a href="Registration/Register.aspx">Click here to register</a> 
if you do not have a user name and password.
          </form>
</div>
</body>
</html>

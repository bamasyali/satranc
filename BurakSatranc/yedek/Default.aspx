﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BurakSatranc.Giris" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 454px">
    
        <asp:Login ID="Login1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" 
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#333333" onauthenticate="Login1_Authenticate1">
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                ForeColor="White" />
        </asp:Login>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Kullancı ADı- Şifre"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="67px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Width="69px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
            Text="Kullanıcı EKle" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="BurakSatranc.Giris" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 454px">
    
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="YENİ OYUN OLUŞTURMAK İÇİN TIKLAYIN" />
        <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="242px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Oyuna 
        Baslayin</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="BurakSatranc.Anasayfa" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Salon-tr Alpha 0.7 Deneme Sayfası</title>
<style type="text/css">
<!--
body,td,th {
	font-family: Georgia, Times New Roman, Times, serif;
	color: #FFFFFF;
}
#apDiv1 {
	position:absolute;
	left:173px;
	top:301px;
	width:236px;
	height:151px;
	z-index:1;
	background-color: #666666;
}
#apDiv2 {
	position:absolute;
	left:270px;
	top:174px;
	width:695px;
	height:114px;
	z-index:2;
}
#apDiv3 {
	position:absolute;
	left:171px;
	top:309px;
	width:239px;
	height:103px;
	z-index:3;
	background-color: #666666;
}
-->
</style>

<style type="text/css">
<!--
#apDiv4 {
	position:absolute;
	left:15px;
	top:180px;
	width:143px;
	height:276px;
	z-index:3;
}
-->
</style>

<style type="text/css">
<!--
body {
	background-color: #333333;
	margin-left: auto;
	margin-right: auto;
	background-image: url(../Resimler/arkaplan2.jpg);
}
#apDiv5 {
	position:absolute;
	left:270px;
	top:300px;
	width:230px;
	height:35px;
	z-index:3;
}
#apDiv6 {
	position:absolute;
	left:270px;
	top:345px;
	width:230px;
	height:35px;
	z-index:4;
}
#apDiv7 {
	position:absolute;
	left:105px;
	top:195px;
	width:145px;
	height:40px;
	z-index:3;
}
#apDiv8 {
	position:absolute;
	left:100px;
	top:255px;
	width:145px;
	height:40px;
	z-index:4;
}
#apDiv9 {
	position:absolute;
	left:100px;
	top:300px;
	width:145px;
	height:40px;
	z-index:5;
}
#apDiv10 {
	position:absolute;
	left:262px;
	top:175px;
	width:697px;
	height:252px;
	z-index:6;
}
#apDiv11 {
	position:absolute;
	left:102px;
	top:30px;
	width:1014px;
	height:1050px;
	z-index:1;
}
#apDiv12 {
	position:absolute;
	left:95px;
	top:25px;
	width:152px;
	height:146px;
	z-index:2;
}
#apDiv13 {
	position:absolute;
	left:252px;
	top:50px;
	width:494px;
	height:144px;
	z-index:3;
}
#apDiv14 {
	position:absolute;
	left:253px;
	top:25px;
	width:713px;
	height:146px;
	z-index:3;
}
#apDiv15 {
	position:absolute;
	left:971px;
	top:25px;
	width:151px;
	height:146px;
	z-index:4;
}
#apDiv16 {
	position:absolute;
	left:253px;
	top:176px;
	width:713px;
	height:789px;
	z-index:5;
	background-color: #999999;
	clip: rect(1,auto,auto,1);
	overflow: visible;
}
#apDiv17 {
	position:absolute;
	left:95px;
	top:176px;
	width:153px;
	height:789px;
	z-index:6;
	background-color: #666666;
	clip: rect(1,auto,auto,auto);
}
#apDiv18 {
	position:absolute;
	left:971px;
	top:176px;
	width:153px;
	height:789px;
	z-index:7;
	background-color: #666666;
	clip: rect(1,auto,auto,1);
}
#apDiv19 {
	position:absolute;
	left:159px;
	top:970px;
	width:899px;
	height:90px;
	z-index:8;
	background-color: #330000;
	clip: rect(1,auto,auto,auto);
}
.style8 {color: #660000}
#apDiv20 {
	position:absolute;
	left:120px;
	top:210px;
	width:100px;
	height:35px;
	z-index:9;
}
#apDiv21 {
	position:absolute;
	left:120px;
	top:260px;
	width:100px;
	height:35px;
	z-index:10;
}
.style9 {
	color: #FFFFFF;
	font-size: 10px;
}
.style12 {font-size: 24px; }
#apDiv22 {
	position:absolute;
	left:120px;
	top:310px;
	width:100px;
	height:35px;
	z-index:11;
}
#apDiv23 {
	position:absolute;
	left:120px;
	top:360px;
	width:100px;
	height:35px;
	z-index:12;
}
#ortala{
	width:1050px;
	text-align:center;
	left:43%;
	margin-left:-525px;
	position:absolute;
}
#apDiv24 {
	position:absolute;
	left:255px;
	top:274px;
	width:320px;
	height:224px;
	z-index:13;
}
#apDiv25 {
	position:absolute;
	left:581px;
	top:271px;
	width:344px;
	height:227px;
	z-index:14;
}

-->
</style>
</head>

<body>
<div id="apDiv24">
  <div align="center">Sizin Devam Maçlarınız <br />
    <span class="style8"> OYUNID - BeyazOyuncu - Siyah Oyuncu</span></div>
</div>
<div id="apDiv25">
  <p align="center"><span class="style8"><br />
    </span>Bütün Maçlar<br />
    <br />
    <br />
  </p>
  <div align="center"> <span class="style8">OYUNID - BeyazOyuncu - Siyah Oyuncu<br />
        <asp:Panel ID="EskiMaclar" runat="server" Height="200px" scrollbars="Vertical" 
            BackColor="#CCCCCC" Width="234px">
          <%EskiMaclariYaz(); %>
        </asp:Panel>
    <asp:Panel ID="ButunMaclar" runat="server" Height="200px" scrollbars="Vertical" 
            BackColor="#CCCCCC" Width="230px">
          <%ButunMaclariYaz(); %>
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
        </asp:Panel>
  </span></div>
</div>
<div id="ortala">
<div id="apDiv11"></div>
<div id="apDiv12">
  <div align="center"><img src="Resimler/logoat.jpg" width="152" height="146" 
        border="1" /></div>
</div>
<div id="apDiv14">
  <div align="center"><img src="Resimler/logo.jpg" width="713" height="146" 
        border="1" /></div>
</div>
<div id="apDiv15">
  <div align="center"><img src="Resimler/logoat1.jpg" width="151" height="146" 
          border="1" /></div>
</div>
<div id="apDiv16">
<form id="Form1" runat="server">
  <p align="center"><a href="MasaOlustur.aspx">Yeni Masa Oluşturmak İçin</a><br>
        <a href="OyunBul.aspx">Masa Bulmak İçin</a><br>
        <br>
        <span class="style8"><br>
        </span>
      </center>
    <p align="left" class="style12">&nbsp;</p>
</form>
<span class="style8"></span></div>
<div id="apDiv17">
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center"><br />
  </p>
  <p align="center"><span class="style8"><br />
  </span></p>
  <p><span class="style8">
    <asp:Panel ID="Panel1" runat="server" Height="100px" scrollbars="Vertical" 
            BackColor="#CCCCCC" Width="610px">
      <%DevamEdenMaclariYaz(); %>
    </asp:Panel>
  </span> <br />
  </p>
  <p align="center">&nbsp;</p>
</div>
<div id="apDiv18">
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">&nbsp;</p>
  <p align="center">asdasd</p>
</div>
<div id="apDiv19"> 
  <p align="center" class="style9">Salon-Tr Geliştirme Takımı:<a href="http://www.burakamasyali.com">Burak Amasyalı</a>-<a href="http://www.erenbasar.com">Eren Başar</a></p>
  <p align="center" class="style9">Copyright Â© 2008</p>
</div>

<div id="apDiv20"><a href="/Default.aspx"><img src="Resimler/anamenu.jpg" width="100" height="35" /></a></div>
<div id='apDiv21'><a href='/Anasayfa.aspx'><img src='Resimler/oyunsayfasi.jpg' width='100' height='35' border='1' /></a></div>
<div id='apDiv22'><a href='GuvenliCikis.aspx'><img src='Resimler/guvenlicikis.jpg'   width='100' height='35' border='1'/></a></div>
<div id='apDiv23'><a href='ProfilDuzenle.aspx'><img src='Resimler/Profilim.jpg'   width='100' height='35' border='1'/></a></div>

</body>
</html>

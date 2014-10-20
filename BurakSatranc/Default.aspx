<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BurakSatranc.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Anasayfa <%Response.Write("| "+Session["KullaniciAdi"]); %></title>
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
	margin-left: 100px;
	margin-right: 100px;
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
#apDiv22 {
	position:absolute;
	left:120px;
	top:310px;
	width:100px;
	height:35px;
	z-index:11;
}
.style9 {
	color: #FFFFFF;
	font-size: 10px;
}
#ortala{
	width:1050px;
	text-align:center;
	left:43%;
	margin-left:-525px;
	position:absolute;
}


-->
</style></head>

<body>
<div id="ortala">
    <form id="form1" runat="server">
<div id="apDiv11"></div>
<div id="apDiv12"><img src="Resimler/logoat.jpg" width="152" height="146" 
        border="0" /></div>
<div id="apDiv14"><a href="/default.aspx"><img src="Resimler/logo.jpg" width="713" height="146" 
        border="0" /></a></div>
<div id="apDiv15">
  <div align="right"><img src="Resimler/logoat1.jpg" width="151" height="146" 
          border="0" /></div>
</div>
<div id="apDiv16">
  <div align="center" class="style8">
  
    <div align="left"><center><h3>Yazışmalı Satranç Sitesi<br />
        beta sayfası<br />
        <br />
        <br />
        Oyuncu İstatistikleri</h3>
        <p>İstatistiklerde Sadece Oyun Bitirmiş Oyuncular Listelenir</p>
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" Height="566px" 
            ScrollBars="Both" Width="659px">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </asp:Panel>
        </center>
      </div>
  </div>
</div>
<div id="apDiv17">
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
</div>
<div id="apDiv18">
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>&nbsp;</p>
  <p>asdasd</p>
</div>
<div id="apDiv19"> 
  <p align="center" class="style9">Salon-Tr geliştirme takımı:<a href="http://www.burakamasyali.com">Burak Amasyalı</a>-<a href="http://www.erenbasar.com">Eren Başar</a></p>
  <p align="center" class="style9">Copyright © 2008</p>
</div>
<% 
    if (Session["KullaniciAdi"] == null)
    {
        Response.Write("<div id='apDiv20'><a href='/KullaniciGirisi.aspx'><img src='Resimler/uyegirisi.jpg' width='100' height='35' border='1' /></a></div>");
        Response.Write("<div id='apDiv21'><a href='YeniUye.aspx'><img src='Resimler/yenikullanici.jpg'   width='100' height='35' border='1'/></a></div>");
        
    }
    else
    {
        Response.Write("<div id='apDiv20'><a href='/Anasayfa.aspx'><img src='Resimler/oyunsayfasi.jpg' width='100' height='35' border='1' /></a></div>");
        Response.Write("<div id='apDiv21'><a href='GuvenliCikis.aspx'><img src='Resimler/guvenlicikis.jpg'   width='100' height='35' border='1'/></a></div>");
        Response.Write("<div id='apDiv22'><a href='ProfilDuzenle.aspx'><img src='Resimler/Profilim.jpg'   width='100' height='35' border='1'/></a></div>");

    }
      %>
    </form>
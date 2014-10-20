<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Yazismali.aspx.cs" Inherits="BurakSatranc.Yazismali" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Oyuna Hoşgeldiniz.</title>
    <style type="text/css">

        .style13
        {
            height: 40px;
        }
        .style2
        {
            width: 41px;
            height: 40px;
        }
        .style14
        {
            width: 37px;
            height: 40px;
        }
        .style4
        {
            width: 35px;
            height: 40px;
        }
        .style15
        {
            height: 40px;
            width: 99px;
        }
        .style12
        {
            width: 32%;
            height: 365px;
        }
        .style10
        {
            width: 22px;
        }
        .style16
        {
            height: 17px;
        }
        #form1
        {
            height: 544px;
            width: 440px;
            margin-left: 31px;
        }
        .style17
        {
            width: 108px;
        }
        .style19
        {
            width: 263px;
        }
        .style21
        {
            width: 108px;
            height: 23px;
        }
        .style22
        {
            width: 478px;
            height: 23px;
        }
        .style23
        {
            width: 263px;
            height: 23px;
        }
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Oyun Sayfası <%Response.Write("| "+Session["KullaniciAdi"]); %></title>
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
.style9 {
	color: #FFFFFF;
	font-size: 10px;
}
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
    .style24
    {
        width: 478px;
    }
-->
</style></head>

<body>
<div id="ortala">
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
    <div align="left">
<head>
</head>
        <body>
<form id="form1" runat="server">
    <table style="width: 156%;">
        <tr>
            <td class="style17">
                Oynayanlar<br />
                <% 
                    Oynayanlar();
                     %>
            </td>
            <td class="style24">
    
    
                sorun&nbsp;
    <asp:TextBox ID="Sorun" runat="server" Width="333px"></asp:TextBox>
    <br />
                Durum<asp:TextBox ID="Durum" runat="server" Width="337px"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="49px"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" Width="51px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Oynat" />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="YEnile" />
        <br />
        <table class="style12" style="margin-left: 0px; cursor: pointer;">
            <tr>
                <td class="style10" rowspan="9">
                    <asp:Image ID="Image65" runat="server" Height="350px" ImageAlign="Top" 
                        ImageUrl="~/Resimler/pc4.gif" Width="23px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton2" runat="server" BackColor="#663300" 
                        Height="40px" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton4" runat="server" BackColor="#663300" 
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton6" runat="server" BackColor="#663300" 
                        Height="40px" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton8" runat="server" BackColor="#663300" 
                        Height="40px" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton9" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton11" runat="server" BackColor="#663300" 
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton12" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton13" runat="server" BackColor="#663300" 
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton14" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton15" runat="server" BackColor="#663300" 
                        Height="40px" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton16" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton17" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton18" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton19" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton20" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton21" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton22" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton23" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton24" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton25" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton26" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton27" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton28" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton29" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton30" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton31" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton32" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton33" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton34" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton35" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton36" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton37" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton38" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton39" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton40" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton41" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton42" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton43" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton44" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton45" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton46" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton47" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton48" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton49" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton50" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton51" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton52" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton53" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton54" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton55" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton56" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton57" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton58" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton59" runat="server" BackColor="#663300"  
                        Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton60" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton61" runat="server" BackColor="#663300"  
                        BorderColor="#663300"  Height="40px" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton62" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton63" runat="server" BackColor="#663300"  
                        BorderColor="#663300"  Height="40px" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton64" runat="server" Height="40px" Width="40px" 
                        BackColor="#CC9900" />
                </td>
            </tr>
            <tr>
                <td class="style16" colspan="8">
                    <asp:Image ID="Image66" runat="server" Height="20px" 
                        ImageUrl="~/Resimler/pc7.gif" Width="345px" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
            </td>
            <td class="style19">
            
                Önceki Hamleler.<br />
                <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCCC" Height="441px" 
                    ScrollBars="Both"><center>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView></center>
                </asp:Panel>
                
            </td>
        </tr>
        <tr>
            <td class="style21">
                </td>
            <td class="style22">
            <center>
                Son Hamle Tarihi :
                <asp:Label ID="SonHamleTarihi" runat="server" Text="Label"></asp:Label></center>
            </td>
            <td class="style23"><center>
                Hamle Limiti :
                <asp:Label ID="HamleLimiti" runat="server" Text="Label"></asp:Label></center>
            </td>
        </tr>
        <tr>
            <td class="style17">
                &nbsp;</td>
            <td class="style24"><center>
                Oyun Başlangıç Tarihi :
                <asp:Label ID="BaslamaTarihi" runat="server" Text="Label"></asp:Label></center>
            </td>
            <td class="style19"><center>
                Oyun Max Süresi :
                <asp:Label ID="OyunSuresi" runat="server" Text="Label"></asp:Label></center>
            </td>
        </tr>
    </table>
    </form>
</body>
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
  <p>asdasd/p&gt;
</div>
<div id="apDiv19"> 
  <p align="center" class="style9">Salon-Tr geliştirme takımı:<a href="http://www.burakamasyali.com">Burak 
      Amasyalı</a>-<a href="http://www.erenbasar.com">Eren Başar</a></p>
  <p align="center" class="style9">Copyright © 2008</p>
</div>
<div id="apDiv20"><a href="/Default.aspx"><img src="Resimler/anamenu.jpg" width="100" height="35" /></a></div>

        <div id='apDiv21'><a href='/Anasayfa.aspx'><img src='Resimler/oyunsayfasi.jpg' width='100' height='35' border='1' /></a></div>
       <div id='apDiv22'><a href='GuvenliCikis.aspx'><img src='Resimler/guvenlicikis.jpg'   width='100' height='35' border='1'/></a></div>
       <div id='apDiv23'><a href='ProfilDuzenle.aspx'><img src='Resimler/Profilim.jpg'   width='100' height='35' border='1'/></a></div>

   
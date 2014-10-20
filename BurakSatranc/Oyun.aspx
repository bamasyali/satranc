<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Oyun.aspx.cs" Inherits="BurakSatranc.Oyun" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">"
    <title>Oyuna Hoşgeldiniz <%Response.Write("| "+Session["KullaniciAdi"]); %></title>
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
        .style20
        {
            width: 457px;
        }
    </style>
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
            <td class="style20">
    
    
    <div>
    <h3> Hoşgeldin <%Response.Write(Session["KullaniciAdi"]); %> </h3>
    </div>
        sorun&nbsp;
    <asp:TextBox ID="Sorun" runat="server" Width="338px"></asp:TextBox>
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
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" 
                        onclick="ImageButton1_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton2" runat="server" BackColor="#663300" 
                        Height="40px" onclick="ImageButton2_Click" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="40px" 
                        onclick="ImageButton3_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton4" runat="server" BackColor="#663300" 
                        Height="40px" onclick="ImageButton4_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="40px" 
                        onclick="ImageButton5_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton6" runat="server" BackColor="#663300" 
                        Height="40px" onclick="ImageButton6_Click" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="40px" 
                        onclick="ImageButton7_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton8" runat="server" BackColor="#663300" 
                        Height="40px" onclick="ImageButton8_Click" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton9" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton9_Click" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="40px" 
                        onclick="ImageButton10_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton11" runat="server" BackColor="#663300" 
                        Height="40px" onclick="ImageButton11_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton12" runat="server" Height="40px" 
                        onclick="ImageButton12_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton13" runat="server" BackColor="#663300" 
                        Height="40px" onclick="ImageButton13_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton14" runat="server" Height="40px" 
                        onclick="ImageButton14_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton15" runat="server" BackColor="#663300" 
                        Height="40px" onclick="ImageButton15_Click" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton16" runat="server" Height="40px" 
                        onclick="ImageButton16_Click" Width="40px" BackColor="#CC9900" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton17" runat="server" Height="40px" 
                        onclick="ImageButton17_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton18" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton18_Click" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton19" runat="server" Height="40px" 
                        onclick="ImageButton19_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton20" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton20_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton21" runat="server" Height="40px" 
                        onclick="ImageButton21_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton22" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton22_Click" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton23" runat="server" Height="40px" 
                        onclick="ImageButton23_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton24" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton24_Click" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton25" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton25_Click" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton26" runat="server" Height="40px" 
                        onclick="ImageButton26_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton27" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton27_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton28" runat="server" Height="40px" 
                        onclick="ImageButton28_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton29" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton29_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton30" runat="server" Height="40px" 
                        onclick="ImageButton30_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton31" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton31_Click" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton32" runat="server" Height="40px" 
                        onclick="ImageButton32_Click" Width="40px" BackColor="#CC9900" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton33" runat="server" Height="40px" 
                        onclick="ImageButton33_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton34" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton34_Click" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton35" runat="server" Height="40px" 
                        onclick="ImageButton35_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton36" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton36_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton37" runat="server" Height="40px" 
                        onclick="ImageButton37_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton38" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton38_Click" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton39" runat="server" Height="40px" 
                        onclick="ImageButton39_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton40" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton40_Click" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton41" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton41_Click" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton42" runat="server" Height="40px" 
                        onclick="ImageButton42_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton43" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton43_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton44" runat="server" Height="40px" 
                        onclick="ImageButton44_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton45" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton45_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton46" runat="server" Height="40px" 
                        onclick="ImageButton46_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton47" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton47_Click" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton48" runat="server" Height="40px" 
                        onclick="ImageButton48_Click" Width="40px" BackColor="#CC9900" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton49" runat="server" Height="40px" 
                        onclick="ImageButton49_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton50" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton50_Click" Width="40px" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton51" runat="server" Height="40px" 
                        onclick="ImageButton51_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton52" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton52_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton53" runat="server" Height="40px" 
                        onclick="ImageButton53_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton54" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton54_Click" Width="40px" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton55" runat="server" Height="40px" 
                        onclick="ImageButton55_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton56" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton56_Click" Width="40px" />
                </td>
            </tr>
            <tr>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton57" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton57_Click" Width="40px" />
                </td>
                <td class="style2">
                    <asp:ImageButton ID="ImageButton58" runat="server" Height="40px" 
                        onclick="ImageButton58_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style13">
                    <asp:ImageButton ID="ImageButton59" runat="server" BackColor="#663300"  
                        Height="40px" onclick="ImageButton59_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton60" runat="server" Height="40px" 
                        onclick="ImageButton60_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton61" runat="server" BackColor="#663300"  
                        BorderColor="#663300"  Height="40px" onclick="ImageButton61_Click" Width="40px" />
                </td>
                <td class="style14">
                    <asp:ImageButton ID="ImageButton62" runat="server" Height="40px" 
                        onclick="ImageButton62_Click" Width="40px" BackColor="#CC9900" />
                </td>
                <td class="style4">
                    <asp:ImageButton ID="ImageButton63" runat="server" BackColor="#663300"  
                        BorderColor="#663300"  Height="40px" onclick="ImageButton63_Click" Width="40px" />
                </td>
                <td class="style15">
                    <asp:ImageButton ID="ImageButton64" runat="server" Height="40px" 
                        onclick="ImageButton64_Click" Width="40px" BackColor="#CC9900" />
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
        <asp:Label ID="iletisim" runat="server" 
            Text="İletişim - bamasyali@hotmail.com.tr"></asp:Label>
    
            </td>
            <td class="style19">
            
                Önceki Hamleler.<br />
                <asp:GridView ID="GridView1" runat="server">
                
                </asp:GridView>
                
            </td>
        </tr>
        <tr>
            <td class="style17">
                &nbsp;</td>
            <td class="style20">
                &nbsp;</td>
            <td class="style19">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style17">
                &nbsp;</td>
            <td class="style20">
                &nbsp;</td>
            <td class="style19">
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>

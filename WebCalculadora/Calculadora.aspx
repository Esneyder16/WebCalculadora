<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WebCalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            background-color:lightgoldenrodyellow;
        }
        .Centrar{
            text-align:center
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            height: 31px;
            width: 175px;
        }
        .auto-style4 {
            width: 175px;
            height: 33px;
        }
        .auto-style5 {
            margin-bottom: 0px;
        }
        .auto-style6 {
            width: 175px;
            height: 457px;
        }
        .auto-style7 {
            height: 457px;
        }
        .auto-style8 {
            width: 175px;
            height: 37px;
        }
        .auto-style9 {
            height: 37px;
        }
        .auto-style10 {
            height: 33px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Centrar">
            <h1 class="auto-style"> Calculadora WEB</h1>
        </div>
   
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Valor 1:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Tvalor1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Valor 2:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="Tvalor2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Resaultado:</td>
                <td class="auto-style9">
                    <asp:Label ID="Lresultado" ForeColor="#FF3300" Font-size="Large" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="48px" ImageUrl="~/Imagenes/descarga.png" OnClick="ImageButton1_Click" Width="56px" />
                    <asp:Button ID="Bcalcular" runat="server" CssClass="auto-style5" Height="68px" Text="CALCULAR" Width="165px" Font-Size="Large" ForeColor="#FF3300" />
                  <br />
                    <br />
                    <asp:RadioButton ID="Rsuma" Text="Suma" runat="server" GroupName="operador" />
                    <br />
                    <asp:RadioButton ID="Rresta" Text="resta" runat="server" GroupName="operador" />
                    <br />
                    <asp:RadioButton ID="Rmultiplicacion" Text="Multiplicacion" runat="server" GroupName="operador" />
                    <br />
                    <asp:RadioButton ID="Rdivision" Text="Division" runat="server" GroupName="operador" />
                    <br />
                    ---------------------<br />
                    <asp:CheckBox ID="Csuma" Text="Suma" runat="server" />
                    <br />
                    <asp:CheckBox ID="Cresta" Text="Resta" runat="server" />
                    <br />
                    ---------------------<br />
                    <br />
                    <asp:DropDownList ID="Doperacion" runat="server" Height="45px" Width="151px">
                        <asp:ListItem>Suma</asp:ListItem>
                        <asp:ListItem>Resta</asp:ListItem>
                        <asp:ListItem>Multiplicacion</asp:ListItem>
                        <asp:ListItem>Division</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <br />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Braiz" runat="server" Text="√x" Height="46px" Width="46px" OnClick="Braiz_Click" />
                    
                    <asp:Button ID="Bc" runat="server" Text="c" OnClick="Bc_Click" Height="46px" Width="46px" />
                    <asp:Button ID="Bquitar" runat="server" Text="⌫" Width="46px" Height="46px" OnClick="Bquitar_Click" />
                    <asp:Button ID="Bn" runat="server" Text="n!" Height="46px" Width="46px" OnClick="Bn_Click" />
                    <asp:Button ID="Bdividir" runat="server" Text="÷" Height="46px" Width="46px" OnClick="Bdividir_Click" />
                    <br />
                    <asp:Button ID="Belevarcualquiera" runat="server" Text="x^" Height="46px" Width="46px" OnClick="Belevarcualquiera_Click" />
                    <asp:Button ID="B7" runat="server" Text="7" Height="46px" Width="46px" OnClick="B7_Click" />
                    <asp:Button ID="B8" runat="server" Text="8" Height="46px" Width="46px" OnClick="B8_Click" />
                    <asp:Button ID="B9" runat="server" Text="9" Height="46px" Width="46px" OnClick="B9_Click" />
                    <asp:Button ID="Bmultiplicacion" runat="server" Text="x" Height="46px" Width="46px" OnClick="Bmultiplicacion_Click" />
                    <br />
                    
                    <asp:Button ID="Bdieselevado" runat="server" Text="10^" Height="46px" Width="46px" OnClick="Bdieselevado_Click" />
                    <asp:Button ID="B4" runat="server" Text="4" OnClick="B4_Click" Height="46px" Width="46px" />
                    <asp:Button ID="B5" runat="server" Text="5" Height="46px" Width="46px" OnClick="B5_Click" />
                    <asp:Button ID="B6" runat="server" Text="6" Height="46px" Width="46px" OnClick="B6_Click" />
                    <asp:Button ID="Bresta" runat="server" Text="-" Height="46px" Width="46px" OnClick="Bresta_Click" />
                    <br />
                    <asp:Button ID="Blogaritmo" runat="server" Text="log" Height="46px" Width="46px" OnClick="Blogaritmo_Click" />
                    
                    <asp:Button ID="B1" runat="server" Text="1" OnClick="B1_Click" Height="46px" Width="46px" />
                    <asp:Button ID="B2" runat="server" Text="2" OnClick="B2_Click" Height="46px" Width="46px" />
                    <asp:Button ID="B3" runat="server" Text="3" OnClick="B3_Click" Height="46px" Width="46px" />
                    <asp:Button ID="Bsuma" runat="server" Text="+" OnClick="Bsuma_Click" Height="46px" Width="46px" />
                    <br />
                    <asp:Button ID="Belevardos" runat="server" Text="x²" Height="46px" Width="46px" OnClick="Belevardos_Click" />
                    <asp:Button ID="Bsumaresta" runat="server" Text="+/- " Height="46px" Width="46px" OnClick="Bsumaresta_Click" />
                    <asp:Button ID="B0" runat="server" Text="0" Height="46px" Width="46px" OnClick="B0_Click" />
                    <asp:Button ID="Bcoma" runat="server" Text="," Height="46px" Width="46px" OnClick="Bcoma_Click" />
                    <asp:Button ID="Bigual" runat="server" Text="=" OnClick="Bigual_Click" Height="46px" Width="46px" BackColor="#00CCFF" ForeColor="Black" />
                    
                    <br />
                    
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

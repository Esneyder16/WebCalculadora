<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="WebCalculadora.Articulos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Articulos</title>
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
   </style>
</head>
<body>
    <form id="form1" runat="server">
            <div class="Centrar">
<h1 class="auto-style">ARTICULOS</h1>
   </div>
  <section>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/descarga.png" Width="110px" OnClick="ImageButton1_Click" />
    <br />
    <br />
    <br />
</section>
    </form>
</body>
</html>

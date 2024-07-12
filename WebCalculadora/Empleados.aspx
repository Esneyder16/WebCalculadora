<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="WebCalculadora.Empleado1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Empleados</title>
       <style>
       body{
           background-color:lightgoldenrodyellow;
       }
       .Centrar{
           text-align:center
       }
       </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="Centrar">
     <h1 class="auto-style">EMPLEADOS</h1>
        </div>
        <section>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/descarga.png" OnClick="ImageButton1_Click" Width="110px" />
            <br />
            <br />
            <br />
        </section>
    </form>
</body>
</html>

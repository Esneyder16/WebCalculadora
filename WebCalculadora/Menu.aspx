<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebCalculadora.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Principal</title>
<style>
ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: #333;
}

li {
  float: left;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

li a:hover:not(.active) {
  background-color: #111;
}

.active {
  background-color: #04AA6D;
}
    .auto-style1 {
        height: 418px;
    }
    .auto-style2 {
        margin-top: 20px;
        margin-left: 0px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
          <div class="Centrar">
           <ul>
                <li><a class="active" href="Menu.aspx"> Inicio </a></li>
                  
               <li> <a href="Articulos.aspx"> Articulos </a> </li>
                  
               <li> <a href="Empleados.aspx"> Empleados </a> </li>

               <li> <a href="Calculadora.aspx"> Calculadora </a> </li>

               <li> <a href="https://uh.ac.cr/"> UH </a> </li>

            
           </ul>
   </div>
   <section class="auto-style1">
       <asp:Image ID="Image1" runat="server" Height="394px" ImageUrl="~/Imagenes/cropped-imagenes-paisajes-bonitos-5.jpg" Width="832px" CssClass="auto-style2" />
   </section>
    </form>
</body>
</html>

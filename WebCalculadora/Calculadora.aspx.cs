using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace WebCalculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
       static decimal num1, num2; //variables globales
       static decimal total;
        string operador;

        protected void Page_Load(object sender, EventArgs e)
        {
          if(!IsPostBack)
            {
                num1 = 0;
                num2 = 0;
                total = 0;
                operador = string.Empty;
            }
        }

        protected void validar()
        {
            decimal.TryParse(Lresultado.Text, out num2);
        }
        protected void RadioButton()
        {
            validar();
            

            if (Rsuma.Checked)
                total = num1 + num2;
            else if (Rresta.Checked)
                total = num1 - num2;
            else if (Rmultiplicacion.Checked)
                total = num1 * num2;
            else total = num1 / num2;

            Lresultado.Text = total.ToString();

        }
        protected void dropdown()
        {
            validar();


            if (Doperacion.SelectedIndex.Equals(0))
                total = num1 + num2;
            else if (Doperacion.SelectedIndex.Equals(1))
                total = num1 - num2;
            else if (Doperacion.SelectedIndex.Equals(2))
                total = num1 * num2;
            else total = num1 / num2;

            Lresultado.Text = total.ToString();

        }

            protected void checkbox()
        {
            validar();
            string resultado = ""; //lo
            if (Csuma.Checked)
            {
                total = num1 + num2;
                resultado = " Suma : " + total.ToString();

                if (Cresta.Checked)
                {
                    total = num1 - num2;
                    resultado = resultado + " Resta : " + total.ToString();
                }
        }
            Lresultado.Text = resultado;
    }

      

        protected void Bsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = decimal.Parse(Lresultado.Text);
            Lresultado.Text = "";
        }

        protected void Bigual_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(Lresultado.Text);
            switch (operador)
            {
                case "+":
                    total = num1 + num2;
                    break;
                case "-":
                    total = num1 - num2;
                    break;
                case "x":
                    break;
                case "÷":
                    total = num1 / num2;
                    break;
                case "x^":
                    total = (decimal)Math.Pow((double)num1, (double)num2);
                    break;
                default:
                    break;
            }
            Lresultado.Text = total.ToString();
        }
        

protected void B1_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "1";
        }

        protected void B2_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "2";
        }

        protected void B3_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "3";
        }

        protected void B4_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "4";
        }

        protected void Bc_Click(object sender, EventArgs e)
        {
            Lresultado.Text = "";
            num1 = 0;
            num2 = 0;
            total = 0;
            operador = string.Empty;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void B5_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "5";
        }

        protected void B6_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "6";
        }

        protected void B7_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "7";
        }

        protected void B8_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "8";
        }

        protected void B9_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "9";
        }

        protected void B0_Click(object sender, EventArgs e)
        {
            Lresultado.Text += "0";
        }

        protected void Bcoma_Click(object sender, EventArgs e)
        {
            if (!Lresultado.Text.Contains(","))
            {
                Lresultado.Text += ",";
            }
          
        }

        protected void Bresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = decimal.Parse(Lresultado.Text);
            Lresultado.Text = "";
        }

        protected void Bmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "x";
            num1 = decimal.Parse(Lresultado.Text);
            Lresultado.Text = "";
        }



        protected void Bdividir_Click(object sender, EventArgs e)
        {
            operador = "÷";
            num1 = decimal.Parse(Lresultado.Text);
            Lresultado.Text = "";
        }

        protected void Belevarcualquiera_Click(object sender, EventArgs e)
        {
            operador = "x^";
            num1 = decimal.Parse(Lresultado.Text);
            Lresultado.Text = "";
        }

        protected void Bquitar_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text.Length > 0)
            {
                Lresultado.Text = Lresultado.Text.Substring(0, Lresultado.Text.Length - 1);
            }
        }

        protected void Braiz_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Lresultado.Text);
            if (num1 >= 0)
            {
                total = (decimal)Math.Sqrt((double)num1);
                Lresultado.Text = total.ToString();
            }
            else
            {
                Lresultado.Text = "Error: Raíz de número negativo.";
            }
        }


        protected void Bsumaresta_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text.StartsWith("-"))
            {
                Lresultado.Text = Lresultado.Text.Substring(1);
            }
            else
            {
                Lresultado.Text = "-" + Lresultado.Text;
            }
        }

        protected void Bn_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Lresultado.Text);
            if (num1 >= 0 && num1 == (int)num1) // asegura que sea un número entero no negativo
            {
                total = Factorial((int)num1);
                Lresultado.Text = total.ToString();
            }
            else
            {
                Lresultado.Text = "Error: Factorial de número negativo o decimal.";
            }
        }

        private decimal Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        protected void Bdieselevado_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Lresultado.Text);
            total = (decimal)Math.Pow(10, (double)num1);
            Lresultado.Text = total.ToString();
        }


        protected void Blogaritmo_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Lresultado.Text);
            if (num1 > 0)
            {
                total = (decimal)Math.Log10((double)num1);
                Lresultado.Text = total.ToString();
            }
            else
            {
                Lresultado.Text = "Error: Logaritmo de número no positivo.";
            }
        }

        protected void Belevardos_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Lresultado.Text);
            total = num1 * num1;
            Lresultado.Text = total.ToString();
        }



        protected void Bcalcular_Click(object sender, EventArgs e)
        {

            dropdown();
          

        }
    }
}
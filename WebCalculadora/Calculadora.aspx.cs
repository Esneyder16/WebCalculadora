using System;
using System.Web.UI;

namespace WebCalculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        static decimal num1, num2; // variables globales
        static decimal total;
        static string operador;
        static bool verificar; // para determinar si estamos ingresando el segundo número

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                num1 = 0;
                num2 = 0;
                total = 0;
                operador = string.Empty;
                verificar = false;
            }
        }

        protected void AssignNumber(string numero)
        {
            if (verificar)
            {
                Tvalor2.Text += numero;
            }
            else
            {
                Tvalor1.Text += numero;
            }
        }

        protected void Bsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            verificar = true;
        }

        protected void Bresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            verificar = true;
        }

        protected void Bmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "x";
            verificar = true;
        }

        protected void Bdividir_Click(object sender, EventArgs e)
        {
            operador = "÷";
            verificar = true;
        }

        protected void Belevarcualquiera_Click(object sender, EventArgs e)
        {
            operador = "x^";
            verificar = true;
        }

        protected void Bigual_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Tvalor1.Text);
            num2 = decimal.Parse(Tvalor2.Text);

            switch (operador)
            {
                case "+":
                    total = num1 + num2;
                    break;
                case "-":
                    total = num1 - num2;
                    break;
                case "x":
                    total = num1 * num2;
                    break;
                case "÷":
                    if (num2 != 0)
                    {
                        total = num1 / num2;
                    }
                    else
                    {
                        Lresultado.Text = "Error: Division by zero";
                        return;
                    }
                    break;
                case "x^":
                    total = (decimal)Math.Pow((double)num1, (double)num2);
                    break;
                default:
                    Lresultado.Text = "Error";
                    return;
            }
            Lresultado.Text = total.ToString();
        }

        protected void B1_Click(object sender, EventArgs e)
        {
            AssignNumber("1");
        }

        protected void B2_Click(object sender, EventArgs e)
        {
            AssignNumber("2");
        }

        protected void B3_Click(object sender, EventArgs e)
        {
            AssignNumber("3");
        }

        protected void B4_Click(object sender, EventArgs e)
        {
            AssignNumber("4");
        }

        protected void B5_Click(object sender, EventArgs e)
        {
            AssignNumber("5");
        }

        protected void B6_Click(object sender, EventArgs e)
        {
            AssignNumber("6");
        }

        protected void B7_Click(object sender, EventArgs e)
        {
            AssignNumber("7");
        }

        protected void B8_Click(object sender, EventArgs e)
        {
            AssignNumber("8");
        }

        protected void B9_Click(object sender, EventArgs e)
        {
            AssignNumber("9");
        }

        protected void B0_Click(object sender, EventArgs e)
        {
            AssignNumber("0");
        }

        protected void Bcoma_Click(object sender, EventArgs e)
        {
            if (verificar)
            {
                if (!Tvalor2.Text.Contains(","))
                {
                    Tvalor2.Text += ",";
                }
            }
            else
            {
                if (!Tvalor1.Text.Contains(","))
                {
                    Tvalor1.Text += ",";
                }
            }
        }

        protected void Bc_Click(object sender, EventArgs e)
        {
            Tvalor1.Text = "";
            Tvalor2.Text = "";
            Lresultado.Text = "";
            num1 = 0;
            num2 = 0;
            total = 0;
            operador = string.Empty;
            verificar = false;
        }

        protected void Bquitar_Click(object sender, EventArgs e)
        {
            if (verificar)
            {
                if (Tvalor2.Text.Length > 0)
                {
                    Tvalor2.Text = Tvalor2.Text.Substring(0, Tvalor2.Text.Length - 1);
                }
            }
            else
            {
                if (Tvalor1.Text.Length > 0)
                {
                    Tvalor1.Text = Tvalor1.Text.Substring(0, Tvalor1.Text.Length - 1);
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void Bsumaresta_Click(object sender, EventArgs e)
        {
            if (verificar)
            {
                if (Tvalor2.Text.StartsWith("-"))
                {
                    Tvalor2.Text = Tvalor2.Text.Substring(1);
                }
                else
                {
                    Tvalor2.Text = "-" + Tvalor2.Text;
                }
            }
            else
            {
                if (Tvalor1.Text.StartsWith("-"))
                {
                    Tvalor1.Text = Tvalor1.Text.Substring(1);
                }
                else
                {
                    Tvalor1.Text = "-" + Tvalor1.Text;
                }
            }
        }

        protected void Bn_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Tvalor1.Text);
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
            num1 = decimal.Parse(Tvalor1.Text);
            total = (decimal)Math.Pow(10, (double)num1);
            Lresultado.Text = total.ToString();
        }

        protected void Blogaritmo_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Tvalor1.Text);
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
            num1 = decimal.Parse(Tvalor1.Text);
            total = num1 * num1;
            Lresultado.Text = total.ToString();
        }

        protected void Braiz_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Tvalor1.Text);
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1ProgramacionII
{
    public partial class Calculadora : System.Web.UI.Page
    {
        //Metodos
        float Factorial(float n)
        {
            float resultado = 1f;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        //Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al cambiar el index de la dropDownList de las formulas se cambian los datos según corresponda
            if (DropDownList2.SelectedIndex == 0)
            {
                //Suma
                label1.Text = "Numero 1";
                labelN2.Text = "Numero 2";
                TextBoxN1.Text = "";
                TextBoxN2.Text = "";
            }
            if (DropDownList2.SelectedIndex == 1)
            {
                //Resta
                label1.Text = "Numero 1";
                labelN2.Text = "Numero 2";
                TextBoxN1.Text = "";
                TextBoxN2.Text = "";
            }
            if (DropDownList2.SelectedIndex == 2)
            {
                //Multiplicación
                label1.Text = "Numero 1";
                labelN2.Text = "Numero 2";
                TextBoxN1.Text = "";
                TextBoxN2.Text = "";
            }
            if (DropDownList2.SelectedIndex == 3)
            {
                //División
                label1.Text = "Numero 1";
                labelN2.Text = "Numero 2";
                TextBoxN1.Text = "";
                TextBoxN2.Text = "";
            }
            else if (DropDownList2.SelectedIndex == 4) 
            {
                //Factorial
                label1.Text = "Factorial de: ";
                TextBoxN1.Text = "";
                TextBoxN2.Text = "----------NO USAR-----------";
            }
            else if (DropDownList2.SelectedIndex == 5)
            {
                //Raíz cuadrada
                label1.Text = "Raiz cuadrada de: ";
                TextBoxN1.Text = "";
                TextBoxN2.Text = "----------NO USAR-----------";
            }
            else if (DropDownList2.SelectedIndex == 6)
            {
                //Logaritmo natural
                label1.Text = "Logaritmo natural de: ";
                TextBoxN1.Text = "";
                TextBoxN2.Text = "----------NO USAR-----------";
            }
            else if (DropDownList2.SelectedIndex == 7)
            {
                //Potencia
                label1.Text = "Base: ";
                TextBoxN1.Text = "";
                labelN2.Text = "elevado a la: ";
                TextBoxN2.Text = "";
            }
            else if (DropDownList2.SelectedIndex == 8)
            {
                //10 a la potencia
                label1.Text = "Numero";
                TextBoxN1.Text = "10";
                labelN2.Text = "elevado a la: ";
                TextBoxN2.Text = "";
            }
            else if (DropDownList2.SelectedIndex == 9)
            {
                //Número al cuadrado
                label1.Text = "Numero";
                TextBoxN1.Text = "";
                labelN2.Text = "elevado al cuadrado: ";
                TextBoxN2.Text = "2";
            }

        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 0 y dependiendo del numero puesto en la dropDownList  se coloca el 0 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "0";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "0";
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Al darle click al botón 1 y dependiendo del numero puesto en la dropDownList  se coloca el 1 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "1";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 2 y dependiendo del numero puesto en la dropDownList  se coloca el 2 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "2";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 3 y dependiendo del numero puesto en la dropDownList  se coloca el 3 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "3";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 4 y dependiendo del numero puesto en la dropDownList  se coloca el 4 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "4";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 5 y dependiendo del numero puesto en la dropDownList  se coloca el 5 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "5";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 6 y dependiendo del numero puesto en la dropDownList  se coloca el 6 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "6";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 7 y dependiendo del numero puesto en la dropDownList  se coloca el 7 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "7";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 8 y dependiendo del numero puesto en la dropDownList  se coloca el 8 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "8";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //Al darle click al botón 9 y dependiendo del numero puesto en la dropDownList  se coloca el 9 ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + "9";
            }
            else TextBoxN2.Text = TextBoxN2.Text + "9";
        }

        protected void ButtonC_Click(object sender, EventArgs e)
        {
            //Se eliminan los datos dentro de la textBox seleccionada en la DropDownList
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = "";
            }
            else TextBoxN2.Text = "";
        }
        protected void ButtonComa_Click(object sender, EventArgs e)
        {
            //Al darle click al botón , y dependiendo del numero puesto en la dropDownList  se coloca la coma ahí
            if (DropDownList1.Text == "Numero 1")
            {
                TextBoxN1.Text = TextBoxN1.Text + ".";
            }
            else TextBoxN2.Text = TextBoxN2.Text + ".";
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            //Al presionar el botón igual, dependiendo del texto de la dropdownList de realiza las siguientes formulas
            if (DropDownList2.SelectedValue == "Suma")
            {
                float num1 = float.Parse(TextBoxN1.Text);
                float num2 = float.Parse(TextBoxN2.Text);
                float resultado = num1 +num2;
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "Resta") 
            {
                float resultado = float.Parse(TextBoxN1.Text) - float.Parse(TextBoxN2.Text);
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "Multiplicacion")
            {
                float resultado = float.Parse(TextBoxN1.Text) * int.Parse(TextBoxN2.Text);
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "Division")
            {
                float resultado = int.Parse(TextBoxN1.Text) / int.Parse(TextBoxN2.Text);
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "Factorial")
            {
                float resultado = Factorial(float.Parse(TextBoxN1.Text));
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "Raiz cuadrada")
            {
                Double RaizCuadrada = Math.Sqrt(int.Parse(TextBoxN1.Text));
                TextBoxResultado.Text = RaizCuadrada.ToString();
            }
            else if (DropDownList2.SelectedValue == "Logaritmo natural")
            {
                double resultado = Math.Log(double.Parse(TextBoxN1.Text));
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "Potencia")
            {
                double resultado = Math.Pow(double.Parse(TextBoxN1.Text), double.Parse(TextBoxN2.Text));
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "10 a la potencia")
            {
                double resultado = Math.Pow(double.Parse(TextBoxN1.Text), double.Parse(TextBoxN2.Text));
                TextBoxResultado.Text = resultado.ToString();
            }
            else if (DropDownList2.SelectedValue == "Numero al cuadrado")
            {
                double resultado = Math.Pow(double.Parse(TextBoxN1.Text), double.Parse(TextBoxN2.Text));
                TextBoxResultado.Text = resultado.ToString();
            }
        }

        protected void ButtonReset_Click(object sender, EventArgs e)
        {
            //Al darle al botón de reset se elimina el texto que haya en todas las textbox de la página
            TextBoxN1.Text = "";
            TextBoxN2.Text = "";
            TextBoxResultado.Text = "";
        }
    }
}
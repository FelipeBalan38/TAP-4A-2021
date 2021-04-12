using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica1
{
    public partial class Form1 : Form
    {
        private int dat1;
        private int dat2;
        private string op;
        private Operaciones operac;
        public Form1()
        {
            InitializeComponent();
            operac = new Operaciones();
        }

        private void btn_1(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "1");
        }

        private void btn_2(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "2");
        }

        private void btn_3(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "3");
        }

        private void btn_suma(object sender, EventArgs e)
        {
            String texto = txt_in.Text;
 
            {
                String nose = txt_in.Text;
                if (isNumber(nose))
                {
                    dat1 = int.Parse(nose);
                    op = "+";
                    txt_in.Text = "";
                }
                else
                    txt_in.Text = "Por favor ingresa solo numeros";
            }
        }

        private void btn_4(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "4");
        }

        private void btn_5(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "5");
        }

        private void btn_6(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "6");
        }

        private void btn_resta(object sender, EventArgs e)
        {
            String nose = txt_in.Text;
            if (isNumber(nose))
            {
                dat1 = int.Parse(nose);
                op = "-";
                txt_in.Text = "";
            }
            else
                txt_in.Text = "Por favor ingresa solo numeros";
        }

        private void btn_7(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "7");
        }

        private void btn_8(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "8");
        }

        private void btn_9(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "9");
        }

        private void btn_div(object sender, EventArgs e)
        {
            String nose = txt_in.Text;
            if (isNumber(nose))
            {
                dat1 = int.Parse(nose);
                op = "/";
                txt_in.Text = "";
            }
            else
                txt_in.Text = "Por favor ingresa solo numeros";
        }

        private void btn_multi(object sender, EventArgs e)
        {
            String nose = txt_in.Text;
            if (isNumber(nose))
            {
                dat1 = int.Parse(nose);
                op = "*";
                txt_in.Text = "";
            }
            else
                txt_in.Text = "Por favor ingresa solo numeros";
        }

        private void btn_0(object sender, EventArgs e)
        {
            txt_in.Text = (txt_in.Text + "0");
        }

        private void btn_cuadra(object sender, EventArgs e)
        {
            String nose = txt_in.Text;
            if (isNumber(nose))
            {
                dat1 = int.Parse(nose);
                op = "^";
                txt_in.Text = "";
            }
            else
                txt_in.Text = "Por favor ingresa solo numeros";
        }

        private void btn_igual(object sender, EventArgs e)
        {
            String nose = txt_in.Text;
            if (isNumber(nose))
            {
                dat2 = int.Parse(nose);
                txt_in.Text = operac.operacion(dat1,dat2,op);
            }
            else
                txt_in.Text = "Por favor ingresa solo numeros";
        }
        public static bool isNumber(String cadena)
        {
            bool resultado;
            try
            {
                int.Parse(cadena);
                resultado = true;
            }
            catch(FormatException)
            {
                resultado = false;
            }
            return resultado;
        }

        private void txtResOP_TextChanged(object sender, EventArgs e)
        {
            txt_in.MaxLength = 20;
            if (txt_in.TextLength == 20)
            {
                txt_in.Text = "Desbordamiento de Digitos";
                MessageBox.Show("Error Desbordamiento de Digitos", null, MessageBoxButtons.OK);
            }
        }

    }
}

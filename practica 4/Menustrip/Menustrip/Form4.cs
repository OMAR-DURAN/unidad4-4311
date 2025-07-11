using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menustrip
{
    public partial class Form4 : Form
    {
        private static Form4 instancia = null;

        public static Form4 ventana_unica2()
        {
            if (instancia == null)
            {
                instancia = new Form4();
                return instancia;
            }
            return instancia;
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            if (int.TryParse(txtLimite.Text, out int limite) && limite >= 0)
            {
                txtResultado.Text = GenerarFibonacci(limite);
            }
            else
            {
                MessageBox.Show("Ingrese un número válido mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string GenerarFibonacci(int limite)
        {
            if (limite == 0) return "0";
            if (limite == 1) return "0, 1";

            int a = 0, b = 1, temp;
            string resultado = "0, 1";

            while (b + a <= limite)
            {
                temp = a + b;
                resultado += ", " + temp;
                a = b;
                b = temp;
            }
            return resultado;
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


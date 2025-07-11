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
    public partial class Form3 : Form
    {
        private static Form3 instancia = null;

        public static Form3 ventana_unica1()
        {
            if (instancia == null)
            {
                instancia = new Form3();
                return instancia;
            }
            return instancia;
        }

        private Dictionary<string, decimal> tasasCambio = new Dictionary<string, decimal>
        {
            { "USD", 1.0m },    // Dólar estadounidense 
            { "EUR", 0.92m },   // Euro
            { "GBP", 0.78m },   // Libra esterlina
            { "JPY", 145.23m }, // Yen japonés
            { "MXN", 17.10m },   // Peso mexicano
            { "DOP", 62.52m },    // Peso dominicano
        };

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                string monedaDesde = comboBoxDesde.SelectedItem.ToString();
                string monedaHasta = comboBoxHasta.SelectedItem.ToString();

                decimal tasaDesde = tasasCambio[monedaDesde];
                decimal tasaHasta = tasasCambio[monedaHasta];

                decimal resultado = cantidad * (tasaHasta / tasaDesde);
                lblResultado.Text = $"{cantidad} {monedaDesde} = {resultado:F2} {monedaHasta}";
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Form3()
        {
            InitializeComponent();
            CargarMonedas();
        }
        private void CargarMonedas()
        {
            foreach (var moneda in tasasCambio.Keys)
            {
                comboBoxDesde.Items.Add(moneda);
                comboBoxHasta.Items.Add(moneda);
            }
            comboBoxDesde.SelectedIndex = 0;
            comboBoxHasta.SelectedIndex = 1;
        }
    }
    
}

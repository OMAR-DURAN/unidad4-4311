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
    public partial class Form2 : Form
    {
        private static Form2 instancia = null;

        public static Form2 ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Form2();
                return instancia;
            }
            return instancia;
        }


        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load; // Vinculamos el evento Load manualmente si no está hecho en diseñador
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (dgvPersonas.Columns.Count == 0)
            {
                dgvPersonas.ColumnCount = 12;
                dgvPersonas.Columns[0].Name = "Nombre";
                dgvPersonas.Columns[1].Name = "Apellido";
                dgvPersonas.Columns[2].Name = "Cédula";
                dgvPersonas.Columns[3].Name = "Edad";
                dgvPersonas.Columns[4].Name = "Sexo";
                dgvPersonas.Columns[5].Name = "Dirección";
                dgvPersonas.Columns[6].Name = "Teléfono";
                dgvPersonas.Columns[7].Name = "Correo";
                dgvPersonas.Columns[8].Name = "Ocupación";
                dgvPersonas.Columns[9].Name = "Estado Civil";
                dgvPersonas.Columns[10].Name = "Nacionalidad";
                dgvPersonas.Columns[11].Name = "Fecha Registro";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            numericEdad.Value = 0;
            comboSexo.SelectedIndex = -1;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtOcupacion.Clear();
            comboEstadoCivil.SelectedIndex = -1;
            txtNacionalidad.Clear();
            dateFechaRegistro.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Add(
              txtNombre.Text,
              txtApellido.Text,
              txtCedula.Text,
              numericEdad.Value.ToString(),
              comboSexo.Text,
              txtDireccion.Text,
              txtTelefono.Text,
              txtCorreo.Text,
              txtOcupacion.Text,
              comboEstadoCivil.Text,
              txtNacionalidad.Text,
              dateFechaRegistro.Value.ToShortDateString()
          );
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPersonas.SelectedRows.Count > 0)
            {
                dgvPersonas.Rows.RemoveAt(dgvPersonas.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            numericEdad.Value = 0;
            comboSexo.SelectedIndex = -1;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtOcupacion.Clear();
            comboEstadoCivil.SelectedIndex = -1;
            txtNacionalidad.Clear();
            dateFechaRegistro.Value = DateTime.Now;
        }
    }
}

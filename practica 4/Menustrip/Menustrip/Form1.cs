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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void nUMEROPRIMOToolStripMenuItem_Click(object sender, EventArgs e)
        {         
        }

        private void nUMEROPRIMOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         Form2 frm = Form2.ventana_unica();
         frm.MdiParent = this;
         frm.Show();
         frm.BringToFront();
        }

        private void nUMEROPERFECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = Form3.ventana_unica1();          
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void sERIEFIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = Form4.ventana_unica2();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}

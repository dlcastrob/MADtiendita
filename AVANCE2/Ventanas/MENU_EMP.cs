using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVANCE2
{
    public partial class Form1 : Form
    {
        VENTA VentaNueva;
        public Form1()
        {
            VentaNueva = new VENTA();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new DialogResult();

            dialog = MessageBox.Show("Seguro que quiere cerrar la aplicacion?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dialog == DialogResult.No)
            {
                this.Close();
            }
            if (dialog == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            VentaNueva.ShowDialog();
        }
    }
}

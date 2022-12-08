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
    public partial class AGREGAR_PRODUCTO : Form
    {
        private int n = 0;
        public AGREGAR_PRODUCTO()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        //EDITAR
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow nuevorenglon = dgvProducto.Rows[n];
            nuevorenglon.Cells[2].Value = tbDesc.Text;
            nuevorenglon.Cells[3].Value = cbDepa.Text;
            nuevorenglon.Cells[4].Value = cbMedida.Text;
            nuevorenglon.Cells[5].Value = tbCosto.Text;
            nuevorenglon.Cells[6].Value = tbPrecio.Text;
            nuevorenglon.Cells[7].Value = dtpAlta.Text;
            nuevorenglon.Cells[8].Value = tbExistencia.Text;
            nuevorenglon.Cells[9].Value = tbReorden.Text;
        }
        //ELIMINAR
        private void button3_Click(object sender, EventArgs e)
        {
            if (n >= 0)
            {
                dgvProducto.Rows.RemoveAt(n);
                MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "Se ha eliminado con exito!!!", MessageBoxButtons.OK);
            }
        }
        //AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVANCE2.Ventanas
{
    public partial class AGREGAR_EMPLEADO : Form
    {
        private int n = 0;
        public AGREGAR_EMPLEADO()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow nuevorenglon = dgvEmp.Rows[n];
            nuevorenglon.Cells[1].Value = tbNombre.Text;
            nuevorenglon.Cells[2].Value = tbPaterno.Text;
            nuevorenglon.Cells[3].Value = tbMaterno.Text;
            nuevorenglon.Cells[4].Value = tbNumEmpleado.Text;
            nuevorenglon.Cells[5].Value = tbNumNomina.Text;
            nuevorenglon.Cells[6].Value = tbNumCuenta.Text;
            nuevorenglon.Cells[7].Value = dtpNacimiento.Text;
            nuevorenglon.Cells[8].Value = tbCURP.Text;
            nuevorenglon.Cells[9].Value = dtpAlta.Text;
            nuevorenglon.Cells[10].Value = tbEmail.Text;
            nuevorenglon.Cells[11].Value = tbContra.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n >= 0)
            {
                dgvEmp.Rows.RemoveAt(n);
                MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "Se ha eliminado con exito!!!", MessageBoxButtons.OK);
            }
        }
        // METER LA INFO DEL RENGLON DEL DGV A SU RESPECTIVA TEXT BOX
        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvEmp.CurrentRow.Cells[1].Value.ToString();
            tbPaterno.Text = dgvEmp.CurrentRow.Cells[2].Value.ToString();
            tbMaterno.Text = dgvEmp.CurrentRow.Cells[3].Value.ToString();
            tbNumEmpleado.Text = dgvEmp.CurrentRow.Cells[4].Value.ToString();
            tbNumNomina.Text = dgvEmp.CurrentRow.Cells[5].Value.ToString();
            tbNumCuenta.Text = dgvEmp.CurrentRow.Cells[6].Value.ToString();
            dtpNacimiento.Text = dgvEmp.CurrentRow.Cells[7].Value.ToString();
            tbCURP.Text = dgvEmp.CurrentRow.Cells[8].Value.ToString();
            dtpAlta.Text = dgvEmp.CurrentRow.Cells[9].Value.ToString();
            tbEmail.Text = dgvEmp.CurrentRow.Cells[10].Value.ToString();
            tbContra.Text = dgvEmp.CurrentRow.Cells[11].Value.ToString();

        }
    }
}

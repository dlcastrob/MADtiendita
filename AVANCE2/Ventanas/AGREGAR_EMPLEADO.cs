using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static AVANCE2.EnlaceDB;
using static AVANCE2.FUNCIONES;
using System.Net.Mail;

namespace AVANCE2.Ventanas
{
    public partial class AGREGAR_EMPLEADO : Form
    {
        private int n = 0;

        public AGREGAR_EMPLEADO()
        {
            InitializeComponent();


        }
        SqlConnection conexion = new SqlConnection("");
        

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        //AGREGAR
        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into CAJERO values("+tbNombre.Text+ ",'" +tbPaterno+ "','" + tbMaterno + "','" + tbCURP + "','" + dtpNacimiento + "','" + tbNumNomina + "','" + tbEmail + "','" + dtpAlta + "' )";
            llenar_tabla();
            if (EsValidoEmail(tbEmail.Text) == true)
            {

            }
            limpiar_campos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //EDITAAAAAAAAAAAAAAAAAAR
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
            llenar_tabla();
            limpiar_campos();
        }
        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n >= 0)
            {
                dgvEmp.Rows.RemoveAt(n);
                MessageBox.Show("SE HAN ACTUALIZADO LOS DATOS", "Se ha eliminado con exito!!!", MessageBoxButtons.OK);
            }
            llenar_tabla();
            limpiar_campos();
        }
        // METER LA INFO DEL RENGLON DEL DGV A SU RESPECTIVA TEXT BOX
        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

  
            tbContra.Text = dgvEmp.CurrentRow.Cells[0].Value.ToString();
            tbNombre.Text = dgvEmp.CurrentRow.Cells[1].Value.ToString();
            tbPaterno.Text = dgvEmp.CurrentRow.Cells[2].Value.ToString();
            tbMaterno.Text = dgvEmp.CurrentRow.Cells[3].Value.ToString();
            tbNumEmpleado.Text = dgvEmp.CurrentRow.Cells[4].Value.ToString();
            tbNumNomina.Text = dgvEmp.CurrentRow.Cells[5].Value.ToString();
            tbNumCuenta.Text = dgvEmp.CurrentRow.Cells[6].Value.ToString();
            dtpNacimiento.Text = dgvEmp.CurrentRow.Cells[7].Value.ToString();
            dtpAlta.Text = dgvEmp.CurrentRow.Cells[9].Value.ToString();
            tbCURP.Text = dgvEmp.CurrentRow.Cells[10].Value.ToString();
            tbEmail.Text = dgvEmp.CurrentRow.Cells[11].Value.ToString();
            llenar_tabla();
            
        }

        

        //ACTUALIZA
        public void llenar_tabla()
        {
            string consulta = "select * from CAJERO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvEmp.DataSource = dt;
        }
        //DESPUES DE HACER UN A, B O C SE LIMPIAN LAS TB
        public void limpiar_campos()
        {
            tbNombre.Clear();
            tbPaterno.Clear();
            tbMaterno.Clear();
            tbNumEmpleado.Clear();
            tbNumNomina.Clear();
            tbNumCuenta.Clear();
            tbEmail.Clear();
            tbContra.Clear();
            tbNombre.Clear();

        }

        private void AGREGAR_EMPLEADO_Load(object sender, EventArgs e)
        {

            var obj = new EnlaceDB();
            var tablita = new DataTable();
            tablita = obj.gestion_Empleados("spGestionEmpleados");
            dgvEmp.DataSource = tablita;
            /*string consulta = "select * from CAJERO";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvEmp.DataSource = dt;
            */
            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conex);
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgvEmp.SelectedCells[2].Value.ToString();
            tbPaterno.Text = dgvEmp.SelectedCells[3].Value.ToString();
            tbMaterno.Text = dgvEmp.SelectedCells[4].Value.ToString();
            tbNumEmpleado.Text = dgvEmp.SelectedCells[5].Value.ToString();
            tbNumNomina.Text = dgvEmp.SelectedCells[6].Value.ToString();
            tbNumCuenta.Text = dgvEmp.SelectedCells[7].Value.ToString();
            dtpNacimiento.Text = dgvEmp.SelectedCells[8].Value.ToString();
            tbCURP.Text = dgvEmp.SelectedCells[9].Value.ToString();
            dtpAlta.Text = dgvEmp.SelectedCells[10].Value.ToString();
            tbEmail.Text = dgvEmp.SelectedCells[11].Value.ToString();
            tbContra.Text = dgvEmp.SelectedCells[12].Value.ToString();

        }

        private void tbNumNomina_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbNumCuenta_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

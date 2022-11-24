using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AVANCE2.FUNCIONES;

namespace AVANCE2
{
   
    public partial class formInicio : Form
    {
        //formAgregarCajero NuevoCajero;
        AGREGAR_PRODUCTO NuevoProducto;
        Ventanas.AGREGAR_EMPLEADO NuevoEmpleado;
        VENTA NuevaVenta;
        Ventanas.DEVOLUCION NuevaDevolucion;
        INVENTARIO NuevoInventario;
        REPORTE_DE_VENTAS NuevoReporte;
        REPORTE_CAJERO NuevoReporteCajero;
        //LOGIN NuevoLogin;
        //formEmpleados NuevoEmpleado;
        public formInicio()
        {
            InitializeComponent();
           // NuevoCajero = new formAgregarCajero();
            NuevoProducto = new AGREGAR_PRODUCTO();
            NuevoEmpleado = new Ventanas.AGREGAR_EMPLEADO();
            NuevaVenta = new VENTA();
            NuevaDevolucion = new Ventanas.DEVOLUCION();
            NuevoInventario = new INVENTARIO();
            NuevoReporte = new REPORTE_DE_VENTAS();
            NuevoReporteCajero = new REPORTE_CAJERO();
            //NuevoLogin = new LOGIN();
            //NuevoEmpleado = new formEmpleados();
        }

        private void percepcionesYDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            //NuevaDeduccion.ShowDialog();
        }

      

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //NuevoEmpleado.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //NuevoEmpleado.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //NuevoBorrado.ShowDialog();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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
        //CON ESTO SE IMPRIME UN PDF PARA EL RICHTEXTBOX RTB
        
        

        private void btnLetra_Click(object sender, EventArgs e)
        {
            //NumeroALetras(tbLETRAS)
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // NuevoLogin.Show();
            
        }

        private void formInicio_Load(object sender, EventArgs e)
        {

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCAJEROS_Click(object sender, EventArgs e)
        {
            NuevoEmpleado.ShowDialog();
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            NuevoProducto.ShowDialog();        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            NuevaVenta.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            NuevoInventario.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            NuevoReporte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoReporte.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NuevoInventario.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NuevaDevolucion.ShowDialog();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            NuevoReporteCajero.ShowDialog();
        }
    }
       
}

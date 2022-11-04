using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AVANCE2.FUNCIONES;




namespace AVANCE2
{
   
    public partial class formInicio : Form
    {
        
        //LOGIN NuevoLogin;
        //formEmpleados NuevoEmpleado;
        public formInicio()
        {

            InitializeComponent();
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

        private void btnPercepciones_Click_1(object sender, EventArgs e)
        {
            
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

        private void btnNomina_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e) //RECIBO ESTA JSJSJA
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }
    }
       
}

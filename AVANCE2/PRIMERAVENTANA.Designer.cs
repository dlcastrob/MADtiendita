
namespace AVANCE2
{
    partial class formInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btnPercepciones = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRecibos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(301, 9);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(203, 17);
            this.lbtitulo.TabIndex = 1;
            this.lbtitulo.Text = "Bienvenido! Que desea hacer?";
            // 
            // btnPercepciones
            // 
            this.btnPercepciones.Location = new System.Drawing.Point(12, 70);
            this.btnPercepciones.Name = "btnPercepciones";
            this.btnPercepciones.Size = new System.Drawing.Size(229, 66);
            this.btnPercepciones.TabIndex = 1;
            this.btnPercepciones.Text = "Gestion Cajeros";
            this.btnPercepciones.UseVisualStyleBackColor = true;
            this.btnPercepciones.Click += new System.EventHandler(this.btnPercepciones_Click_1);
            // 
            // btnNomina
            // 
            this.btnNomina.Location = new System.Drawing.Point(541, 70);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(242, 66);
            this.btnNomina.TabIndex = 2;
            this.btnNomina.Text = "Gestion productos";
            this.btnNomina.UseVisualStyleBackColor = true;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecibos
            // 
            this.btnRecibos.Location = new System.Drawing.Point(541, 161);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(242, 65);
            this.btnRecibos.TabIndex = 4;
            this.btnRecibos.Text = "Inventario";
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir y Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(12, 248);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(229, 66);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Consultar recibos";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 66);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reporte por cajero";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRecibos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNomina);
            this.Controls.Add(this.btnPercepciones);
            this.Controls.Add(this.lbtitulo);
            this.Name = "formInicio";
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.formInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btnPercepciones;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRecibos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button button3;
    }
}


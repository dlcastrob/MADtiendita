﻿
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
            this.btnCAJEROS = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbtitulo.Location = new System.Drawing.Point(248, 18);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(282, 25);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Bienvenido! Que desea hacer?";
            // 
            // btnCAJEROS
            // 
            this.btnCAJEROS.Location = new System.Drawing.Point(114, 99);
            this.btnCAJEROS.Name = "btnCAJEROS";
            this.btnCAJEROS.Size = new System.Drawing.Size(229, 66);
            this.btnCAJEROS.TabIndex = 1;
            this.btnCAJEROS.Text = "Gestion Cajeros";
            this.btnCAJEROS.UseVisualStyleBackColor = true;
            this.btnCAJEROS.Click += new System.EventHandler(this.btnCAJEROS_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(448, 99);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(229, 66);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Gestion productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(448, 181);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(229, 65);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Cantidad de cajas";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir y Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(114, 181);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(229, 66);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Consultar recibos";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 66);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reporte por cajero";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reporte por ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 66);
            this.button4.TabIndex = 9;
            this.button4.Text = "Inventario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(448, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 66);
            this.button5.TabIndex = 10;
            this.button5.Text = "Devoluciones";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(795, 554);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnCAJEROS);
            this.Controls.Add(this.lbtitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formInicio";
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.formInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button btnCAJEROS;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

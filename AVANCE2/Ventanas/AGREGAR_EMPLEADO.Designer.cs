
namespace AVANCE2.Ventanas
{
    partial class AGREGAR_EMPLEADO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.tbNumEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPaterno = new System.Windows.Forms.TextBox();
            this.tbMaterno = new System.Windows.Forms.TextBox();
            this.tbNumNomina = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNumCuenta = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAlta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCURP = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox5.Location = new System.Drawing.Point(-245, 202);
            this.maskedTextBox5.Mask = "99999";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(155, 22);
            this.maskedTextBox5.TabIndex = 31;
            this.maskedTextBox5.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox4.Location = new System.Drawing.Point(-247, 154);
            this.maskedTextBox4.Mask = "99999";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(155, 22);
            this.maskedTextBox4.TabIndex = 30;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // tbNumEmpleado
            // 
            this.tbNumEmpleado.BeepOnError = true;
            this.tbNumEmpleado.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbNumEmpleado.Location = new System.Drawing.Point(208, 196);
            this.tbNumEmpleado.Mask = "99999";
            this.tbNumEmpleado.Name = "tbNumEmpleado";
            this.tbNumEmpleado.Size = new System.Drawing.Size(193, 22);
            this.tbNumEmpleado.TabIndex = 4;
            this.tbNumEmpleado.ValidatingType = typeof(int);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(927, 537);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 48);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(735, 537);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(137, 48);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(429, 84);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.RowHeadersWidth = 51;
            this.dgvEmp.RowTemplate.Height = 24;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmp.Size = new System.Drawing.Size(912, 399);
            this.dgvEmp.TabIndex = 33;
            this.dgvEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-179, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 49);
            this.button1.TabIndex = 32;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(208, 314);
            this.dtpNacimiento.MaxDate = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.ShowCheckBox = true;
            this.dtpNacimiento.Size = new System.Drawing.Size(192, 22);
            this.dtpNacimiento.TabIndex = 7;
            this.dtpNacimiento.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Número de empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kilo",
            "Gramos",
            "Litro",
            "Metro"});
            this.comboBox2.Location = new System.Drawing.Point(-245, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 24);
            this.comboBox2.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-245, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(-246, 1);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(155, 22);
            this.tbDesc.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(-399, 207);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 17);
            this.label23.TabIndex = 20;
            this.label23.Text = "Precio unitario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-400, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Unidad de medida";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(-400, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Costo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-400, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Departamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-400, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Descripcion";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAtras.Location = new System.Drawing.Point(1300, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(53, 47);
            this.btnAtras.TabIndex = 38;
            this.btnAtras.Text = "↩";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(208, 81);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(193, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nombre(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Apellido paterno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Apellido materno";
            // 
            // tbPaterno
            // 
            this.tbPaterno.Location = new System.Drawing.Point(208, 118);
            this.tbPaterno.Name = "tbPaterno";
            this.tbPaterno.Size = new System.Drawing.Size(193, 22);
            this.tbPaterno.TabIndex = 2;
            // 
            // tbMaterno
            // 
            this.tbMaterno.Location = new System.Drawing.Point(208, 152);
            this.tbMaterno.Name = "tbMaterno";
            this.tbMaterno.Size = new System.Drawing.Size(193, 22);
            this.tbMaterno.TabIndex = 3;
            // 
            // tbNumNomina
            // 
            this.tbNumNomina.BeepOnError = true;
            this.tbNumNomina.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbNumNomina.Location = new System.Drawing.Point(208, 235);
            this.tbNumNomina.Mask = "99999";
            this.tbNumNomina.Name = "tbNumNomina";
            this.tbNumNomina.Size = new System.Drawing.Size(193, 22);
            this.tbNumNomina.TabIndex = 5;
            this.tbNumNomina.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Número de nómina";
            // 
            // tbNumCuenta
            // 
            this.tbNumCuenta.BeepOnError = true;
            this.tbNumCuenta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbNumCuenta.Location = new System.Drawing.Point(208, 276);
            this.tbNumCuenta.Mask = "99999";
            this.tbNumCuenta.Name = "tbNumCuenta";
            this.tbNumCuenta.Size = new System.Drawing.Size(193, 22);
            this.tbNumCuenta.TabIndex = 6;
            this.tbNumCuenta.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Número de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "CURP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(208, 423);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(193, 22);
            this.tbEmail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpAlta
            // 
            this.dtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlta.Location = new System.Drawing.Point(207, 384);
            this.dtpAlta.MaxDate = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            this.dtpAlta.Name = "dtpAlta";
            this.dtpAlta.ShowCheckBox = true;
            this.dtpAlta.Size = new System.Drawing.Size(192, 22);
            this.dtpAlta.TabIndex = 9;
            this.dtpAlta.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            this.dtpAlta.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Fecha de alta";
            // 
            // tbContra
            // 
            this.tbContra.Location = new System.Drawing.Point(207, 462);
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(193, 22);
            this.tbContra.TabIndex = 11;
            this.tbContra.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 462);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 55;
            this.label14.Text = "Contraseña";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // tbCURP
            // 
            this.tbCURP.BeepOnError = true;
            this.tbCURP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbCURP.Location = new System.Drawing.Point(208, 351);
            this.tbCURP.Mask = "AAAA-999999-AAA-AAA-AA";
            this.tbCURP.Name = "tbCURP";
            this.tbCURP.Size = new System.Drawing.Size(193, 22);
            this.tbCURP.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(171, 553);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 49);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Agregue un empleado";
            // 
            // AGREGAR_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 685);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbCURP);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpAlta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNumCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNumNomina);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbMaterno);
            this.Controls.Add(this.tbPaterno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.tbNumEmpleado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Name = "AGREGAR_EMPLEADO";
            this.Text = "AGREGAR EMPLEADO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox tbNumEmpleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPaterno;
        private System.Windows.Forms.TextBox tbMaterno;
        private System.Windows.Forms.MaskedTextBox tbNumNomina;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox tbNumCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAlta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox tbCURP;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
    }
}

namespace AVANCE2
{
    partial class VENTA
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbCodigoP = new System.Windows.Forms.MaskedTextBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCaja = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNumArticulo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBuscaProducto = new System.Windows.Forms.TextBox();
            this.dgvArticulosAgregados = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosAgregados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(467, 394);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(118, 22);
            this.tbTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del empleado";
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de debito",
            "Credito",
            "Cheque",
            "Vale de despensa"});
            this.cbPago.Location = new System.Drawing.Point(171, 493);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(154, 24);
            this.cbPago.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Forma de pago";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(1513, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "↩";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvProductos.Location = new System.Drawing.Point(21, 169);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(428, 466);
            this.dgvProductos.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre producto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Existencia";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbProducto);
            this.groupBox1.Controls.Add(this.tbCodigoP);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Location = new System.Drawing.Point(47, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 653);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de precios ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo producto";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(167, 104);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(206, 22);
            this.tbProducto.TabIndex = 9;
            // 
            // tbCodigoP
            // 
            this.tbCodigoP.Location = new System.Drawing.Point(167, 65);
            this.tbCodigoP.Mask = "99999";
            this.tbCodigoP.Name = "tbCodigoP";
            this.tbCodigoP.Size = new System.Drawing.Size(206, 22);
            this.tbCodigoP.TabIndex = 8;
            this.tbCodigoP.ValidatingType = typeof(int);
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(197, 36);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.ReadOnly = true;
            this.tbEmpleado.Size = new System.Drawing.Size(293, 22);
            this.tbEmpleado.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbCaja
            // 
            this.tbCaja.Location = new System.Drawing.Point(1032, 36);
            this.tbCaja.Name = "tbCaja";
            this.tbCaja.ReadOnly = true;
            this.tbCaja.Size = new System.Drawing.Size(293, 22);
            this.tbCaja.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(958, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "No. caja";
            // 
            // tbNumArticulo
            // 
            this.tbNumArticulo.Location = new System.Drawing.Point(167, 38);
            this.tbNumArticulo.Mask = "99999";
            this.tbNumArticulo.Name = "tbNumArticulo";
            this.tbNumArticulo.Size = new System.Drawing.Size(135, 22);
            this.tbNumArticulo.TabIndex = 15;
            this.tbNumArticulo.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Numero de artículo";
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(700, 170);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(135, 22);
            this.Cantidad.TabIndex = 17;
            this.Cantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cantidad";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbNumArticulo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(533, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 645);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar artículo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvArticulos);
            this.groupBox3.Controls.Add(this.tbBuscaProducto);
            this.groupBox3.Location = new System.Drawing.Point(16, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 466);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar.Location = new System.Drawing.Point(110, 404);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 44);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column9,
            this.Column10});
            this.dgvArticulos.Location = new System.Drawing.Point(11, 79);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(405, 310);
            this.dgvArticulos.TabIndex = 4;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre artículo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Numero de artículo";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Cantidad";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // tbBuscaProducto
            // 
            this.tbBuscaProducto.Location = new System.Drawing.Point(151, 48);
            this.tbBuscaProducto.Name = "tbBuscaProducto";
            this.tbBuscaProducto.Size = new System.Drawing.Size(184, 22);
            this.tbBuscaProducto.TabIndex = 12;
            // 
            // dgvArticulosAgregados
            // 
            this.dgvArticulosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosAgregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.dataGridViewTextBoxColumn1,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvArticulosAgregados.Location = new System.Drawing.Point(35, 38);
            this.dgvArticulosAgregados.Name = "dgvArticulosAgregados";
            this.dgvArticulosAgregados.RowHeadersWidth = 51;
            this.dgvArticulosAgregados.RowTemplate.Height = 24;
            this.dgvArticulosAgregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosAgregados.Size = new System.Drawing.Size(557, 299);
            this.dgvArticulosAgregados.TabIndex = 5;
            this.dgvArticulosAgregados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Codigo producto";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre artículo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Descuento";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(624, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(731, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGenerarRecibo);
            this.groupBox4.Controls.Add(this.btnPagar);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tbMonto);
            this.groupBox4.Controls.Add(this.btnEliminarArticulo);
            this.groupBox4.Controls.Add(this.tbSubtotal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.dgvArticulosAgregados);
            this.groupBox4.Controls.Add(this.tbTotal);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbPago);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(1000, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(590, 645);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de artículos agregados";
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerarRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRecibo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGenerarRecibo.Location = new System.Drawing.Point(470, 565);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(115, 62);
            this.btnGenerarRecibo.TabIndex = 29;
            this.btnGenerarRecibo.Text = "Generar recibo";
            this.btnGenerarRecibo.UseVisualStyleBackColor = false;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPagar.Location = new System.Drawing.Point(210, 583);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(115, 44);
            this.btnPagar.TabIndex = 28;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 536);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Monto";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(171, 536);
            this.tbMonto.Mask = "99999";
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(154, 22);
            this.tbMonto.TabIndex = 26;
            this.tbMonto.ValidatingType = typeof(int);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(35, 343);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(115, 44);
            this.btnEliminarArticulo.TabIndex = 25;
            this.btnEliminarArticulo.Text = "Eliminar producto";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Enabled = false;
            this.tbSubtotal.Location = new System.Drawing.Point(467, 353);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(118, 22);
            this.tbSubtotal.TabIndex = 7;
            this.tbSubtotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(383, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Subtotal";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Realice una venta";
            // 
            // VENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 740);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.tbCaja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEmpleado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "VENTA";
            this.Text = "VENTA";
            this.Load += new System.EventHandler(this.VENTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosAgregados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.MaskedTextBox tbCodigoP;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCaja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tbNumArticulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox tbBuscaProducto;
        private System.Windows.Forms.DataGridView dgvArticulosAgregados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox tbMonto;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
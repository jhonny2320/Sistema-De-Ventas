namespace CapaPresentacion
{
    partial class FRMIngreso
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidIngreso = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidArticulo = new System.Windows.Forms.TextBox();
            this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tbMantenimiento = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpListado = new System.Windows.Forms.TabPage();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblTotalArticulos = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgIngreso = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.MensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.sISTEMA_DE_VENTASDataSet1 = new CapaPresentacion.SISTEMA_DE_VENTASDataSet1();
            this.sISTEMADEVENTASDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISTEMA_DE_VENTASDataSet2 = new CapaPresentacion.SISTEMA_DE_VENTASDataSet2();
            this.servicioMostrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicio_MostrarTableAdapter = new CapaPresentacion.SISTEMA_DE_VENTASDataSet2TableAdapters.Servicio_MostrarTableAdapter();
            this.ventaMostrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.venta_MostrarTableAdapter = new CapaPresentacion.SISTEMA_DE_VENTASDataSet2TableAdapters.Venta_MostrarTableAdapter();
            this.sISTEMA_DE_VENTASDataSet3 = new CapaPresentacion.SISTEMA_DE_VENTASDataSet3();
            this.ventaMostrarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.venta_MostrarTableAdapter1 = new CapaPresentacion.SISTEMA_DE_VENTASDataSet3TableAdapters.Venta_MostrarTableAdapter();
            this.facidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facNumeroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facObservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facfechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tbMantenimiento.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_DE_VENTASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMADEVENTASDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_DE_VENTASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMostrarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaMostrarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_DE_VENTASDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaMostrarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.AutoSize = true;
            this.btnAtras.Location = new System.Drawing.Point(413, 590);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(147, 28);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "INGRESO";
            // 
            // txtidIngreso
            // 
            this.txtidIngreso.BackColor = System.Drawing.Color.Moccasin;
            this.txtidIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidIngreso.Location = new System.Drawing.Point(119, 30);
            this.txtidIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtidIngreso.Name = "txtidIngreso";
            this.txtidIngreso.Size = new System.Drawing.Size(54, 22);
            this.txtidIngreso.TabIndex = 47;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Location = new System.Drawing.Point(727, 412);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 33);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(459, 412);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 33);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "&CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTotalPagado);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.dgDetalle);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtidArticulo);
            this.groupBox1.Controls.Add(this.dtFechaIngreso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtidIngreso);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(23, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(919, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESOS ALMACEN";
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.Moccasin;
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Location = new System.Drawing.Point(555, 23);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(115, 22);
            this.txtSerie.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "NUMERO";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Location = new System.Drawing.Point(115, 412);
            this.lblTotalPagado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(28, 17);
            this.lblTotalPagado.TabIndex = 62;
            this.lblTotalPagado.Text = "0.0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(4, 412);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(105, 17);
            this.lbl1.TabIndex = 61;
            this.lbl1.Text = "Total Pagado $";
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Location = new System.Drawing.Point(8, 224);
            this.dgDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.RowHeadersWidth = 51;
            this.dgDetalle.Size = new System.Drawing.Size(813, 175);
            this.dgDetalle.TabIndex = 56;
            this.dgDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalle_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarArticulo);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.txtPrecioVenta);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtStockInicial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtArticulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(813, 133);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.AutoSize = true;
            this.btnBuscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(304, 28);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(41, 41);
            this.btnBuscarArticulo.TabIndex = 61;
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(712, 17);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(60, 46);
            this.btnAgregar.TabIndex = 57;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.AutoSize = true;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.errorIcono.SetIconAlignment(this.btnQuitar, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(712, 70);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnQuitar.Size = new System.Drawing.Size(60, 55);
            this.btnQuitar.TabIndex = 56;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.Moccasin;
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Location = new System.Drawing.Point(491, 82);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(175, 22);
            this.txtPrecioVenta.TabIndex = 59;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Precio Venta";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.Moccasin;
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Location = new System.Drawing.Point(491, 38);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(175, 22);
            this.txtPrecioCompra.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 58;
            this.label7.Text = "Precio Compra";
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.BackColor = System.Drawing.Color.Moccasin;
            this.txtStockInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockInicial.Location = new System.Drawing.Point(99, 82);
            this.txtStockInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(197, 22);
            this.txtStockInicial.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Stock Inicial";
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.Moccasin;
            this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArticulo.Location = new System.Drawing.Point(99, 38);
            this.txtArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(197, 22);
            this.txtArticulo.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "ARTICULO";
            // 
            // txtidArticulo
            // 
            this.txtidArticulo.BackColor = System.Drawing.Color.Moccasin;
            this.txtidArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidArticulo.Location = new System.Drawing.Point(37, 52);
            this.txtidArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtidArticulo.Name = "txtidArticulo";
            this.txtidArticulo.Size = new System.Drawing.Size(54, 22);
            this.txtidArticulo.TabIndex = 55;
            // 
            // dtFechaIngreso
            // 
            this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaIngreso.Location = new System.Drawing.Point(313, 23);
            this.dtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaIngreso.Name = "dtFechaIngreso";
            this.dtFechaIngreso.Size = new System.Drawing.Size(125, 22);
            this.dtFechaIngreso.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "FECHA";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.errorIcono.SetIconAlignment(this.btnNuevo, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(596, 412);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNuevo.Size = new System.Drawing.Size(99, 33);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.Text = "&NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tbMantenimiento
            // 
            this.tbMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.tbMantenimiento.Controls.Add(this.groupBox1);
            this.tbMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tbMantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tbMantenimiento.Name = "tbMantenimiento";
            this.tbMantenimiento.Padding = new System.Windows.Forms.Padding(4);
            this.tbMantenimiento.Size = new System.Drawing.Size(972, 499);
            this.tbMantenimiento.TabIndex = 1;
            this.tbMantenimiento.Text = "MANTENIMIENTO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpListado);
            this.tabControl1.Controls.Add(this.tbMantenimiento);
            this.tabControl1.Location = new System.Drawing.Point(16, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 528);
            this.tabControl1.TabIndex = 14;
            // 
            // tpListado
            // 
            this.tpListado.Controls.Add(this.dtFechaFinal);
            this.tpListado.Controls.Add(this.label5);
            this.tpListado.Controls.Add(this.dtFechaInicio);
            this.tpListado.Controls.Add(this.lblTotalArticulos);
            this.tpListado.Controls.Add(this.chkEliminar);
            this.tpListado.Controls.Add(this.label8);
            this.tpListado.Controls.Add(this.btnEliminar);
            this.tpListado.Controls.Add(this.btnBuscar);
            this.tpListado.Controls.Add(this.dgIngreso);
            this.tpListado.Location = new System.Drawing.Point(4, 25);
            this.tpListado.Margin = new System.Windows.Forms.Padding(4);
            this.tpListado.Name = "tpListado";
            this.tpListado.Padding = new System.Windows.Forms.Padding(4);
            this.tpListado.Size = new System.Drawing.Size(972, 499);
            this.tpListado.TabIndex = 0;
            this.tpListado.Text = "LISTADO";
            this.tpListado.UseVisualStyleBackColor = true;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(292, 52);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(125, 22);
            this.dtFechaFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "FECHA FINAL";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(124, 52);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(125, 22);
            this.dtFechaInicio.TabIndex = 8;
            this.dtFechaInicio.Value = new System.DateTime(2017, 6, 2, 19, 45, 8, 0);
            // 
            // lblTotalArticulos
            // 
            this.lblTotalArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalArticulos.AutoSize = true;
            this.lblTotalArticulos.Location = new System.Drawing.Point(552, 119);
            this.lblTotalArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalArticulos.Name = "lblTotalArticulos";
            this.lblTotalArticulos.Size = new System.Drawing.Size(122, 17);
            this.lblTotalArticulos.TabIndex = 7;
            this.lblTotalArticulos.Text = "lblTotalCategorias";
            // 
            // chkEliminar
            // 
            this.chkEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(72, 119);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(71, 21);
            this.chkEliminar.TabIndex = 6;
            this.chkEliminar.Text = "Anular";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "FECHA INICIO";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Location = new System.Drawing.Point(573, 48);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(439, 48);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgIngreso
            // 
            this.dgIngreso.AllowUserToAddRows = false;
            this.dgIngreso.AllowUserToDeleteRows = false;
            this.dgIngreso.AllowUserToOrderColumns = true;
            this.dgIngreso.AutoGenerateColumns = false;
            this.dgIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.facidDataGridViewTextBoxColumn,
            this.facNumeroFacturaDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.facObservacionDataGridViewTextBoxColumn,
            this.facfechaDataGridViewTextBoxColumn});
            this.dgIngreso.DataSource = this.ventaMostrarBindingSource1;
            this.dgIngreso.Location = new System.Drawing.Point(8, 161);
            this.dgIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dgIngreso.MultiSelect = false;
            this.dgIngreso.Name = "dgIngreso";
            this.dgIngreso.ReadOnly = true;
            this.dgIngreso.RowHeadersWidth = 51;
            this.dgIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIngreso.Size = new System.Drawing.Size(939, 327);
            this.dgIngreso.TabIndex = 0;
            this.dgIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIngreso_CellContentClick);
            this.dgIngreso.DoubleClick += new System.EventHandler(this.dgIngreso_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "INGRESOS ALMACEN";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // MensajeAyuda
            // 
            this.MensajeAyuda.IsBalloon = true;
            // 
            // sISTEMA_DE_VENTASDataSet1
            // 
            this.sISTEMA_DE_VENTASDataSet1.DataSetName = "SISTEMA_DE_VENTASDataSet1";
            this.sISTEMA_DE_VENTASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sISTEMADEVENTASDataSet1BindingSource
            // 
            this.sISTEMADEVENTASDataSet1BindingSource.DataSource = this.sISTEMA_DE_VENTASDataSet1;
            this.sISTEMADEVENTASDataSet1BindingSource.Position = 0;
            // 
            // sISTEMA_DE_VENTASDataSet2
            // 
            this.sISTEMA_DE_VENTASDataSet2.DataSetName = "SISTEMA_DE_VENTASDataSet2";
            this.sISTEMA_DE_VENTASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioMostrarBindingSource
            // 
            this.servicioMostrarBindingSource.DataMember = "Servicio_Mostrar";
            this.servicioMostrarBindingSource.DataSource = this.sISTEMA_DE_VENTASDataSet2;
            // 
            // servicio_MostrarTableAdapter
            // 
            this.servicio_MostrarTableAdapter.ClearBeforeFill = true;
            // 
            // ventaMostrarBindingSource
            // 
            this.ventaMostrarBindingSource.DataMember = "Venta_Mostrar";
            this.ventaMostrarBindingSource.DataSource = this.sISTEMA_DE_VENTASDataSet2;
            // 
            // venta_MostrarTableAdapter
            // 
            this.venta_MostrarTableAdapter.ClearBeforeFill = true;
            // 
            // sISTEMA_DE_VENTASDataSet3
            // 
            this.sISTEMA_DE_VENTASDataSet3.DataSetName = "SISTEMA_DE_VENTASDataSet3";
            this.sISTEMA_DE_VENTASDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaMostrarBindingSource1
            // 
            this.ventaMostrarBindingSource1.DataMember = "Venta_Mostrar";
            this.ventaMostrarBindingSource1.DataSource = this.sISTEMA_DE_VENTASDataSet3;
            // 
            // venta_MostrarTableAdapter1
            // 
            this.venta_MostrarTableAdapter1.ClearBeforeFill = true;
            // 
            // facidDataGridViewTextBoxColumn
            // 
            this.facidDataGridViewTextBoxColumn.DataPropertyName = "Fac_id";
            this.facidDataGridViewTextBoxColumn.HeaderText = "Fac_id";
            this.facidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facidDataGridViewTextBoxColumn.Name = "facidDataGridViewTextBoxColumn";
            this.facidDataGridViewTextBoxColumn.ReadOnly = true;
            this.facidDataGridViewTextBoxColumn.Width = 125;
            // 
            // facNumeroFacturaDataGridViewTextBoxColumn
            // 
            this.facNumeroFacturaDataGridViewTextBoxColumn.DataPropertyName = "Fac_NumeroFactura";
            this.facNumeroFacturaDataGridViewTextBoxColumn.HeaderText = "Fac_NumeroFactura";
            this.facNumeroFacturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facNumeroFacturaDataGridViewTextBoxColumn.Name = "facNumeroFacturaDataGridViewTextBoxColumn";
            this.facNumeroFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.facNumeroFacturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.empleadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // facObservacionDataGridViewTextBoxColumn
            // 
            this.facObservacionDataGridViewTextBoxColumn.DataPropertyName = "Fac_Observacion";
            this.facObservacionDataGridViewTextBoxColumn.HeaderText = "Fac_Observacion";
            this.facObservacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facObservacionDataGridViewTextBoxColumn.Name = "facObservacionDataGridViewTextBoxColumn";
            this.facObservacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.facObservacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // facfechaDataGridViewTextBoxColumn
            // 
            this.facfechaDataGridViewTextBoxColumn.DataPropertyName = "Fac_fecha";
            this.facfechaDataGridViewTextBoxColumn.HeaderText = "Fac_fecha";
            this.facfechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facfechaDataGridViewTextBoxColumn.Name = "facfechaDataGridViewTextBoxColumn";
            this.facfechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.facfechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // FRMIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 633);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMIngreso";
            this.Text = "INGRESO ALMACEN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMIngreso_FormClosing);
            this.Load += new System.EventHandler(this.FRMIngreso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbMantenimiento.ResumeLayout(false);
            this.tbMantenimiento.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpListado.ResumeLayout(false);
            this.tpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_DE_VENTASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMADEVENTASDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_DE_VENTASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioMostrarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaMostrarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISTEMA_DE_VENTASDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaMostrarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip MensajeAyuda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtidArticulo;
        private System.Windows.Forms.DateTimePicker dtFechaIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpListado;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label lblTotalArticulos;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgIngreso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tbMantenimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sISTEMADEVENTASDataSet1BindingSource;
        private SISTEMA_DE_VENTASDataSet1 sISTEMA_DE_VENTASDataSet1;
        private SISTEMA_DE_VENTASDataSet2 sISTEMA_DE_VENTASDataSet2;
        private System.Windows.Forms.BindingSource servicioMostrarBindingSource;
        private SISTEMA_DE_VENTASDataSet2TableAdapters.Servicio_MostrarTableAdapter servicio_MostrarTableAdapter;
        private System.Windows.Forms.BindingSource ventaMostrarBindingSource;
        private SISTEMA_DE_VENTASDataSet2TableAdapters.Venta_MostrarTableAdapter venta_MostrarTableAdapter;
        private SISTEMA_DE_VENTASDataSet3 sISTEMA_DE_VENTASDataSet3;
        private System.Windows.Forms.BindingSource ventaMostrarBindingSource1;
        private SISTEMA_DE_VENTASDataSet3TableAdapters.Venta_MostrarTableAdapter venta_MostrarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facNumeroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facObservacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facfechaDataGridViewTextBoxColumn;
    }
}
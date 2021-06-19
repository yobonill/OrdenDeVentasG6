
namespace prj_Presentacion
{
    partial class Shop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbArticulos = new System.Windows.Forms.ComboBox();
            this.upDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Dg_Detalles = new System.Windows.Forms.DataGridView();
            this.ID_ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.BtnRegistrarFactura = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_descuento = new System.Windows.Forms.Label();
            this.txbDescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalGeneral = new System.Windows.Forms.Label();
            this.CbClientes = new System.Windows.Forms.ComboBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datSistema = new prj_Presentacion.DatSistema();
            this.label5 = new System.Windows.Forms.Label();
            this.personaTableAdapter = new prj_Presentacion.DatSistemaTableAdapters.personaTableAdapter();
            this.TxtItbis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ck_Itbis = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Ck_ncf = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(763, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Creado por el grupo 6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CbArticulos);
            this.groupBox1.Controls.Add(this.upDownCantidad);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(17, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(947, 58);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.AutoSize = true;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(577, 17);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(68, 31);
            this.txt_cantidad.TabIndex = 12;
            this.txt_cantidad.Text = "XXX";
            this.txt_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "EN EXISTENCIA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbArticulos
            // 
            this.CbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbArticulos.FormattingEnabled = true;
            this.CbArticulos.Location = new System.Drawing.Point(205, 21);
            this.CbArticulos.Name = "CbArticulos";
            this.CbArticulos.Size = new System.Drawing.Size(201, 24);
            this.CbArticulos.TabIndex = 10;
            this.CbArticulos.Text = "Seleccione un articulo";
            // 
            // upDownCantidad
            // 
            this.upDownCantidad.Location = new System.Drawing.Point(412, 22);
            this.upDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownCantidad.Name = "upDownCantidad";
            this.upDownCantidad.Size = new System.Drawing.Size(32, 22);
            this.upDownCantidad.TabIndex = 9;
            this.upDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregar.Enabled = false;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = global::prj_Presentacion.Properties.Resources.add_48;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(731, 19);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(124, 27);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "AÑADIR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "SELECCIONAR ARTICULOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dg_Detalles
            // 
            this.Dg_Detalles.AllowUserToAddRows = false;
            this.Dg_Detalles.AllowUserToDeleteRows = false;
            this.Dg_Detalles.AllowUserToOrderColumns = true;
            this.Dg_Detalles.AllowUserToResizeColumns = false;
            this.Dg_Detalles.AllowUserToResizeRows = false;
            this.Dg_Detalles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Detalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dg_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ARTICULO,
            this.DESC_PRODUCTO,
            this.CANTIDAD,
            this.PRECIO,
            this.TOTALS});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Detalles.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dg_Detalles.Location = new System.Drawing.Point(17, 187);
            this.Dg_Detalles.Margin = new System.Windows.Forms.Padding(2);
            this.Dg_Detalles.Name = "Dg_Detalles";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Detalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dg_Detalles.RowHeadersVisible = false;
            this.Dg_Detalles.RowHeadersWidth = 51;
            this.Dg_Detalles.RowTemplate.Height = 24;
            this.Dg_Detalles.Size = new System.Drawing.Size(947, 264);
            this.Dg_Detalles.TabIndex = 74;
            this.Dg_Detalles.AllowUserToDeleteRowsChanged += new System.EventHandler(this.Dg_Detalles_AllowUserToDeleteRowsChanged);
            this.Dg_Detalles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Detalles_CellDoubleClick);
            // 
            // ID_ARTICULO
            // 
            this.ID_ARTICULO.Frozen = true;
            this.ID_ARTICULO.HeaderText = "#REFERENCIA";
            this.ID_ARTICULO.Name = "ID_ARTICULO";
            // 
            // DESC_PRODUCTO
            // 
            this.DESC_PRODUCTO.Frozen = true;
            this.DESC_PRODUCTO.HeaderText = "PRODUCTO";
            this.DESC_PRODUCTO.Name = "DESC_PRODUCTO";
            this.DESC_PRODUCTO.Width = 500;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Frozen = true;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // PRECIO
            // 
            this.PRECIO.Frozen = true;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 175;
            // 
            // TOTALS
            // 
            this.TOTALS.Frozen = true;
            this.TOTALS.HeaderText = "TOTAL";
            this.TOTALS.Name = "TOTALS";
            this.TOTALS.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 52);
            this.label1.TabIndex = 73;
            this.label1.Text = "Venta de productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Sistema de Orden de Ventas";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Image = global::prj_Presentacion.Properties.Resources.backArrow_64;
            this.backButton.Location = new System.Drawing.Point(55, 52);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(62, 52);
            this.backButton.TabIndex = 72;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.BackColor = System.Drawing.Color.Black;
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.ForeColor = System.Drawing.Color.Black;
            this.logOutButton.Image = global::prj_Presentacion.Properties.Resources.logout_32;
            this.logOutButton.Location = new System.Drawing.Point(926, 3);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(49, 37);
            this.logOutButton.TabIndex = 71;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // BtnRegistrarFactura
            // 
            this.BtnRegistrarFactura.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnRegistrarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarFactura.Enabled = false;
            this.BtnRegistrarFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.BtnRegistrarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnRegistrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarFactura.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarFactura.Image = global::prj_Presentacion.Properties.Resources.save_48;
            this.BtnRegistrarFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegistrarFactura.Location = new System.Drawing.Point(300, 463);
            this.BtnRegistrarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrarFactura.Name = "BtnRegistrarFactura";
            this.BtnRegistrarFactura.Size = new System.Drawing.Size(390, 63);
            this.BtnRegistrarFactura.TabIndex = 78;
            this.BtnRegistrarFactura.Text = "GUARDAR FACTURA";
            this.BtnRegistrarFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistrarFactura.UseVisualStyleBackColor = false;
            this.BtnRegistrarFactura.Click += new System.EventHandler(this.BtnRegistrarFactura_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackColor = System.Drawing.Color.Black;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Image = global::prj_Presentacion.Properties.Resources.settings_32;
            this.settingsButton.Location = new System.Drawing.Point(863, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(46, 37);
            this.settingsButton.TabIndex = 79;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 539);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(987, 37);
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(987, 46);
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // txt_descuento
            // 
            this.txt_descuento.AutoSize = true;
            this.txt_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descuento.Location = new System.Drawing.Point(58, 466);
            this.txt_descuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(94, 17);
            this.txt_descuento.TabIndex = 13;
            this.txt_descuento.Text = "DESCUENTO";
            this.txt_descuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbDescuento
            // 
            this.txbDescuento.Location = new System.Drawing.Point(156, 464);
            this.txbDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txbDescuento.Name = "txbDescuento";
            this.txbDescuento.Size = new System.Drawing.Size(106, 22);
            this.txbDescuento.TabIndex = 82;
            this.txbDescuento.Leave += new System.EventHandler(this.txbDescuento_Leave_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(745, 514);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "TOTAL GENERAL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.AutoSize = true;
            this.txtTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGeneral.Location = new System.Drawing.Point(863, 510);
            this.txtTotalGeneral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.Size = new System.Drawing.Size(54, 25);
            this.txtTotalGeneral.TabIndex = 13;
            this.txtTotalGeneral.Text = "XXX";
            this.txtTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbClientes
            // 
            this.CbClientes.DataSource = this.personaBindingSource;
            this.CbClientes.DisplayMember = "nombre";
            this.CbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbClientes.FormattingEnabled = true;
            this.CbClientes.Location = new System.Drawing.Point(125, 492);
            this.CbClientes.Name = "CbClientes";
            this.CbClientes.Size = new System.Drawing.Size(137, 24);
            this.CbClientes.TabIndex = 14;
            this.CbClientes.ValueMember = "idpersona";
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "persona";
            this.personaBindingSource.DataSource = this.datSistema;
            // 
            // datSistema
            // 
            this.datSistema.DataSetName = "DatSistema";
            this.datSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 495);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "CLIENTE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // TxtItbis
            // 
            this.TxtItbis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtItbis.Location = new System.Drawing.Point(819, 485);
            this.TxtItbis.Name = "TxtItbis";
            this.TxtItbis.ReadOnly = true;
            this.TxtItbis.Size = new System.Drawing.Size(116, 22);
            this.TxtItbis.TabIndex = 363;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(747, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 362;
            this.label7.Text = "ITBIS";
            // 
            // Ck_Itbis
            // 
            this.Ck_Itbis.AutoSize = true;
            this.Ck_Itbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_Itbis.Location = new System.Drawing.Point(797, 489);
            this.Ck_Itbis.Name = "Ck_Itbis";
            this.Ck_Itbis.Size = new System.Drawing.Size(15, 14);
            this.Ck_Itbis.TabIndex = 361;
            this.Ck_Itbis.UseVisualStyleBackColor = true;
            this.Ck_Itbis.CheckedChanged += new System.EventHandler(this.Ck_Itbis_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(747, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 365;
            this.label9.Text = "NCF";
            // 
            // Ck_ncf
            // 
            this.Ck_ncf.AutoSize = true;
            this.Ck_ncf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ck_ncf.Location = new System.Drawing.Point(797, 465);
            this.Ck_ncf.Name = "Ck_ncf";
            this.Ck_ncf.Size = new System.Drawing.Size(15, 14);
            this.Ck_ncf.TabIndex = 364;
            this.Ck_ncf.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(297, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 366;
            this.label10.Text = "Doble click en registro para eliminarlo";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 576);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Ck_ncf);
            this.Controls.Add(this.TxtItbis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ck_Itbis);
            this.Controls.Add(this.CbClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalGeneral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbDescuento);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.BtnRegistrarFactura);
            this.Controls.Add(this.Dg_Detalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbArticulos;
        private System.Windows.Forms.NumericUpDown upDownCantidad;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button BtnRegistrarFactura;
        private System.Windows.Forms.DataGridView Dg_Detalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_cantidad;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALS;
        private System.Windows.Forms.Label txt_descuento;
        private System.Windows.Forms.TextBox txbDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotalGeneral;
        private System.Windows.Forms.ComboBox CbClientes;
        private System.Windows.Forms.Label label5;
        private DatSistema datSistema;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private DatSistemaTableAdapters.personaTableAdapter personaTableAdapter;
        internal System.Windows.Forms.TextBox TxtItbis;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.CheckBox Ck_Itbis;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.CheckBox Ck_ncf;
        private System.Windows.Forms.Label label10;
    }
}
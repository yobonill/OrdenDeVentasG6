
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BtnTipo = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_descuento = new System.Windows.Forms.Label();
            this.txb_descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalGeneral = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // 
            // upDownCantidad
            // 
            this.upDownCantidad.Location = new System.Drawing.Point(412, 24);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Detalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ARTICULO,
            this.DESC_PRODUCTO,
            this.CANTIDAD,
            this.PRECIO,
            this.TOTALS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dg_Detalles.Location = new System.Drawing.Point(17, 187);
            this.Dg_Detalles.Margin = new System.Windows.Forms.Padding(2);
            this.Dg_Detalles.Name = "Dg_Detalles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Detalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg_Detalles.RowHeadersVisible = false;
            this.Dg_Detalles.RowHeadersWidth = 51;
            this.Dg_Detalles.RowTemplate.Height = 24;
            this.Dg_Detalles.Size = new System.Drawing.Size(947, 264);
            this.Dg_Detalles.TabIndex = 74;
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
            // BtnTipo
            // 
            this.BtnTipo.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.BtnTipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTipo.ForeColor = System.Drawing.Color.White;
            this.BtnTipo.Image = global::prj_Presentacion.Properties.Resources.save_48;
            this.BtnTipo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTipo.Location = new System.Drawing.Point(300, 471);
            this.BtnTipo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTipo.Name = "BtnTipo";
            this.BtnTipo.Size = new System.Drawing.Size(390, 63);
            this.BtnTipo.TabIndex = 78;
            this.BtnTipo.Text = "GUARDAR";
            this.BtnTipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnTipo.UseVisualStyleBackColor = false;
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
            this.txt_descuento.Location = new System.Drawing.Point(76, 466);
            this.txt_descuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(94, 17);
            this.txt_descuento.TabIndex = 13;
            this.txt_descuento.Text = "DESCUENTO";
            this.txt_descuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_descuento
            // 
            this.txb_descuento.Location = new System.Drawing.Point(174, 464);
            this.txb_descuento.Margin = new System.Windows.Forms.Padding(2);
            this.txb_descuento.Name = "txb_descuento";
            this.txb_descuento.Size = new System.Drawing.Size(88, 22);
            this.txb_descuento.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(747, 461);
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
            this.txtTotalGeneral.Location = new System.Drawing.Point(865, 457);
            this.txtTotalGeneral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.Size = new System.Drawing.Size(54, 25);
            this.txtTotalGeneral.TabIndex = 13;
            this.txtTotalGeneral.Text = "XXX";
            this.txtTotalGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 576);
            this.Controls.Add(this.txtTotalGeneral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_descuento);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.BtnTipo);
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
        private System.Windows.Forms.Button BtnTipo;
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
        private System.Windows.Forms.TextBox txb_descuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotalGeneral;
    }
}
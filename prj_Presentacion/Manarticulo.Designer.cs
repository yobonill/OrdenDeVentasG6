
namespace prj_Presentacion
{
    partial class Manarticulo
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
            System.Windows.Forms.Label idarticuloLabel;
            System.Windows.Forms.Label idcategoriaLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label precio_ventaLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            this.datUsuario = new prj_Presentacion.DatUsuario();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new prj_Presentacion.DatUsuarioTableAdapters.articuloTableAdapter();
            this.tableAdapterManager = new prj_Presentacion.DatUsuarioTableAdapters.TableAdapterManager();
            this.idarticuloTextBox = new System.Windows.Forms.TextBox();
            this.idcategoriaTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precio_ventaTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNGuardar = new System.Windows.Forms.ToolStripButton();
            this.BTNLimpiar = new System.Windows.Forms.ToolStripButton();
            this.BTNEliminar = new System.Windows.Forms.ToolStripButton();
            this.BTNAyuda = new System.Windows.Forms.ToolStripButton();
            this.BTNSalir = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            idarticuloLabel = new System.Windows.Forms.Label();
            idcategoriaLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            precio_ventaLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idarticuloLabel
            // 
            idarticuloLabel.AutoSize = true;
            idarticuloLabel.Location = new System.Drawing.Point(36, 50);
            idarticuloLabel.Name = "idarticuloLabel";
            idarticuloLabel.Size = new System.Drawing.Size(52, 13);
            idarticuloLabel.TabIndex = 1;
            idarticuloLabel.Text = "idarticulo:";
            // 
            // idcategoriaLabel
            // 
            idcategoriaLabel.AutoSize = true;
            idcategoriaLabel.Location = new System.Drawing.Point(36, 76);
            idcategoriaLabel.Name = "idcategoriaLabel";
            idcategoriaLabel.Size = new System.Drawing.Size(62, 13);
            idcategoriaLabel.TabIndex = 3;
            idcategoriaLabel.Text = "idcategoria:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(36, 102);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(42, 13);
            codigoLabel.TabIndex = 5;
            codigoLabel.Text = "codigo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(36, 128);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "nombre:";
            // 
            // precio_ventaLabel
            // 
            precio_ventaLabel.AutoSize = true;
            precio_ventaLabel.Location = new System.Drawing.Point(36, 154);
            precio_ventaLabel.Name = "precio_ventaLabel";
            precio_ventaLabel.Size = new System.Drawing.Size(69, 13);
            precio_ventaLabel.TabIndex = 9;
            precio_ventaLabel.Text = "precio venta:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(36, 180);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 11;
            stockLabel.Text = "stock:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(36, 206);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 13;
            descripcionLabel.Text = "descripcion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(36, 234);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(42, 13);
            estadoLabel.TabIndex = 15;
            estadoLabel.Text = "estado:";
            // 
            // datUsuario
            // 
            this.datUsuario.DataSetName = "DatUsuario";
            this.datUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "articulo";
            this.articuloBindingSource.DataSource = this.datUsuario;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articuloTableAdapter = this.articuloTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.personaTableAdapter = null;
            this.tableAdapterManager.rolTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prj_Presentacion.DatUsuarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // idarticuloTextBox
            // 
            this.idarticuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "idarticulo", true));
            this.idarticuloTextBox.Location = new System.Drawing.Point(111, 47);
            this.idarticuloTextBox.Name = "idarticuloTextBox";
            this.idarticuloTextBox.Size = new System.Drawing.Size(104, 20);
            this.idarticuloTextBox.TabIndex = 2;
            this.idarticuloTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idarticuloTextBox_KeyPress);
            // 
            // idcategoriaTextBox
            // 
            this.idcategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "idcategoria", true));
            this.idcategoriaTextBox.Location = new System.Drawing.Point(111, 73);
            this.idcategoriaTextBox.Name = "idcategoriaTextBox";
            this.idcategoriaTextBox.Size = new System.Drawing.Size(104, 20);
            this.idcategoriaTextBox.TabIndex = 4;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(111, 99);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(104, 20);
            this.codigoTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(111, 125);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // precio_ventaTextBox
            // 
            this.precio_ventaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "precio_venta", true));
            this.precio_ventaTextBox.Location = new System.Drawing.Point(111, 151);
            this.precio_ventaTextBox.Name = "precio_ventaTextBox";
            this.precio_ventaTextBox.Size = new System.Drawing.Size(104, 20);
            this.precio_ventaTextBox.TabIndex = 10;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(111, 177);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(104, 20);
            this.stockTextBox.TabIndex = 12;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articuloBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(111, 203);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(104, 20);
            this.descripcionTextBox.TabIndex = 14;
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.articuloBindingSource, "estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(111, 229);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoCheckBox.TabIndex = 16;
            this.estadoCheckBox.Text = "checkBox1";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNGuardar,
            this.BTNLimpiar,
            this.BTNEliminar,
            this.BTNAyuda,
            this.BTNSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(313, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNGuardar.Image = global::prj_Presentacion.Properties.Resources.save_48px;
            this.BTNGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(23, 22);
            this.BTNGuardar.Text = "toolStripButton1";
            this.BTNGuardar.ToolTipText = "Guardar";
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNLimpiar.Image = global::prj_Presentacion.Properties.Resources.broom_80px;
            this.BTNLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(23, 22);
            this.BTNLimpiar.Text = "toolStripButton2";
            this.BTNLimpiar.ToolTipText = "Limpiar";
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNEliminar.Image = global::prj_Presentacion.Properties.Resources.delete_96px;
            this.BTNEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(23, 22);
            this.BTNEliminar.Text = "toolStripButton3";
            this.BTNEliminar.ToolTipText = "Eliminar";
            this.BTNEliminar.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // BTNAyuda
            // 
            this.BTNAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNAyuda.Image = global::prj_Presentacion.Properties.Resources.help_48px;
            this.BTNAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNAyuda.Name = "BTNAyuda";
            this.BTNAyuda.Size = new System.Drawing.Size(23, 22);
            this.BTNAyuda.Text = "toolStripButton4";
            this.BTNAyuda.ToolTipText = "Ayuda";
            this.BTNAyuda.Click += new System.EventHandler(this.BTNAyuda_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNSalir.Image = global::prj_Presentacion.Properties.Resources.logout_32;
            this.BTNSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(23, 22);
            this.BTNSalir.Text = "toolStripButton5";
            this.BTNSalir.ToolTipText = "Salir";
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Manarticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(idarticuloLabel);
            this.Controls.Add(this.idarticuloTextBox);
            this.Controls.Add(idcategoriaLabel);
            this.Controls.Add(this.idcategoriaTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(precio_ventaLabel);
            this.Controls.Add(this.precio_ventaTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoCheckBox);
            this.Name = "Manarticulo";
            this.Text = "Manarticulo";
            this.Load += new System.EventHandler(this.Manarticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatUsuario datUsuario;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private DatUsuarioTableAdapters.articuloTableAdapter articuloTableAdapter;
        private DatUsuarioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idarticuloTextBox;
        private System.Windows.Forms.TextBox idcategoriaTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precio_ventaTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNGuardar;
        private System.Windows.Forms.ToolStripButton BTNLimpiar;
        private System.Windows.Forms.ToolStripButton BTNEliminar;
        private System.Windows.Forms.ToolStripButton BTNAyuda;
        private System.Windows.Forms.ToolStripButton BTNSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

namespace prj_Presentacion
{
    partial class Mancategoria
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
            System.Windows.Forms.Label idcategoriaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            this.datUsuario = new prj_Presentacion.DatUsuario();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new prj_Presentacion.DatUsuarioTableAdapters.categoriaTableAdapter();
            this.tableAdapterManager = new prj_Presentacion.DatUsuarioTableAdapters.TableAdapterManager();
            this.idcategoriaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNGuardar = new System.Windows.Forms.ToolStripButton();
            this.BTNLimpiar = new System.Windows.Forms.ToolStripButton();
            this.BTNEliminar = new System.Windows.Forms.ToolStripButton();
            this.BTNAyuda = new System.Windows.Forms.ToolStripButton();
            this.BTNSalir = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            idcategoriaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idcategoriaLabel
            // 
            idcategoriaLabel.AutoSize = true;
            idcategoriaLabel.Location = new System.Drawing.Point(23, 58);
            idcategoriaLabel.Name = "idcategoriaLabel";
            idcategoriaLabel.Size = new System.Drawing.Size(62, 13);
            idcategoriaLabel.TabIndex = 1;
            idcategoriaLabel.Text = "idcategoria:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(23, 84);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(23, 110);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(64, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "descripcion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(23, 138);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(42, 13);
            estadoLabel.TabIndex = 7;
            estadoLabel.Text = "estado:";
            // 
            // datUsuario
            // 
            this.datUsuario.DataSetName = "DatUsuario";
            this.datUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.datUsuario;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articuloTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.personaTableAdapter = null;
            this.tableAdapterManager.rolTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prj_Presentacion.DatUsuarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // idcategoriaTextBox
            // 
            this.idcategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "idcategoria", true));
            this.idcategoriaTextBox.Location = new System.Drawing.Point(93, 55);
            this.idcategoriaTextBox.Name = "idcategoriaTextBox";
            this.idcategoriaTextBox.Size = new System.Drawing.Size(104, 20);
            this.idcategoriaTextBox.TabIndex = 2;
            this.idcategoriaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idcategoriaTextBox_KeyPress);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(93, 81);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(93, 107);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(104, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.categoriaBindingSource, "estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(93, 133);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoCheckBox.TabIndex = 8;
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 9;
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
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNAyuda
            // 
            this.BTNAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNAyuda.Image = global::prj_Presentacion.Properties.Resources.help_48px;
            this.BTNAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNAyuda.Name = "BTNAyuda";
            this.BTNAyuda.Size = new System.Drawing.Size(23, 22);
            this.BTNAyuda.Text = "toolStripButton4";
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
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Mancategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(idcategoriaLabel);
            this.Controls.Add(this.idcategoriaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoCheckBox);
            this.Name = "Mancategoria";
            this.Text = "Mancategoria";
            this.Load += new System.EventHandler(this.Mancategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatUsuario datUsuario;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DatUsuarioTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private DatUsuarioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idcategoriaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNGuardar;
        private System.Windows.Forms.ToolStripButton BTNLimpiar;
        private System.Windows.Forms.ToolStripButton BTNEliminar;
        private System.Windows.Forms.ToolStripButton BTNAyuda;
        private System.Windows.Forms.ToolStripButton BTNSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

namespace prj_Presentacion
{
    partial class MantPersona
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
            System.Windows.Forms.Label idpersonaLabel;
            System.Windows.Forms.Label tipo_personaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tipo_documentoLabel;
            System.Windows.Forms.Label num_documentoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantPersona));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idpersonaTextBox = new System.Windows.Forms.TextBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datUsuario = new prj_Presentacion.DatUsuario();
            this.tipo_personaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tipo_documentoTextBox = new System.Windows.Forms.TextBox();
            this.num_documentoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.personaTableAdapter = new prj_Presentacion.DatUsuarioTableAdapters.personaTableAdapter();
            this.tableAdapterManager = new prj_Presentacion.DatUsuarioTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.BtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.BtnAyuda = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.LblMensaje = new System.Windows.Forms.Label();
            idpersonaLabel = new System.Windows.Forms.Label();
            tipo_personaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            tipo_documentoLabel = new System.Windows.Forms.Label();
            num_documentoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idpersonaLabel
            // 
            idpersonaLabel.AutoSize = true;
            idpersonaLabel.Location = new System.Drawing.Point(27, 71);
            idpersonaLabel.Name = "idpersonaLabel";
            idpersonaLabel.Size = new System.Drawing.Size(75, 17);
            idpersonaLabel.TabIndex = 17;
            idpersonaLabel.Text = "idpersona:";
            // 
            // tipo_personaLabel
            // 
            tipo_personaLabel.AutoSize = true;
            tipo_personaLabel.Location = new System.Drawing.Point(27, 99);
            tipo_personaLabel.Name = "tipo_personaLabel";
            tipo_personaLabel.Size = new System.Drawing.Size(91, 17);
            tipo_personaLabel.TabIndex = 19;
            tipo_personaLabel.Text = "tipo persona:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(27, 127);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "nombre:";
            // 
            // tipo_documentoLabel
            // 
            tipo_documentoLabel.AutoSize = true;
            tipo_documentoLabel.Location = new System.Drawing.Point(27, 155);
            tipo_documentoLabel.Name = "tipo_documentoLabel";
            tipo_documentoLabel.Size = new System.Drawing.Size(109, 17);
            tipo_documentoLabel.TabIndex = 23;
            tipo_documentoLabel.Text = "tipo documento:";
            // 
            // num_documentoLabel
            // 
            num_documentoLabel.AutoSize = true;
            num_documentoLabel.Location = new System.Drawing.Point(27, 183);
            num_documentoLabel.Name = "num_documentoLabel";
            num_documentoLabel.Size = new System.Drawing.Size(113, 17);
            num_documentoLabel.TabIndex = 25;
            num_documentoLabel.Text = "num documento:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(27, 211);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(69, 17);
            direccionLabel.TabIndex = 27;
            direccionLabel.Text = "direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(27, 239);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(63, 17);
            telefonoLabel.TabIndex = 29;
            telefonoLabel.Text = "telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(27, 267);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 17);
            emailLabel.TabIndex = 31;
            emailLabel.Text = "email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idpersonaLabel);
            this.groupBox1.Controls.Add(this.idpersonaTextBox);
            this.groupBox1.Controls.Add(tipo_personaLabel);
            this.groupBox1.Controls.Add(this.tipo_personaTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(tipo_documentoLabel);
            this.groupBox1.Controls.Add(this.tipo_documentoTextBox);
            this.groupBox1.Controls.Add(num_documentoLabel);
            this.groupBox1.Controls.Add(this.num_documentoTextBox);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Location = new System.Drawing.Point(54, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 334);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // idpersonaTextBox
            // 
            this.idpersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "idpersona", true));
            this.idpersonaTextBox.Location = new System.Drawing.Point(146, 68);
            this.idpersonaTextBox.Name = "idpersonaTextBox";
            this.idpersonaTextBox.Size = new System.Drawing.Size(191, 22);
            this.idpersonaTextBox.TabIndex = 18;
            this.idpersonaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idpersonaTextBox_KeyPress);
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "persona";
            this.personaBindingSource.DataSource = this.datUsuario;
            // 
            // datUsuario
            // 
            this.datUsuario.DataSetName = "DatUsuario";
            this.datUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_personaTextBox
            // 
            this.tipo_personaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "tipo_persona", true));
            this.tipo_personaTextBox.Location = new System.Drawing.Point(146, 96);
            this.tipo_personaTextBox.Name = "tipo_personaTextBox";
            this.tipo_personaTextBox.Size = new System.Drawing.Size(191, 22);
            this.tipo_personaTextBox.TabIndex = 20;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(146, 124);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(191, 22);
            this.nombreTextBox.TabIndex = 22;
            // 
            // tipo_documentoTextBox
            // 
            this.tipo_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "tipo_documento", true));
            this.tipo_documentoTextBox.Location = new System.Drawing.Point(146, 152);
            this.tipo_documentoTextBox.Name = "tipo_documentoTextBox";
            this.tipo_documentoTextBox.Size = new System.Drawing.Size(191, 22);
            this.tipo_documentoTextBox.TabIndex = 24;
            // 
            // num_documentoTextBox
            // 
            this.num_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "num_documento", true));
            this.num_documentoTextBox.Location = new System.Drawing.Point(146, 180);
            this.num_documentoTextBox.Name = "num_documentoTextBox";
            this.num_documentoTextBox.Size = new System.Drawing.Size(191, 22);
            this.num_documentoTextBox.TabIndex = 26;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(146, 208);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(191, 22);
            this.direccionTextBox.TabIndex = 28;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(146, 236);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(191, 22);
            this.telefonoTextBox.TabIndex = 30;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(146, 264);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(191, 22);
            this.emailTextBox.TabIndex = 32;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.personaTableAdapter = this.personaTableAdapter;
            this.tableAdapterManager.rolTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prj_Presentacion.DatUsuarioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardar,
            this.BtnLimpiar,
            this.BtnEliminar,
            this.toolStripButton4,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.BtnAyuda,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(512, 27);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnGuardar.Image = global::prj_Presentacion.Properties.Resources.save_48px;
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(29, 24);
            this.BtnGuardar.Text = "toolStripButton1";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnLimpiar.Image = global::prj_Presentacion.Properties.Resources.broom_80px;
            this.BtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(29, 24);
            this.BtnLimpiar.Text = "toolStripButton2";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEliminar.Image = global::prj_Presentacion.Properties.Resources.delete_96px;
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(29, 24);
            this.BtnEliminar.Text = "toolStripButton3";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::prj_Presentacion.Properties.Resources.print_52px;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 24);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(147, 24);
            this.toolStripLabel2.Text = "toolStripLabel2         ";
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyuda.Image")));
            this.BtnAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(29, 24);
            this.BtnAyuda.Text = "toolStripButton5";
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::prj_Presentacion.Properties.Resources.logout_32;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.Location = new System.Drawing.Point(144, 36);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(153, 25);
            this.LblMensaje.TabIndex = 19;
            this.LblMensaje.Text = "Mantenimiento";
            // 
            // MantPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 470);
            this.ControlBox = false;
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantPersona";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantPersona";
            this.Load += new System.EventHandler(this.MantPersona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatUsuario datUsuario;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private DatUsuarioTableAdapters.personaTableAdapter personaTableAdapter;
        private DatUsuarioTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idpersonaTextBox;
        private System.Windows.Forms.TextBox tipo_personaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox tipo_documentoTextBox;
        private System.Windows.Forms.TextBox num_documentoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.ToolStripButton BtnLimpiar;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton BtnAyuda;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}
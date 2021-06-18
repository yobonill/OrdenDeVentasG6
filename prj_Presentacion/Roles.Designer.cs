namespace prj_Presentacion
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.Tmr2click = new System.Windows.Forms.Timer(this.components);
            this.Lbltotal = new System.Windows.Forms.Label();
            this.TmrMensaje = new System.Windows.Forms.Timer(this.components);
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtdescripcion = new System.Windows.Forms.TextBox();
            this.Txtidrol = new System.Windows.Forms.TextBox();
            this.datalistadorol = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblHora2 = new System.Windows.Forms.Label();
            this.LblFecha2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadorol)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmr2click
            // 
            this.Tmr2click.Enabled = true;
            this.Tmr2click.Interval = 300;
            this.Tmr2click.Tick += new System.EventHandler(this.Tmr2click_Tick_1);
            // 
            // Lbltotal
            // 
            this.Lbltotal.AutoSize = true;
            this.Lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltotal.ForeColor = System.Drawing.Color.OrangeRed;
            this.Lbltotal.Location = new System.Drawing.Point(927, 621);
            this.Lbltotal.Name = "Lbltotal";
            this.Lbltotal.Size = new System.Drawing.Size(49, 20);
            this.Lbltotal.TabIndex = 84;
            this.Lbltotal.Text = "0000";
            // 
            // TmrMensaje
            // 
            this.TmrMensaje.Enabled = true;
            this.TmrMensaje.Tick += new System.EventHandler(this.TmrMensaje_Tick);
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.Black;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHora.Location = new System.Drawing.Point(895, 19);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(50, 20);
            this.LblHora.TabIndex = 83;
            this.LblHora.Text = "Hora";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Black;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFecha.Location = new System.Drawing.Point(1003, 18);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(114, 20);
            this.LblFecha.TabIndex = 82;
            this.LblFecha.Text = "Fecha larga ";
            // 
            // TmrHora
            // 
            this.TmrHora.Enabled = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 622);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "Doble click para seleccionar registro";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Black;
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblUsuario.Location = new System.Drawing.Point(61, 675);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(64, 17);
            this.LblUsuario.TabIndex = 81;
            this.LblUsuario.Text = "Logeado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(724, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Registros Cargados:";
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(554, 28);
            this.Txtnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(101, 22);
            this.Txtnombre.TabIndex = 7;
            this.toolTip1.SetToolTip(this.Txtnombre, "Ingrese registro a filtrar");
            this.Txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombre_KeyPress_1);
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.Location = new System.Drawing.Point(840, 27);
            this.Txtdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(263, 22);
            this.Txtdescripcion.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Txtdescripcion, "Ingrese registro a filtrar");
            this.Txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdescripcion_KeyPress_1);
            // 
            // Txtidrol
            // 
            this.Txtidrol.Location = new System.Drawing.Point(307, 27);
            this.Txtidrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txtidrol.Name = "Txtidrol";
            this.Txtidrol.Size = new System.Drawing.Size(101, 22);
            this.Txtidrol.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Txtidrol, "Ingrese registro a filtrar");
            this.Txtidrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtidrol_KeyPress_1);
            // 
            // datalistadorol
            // 
            this.datalistadorol.AllowUserToAddRows = false;
            this.datalistadorol.AllowUserToDeleteRows = false;
            this.datalistadorol.AllowUserToOrderColumns = true;
            this.datalistadorol.AllowUserToResizeColumns = false;
            this.datalistadorol.AllowUserToResizeRows = false;
            this.datalistadorol.BackgroundColor = System.Drawing.Color.White;
            this.datalistadorol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadorol.Location = new System.Drawing.Point(221, 230);
            this.datalistadorol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datalistadorol.Name = "datalistadorol";
            this.datalistadorol.RowHeadersVisible = false;
            this.datalistadorol.RowHeadersWidth = 51;
            this.datalistadorol.RowTemplate.Height = 24;
            this.datalistadorol.Size = new System.Drawing.Size(771, 375);
            this.datalistadorol.TabIndex = 73;
            this.toolTip1.SetToolTip(this.datalistadorol, "Tabla de usuarios");
            this.datalistadorol.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datalistadorol_CellMouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::prj_Presentacion.Properties.Resources.logout_32;
            this.button2.Location = new System.Drawing.Point(1219, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 46);
            this.button2.TabIndex = 89;
            this.toolTip1.SetToolTip(this.button2, "Cerrar ventana");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.BackColor = System.Drawing.Color.Black;
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.ForeColor = System.Drawing.Color.Black;
            this.Cerrar.Image = global::prj_Presentacion.Properties.Resources.logout_32;
            this.Cerrar.Location = new System.Drawing.Point(1235, 4);
            this.Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(65, 46);
            this.Cerrar.TabIndex = 79;
            this.toolTip1.SetToolTip(this.Cerrar, "Cerrar ventana");
            this.Cerrar.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Image = global::prj_Presentacion.Properties.Resources.addUser_64;
            this.BtnNuevo.Location = new System.Drawing.Point(1090, 270);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(91, 78);
            this.BtnNuevo.TabIndex = 76;
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnNuevo, "Ingresar nuevo registro");
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Image = global::prj_Presentacion.Properties.Resources.editUser_64;
            this.BtnEditar.Location = new System.Drawing.Point(1091, 400);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(91, 78);
            this.BtnEditar.TabIndex = 77;
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnEditar, " Editar registro");
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // backButton2
            // 
            this.backButton2.BackColor = System.Drawing.Color.Transparent;
            this.backButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton2.FlatAppearance.BorderSize = 0;
            this.backButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.backButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.backButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton2.ForeColor = System.Drawing.Color.Black;
            this.backButton2.Image = global::prj_Presentacion.Properties.Resources.backArrow_64;
            this.backButton2.Location = new System.Drawing.Point(73, 75);
            this.backButton2.Margin = new System.Windows.Forms.Padding(4);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(83, 64);
            this.backButton2.TabIndex = 75;
            this.toolTip1.SetToolTip(this.backButton2, "Volver atras");
            this.backButton2.UseVisualStyleBackColor = false;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Image = global::prj_Presentacion.Properties.Resources.brush_32;
            this.BtnLimpiar.Location = new System.Drawing.Point(1208, 21);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(49, 33);
            this.BtnLimpiar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.BtnLimpiar, "Limpiar campos");
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Image = global::prj_Presentacion.Properties.Resources.search_32;
            this.BtnBuscar.Location = new System.Drawing.Point(1141, 21);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(49, 33);
            this.BtnBuscar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.BtnBuscar, "Buscar filtro");
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_2);
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
            this.backButton.Location = new System.Drawing.Point(73, 64);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 64);
            this.backButton.TabIndex = 71;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filtrar roles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "NOMBRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "DESCRIPCION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID ROL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.Txtnombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txtdescripcion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txtidrol);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(23, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1263, 71);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 63);
            this.label1.TabIndex = 72;
            this.label1.Text = "Configuración de roles";
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
            this.logOutButton.Location = new System.Drawing.Point(1235, 4);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(65, 46);
            this.logOutButton.TabIndex = 70;
            this.logOutButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(1017, 672);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 29);
            this.label2.TabIndex = 69;
            this.label2.Text = "Creado por el grupo 6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Sistema de Orden de Ventas";
            // 
            // LblHora2
            // 
            this.LblHora2.AutoSize = true;
            this.LblHora2.BackColor = System.Drawing.Color.Black;
            this.LblHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHora2.Location = new System.Drawing.Point(848, 19);
            this.LblHora2.Name = "LblHora2";
            this.LblHora2.Size = new System.Drawing.Size(50, 20);
            this.LblHora2.TabIndex = 88;
            this.LblHora2.Text = "Hora";
            // 
            // LblFecha2
            // 
            this.LblFecha2.AutoSize = true;
            this.LblFecha2.BackColor = System.Drawing.Color.Black;
            this.LblFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFecha2.Location = new System.Drawing.Point(967, 18);
            this.LblFecha2.Name = "LblFecha2";
            this.LblFecha2.Size = new System.Drawing.Size(114, 20);
            this.LblFecha2.TabIndex = 87;
            this.LblFecha2.Text = "Fecha larga ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(18, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(338, 29);
            this.label12.TabIndex = 86;
            this.label12.Text = "Sistema de Orden de Ventas";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(1018, 671);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(257, 29);
            this.label13.TabIndex = 90;
            this.label13.Text = "Creado por el grupo 6";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 663);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1316, 46);
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1316, 57);
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 709);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LblHora2);
            this.Controls.Add(this.LblFecha2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Lbltotal);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datalistadorol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistadorol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tmr2click;
        private System.Windows.Forms.Label Lbltotal;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer TmrMensaje;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer TmrHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.TextBox Txtdescripcion;
        private System.Windows.Forms.TextBox Txtidrol;
        private System.Windows.Forms.DataGridView datalistadorol;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblHora2;
        private System.Windows.Forms.Label LblFecha2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
    }
}
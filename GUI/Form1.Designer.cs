namespace GUI
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.VerContactos = new System.Windows.Forms.Button();
            this.AñadirContacto = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.texBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelFondo.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(104, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(331, 38);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Agenda de Contactos";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Blue;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(56, 75);
            this.BtnMenu.TabIndex = 3;
            this.BtnMenu.Text = "☰";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.panelMenu.Controls.Add(this.VerContactos);
            this.panelMenu.Controls.Add(this.AñadirContacto);
            this.panelMenu.Controls.Add(this.Inicio);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 75);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(172, 679);
            this.panelMenu.TabIndex = 1;
            // 
            // VerContactos
            // 
            this.VerContactos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.VerContactos.FlatAppearance.BorderSize = 0;
            this.VerContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerContactos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerContactos.ForeColor = System.Drawing.Color.White;
            this.VerContactos.Location = new System.Drawing.Point(0, 144);
            this.VerContactos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VerContactos.Name = "VerContactos";
            this.VerContactos.Size = new System.Drawing.Size(161, 48);
            this.VerContactos.TabIndex = 2;
            this.VerContactos.Text = "Ver Contactos";
            this.VerContactos.UseVisualStyleBackColor = false;
            this.VerContactos.Click += new System.EventHandler(this.VerContactos_Click);
            // 
            // AñadirContacto
            // 
            this.AñadirContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.AñadirContacto.FlatAppearance.BorderSize = 0;
            this.AñadirContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirContacto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirContacto.ForeColor = System.Drawing.Color.White;
            this.AñadirContacto.Location = new System.Drawing.Point(0, 88);
            this.AñadirContacto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AñadirContacto.Name = "AñadirContacto";
            this.AñadirContacto.Size = new System.Drawing.Size(161, 48);
            this.AñadirContacto.TabIndex = 1;
            this.AñadirContacto.Text = "Añadir Contactos";
            this.AñadirContacto.UseVisualStyleBackColor = false;
            this.AñadirContacto.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Inicio.FlatAppearance.BorderSize = 0;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.ForeColor = System.Drawing.Color.White;
            this.Inicio.Location = new System.Drawing.Point(0, 34);
            this.Inicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(161, 48);
            this.Inicio.TabIndex = 0;
            this.Inicio.Text = "Inicio";
            this.Inicio.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.ButtonBuscar);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panelFondo);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.texBuscar);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(172, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 679);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.BorderRadius = 5;
            this.ButtonBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ButtonBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBuscar.ForeColor = System.Drawing.Color.White;
            this.ButtonBuscar.Location = new System.Drawing.Point(523, 6);
            this.ButtonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(100, 31);
            this.ButtonBuscar.TabIndex = 8;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(1, 46);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(763, 2);
            this.panel7.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(764, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 671);
            this.panel6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lista de Contactos";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFondo.Controls.Add(this.panelDetalles);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFondo.Location = new System.Drawing.Point(764, 0);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(281, 679);
            this.panelFondo.TabIndex = 4;
            this.panelFondo.Visible = false;
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelDetalles.Controls.Add(this.textDireccion);
            this.panelDetalles.Controls.Add(this.textTelefono);
            this.panelDetalles.Controls.Add(this.textCorreo);
            this.panelDetalles.Controls.Add(this.textNombre);
            this.panelDetalles.Controls.Add(this.panel8);
            this.panelDetalles.Controls.Add(this.Eliminar);
            this.panelDetalles.Controls.Add(this.Guardar);
            this.panelDetalles.Controls.Add(this.label8);
            this.panelDetalles.Controls.Add(this.label7);
            this.panelDetalles.Controls.Add(this.label6);
            this.panelDetalles.Controls.Add(this.label4);
            this.panelDetalles.Controls.Add(this.label3);
            this.panelDetalles.Location = new System.Drawing.Point(17, 34);
            this.panelDetalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(251, 315);
            this.panelDetalles.TabIndex = 2;
            this.panelDetalles.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(82, 169);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(150, 26);
            this.textDireccion.TabIndex = 11;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(80, 128);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(150, 26);
            this.textTelefono.TabIndex = 10;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(72, 90);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(150, 26);
            this.textCorreo.TabIndex = 9;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(75, 52);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(150, 26);
            this.textNombre.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(15, 46);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(236, 2);
            this.panel8.TabIndex = 7;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(129, 229);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(84, 41);
            this.Eliminar.TabIndex = 6;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(27, 229);
            this.Guardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(93, 41);
            this.Guardar.TabIndex = 5;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Direccion:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detalles del Contacto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Correo,
            this.Telefono,
            this.Direccion,
            this.Editar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(21, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 392);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Acciones";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // texBuscar
            // 
            this.texBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texBuscar.Location = new System.Drawing.Point(201, 9);
            this.texBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texBuscar.Name = "texBuscar";
            this.texBuscar.Size = new System.Drawing.Size(314, 30);
            this.texBuscar.TabIndex = 1;
            this.texBuscar.Text = "Buscar..";
            this.texBuscar.TextChanged += new System.EventHandler(this.texBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Contacto";
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.TimerMenu_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 754);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "AGUENDA DE CONTACTOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelFondo.ResumeLayout(false);
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button VerContactos;
        private System.Windows.Forms.Button AñadirContacto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox texBuscar;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BtnMenu;
        private Guna.UI2.WinForms.Guna2Button ButtonBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}
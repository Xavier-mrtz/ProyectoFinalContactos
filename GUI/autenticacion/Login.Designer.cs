using System;

namespace GUI.autenticacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.PicUsuario = new System.Windows.Forms.PictureBox();
            this.PicContra = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.InicioPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicContra)).BeginInit();
            this.InicioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(74, 120);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(332, 39);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(74, 236);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(332, 39);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(69, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(158, 38);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Bienvenido";
            // 
            // PicUsuario
            // 
            this.PicUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PicUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PicUsuario.Image")));
            this.PicUsuario.Location = new System.Drawing.Point(74, 79);
            this.PicUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicUsuario.Name = "PicUsuario";
            this.PicUsuario.Size = new System.Drawing.Size(34, 38);
            this.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUsuario.TabIndex = 6;
            this.PicUsuario.TabStop = false;
            this.PicUsuario.Click += new System.EventHandler(this.PicUsuario_Click);
            // 
            // PicContra
            // 
            this.PicContra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PicContra.Image = ((System.Drawing.Image)(resources.GetObject("PicContra.Image")));
            this.PicContra.Location = new System.Drawing.Point(124, 178);
            this.PicContra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicContra.Name = "PicContra";
            this.PicContra.Size = new System.Drawing.Size(48, 38);
            this.PicContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicContra.TabIndex = 7;
            this.PicContra.TabStop = false;
            this.PicContra.Click += new System.EventHandler(this.PicContra_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BorderRadius = 5;
            this.btnIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(140, 329);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(202, 56);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar";
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click_1);
            // 
            // InicioPanel
            // 
            this.InicioPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InicioPanel.BorderRadius = 10;
            this.InicioPanel.Controls.Add(this.PicContra);
            this.InicioPanel.Location = new System.Drawing.Point(63, 15);
            this.InicioPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InicioPanel.Name = "InicioPanel";
            this.InicioPanel.Size = new System.Drawing.Size(392, 406);
            this.InicioPanel.TabIndex = 9;
            this.InicioPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InicioPanel_Paint);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(18, -1);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(494, 449);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 466);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.PicUsuario);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InicioPanel);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicContra)).EndInit();
            this.InicioPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.PictureBox PicUsuario;
        private System.Windows.Forms.PictureBox PicContra;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2Panel InicioPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
    }
}
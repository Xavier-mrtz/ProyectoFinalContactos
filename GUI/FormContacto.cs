using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormContacto : Form
    {
        public FormContacto()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        private void Guardar_Click(object sender, EventArgs e)
        {
            // VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            // VALIDAR CORREO 
            if (!txtCorreo.Text.EndsWith("@gmail.com") || !txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe ser válido y terminar en @gmail.com");
                return;
            }

            // VALIDAR TELÉFONO 
            if (txtTelefono.Text.Length < 8)
            {
                MessageBox.Show("El teléfono debe tener al menos 8 dígitos");
                return;
            }

            // SI TODO ESTÁ BIEN, GUARDA
            Nombre = txtNombre.Text;
            Correo = txtCorreo.Text;
            Telefono = txtTelefono.Text;
            Direccion = txtDireccion.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormContacto_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 248, 255); // Fondo suave          

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}

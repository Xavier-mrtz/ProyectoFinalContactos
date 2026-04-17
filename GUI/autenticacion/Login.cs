using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.autenticacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 248, 255); // Fondo suave          

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PicUsuario_Click(object sender, EventArgs e)
        {

        }

        private void PicContra_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {

            // validar las credenciales
            if (txtUsuario.Text.Equals("admin") && txtContraseña.Text.Equals("admin"))
            {
                // vamos a agregar el valor DialogResult.Ok a la propiedad DialogResult del formulario Login
                this.DialogResult = DialogResult.OK;
                // cerrar el formulario
                this.Close();
            }
            else
            {
                // mostrar un mensaje de error
                MessageBox.Show("Credenciales incorrectas.", "Banco Green | Inicio de Sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // limpiar los txt y enfocar el txtUsuario
                txtUsuario.Clear();
                txtContraseña.Clear();

                txtUsuario.Focus();
            }

        }

        private void InicioPanel_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 248, 255);
        }
    }
}

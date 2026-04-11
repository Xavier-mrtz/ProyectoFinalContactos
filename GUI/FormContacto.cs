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

        private void label4_Click(object sender, EventArgs e)
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
            Nombre = textBox1.Text;
            Correo = textBox2.Text;
            Telefono = textBox3.Text;
            Direccion = textBox4.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

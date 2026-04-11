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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormContacto frm = new FormContacto();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(
                    frm.Nombre,
                    frm.Correo,
                    frm.Telefono,
                    frm.Direccion
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("Ana López", "ana@email.com", "78901234", "San Salvador");
            dataGridView1.Rows.Add("Carlos Ramírez", "carlos@email.com", "70123456", "Santa Ana");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

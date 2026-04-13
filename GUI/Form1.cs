using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Form1 : Form
    {
        //Variable del control
        bool menuExpandido = true;

        int filaSeleccionada = -1;
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
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                filaSeleccionada = e.RowIndex;

                textNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                textCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
                textTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                textDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();

                panelFondo.Visible = true;
               
            }
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VerContactos_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Correo", "Correo");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Direccion", "Dirección");

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Acciones";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btnEditar);

        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            if (filaSeleccionada >= 0)
            {
                dataGridView1.Rows[filaSeleccionada].Cells["Nombre"].Value = textNombre.Text;
                dataGridView1.Rows[filaSeleccionada].Cells["Correo"].Value = textCorreo.Text;
                dataGridView1.Rows[filaSeleccionada].Cells["Telefono"].Value = textTelefono.Text;
                dataGridView1.Rows[filaSeleccionada].Cells["Direccion"].Value = textDireccion.Text;

                MessageBox.Show("Contacto actualizado");

                filaSeleccionada = -1;

                // LIMPIAR CAMPOS
                textNombre.Clear();
                textCorreo.Clear();
                textTelefono.Clear();
                textDireccion.Clear();

                // OCULTAR PANEL
                panelFondo.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecciona un contacto para editar");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            // 🔥 Si no hay fila seleccionada, toma la actual
            if (filaSeleccionada < 0 && dataGridView1.CurrentRow != null)
            {
                filaSeleccionada = dataGridView1.CurrentRow.Index;
            }

            if (filaSeleccionada >= 0)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que deseas eliminar este contacto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (resultado == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(filaSeleccionada);

                    MessageBox.Show("Contacto eliminado");

                    filaSeleccionada = -1;

                    textNombre.Clear();
                    textCorreo.Clear();
                    textTelefono.Clear();
                    textDireccion.Clear();

                    // OCULTAR PANEL
                    panelFondo.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un contacto primero");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        // Valores de ancho
        int anchoCerrado = 0;
        int anchoAbierto = 120;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpandido)
            {
                // Reducir poco a poco
                panelMenu.Width -= 10;

                if (panelMenu.Width <= anchoCerrado)
                {
                    menuExpandido = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                // Aumentar poco a poco
                panelMenu.Width += 10;

                if (panelMenu.Width >= anchoAbierto)
                {
                    menuExpandido = true;
                    timerMenu.Stop();
                }
            }


        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

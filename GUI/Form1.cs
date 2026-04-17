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
        int contadorId = 1;
        //Variable del control
        bool menuExpandido = true;

        int filaSeleccionada = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            FormContacto frm = new FormContacto();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(
                    contadorId++,
                    frm.Nombre,
                    frm.Correo,
                    frm.Telefono,
                    frm.Direccion
                );
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VerContactos_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Correo", "Correo");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Direccion", "Dirección");

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            {
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Acciones";
                btnEditar.Text = "Editar";
                btnEditar.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btnEditar);
            }
           

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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        // Valores de ancho
        readonly int anchoCerrado = 0;
        readonly int anchoAbierto = 120;


        private void TimerMenu_Tick(object sender, EventArgs e)
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {

            string texto = texBuscar.Text.ToLower();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells["Nombre"].Value != null)
                {
                    string nombre = fila.Cells["Nombre"].Value.ToString().ToLower();

                    fila.Visible = nombre.Contains(texto);
                }
            }
        }

        private void texBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

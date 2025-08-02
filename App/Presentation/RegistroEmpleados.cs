using Datos;
using Guna.UI2.WinForms;
using MaterialSkin;
using Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class RegistroEmpleado : MaterialSkin.Controls.MaterialForm
    {
        Procedimientos pr = new Procedimientos();
        private string Id = null;
        private bool editar = false;

        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        public void MostrarDatos()
        {
            Procedimientos obj = new Procedimientos();
            guna2DataGridView1.DataSource = obj.Mostrar();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtContraseña.Clear();
            txtCargo.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.");
                return;
            }

            if (editar == false)
            {
                try
                {
                    pr.Agregar(txtNombre.Text, txtContraseña.Text, txtCargo.Text);
                    MessageBox.Show("Se agregó correctamente");
                    MostrarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    pr.Modificar(Convert.ToInt32(Id), txtNombre.Text, txtContraseña.Text, txtCargo.Text);
                    MessageBox.Show("Se modificó correctamente");
                    MostrarDatos();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar los datos: " + ex.Message);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                Id = guna2DataGridView1.CurrentRow.Cells["id"].Value.ToString();
                pr.Eliminar(Convert.ToInt32(Id));
                MessageBox.Show("El registro se eliminó correctamente");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["Id"].Value);
                string nombre = guna2DataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                string contraseña = guna2DataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                string cargo = guna2DataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();

                Modificar modificarForm = new Modificar
                {
                    Id = id,
                    Nombre = nombre,
                    Contraseña = contraseña,
                    Cargo = cargo
                };

                modificarForm.ShowDialog();
                MostrarDatos(); // Refrescar la tabla
            }
            else
            {
                MessageBox.Show("Selecciona una fila para modificar.");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

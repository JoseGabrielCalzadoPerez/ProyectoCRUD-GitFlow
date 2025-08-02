using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Modificar : MaterialSkin.Controls.MaterialForm
    {
        public int Id { get; set; }

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        public string Contraseña
        {
            get { return txtContraseña.Text; }
            set { txtContraseña.Text = value; }
        }

        public string Cargo
        {
            get { return txtCargo.Text; }
            set { txtCargo.Text = value; }
        }

        public Modificar()
        {
            InitializeComponent();
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre) ||
       string.IsNullOrWhiteSpace(Contraseña) ||
       string.IsNullOrWhiteSpace(Cargo))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                Tramite tramite = new Tramite();
                tramite.ModificarData(Id, Nombre, Contraseña, Cargo);
                MessageBox.Show("Datos modificados correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los datos: " + ex.Message);
            }
        }
    }
}

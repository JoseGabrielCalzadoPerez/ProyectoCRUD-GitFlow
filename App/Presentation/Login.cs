using Guna.UI2.WinForms;
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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();

            // Conectar eventos manualmente (usa los nombres reales de tus PictureBox)
            pbMostrar.Click += guna2PictureBox1_Click;
            pbOcultar.Click += guna2PictureBox2_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Inicializar la contraseña como oculta
            txtContraseña.PasswordChar = '*';

            // Configurar los PictureBox en la misma posición
            pbMostrar.Cursor = Cursors.Hand;
            pbOcultar.Cursor = Cursors.Hand;

            // Estado inicial: contraseña oculta, mostrar ícono de "mostrar"
            pbMostrar.Visible = true;   // Mostrar el ícono de "ojo abierto"
            pbOcultar.Visible = false;  // Ocultar el ícono de "ojo cerrado"
        }

        // Evento para MOSTRAR la contraseña (cuando haces clic en el ojo abierto)
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            // Mostrar la contraseña
            txtContraseña.PasswordChar = '\0'; // Quita el carácter de máscara

            // Cambiar íconos: ocultar "mostrar" y mostrar "ocultar"
            pbMostrar.Visible = false;  // Ocultar ícono de "ojo abierto"
            pbOcultar.Visible = true;   // Mostrar ícono de "ojo cerrado/tachado"
        }

        // Evento para OCULTAR la contraseña (cuando haces clic en el ojo cerrado/tachado)
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            // Ocultar la contraseña
            txtContraseña.PasswordChar = '*'; // Pone el carácter de máscara

            // Cambiar íconos: ocultar "ocultar" y mostrar "mostrar"
            pbOcultar.Visible = false;  // Ocultar ícono de "ojo cerrado/tachado"
            pbMostrar.Visible = true;   // Mostrar ícono de "ojo abierto"
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contraseña = txtContraseña.Text;

            //creamos la instancia
            Tramite negocio = new Tramite();
            string cargo = negocio.ValidarCredenciales(usuario, contraseña);

            if (cargo != null)
            {
                MessageBox.Show($"Bienvenido {cargo}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RegistroEmpleado formRegistro = new RegistroEmpleado();
                formRegistro.Show();
                this.Hide(); // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}
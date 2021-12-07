using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            string username = txtBoxCorreo.Text.Trim();
            string password = txtContrasena.Text.Trim();

            if (validarCampos(username, password))
            {
                try
                {

                    found = Negocio.NUsuarios.SignIn(username, password);
                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                MensajeError("Deben llenarse los campos obligatorios");
            }

            if (found)
            {
                MostrarAdminoUserForm();
            }
            else
            {

                MensajeError("Datos invalidos o usuario inexistente");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private bool validarCampos(string username, string password)
        {
            bool valido = true;
            if (username == string.Empty)
            {
                valido = false;

            }
            if (password == string.Empty)
            {
                valido = false;
            }

            return valido;
        }
        private void MensajeError(string e)
        {
            MessageBox.Show(e, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MostrarAdminoUserForm()
        {
            //agregar por roles
            PrincipalForm pf = new PrincipalForm();
            pf.Show();
            this.Hide();

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

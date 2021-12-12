using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.User
{
    public partial class CreateUserForm : MaterialSkin.Controls.MaterialForm
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseQuestBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Unametxt.Text) && !string.IsNullOrEmpty(Ulastnametxt.Text) && !string.IsNullOrEmpty(Usernametxt.Text) && !string.IsNullOrEmpty(passwdtxt.Text) && passwdtxt.Text == confpasswdtxt.Text)
            {
                
                String respuesta = Negocio.NUsuarios.insert(Unametxt.Text, Ulastnametxt.Text, Usernametxt.Text,Uemail.Text, passwdtxt.Text);
                MessageBox.Show(respuesta);
                Close();
            }
            else
            {
                if (!string.IsNullOrEmpty(Unametxt.Text) && !string.IsNullOrEmpty(Ulastnametxt.Text) && !string.IsNullOrEmpty(Usernametxt.Text) && !string.IsNullOrEmpty(passwdtxt.Text) && passwdtxt.Text != confpasswdtxt.Text)
                {
                    MensajeError("Las contraseñas no coinciden");
                }
                else
                {
                    MensajeError("Debe llenar los campos correctamente!");
                }
            }
        }

        private void MensajeError(string e)
        {
            MessageBox.Show(e, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

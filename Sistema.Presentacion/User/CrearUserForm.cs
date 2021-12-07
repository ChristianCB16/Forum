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
    public partial class CrearUserForm : MaterialSkin.Controls.MaterialForm
    {
        public CrearUserForm()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Unametxt.Text) && !string.IsNullOrEmpty(Ulastnametxt.Text) && !string.IsNullOrEmpty(Usernametxt.Text) && !string.IsNullOrEmpty(passwdtxt.Text)  && passwdtxt.Text == confpasswdtxt.Text)
            {
                int admin=0;

                if (adminFlagBtn.Checked) {
                    admin = 1;
                }
                //setear reglas de contra?


                //String respuesta=Negocio.NUsuarios.insert(Unametxt.Text, Ulastnametxt.Text, Usernametxt.Text,passwdtxt.Text, passwdtxt.Text, admin);
                //MessageBox.Show(respuesta);
                Close();
            }
            else {
                if (!string.IsNullOrEmpty(Unametxt.Text) && !string.IsNullOrEmpty(Ulastnametxt.Text) && !string.IsNullOrEmpty(Usernametxt.Text)  && !string.IsNullOrEmpty(passwdtxt.Text) && passwdtxt.Text != confpasswdtxt.Text)
                {
                    MensajeError("Las contraseñas no coinciden");
                }
                else {
                    MensajeError("Debe llenar los campos correctamente!");
                }
            }
        }

        private void MensajeError(string e)
        {
            MessageBox.Show(e, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

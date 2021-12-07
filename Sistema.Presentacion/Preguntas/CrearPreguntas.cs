using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class CrearPreguntasForm : MaterialSkin.Controls.MaterialForm
    {
        public CrearPreguntasForm()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Titulotxt.Text) && !string.IsNullOrEmpty(Descripciontxt.Text))
            {
                int estado = 0;
                int i = (int)Membership.GetUser().ProviderUserKey;

                if (adminFlagBtn.Checked)
                {
                    estado = 1;
                }
                //setear reglas de contra?


                String respuesta = Negocio.Npregunta.insert(Titulotxt.Text, Descripciontxt.Text, estado, i);
                MessageBox.Show(respuesta);
                Close();
            }
            else
            {
                if (!string.IsNullOrEmpty(Titulotxt.Text) && !string.IsNullOrEmpty(Descripciontxt.Text) )
                {
                    MensajeError("Hay un error en los datos ingresados");
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
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Uemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearUserForm_Load(object sender, EventArgs e)
        {

        }

        private void Titulotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Descripciontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminFlagBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

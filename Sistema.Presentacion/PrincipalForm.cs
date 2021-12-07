using Sistema.Datos;
using Sistema.Entidades;

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
    public partial class PrincipalForm : MaterialSkin.Controls.MaterialForm
    {
        public PrincipalForm()
        {
            InitializeComponent();

            
        }

        private void refreshdata()
        {
            //evitar que sea editable el GridView
            UserDgv.ReadOnly = true;
            UserDgv.DataSource = Negocio.NUsuarios.List();

            Ingredgv.ReadOnly = true;
            
           
        }
       
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            refreshdata();
            this.UserDgv.Columns[0].Visible = false;
            this.UserDgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UserDgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UserDgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UserDgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }



        private void materialTabSelector1_Click_1(object sender, EventArgs e)
        {

        }

        private void TodasTab_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void cb_modo_SelectedIndexChanged(object sender, EventArgs e)
        { }



        private void MensajeError(string e)
        {
            MessageBox.Show(e, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_ingredientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Preguntas_Click(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ingredientesCmbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void recetasdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void UserDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usersAdminTab_Click(object sender, EventArgs e)
        {

        }

        private void InsertquestBtn_Click(object sender, EventArgs e)
        {

        }

        private void CloseQuestBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

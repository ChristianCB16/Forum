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
using System.Web.Security;
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
        
            Preguntasdgv.ReadOnly = true;
            Preguntasdgv.DataSource = Negocio.Npregunta.Listar();

            int i = 1;
            MisquestDgv.ReadOnly = true;
            MisquestDgv.DataSource = Negocio.Npregunta.Listar_Mispregnutas(i);
        }
       
        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            refreshdata();
            /*this.UserDgv.Columns[0].Visible = false;
            this.UserDgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UserDgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UserDgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.UserDgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;*/

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

        private void MisquestDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshdata();
        }

        private void usersAdminTab_Click(object sender, EventArgs e)
        {

        }

        private void InsertquestBtn_Click(object sender, EventArgs e)
        {
            var formPopup = new CrearPreguntasForm();
            formPopup.ShowDialog();
            refreshdata();
        }

        private void CloseQuestBtn_Click(object sender, EventArgs e)
        {

        }
        
    }
}

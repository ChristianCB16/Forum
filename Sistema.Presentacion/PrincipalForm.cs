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
        string current_user;
        
        public PrincipalForm(string username)
        {
            InitializeComponent();

            current_user = username; 
        }
        
        private void refreshdata()
        {
        
            Preguntasdgv.ReadOnly = true;
            Preguntasdgv.DataSource = Negocio.Npregunta.Listar();

           
            MisquestDgv.ReadOnly = true;
            MisquestDgv.DataSource = Negocio.Npregunta.Listar_Mispregnutas(current_user);

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
            var formPopup = new CrearPreguntasForm(current_user);
            formPopup.ShowDialog();
            refreshdata();
        }

        private void CloseQuestBtn_Click(object sender, EventArgs e)
        {
            var formPopup = new Preguntas.CerrarPreguntaForm();
            formPopup.ShowDialog();
            refreshdata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SeeQuestbtn_Click(object sender, EventArgs e)
        {
            int numVal = Int32.Parse(questidtxt.Text);
            Answerdgv.DataSource = Negocio.Nrespuesta.Buscar_respuestas(numVal);
        }

        private void questidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerquestbutton_Click(object sender, EventArgs e)
        {
            int quest_id = Int32.Parse(respondertxt.Text);
            var formPopup = new Respuestas.RespuestasForm(current_user, quest_id);
            formPopup.ShowDialog();
            refreshdata();
        }

        private void respondertxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Respuestas
{
    public partial class RespuestasForm : MaterialSkin.Controls.MaterialForm
    {
        public string current_user;
        public int questId;
        public RespuestasForm(string username, int quest_id)
        {
            InitializeComponent();
            current_user = username;
            questId = quest_id;
        }

        private void RespuestasForm_Load(object sender, EventArgs e)
        {

        }

        private void InsertanswerBtn_Click(object sender, EventArgs e)
        {
            
            string descripcion = textBox1.Text;
            String respuesta = Negocio.Nrespuesta.insert(descripcion, current_user, questId);
            MessageBox.Show(respuesta);
            Close();
        }
    }
}

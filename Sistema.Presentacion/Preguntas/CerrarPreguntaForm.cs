using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion.Preguntas
{
    public partial class CerrarPreguntaForm : MaterialSkin.Controls.MaterialForm
    {
        public CerrarPreguntaForm()
        {
            InitializeComponent();
        }

        private void CerrarPreguntaForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseQuestBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(cerrartxt.Text);
            Negocio.Npregunta.cerrar_pregunta(id);
           
        }
    }
}

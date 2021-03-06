
namespace Sistema.Presentacion
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.myquestionsTab = new System.Windows.Forms.TabPage();
            this.CloseQuestBtn = new System.Windows.Forms.Button();
            this.InsertquestBtn = new System.Windows.Forms.Button();
            this.MisquestDgv = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.todoTab = new System.Windows.Forms.TabPage();
            this.respondertxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Answerdgv = new System.Windows.Forms.DataGridView();
            this.questidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SeeQuestbtn = new System.Windows.Forms.Button();
            this.answerquestbutton = new System.Windows.Forms.Button();
            this.Preguntasdgv = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.myquestionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisquestDgv)).BeginInit();
            this.todoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Answerdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preguntasdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.myquestionsTab);
            this.materialTabControl1.Controls.Add(this.todoTab);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 126);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1319, 515);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // myquestionsTab
            // 
            this.myquestionsTab.Controls.Add(this.CloseQuestBtn);
            this.myquestionsTab.Controls.Add(this.InsertquestBtn);
            this.myquestionsTab.Controls.Add(this.MisquestDgv);
            this.myquestionsTab.Controls.Add(this.materialLabel2);
            this.myquestionsTab.Location = new System.Drawing.Point(4, 25);
            this.myquestionsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myquestionsTab.Name = "myquestionsTab";
            this.myquestionsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myquestionsTab.Size = new System.Drawing.Size(1311, 486);
            this.myquestionsTab.TabIndex = 0;
            this.myquestionsTab.Text = "Mis preguntas";
            this.myquestionsTab.UseVisualStyleBackColor = true;
            this.myquestionsTab.Click += new System.EventHandler(this.usersAdminTab_Click);
            // 
            // CloseQuestBtn
            // 
            this.CloseQuestBtn.AutoSize = true;
            this.CloseQuestBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.CloseQuestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.CloseQuestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseQuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseQuestBtn.Location = new System.Drawing.Point(678, 391);
            this.CloseQuestBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseQuestBtn.Name = "CloseQuestBtn";
            this.CloseQuestBtn.Size = new System.Drawing.Size(221, 36);
            this.CloseQuestBtn.TabIndex = 12;
            this.CloseQuestBtn.Text = "Cerrar Pregunta";
            this.CloseQuestBtn.UseVisualStyleBackColor = true;
            this.CloseQuestBtn.Click += new System.EventHandler(this.CloseQuestBtn_Click);
            // 
            // InsertquestBtn
            // 
            this.InsertquestBtn.AutoSize = true;
            this.InsertquestBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.InsertquestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.InsertquestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertquestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertquestBtn.Location = new System.Drawing.Point(427, 391);
            this.InsertquestBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertquestBtn.Name = "InsertquestBtn";
            this.InsertquestBtn.Size = new System.Drawing.Size(221, 36);
            this.InsertquestBtn.TabIndex = 10;
            this.InsertquestBtn.Text = "Hacer una Pregunta";
            this.InsertquestBtn.UseVisualStyleBackColor = true;
            this.InsertquestBtn.Click += new System.EventHandler(this.InsertquestBtn_Click);
            // 
            // MisquestDgv
            // 
            this.MisquestDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MisquestDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MisquestDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MisquestDgv.Location = new System.Drawing.Point(7, 6);
            this.MisquestDgv.Margin = new System.Windows.Forms.Padding(4);
            this.MisquestDgv.Name = "MisquestDgv";
            this.MisquestDgv.RowHeadersWidth = 51;
            this.MisquestDgv.Size = new System.Drawing.Size(1300, 357);
            this.MisquestDgv.TabIndex = 2;
            this.MisquestDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MisquestDgv_CellContentClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(416, 62);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(0, 24);
            this.materialLabel2.TabIndex = 1;
            // 
            // todoTab
            // 
            this.todoTab.Controls.Add(this.respondertxt);
            this.todoTab.Controls.Add(this.label2);
            this.todoTab.Controls.Add(this.Answerdgv);
            this.todoTab.Controls.Add(this.questidtxt);
            this.todoTab.Controls.Add(this.label1);
            this.todoTab.Controls.Add(this.SeeQuestbtn);
            this.todoTab.Controls.Add(this.answerquestbutton);
            this.todoTab.Controls.Add(this.Preguntasdgv);
            this.todoTab.Location = new System.Drawing.Point(4, 25);
            this.todoTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todoTab.Name = "todoTab";
            this.todoTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todoTab.Size = new System.Drawing.Size(1311, 486);
            this.todoTab.TabIndex = 1;
            this.todoTab.Text = "Todas las preguntas";
            this.todoTab.UseVisualStyleBackColor = true;
            this.todoTab.Click += new System.EventHandler(this.TodasTab_Click);
            // 
            // respondertxt
            // 
            this.respondertxt.Location = new System.Drawing.Point(528, 442);
            this.respondertxt.Name = "respondertxt";
            this.respondertxt.Size = new System.Drawing.Size(316, 22);
            this.respondertxt.TabIndex = 20;
            this.respondertxt.TextChanged += new System.EventHandler(this.respondertxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(40, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Responder a pregunta (Ingrese el Id de la pregunta): ";
            // 
            // Answerdgv
            // 
            this.Answerdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Answerdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Answerdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Answerdgv.Location = new System.Drawing.Point(-4, 251);
            this.Answerdgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Answerdgv.Name = "Answerdgv";
            this.Answerdgv.ReadOnly = true;
            this.Answerdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Answerdgv.RowTemplate.Height = 24;
            this.Answerdgv.Size = new System.Drawing.Size(1305, 168);
            this.Answerdgv.TabIndex = 18;
            // 
            // questidtxt
            // 
            this.questidtxt.Location = new System.Drawing.Point(528, 203);
            this.questidtxt.Name = "questidtxt";
            this.questidtxt.Size = new System.Drawing.Size(316, 22);
            this.questidtxt.TabIndex = 17;
            this.questidtxt.TextChanged += new System.EventHandler(this.questidtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label1.Location = new System.Drawing.Point(40, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar Respuestas a la pregunta (Ingrese el Id de la pregunta): ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SeeQuestbtn
            // 
            this.SeeQuestbtn.AutoSize = true;
            this.SeeQuestbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.SeeQuestbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SeeQuestbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeQuestbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeQuestbtn.Location = new System.Drawing.Point(926, 196);
            this.SeeQuestbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeQuestbtn.Name = "SeeQuestbtn";
            this.SeeQuestbtn.Size = new System.Drawing.Size(221, 36);
            this.SeeQuestbtn.TabIndex = 15;
            this.SeeQuestbtn.Text = "Ver Respuestas";
            this.SeeQuestbtn.UseVisualStyleBackColor = true;
            this.SeeQuestbtn.Click += new System.EventHandler(this.SeeQuestbtn_Click);
            // 
            // answerquestbutton
            // 
            this.answerquestbutton.AutoSize = true;
            this.answerquestbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.answerquestbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.answerquestbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerquestbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerquestbutton.Location = new System.Drawing.Point(926, 435);
            this.answerquestbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answerquestbutton.Name = "answerquestbutton";
            this.answerquestbutton.Size = new System.Drawing.Size(221, 36);
            this.answerquestbutton.TabIndex = 14;
            this.answerquestbutton.Text = "Responder a pregunta";
            this.answerquestbutton.UseVisualStyleBackColor = true;
            this.answerquestbutton.Click += new System.EventHandler(this.answerquestbutton_Click);
            // 
            // Preguntasdgv
            // 
            this.Preguntasdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Preguntasdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Preguntasdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Preguntasdgv.Location = new System.Drawing.Point(3, 13);
            this.Preguntasdgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Preguntasdgv.Name = "Preguntasdgv";
            this.Preguntasdgv.ReadOnly = true;
            this.Preguntasdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Preguntasdgv.RowTemplate.Height = 24;
            this.Preguntasdgv.Size = new System.Drawing.Size(1305, 168);
            this.Preguntasdgv.TabIndex = 7;
            this.Preguntasdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Preguntas_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 84);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1319, 27);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "TabSelector";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click_1);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 652);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalForm";
            this.Text = "Control Principal de Foro BAC";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.myquestionsTab.ResumeLayout(false);
            this.myquestionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisquestDgv)).EndInit();
            this.todoTab.ResumeLayout(false);
            this.todoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Answerdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preguntasdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage myquestionsTab;
        private System.Windows.Forms.TabPage todoTab;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView Preguntasdgv;
        private System.Windows.Forms.DataGridView MisquestDgv;
        private System.Windows.Forms.Button CloseQuestBtn;
        private System.Windows.Forms.Button InsertquestBtn;
        private System.Windows.Forms.Button SeeQuestbtn;
        private System.Windows.Forms.Button answerquestbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Answerdgv;
        private System.Windows.Forms.TextBox questidtxt;
        private System.Windows.Forms.TextBox respondertxt;
        private System.Windows.Forms.Label label2;
    }
}
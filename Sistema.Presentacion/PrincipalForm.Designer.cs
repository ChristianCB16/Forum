
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
            this.UserDgv = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.todoTab = new System.Windows.Forms.TabPage();
            this.Ingredgv = new System.Windows.Forms.DataGridView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.SeeQuestbtn = new System.Windows.Forms.Button();
            this.IngredCreatebutton = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.myquestionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDgv)).BeginInit();
            this.todoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ingredgv)).BeginInit();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1085, 322);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // myquestionsTab
            // 
            this.myquestionsTab.Controls.Add(this.CloseQuestBtn);
            this.myquestionsTab.Controls.Add(this.InsertquestBtn);
            this.myquestionsTab.Controls.Add(this.UserDgv);
            this.myquestionsTab.Controls.Add(this.materialLabel2);
            this.myquestionsTab.Location = new System.Drawing.Point(4, 25);
            this.myquestionsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myquestionsTab.Name = "myquestionsTab";
            this.myquestionsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myquestionsTab.Size = new System.Drawing.Size(1077, 293);
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
            this.CloseQuestBtn.Location = new System.Drawing.Point(536, 245);
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
            this.InsertquestBtn.Location = new System.Drawing.Point(285, 245);
            this.InsertquestBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertquestBtn.Name = "InsertquestBtn";
            this.InsertquestBtn.Size = new System.Drawing.Size(221, 36);
            this.InsertquestBtn.TabIndex = 10;
            this.InsertquestBtn.Text = "Hacer una Pregunta";
            this.InsertquestBtn.UseVisualStyleBackColor = true;
            this.InsertquestBtn.Click += new System.EventHandler(this.InsertquestBtn_Click);
            // 
            // UserDgv
            // 
            this.UserDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDgv.Location = new System.Drawing.Point(7, 6);
            this.UserDgv.Margin = new System.Windows.Forms.Padding(4);
            this.UserDgv.Name = "UserDgv";
            this.UserDgv.RowHeadersWidth = 51;
            this.UserDgv.Size = new System.Drawing.Size(1061, 212);
            this.UserDgv.TabIndex = 2;
            this.UserDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDgv_CellContentClick);
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
            this.todoTab.Controls.Add(this.SeeQuestbtn);
            this.todoTab.Controls.Add(this.IngredCreatebutton);
            this.todoTab.Controls.Add(this.Ingredgv);
            this.todoTab.Location = new System.Drawing.Point(4, 25);
            this.todoTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todoTab.Name = "todoTab";
            this.todoTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todoTab.Size = new System.Drawing.Size(1077, 293);
            this.todoTab.TabIndex = 1;
            this.todoTab.Text = "Todas las preguntas";
            this.todoTab.UseVisualStyleBackColor = true;
            this.todoTab.Click += new System.EventHandler(this.TodasTab_Click);
            // 
            // Ingredgv
            // 
            this.Ingredgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ingredgv.Location = new System.Drawing.Point(3, 13);
            this.Ingredgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ingredgv.Name = "Ingredgv";
            this.Ingredgv.RowHeadersWidth = 51;
            this.Ingredgv.RowTemplate.Height = 24;
            this.Ingredgv.Size = new System.Drawing.Size(1067, 207);
            this.Ingredgv.TabIndex = 7;
            this.Ingredgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Preguntas_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 84);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1080, 27);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "TabSelector";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click_1);
            // 
            // SeeQuestbtn
            // 
            this.SeeQuestbtn.AutoSize = true;
            this.SeeQuestbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.SeeQuestbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.SeeQuestbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeeQuestbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeeQuestbtn.Location = new System.Drawing.Point(531, 253);
            this.SeeQuestbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeeQuestbtn.Name = "SeeQuestbtn";
            this.SeeQuestbtn.Size = new System.Drawing.Size(221, 36);
            this.SeeQuestbtn.TabIndex = 15;
            this.SeeQuestbtn.Text = "Ver Respuestas";
            this.SeeQuestbtn.UseVisualStyleBackColor = true;
            // 
            // IngredCreatebutton
            // 
            this.IngredCreatebutton.AutoSize = true;
            this.IngredCreatebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.IngredCreatebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.IngredCreatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngredCreatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredCreatebutton.Location = new System.Drawing.Point(283, 253);
            this.IngredCreatebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IngredCreatebutton.Name = "IngredCreatebutton";
            this.IngredCreatebutton.Size = new System.Drawing.Size(221, 36);
            this.IngredCreatebutton.TabIndex = 14;
            this.IngredCreatebutton.Text = "Responder a pregunta";
            this.IngredCreatebutton.UseVisualStyleBackColor = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 470);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrincipalForm";
            this.Text = "Control Principal de Foro BAC";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.myquestionsTab.ResumeLayout(false);
            this.myquestionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDgv)).EndInit();
            this.todoTab.ResumeLayout(false);
            this.todoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ingredgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage myquestionsTab;
        private System.Windows.Forms.TabPage todoTab;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.DataGridView Ingredgv;
        private System.Windows.Forms.DataGridView UserDgv;
        private System.Windows.Forms.Button CloseQuestBtn;
        private System.Windows.Forms.Button InsertquestBtn;
        private System.Windows.Forms.Button SeeQuestbtn;
        private System.Windows.Forms.Button IngredCreatebutton;
    }
}
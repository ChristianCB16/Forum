
namespace Sistema.Presentacion
{
    partial class CrearPreguntasForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Titulotxt = new System.Windows.Forms.TextBox();
            this.Descripciontxt = new System.Windows.Forms.TextBox();
            this.adminFlagBtn = new System.Windows.Forms.RadioButton();
            this.hacerBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // Titulotxt
            // 
            this.Titulotxt.Location = new System.Drawing.Point(187, 107);
            this.Titulotxt.Margin = new System.Windows.Forms.Padding(4);
            this.Titulotxt.Name = "Titulotxt";
            this.Titulotxt.Size = new System.Drawing.Size(670, 22);
            this.Titulotxt.TabIndex = 3;
            this.Titulotxt.TextChanged += new System.EventHandler(this.Titulotxt_TextChanged);
            // 
            // Descripciontxt
            // 
            this.Descripciontxt.Location = new System.Drawing.Point(187, 144);
            this.Descripciontxt.Margin = new System.Windows.Forms.Padding(4);
            this.Descripciontxt.Name = "Descripciontxt";
            this.Descripciontxt.Size = new System.Drawing.Size(670, 22);
            this.Descripciontxt.TabIndex = 4;
            this.Descripciontxt.TextChanged += new System.EventHandler(this.Descripciontxt_TextChanged);
            // 
            // adminFlagBtn
            // 
            this.adminFlagBtn.AutoSize = true;
            this.adminFlagBtn.Location = new System.Drawing.Point(187, 193);
            this.adminFlagBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminFlagBtn.Name = "adminFlagBtn";
            this.adminFlagBtn.Size = new System.Drawing.Size(67, 21);
            this.adminFlagBtn.TabIndex = 10;
            this.adminFlagBtn.TabStop = true;
            this.adminFlagBtn.Text = "Activo";
            this.adminFlagBtn.UseVisualStyleBackColor = true;
            this.adminFlagBtn.CheckedChanged += new System.EventHandler(this.adminFlagBtn_CheckedChanged);
            // 
            // hacerBtn
            // 
            this.hacerBtn.Location = new System.Drawing.Point(223, 239);
            this.hacerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.hacerBtn.Name = "hacerBtn";
            this.hacerBtn.Size = new System.Drawing.Size(187, 28);
            this.hacerBtn.TabIndex = 11;
            this.hacerBtn.Text = "Hacer Pregunta";
            this.hacerBtn.UseVisualStyleBackColor = true;
            this.hacerBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(488, 239);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(172, 28);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // CrearPreguntasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 300);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.hacerBtn);
            this.Controls.Add(this.adminFlagBtn);
            this.Controls.Add(this.Descripciontxt);
            this.Controls.Add(this.Titulotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrearPreguntasForm";
            this.Text = "Hacer nueva pregunta";
            this.Load += new System.EventHandler(this.CrearUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Titulotxt;
        private System.Windows.Forms.TextBox Descripciontxt;
        private System.Windows.Forms.RadioButton adminFlagBtn;
        private System.Windows.Forms.Button hacerBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}
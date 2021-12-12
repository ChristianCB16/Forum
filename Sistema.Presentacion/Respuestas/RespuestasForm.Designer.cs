
namespace Sistema.Presentacion.Respuestas
{
    partial class RespuestasForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertanswerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(184, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa tu respuesta a la pregunta";
            // 
            // InsertanswerBtn
            // 
            this.InsertanswerBtn.AutoSize = true;
            this.InsertanswerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.InsertanswerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.InsertanswerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertanswerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertanswerBtn.Location = new System.Drawing.Point(187, 170);
            this.InsertanswerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertanswerBtn.Name = "InsertanswerBtn";
            this.InsertanswerBtn.Size = new System.Drawing.Size(221, 36);
            this.InsertanswerBtn.TabIndex = 11;
            this.InsertanswerBtn.Text = "Publicar respuesta";
            this.InsertanswerBtn.UseVisualStyleBackColor = true;
            this.InsertanswerBtn.Click += new System.EventHandler(this.InsertanswerBtn_Click);
            // 
            // RespuestasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 236);
            this.Controls.Add(this.InsertanswerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "RespuestasForm";
            this.Text = "Respondiendo a Pregunta";
            this.Load += new System.EventHandler(this.RespuestasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertanswerBtn;
    }
}
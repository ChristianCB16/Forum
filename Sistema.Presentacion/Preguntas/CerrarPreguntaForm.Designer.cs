﻿
namespace Sistema.Presentacion.Preguntas
{
    partial class CerrarPreguntaForm
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
            this.cerrartxt = new System.Windows.Forms.TextBox();
            this.CloseQuestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el ID de la pregunta que quiere cerrar";
            // 
            // cerrartxt
            // 
            this.cerrartxt.Location = new System.Drawing.Point(69, 127);
            this.cerrartxt.Name = "cerrartxt";
            this.cerrartxt.Size = new System.Drawing.Size(308, 22);
            this.cerrartxt.TabIndex = 1;
            // 
            // CloseQuestBtn
            // 
            this.CloseQuestBtn.AutoSize = true;
            this.CloseQuestBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.CloseQuestBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.CloseQuestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseQuestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseQuestBtn.Location = new System.Drawing.Point(103, 179);
            this.CloseQuestBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseQuestBtn.Name = "CloseQuestBtn";
            this.CloseQuestBtn.Size = new System.Drawing.Size(221, 36);
            this.CloseQuestBtn.TabIndex = 13;
            this.CloseQuestBtn.Text = "Cerrar Pregunta";
            this.CloseQuestBtn.UseVisualStyleBackColor = true;
            this.CloseQuestBtn.Click += new System.EventHandler(this.CloseQuestBtn_Click);
            // 
            // CerrarPreguntaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 267);
            this.Controls.Add(this.CloseQuestBtn);
            this.Controls.Add(this.cerrartxt);
            this.Controls.Add(this.label1);
            this.Name = "CerrarPreguntaForm";
            this.Text = "CerrarPreguntaForm";
            this.Load += new System.EventHandler(this.CerrarPreguntaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cerrartxt;
        private System.Windows.Forms.Button CloseQuestBtn;
    }
}
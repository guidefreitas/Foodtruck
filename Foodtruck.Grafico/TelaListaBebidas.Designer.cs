﻿namespace Foodtruck.Grafico
{
    partial class TelaListaBebidas
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
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(203, 26);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(72, 34);
            this.btAlterar.TabIndex = 5;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(116, 26);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(84, 34);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(32, 26);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(80, 34);
            this.btAdicionar.TabIndex = 3;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            // 
            // TelaListaBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaListaBebidas";
            this.Text = "TelaListaBebidas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
    }
}
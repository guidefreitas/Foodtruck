namespace Foodtruck.Grafico
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
            this.tbBebidasId = new System.Windows.Forms.TextBox();
            this.tbBebidasNome = new System.Windows.Forms.TextBox();
            this.tbBebidasValor = new System.Windows.Forms.TextBox();
            this.tbBebidaTamanho = new System.Windows.Forms.TextBox();
            this.btBebidaSalvar = new System.Windows.Forms.Button();
            this.btBebidaCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBebidasId
            // 
            this.tbBebidasId.Location = new System.Drawing.Point(55, 42);
            this.tbBebidasId.Name = "tbBebidasId";
            this.tbBebidasId.Size = new System.Drawing.Size(100, 20);
            this.tbBebidasId.TabIndex = 0;
            // 
            // tbBebidasNome
            // 
            this.tbBebidasNome.Location = new System.Drawing.Point(55, 78);
            this.tbBebidasNome.Name = "tbBebidasNome";
            this.tbBebidasNome.Size = new System.Drawing.Size(100, 20);
            this.tbBebidasNome.TabIndex = 0;
            // 
            // tbBebidasValor
            // 
            this.tbBebidasValor.Location = new System.Drawing.Point(55, 104);
            this.tbBebidasValor.Name = "tbBebidasValor";
            this.tbBebidasValor.Size = new System.Drawing.Size(100, 20);
            this.tbBebidasValor.TabIndex = 0;
            // 
            // tbBebidaTamanho
            // 
            this.tbBebidaTamanho.Location = new System.Drawing.Point(55, 142);
            this.tbBebidaTamanho.Name = "tbBebidaTamanho";
            this.tbBebidaTamanho.Size = new System.Drawing.Size(100, 20);
            this.tbBebidaTamanho.TabIndex = 0;
            // 
            // btBebidaSalvar
            // 
            this.btBebidaSalvar.Location = new System.Drawing.Point(183, 203);
            this.btBebidaSalvar.Name = "btBebidaSalvar";
            this.btBebidaSalvar.Size = new System.Drawing.Size(75, 23);
            this.btBebidaSalvar.TabIndex = 1;
            this.btBebidaSalvar.Text = "button1";
            this.btBebidaSalvar.UseVisualStyleBackColor = true;
            // 
            // btBebidaCancelar
            // 
            this.btBebidaCancelar.Location = new System.Drawing.Point(80, 203);
            this.btBebidaCancelar.Name = "btBebidaCancelar";
            this.btBebidaCancelar.Size = new System.Drawing.Size(75, 23);
            this.btBebidaCancelar.TabIndex = 1;
            this.btBebidaCancelar.Text = "button1";
            this.btBebidaCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaListaBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btBebidaCancelar);
            this.Controls.Add(this.btBebidaSalvar);
            this.Controls.Add(this.tbBebidaTamanho);
            this.Controls.Add(this.tbBebidasValor);
            this.Controls.Add(this.tbBebidasNome);
            this.Controls.Add(this.tbBebidasId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaListaBebidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBebidasId;
        private System.Windows.Forms.TextBox tbBebidasNome;
        private System.Windows.Forms.TextBox tbBebidasValor;
        private System.Windows.Forms.TextBox tbBebidaTamanho;
        private System.Windows.Forms.Button btBebidaSalvar;
        private System.Windows.Forms.Button btBebidaCancelar;
    }
}
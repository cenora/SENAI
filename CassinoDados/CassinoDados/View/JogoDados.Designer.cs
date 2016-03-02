namespace CassinoDados
{
    partial class JogoDados
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Lime;
            this.btnJogar.Location = new System.Drawing.Point(56, 102);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(175, 57);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar!";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(31, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Clique no botão abaixo para faturar o Prêmio!";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(115, 191);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // JogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnJogar);
            this.Name = "JogoDados";
            this.Text = "Tire a sorte grande!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblResultado;
    }
}


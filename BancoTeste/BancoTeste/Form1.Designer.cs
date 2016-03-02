namespace BancoTeste
{
    partial class Form1
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
            this.lbNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(13, 41);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(85, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome do Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(16, 71);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 3;
            this.lbEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(118, 71);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(154, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
    }
}


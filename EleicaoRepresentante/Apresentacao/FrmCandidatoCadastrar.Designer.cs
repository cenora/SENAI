namespace Apresentacao
{
    partial class FrmCandidatoCadastrar
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNascimento = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.PickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 12);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelNascimento
            // 
            this.labelNascimento.AutoSize = true;
            this.labelNascimento.Location = new System.Drawing.Point(12, 59);
            this.labelNascimento.Name = "labelNascimento";
            this.labelNascimento.Size = new System.Drawing.Size(104, 13);
            this.labelNascimento.TabIndex = 2;
            this.labelNascimento.Text = "Data de Nascimento";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(12, 130);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 11;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(12, 163);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 12;
            this.labelSenha.Text = "Senha";
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(9, 276);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(38, 13);
            this.labelIdioma.TabIndex = 13;
            this.labelIdioma.Text = "Idioma";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 28);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(240, 20);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(64, 127);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 4;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(64, 160);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenha.TabIndex = 5;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // PickerDataNascimento
            // 
            this.PickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickerDataNascimento.Location = new System.Drawing.Point(12, 75);
            this.PickerDataNascimento.Name = "PickerDataNascimento";
            this.PickerDataNascimento.Size = new System.Drawing.Size(104, 20);
            this.PickerDataNascimento.TabIndex = 3;
            this.PickerDataNascimento.ValueChanged += new System.EventHandler(this.PickerDataNascimento_ValueChanged);
            // 
            // pictureBoxFoto
            // 
            //this.pictureBoxFoto.Image = global::Apresentacao.Properties.Resources.perfil;
            this.pictureBoxFoto.Location = new System.Drawing.Point(258, 12);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(165, 181);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 3;
            this.pictureBoxFoto.TabStop = false;
            this.pictureBoxFoto.LocationChanged += new System.EventHandler(this.pictureBoxFoto_LocationChanged);
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(64, 273);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdioma.TabIndex = 6;
            this.comboBoxIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdioma_SelectedIndexChanged);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(258, 199);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 8;
            this.buttonAtualizar.Text = "&Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(348, 199);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "&Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(263, 271);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "&Salvar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(344, 271);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(224, 75);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(28, 20);
            this.textBoxCodigo.TabIndex = 14;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(178, 78);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 15;
            this.labelCodigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "OK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "OK";
            // 
            // FrmPessoaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.PickerDataNascimento);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelNascimento);
            this.Controls.Add(this.labelNome);
            this.Name = "FrmPessoaCadastrar";
            this.Text = "Cadastro de Pessoa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNascimento;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.DateTimePicker PickerDataNascimento;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
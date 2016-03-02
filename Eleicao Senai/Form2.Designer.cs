namespace Eleicao
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bntSaveData = new System.Windows.Forms.Button();
            this.bntUpdateData = new System.Windows.Forms.Button();
            this.bntDeleteData = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eleicaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.eleicaoDataSet = new Eleicao.eleicaoDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bgBindingSource = new System.Windows.Forms.BindingSource(this.components);
  //          this.bgTableAdapter = new Eleicao.eleicaoDataSetTableAdapters.bgTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turmasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdVotosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(12, 28);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 1;
            this.lblTurma.Text = "Turma";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(161, 28);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(100, 20);
            this.txtTurma.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(161, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // bntSaveData
            // 
            this.bntSaveData.Location = new System.Drawing.Point(6, 15);
            this.bntSaveData.Name = "bntSaveData";
            this.bntSaveData.Size = new System.Drawing.Size(91, 23);
            this.bntSaveData.TabIndex = 10;
            this.bntSaveData.Text = "Salvar";
            this.bntSaveData.UseVisualStyleBackColor = true;
            this.bntSaveData.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntUpdateData
            // 
            this.bntUpdateData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bntUpdateData.Location = new System.Drawing.Point(103, 15);
            this.bntUpdateData.Name = "bntUpdateData";
            this.bntUpdateData.Size = new System.Drawing.Size(91, 23);
            this.bntUpdateData.TabIndex = 11;
            this.bntUpdateData.Text = "Atualizar";
            this.bntUpdateData.UseVisualStyleBackColor = true;
            this.bntUpdateData.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntDeleteData
            // 
            this.bntDeleteData.Location = new System.Drawing.Point(59, 44);
            this.bntDeleteData.Name = "bntDeleteData";
            this.bntDeleteData.Size = new System.Drawing.Size(91, 23);
            this.bntDeleteData.TabIndex = 12;
            this.bntDeleteData.Text = "Retirar";
            this.bntDeleteData.UseVisualStyleBackColor = true;
            this.bntDeleteData.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(586, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTurma);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtTurma);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(34, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 125);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidato";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(161, 93);
            this.idText.MaxLength = 2;
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(33, 20);
            this.idText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntSaveData);
            this.groupBox2.Controls.Add(this.bntUpdateData);
            this.groupBox2.Controls.Add(this.bntDeleteData);
            this.groupBox2.Location = new System.Drawing.Point(34, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 105);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(34, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cadastro de Candidato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(557, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cadastrados";
            // 
            // eleicaoDataSetBindingSource
            // 
            this.eleicaoDataSetBindingSource.DataSource = this.eleicaoDataSet;
            this.eleicaoDataSetBindingSource.Position = 0;
            // 
            // eleicaoDataSet
            // 
            this.eleicaoDataSet.DataSetName = "eleicaoDataSet";
            this.eleicaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.candidatoDataGridViewTextBoxColumn,
            this.turmasDataGridViewTextBoxColumn,
            this.qtdVotosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bgBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(413, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 248);
            this.dataGridView1.TabIndex = 19;
            // 
            // bgBindingSource
            // 
            this.bgBindingSource.DataMember = "bg";
            this.bgBindingSource.DataSource = this.eleicaoDataSetBindingSource;
            // 
            // bgTableAdapter
            // 
            this.bgTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // candidatoDataGridViewTextBoxColumn
            // 
            this.candidatoDataGridViewTextBoxColumn.DataPropertyName = "candidato";
            this.candidatoDataGridViewTextBoxColumn.HeaderText = "candidato";
            this.candidatoDataGridViewTextBoxColumn.Name = "candidatoDataGridViewTextBoxColumn";
            // 
            // turmasDataGridViewTextBoxColumn
            // 
            this.turmasDataGridViewTextBoxColumn.DataPropertyName = "turmas";
            this.turmasDataGridViewTextBoxColumn.HeaderText = "turmas";
            this.turmasDataGridViewTextBoxColumn.Name = "turmasDataGridViewTextBoxColumn";
            // 
            // qtdVotosDataGridViewTextBoxColumn
            // 
            this.qtdVotosDataGridViewTextBoxColumn.DataPropertyName = "qtdVotos";
            this.qtdVotosDataGridViewTextBoxColumn.HeaderText = "qtdVotos";
            this.qtdVotosDataGridViewTextBoxColumn.Name = "qtdVotosDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(862, 372);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Eleição de Representante SESI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button bntSaveData;
        private System.Windows.Forms.Button bntUpdateData;
        private System.Windows.Forms.Button bntDeleteData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource eleicaoDataSetBindingSource;
        private eleicaoDataSet eleicaoDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bgBindingSource;
        private eleicaoDataSetTableAdapters.bgTableAdapter bgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turmasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdVotosDataGridViewTextBoxColumn;
    }
}
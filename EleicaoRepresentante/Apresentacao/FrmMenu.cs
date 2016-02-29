using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCandidatoCadastrar frmPessoaCadastrar = new FrmCandidatoCadastrar(CRUD.Inserir, null);
            frmPessoaCadastrar.MdiParent = this;
            frmPessoaCadastrar.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCandidatoSelecionar frmPessoaSelecionar = new FrmCandidatoSelecionar();
            frmPessoaSelecionar.MdiParent = this;
            frmPessoaSelecionar.Show();
        }

    }
}

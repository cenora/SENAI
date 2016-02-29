using System;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmCandidatoSelecionar : Form
    {
        public FrmCandidatoSelecionar()
        {
            InitializeComponent();
            //Negar geração automatica do Grid
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            CandidatoNegocios pessoaNegocios = new CandidatoNegocios();
            CandidatoCollection pessoaColecao = new CandidatoCollection();
            pessoaColecao = pessoaNegocios.ConsultaPorNome(textBoxPesquisa.Text);
            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = pessoaColecao;

            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }

        private void buttonfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //tem registro?
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma pessoa selecionada.");
                return;
            }
            //deseja realmente excluir?
            DialogResult resultado = MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Pegar cliente selecionado
            Candidato pessoaSelecionada = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Candidato);

            CandidatoNegocios pessoaNegocio = new CandidatoNegocios();
            string retorno = pessoaNegocio.Excluir(pessoaSelecionada);

            try
            {
                int idPessoa = Convert.ToInt32(retorno);
                MessageBox.Show("Pessoa excluída com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {

                MessageBox.Show("Não foi possível excluir." + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            FrmCandidatoCadastrar frmCadastrarPessoa = new FrmCandidatoCadastrar(CRUD.Inserir, null);
            DialogResult dialogResult = frmCadastrarPessoa.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
            //frmCadastrarPessoa.ShowDialog();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //tem registro?
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma pessoa selecionada.");
                return;
            }

            //Pegar cliente selecionado CAST
            Candidato pessoaSelecionada = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Candidato);

            FrmCandidatoCadastrar frmPessoaCadastrar = new FrmCandidatoCadastrar(CRUD.Alterar, pessoaSelecionada);
            //frmCadastrarPessoa.ShowDialog();
            DialogResult resultado = frmPessoaCadastrar.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //tem registro?
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma pessoa selecionada.");
                return;
            }

            //Pegar cliente selecionado CAST
            Candidato pessoaSelecionada = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Candidato);

            FrmCandidatoCadastrar frmCadastrarPessoa = new FrmCandidatoCadastrar(CRUD.Consultar, pessoaSelecionada);
            frmCadastrarPessoa.ShowDialog();
        }
    }
}

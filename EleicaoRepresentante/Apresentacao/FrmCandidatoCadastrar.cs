using System;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmCandidatoCadastrar : Form
    {
        //Pegar objeto que veio pelo construtor
        CRUD acaoNaTelaSelecionada;


        public FrmCandidatoCadastrar(CRUD crud, Candidato candidato)
        {
            InitializeComponent();

            acaoNaTelaSelecionada = crud;

            switch (crud)
            {
                case CRUD.Alterar:
                    Text = "Alterar Pessoa";
                    PreencheFrm(candidato);
                    buttonCadastrar.Enabled = false;
                    break;
                case CRUD.Consultar:
                    Text = "Consultar Pessoa";
                    PreencheFrm(candidato);
                    DesabilitaFrm();
                    break;
                case CRUD.Excluir:
                    Text = "Excluir Pessoa";
                    break;
                case CRUD.Inserir:
                    Text = "Inserir Pessoa";
                    buttonCadastrar.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void PreencheFrm(Candidato candidato)
        {
            textBoxNome.Text = candidato.Nome.ToString();
            //textBoxSenha.Text = candidato.Senha.ToString();
            //textBoxUsuario.Text = candidato.Usuario.ToString();
            //textBoxCodigo.Text = candidato.IdPessoa.ToString();
            //PickerDataNascimento.Value = candidato.Nascimento;
            //comboBoxIdioma.SelectedValue = pessoa;
            pictureBoxFoto.ImageLocation = candidato.Foto;
        }

        private void DesabilitaFrm()
        {
            textBoxNome.ReadOnly = true;
            textBoxSenha.ReadOnly = true;
            textBoxUsuario.ReadOnly = true;
            PickerDataNascimento.Enabled = false;
            comboBoxIdioma.Enabled = false;
            buttonCadastrar.Visible = false;
            buttonAtualizar.Visible = false;
            buttonApagar.Visible = false;
            buttonCancelar.Text = "Fechar";
            buttonCancelar.Focus();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (acaoNaTelaSelecionada == CRUD.Inserir)
            {
                Candidato candidato = new Candidato();
                candidato.Nome = textBoxNome.Text;
                //candidato.Usuario = textBoxUsuario.Text;
                //candidato.Senha = textBoxSenha.Text;
                //candidato.Nascimento = PickerDataNascimento.Value;
                candidato.Foto = pictureBoxFoto.ImageLocation;
                //pessoa.idioma = comboBoxIdioma.SelectedItem;
                CandidatoNegocios pessoaNegocios = new CandidatoNegocios();
                string retorno = pessoaNegocios.Inserir(candidato);

                try
                {
                    int idPessoa = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa inserida com sucesso. Código: " + idPessoa.ToString());
                    DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel inserir a pessoa. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }
            }

            if (acaoNaTelaSelecionada == CRUD.Alterar)
            {
                Candidato candidato = new Candidato();
                //candidato.IdPessoa = int.Parse(textBoxCodigo.Text);
                candidato.Nome = textBoxNome.Text;
                //candidato.Usuario = textBoxUsuario.Text;
                //candidato.Senha = textBoxSenha.Text;
                //candidato.Nascimento = PickerDataNascimento.Value;
                candidato.Foto = pictureBoxFoto.ImageLocation;
                //pessoa.idioma = comboBoxIdioma.SelectedItem;
                CandidatoNegocios pessoaNegocios = new CandidatoNegocios();
                string retorno = pessoaNegocios.Alterar(candidato);

                try
                {
                    int idPessoa = Convert.ToInt32(retorno);
                    MessageBox.Show("Pessoa alterada com sucesso. Código: " + idPessoa.ToString());
                    DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar a pessoa. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.No;
                }
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            OpenFileDialog alterarImagem = new OpenFileDialog();
            alterarImagem.Filter = "Bitmap|*.bmp|Jpeg|*.jpg|PNG|*.png";
            if (alterarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.ImageLocation = alterarImagem.FileName;
                pictureBoxFoto.Refresh();
            }
        }

        private void HabilitarSalvar()
        {
            if (!string.IsNullOrWhiteSpace(textBoxNome.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSenha.Text) &&
                !string.IsNullOrWhiteSpace(textBoxUsuario.Text) &&
                !string.IsNullOrWhiteSpace(pictureBoxFoto.ImageLocation) &&
                !string.IsNullOrWhiteSpace(PickerDataNascimento.Value.ToString()) &&
                !string.IsNullOrWhiteSpace(comboBoxIdioma.SelectedItem.ToString())
                )
            {
                buttonCadastrar.Enabled = true;
            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            HabilitarSalvar();
        }

        private void PickerDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            HabilitarSalvar();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            CandidatoNegocios pessoaNegocios = new CandidatoNegocios();
            ///TODO : Criar procedure VerificarNome
            ///Não deve Haver numeros
            //string retorno = pessoaNegocios.Inserir(pessoa);
            HabilitarSalvar();
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            ///TODO : Verificar Senha 1 Mausculo, 1 minusculo E numero
            HabilitarSalvar();
        }

        private void pictureBoxFoto_LocationChanged(object sender, EventArgs e)
        {
            HabilitarSalvar();
        }

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarSalvar();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            pictureBoxFoto.Image = Properties.Resources.perfil;
        }
    }
}

using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    /// <summary>
    /// Regras de Negocio para Pessoa
    /// </summary>
    public class PessoaNegocios
    {
        AcessoDadosMySQL acessoDadosMySql = new AcessoDadosMySQL();
        /// <summary>
        /// Inserir pessoa no Banco
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa, DTO Pessoa</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Inserir(Pessoa pessoa)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("@Nome",pessoa.Nome);
                acessoDadosMySql.AdicionarParametros("@Nascimento", pessoa.Nascimento);
                acessoDadosMySql.AdicionarParametros("@Usuario", pessoa.Usuario);
                acessoDadosMySql.AdicionarParametros("@Senha", pessoa.Senha);
                acessoDadosMySql.AdicionarParametros("@Foto", pessoa.Foto);
                string idPessoa = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaInserir").ToString();
                return idPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        /// <summary>
        /// Alterar pessoa no banco, enviar o Id
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa, DTO Pessoa</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Alterar(Pessoa pessoa)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("@IdPessoa", pessoa.IdPessoa);
                acessoDadosMySql.AdicionarParametros("@Nome", pessoa.Nome);
                acessoDadosMySql.AdicionarParametros("@Nascimento", pessoa.Nascimento);
                acessoDadosMySql.AdicionarParametros("@Usuario", pessoa.Usuario);
                acessoDadosMySql.AdicionarParametros("@Senha", pessoa.Senha);
                acessoDadosMySql.AdicionarParametros("@Foto", pessoa.Foto);
                string idPessoa = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaAlterar").ToString();
                return idPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        /// <summary>
        /// Excluir pessoa do banco
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa, DTO Pessoa</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Excluir(Pessoa pessoa)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("@IdPessoa", pessoa.IdPessoa);
                string idPessoa = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaExcluir").ToString();
                return idPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public PessoaCollection ConsultaPorNome(string nome)
        {
            try
            {
                PessoaCollection pessoaColecao = new PessoaCollection();
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("@Nome", nome);

                DataTable dataTablePessoa = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoaConsultarPorNome");

                foreach (DataRow linha in dataTablePessoa.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Nascimento = Convert.ToDateTime(linha["Nascimento"]);
                    pessoa.Usuario = Convert.ToString(linha["Usuario"]);
                    pessoa.Senha = Convert.ToString(linha["Senha"]);
                    pessoa.Foto = Convert.ToString(linha["Foto"]);
                    pessoaColecao.Add(pessoa);

                }

                return pessoaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar por Nome. Detalhes: "+exception.Message);
            }
        }

        public PessoaCollection ConsultarPorId(int idPessoa)
        {
            try
            {
                PessoaCollection pessoaColecao = new PessoaCollection();

                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("@IdPessoa",idPessoa);

                DataTable datatablePessoa = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPorId");

                foreach (DataRow linha in datatablePessoa.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Nascimento = Convert.ToDateTime(linha["Nascimento"]);
                    pessoa.Usuario = Convert.ToString(linha["Usuario"]);
                    pessoa.Senha = Convert.ToString(linha["Senha"]);
                    pessoa.Foto = Convert.ToString(linha["Foto"]);
                    pessoaColecao.Add(pessoa);
                }

                return pessoaColecao;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Não foi possivel consultar a pessoa pelo código. Detalhes: "+ex.Message);
            }
        }

    }
}

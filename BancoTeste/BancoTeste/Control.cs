using System;
using System.Data;

namespace BancoTeste
{

    /// <summary>
    /// Regras de Negocio para Pessoa
    /// </summary>
    public class Control
    {
        Model acessoDadosSqlServer = new Model();

        /// <summary>
        /// Inserir pessoa no Banco
        /// </summary>
        /// <param name="pessoa">Objeto Pessoa, DTO Pessoa</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Inserir(DTOPessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("n", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("r", pessoa.Endereco);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsere").ToString();
                return retorno;
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
        public string Alterar(DTOPessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("n", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("r", pessoa.Endereco);
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaAlterar").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }



    }
}

using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    /// <summary>
    /// Regras de Negocio para usuario
    /// </summary>
    class UsuarioNegocios
    {
        AcessoDadosMySQL acessoDadosMySql = new AcessoDadosMySQL();

        /// <summary>
        /// Inserir usuario no Banco
        /// </summary>
        /// <param name="usuario">Objeto usuario, DTO usuario</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Inserir(Usuario usuario)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("nome", usuario.Nome);
                acessoDadosMySql.AdicionarParametros("senha", usuario.Senha);

                string idUsuario = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spUsuarioCadastro").ToString();
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        /// <summary>
        /// Alterar usuario no banco, enviar o Id
        /// </summary>
        /// <param name="usuario">Objeto usuario, DTO usuario</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Alterar(Usuario usuario)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idCandidato", usuario.IdUsuario);
                acessoDadosMySql.AdicionarParametros("nome", usuario.Nome);
                acessoDadosMySql.AdicionarParametros("senha", usuario.Senha);
                string idUsuario = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spUsuarioAtualiza").ToString();
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Excluir usuario do banco
        /// </summary>
        /// <param name="usuario">Objeto usuario, DTO usuario</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idUsuario", usuario.IdUsuario);
                string idUsuario = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spUsuarioDeleta").ToString();
                return idUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        /// <summary>
        /// Consultar Foto por Legenda
        /// </summary>
        /// <param name="legenda">int</param>
        /// <returns>CandidatoCollection</returns>
        public CandidatoCollection ConsultarFotoPorLegenda(int legenda)
        {
            try
            {
                CandidatoCollection candidatoColecao = new CandidatoCollection();

                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("legenda", legenda);

                DataTable datatableCandidato = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "spCandidatoSelecionaFotoPorLegenda");

                foreach (DataRow linha in datatableCandidato.Rows)
                {
                    Candidato candidato = new Candidato();
                    candidato.Foto = Convert.ToString(linha["foto"]);
                    candidatoColecao.Add(candidato);
                }

                return candidatoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel consultar a foto do Candidato. Detalhes: " + ex.Message);
            }
        }

    }
}

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
        /// Consultar Usuario por ID
        /// </summary>
        /// <param name="idUsuario">int</param>
        /// <returns>UsuarioCollection</returns>
        public UsuarioCollection ConsultarPorId(int idUsuario)
        {
            try
            {
                UsuarioCollection usuarioColecao = new UsuarioCollection();

                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idUsuario", idUsuario);

                DataTable datatableUsuario = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "spUsuarioSelecionaPorId");

                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.Nome = Convert.ToString(linha["nome"]);
                    usuario.Senha = Convert.ToString(linha["senha"]);
                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel consultar a foto do Candidato. Detalhes: " + ex.Message);
            }
        }

        /// <summary>
        /// Fazer login em Usuario
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="senha"></param>
        /// <returns>True para login</returns>
        public bool Login(string nome, string senha)
        {
            try
            {
                UsuarioCollection usuarioColecao = new UsuarioCollection();

                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("nome", nome);
                acessoDadosMySql.AdicionarParametros("senha", senha);

                DataTable datatableUsuario = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "spUsuarioLogin");

                foreach (DataRow linha in datatableUsuario.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(linha["idUsuario"]);
                    usuarioColecao.Add(usuario);
                }

                if (usuarioColecao.Count != 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel fazer login. Detalhes: " + ex.Message);
            }
        }

    }
}

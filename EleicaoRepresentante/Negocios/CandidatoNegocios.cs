using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    /// <summary>
    /// Regras de Negocio para candidato
    /// </summary>
    public class CandidatoNegocios
    {
        AcessoDadosMySQL acessoDadosMySql = new AcessoDadosMySQL();

        /// <summary>
        /// Inserir candidato no Banco
        /// </summary>
        /// <param name="candidato">Objeto Candidato, DTO Candidato</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Inserir(Candidato candidato)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("legenda", candidato.Legenda);
                acessoDadosMySql.AdicionarParametros("sexo", candidato.Sexo);
                acessoDadosMySql.AdicionarParametros("foto", candidato.Foto);
                acessoDadosMySql.AdicionarParametros("idTurma", candidato.IdTurma);
                acessoDadosMySql.AdicionarParametros("nome", candidato.Nome);
                acessoDadosMySql.AdicionarParametros("escola", candidato.Escola);
                string idCandidato = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spCandidatoCadastro").ToString();
                return idCandidato;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        /// <summary>
        /// Alterar candidato no banco, enviar o Id
        /// </summary>
        /// <param name="candidato">Objeto Candidato, DTO Candidato</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Alterar(Candidato candidato)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idCandidato", candidato.IdCandidato);
                acessoDadosMySql.AdicionarParametros("legenda", candidato.Legenda);
                acessoDadosMySql.AdicionarParametros("sexo", candidato.Sexo);
                acessoDadosMySql.AdicionarParametros("foto", candidato.Foto);
                acessoDadosMySql.AdicionarParametros("idTurma", candidato.IdTurma);
                acessoDadosMySql.AdicionarParametros("nome", candidato.Nome);
                acessoDadosMySql.AdicionarParametros("escola", candidato.Escola);
                string idCandidato = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spCandidatoAtualiza").ToString();
                return idCandidato;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Excluir candidato do banco
        /// </summary>
        /// <param name="candidato">Objeto Candidato, DTO Candidato</param>
        /// <returns>Id do Registro ou mensagem de erro</returns>
        public string Excluir(Candidato candidato)
        {
            try
            {
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idCandidato", candidato.IdCandidato);
                string idCandidato = acessoDadosMySql.ExecutarManipulacao(CommandType.StoredProcedure, "spCandidatoDeleta").ToString();
                return idCandidato;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Consultar Candidato por Turma
        /// </summary>
        /// <param name="turma">int</param>
        /// <returns>CandidatoCollection</returns>
        public CandidatoCollection ConsultaPorTurma(int turma)
        {
            try
            {
                CandidatoCollection candidatoColecao = new CandidatoCollection();
                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idTurma", turma);

                DataTable dataTableCandidato = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "spCandidatoSelecionaPorTurma");

                foreach (DataRow linha in dataTableCandidato.Rows)
                {
                    Candidato candidato = new Candidato();
                    candidato.IdCandidato = Convert.ToInt32(linha["idCandidato"]);
                    candidato.Legenda = Convert.ToInt32(linha["legenda"]);
                    candidato.Sexo = Convert.ToString(linha["sexo"]);
                    candidato.Foto = Convert.ToString(linha["foto"]);
                    candidato.Nome = Convert.ToString(linha["nome"]);
                    candidato.Escola = Convert.ToString(linha["escola"]);
                    candidato.TotalVotos = Convert.ToInt32(linha["totalVotos"]);
                    candidatoColecao.Add(candidato);

                }

                return candidatoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar por Turma. Detalhes: "+exception.Message);
            }
        }

        /// <summary>
        /// Consultar Candidato por Id
        /// </summary>
        /// <param name="idCandidato">int</param>
        /// <returns>CandidatoCollection</returns>
        public CandidatoCollection ConsultarPorId(int idCandidato)
        {
            try
            {
                CandidatoCollection candidatoColecao = new CandidatoCollection();

                acessoDadosMySql.LimparParametros();
                acessoDadosMySql.AdicionarParametros("idCandidato",idCandidato);

                DataTable datatableCandidato = acessoDadosMySql.ExecutarConsulta(CommandType.StoredProcedure, "spCandidatoSelecionaPorId");

                foreach (DataRow linha in datatableCandidato.Rows)
                {
                    Candidato candidato = new Candidato();
                    candidato.Legenda = Convert.ToInt32(linha["legenda"]);
                    candidato.Sexo = Convert.ToString(linha["sexo"]);
                    candidato.Foto = Convert.ToString(linha["foto"]);
                    candidato.Nome = Convert.ToString(linha["nome"]);
                    candidato.Escola = Convert.ToString(linha["escola"]);
                    candidato.TotalVotos = Convert.ToInt32(linha["totalVotos"]);
                    candidatoColecao.Add(candidato);
                }

                return candidatoColecao;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Não foi possivel consultar o candidato pelo código. Detalhes: "+ex.Message);
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

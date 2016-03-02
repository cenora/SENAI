using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EleicaoMVC.DTO;

namespace EleicaoMVC.Control
{
    class CandidatoControl
    {
        DTOcandidato dto = new DTOcandidato();
        //inserir
        public int InserirCandidato()
        {
            try
            {
                //model.executar(stp,@){
                dto.Nome = "";
                dto.Sexo = 'c';
                dto.Turma = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro", "Erro", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                throw;
            }
            return 0;
        }
        //deletar
        //alterar
        //consultarNome
        //ConsultarTurma
        //ConsultarLegenda
        //InserirFoto
    }
}

using System;

namespace ObjetoTransferencia
{
    public class Candidato
    {
        public int IdCandidato { get; set; }
        public int Legenda { get; set; }
        public string Sexo { get; set; }
        public string Foto { get; set; }
        public int IdTurma { get; set; }
        public string Nome { get; set; }
        public string escola { get; set; }

        //apagar
        public string Senha { get; set; }
        public string Usuario { get; set; }
        public DateTime Nascimento { get; set; }
    }
}

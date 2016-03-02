using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoMVC.DTO
{
    public class DTOcandidato
    {
        int legenda;
        string nome, endFoto, turma;
        char sexo;

        public string EndFoto
        {
            get
            {
                return endFoto;
            }

            set
            {
                endFoto = value;
            }
        }

        public int Legenda
        {
            get
            {
                return legenda;
            }

            set
            {
                legenda = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Turma
        {
            get
            {
                return turma;
            }

            set
            {
                turma = value;
            }
        }
    }
}

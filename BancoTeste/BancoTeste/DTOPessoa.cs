using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoTeste
{
    public class DTOPessoa
    {
        string nome;
        string endereco;
        int id;

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

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosOO
{
    class D6Normal:DadoNormal
    {
        public D6Normal()
        {
            tamanho = "pequeno";
            cor = "branco";
            maiorFace = 6;
            menorFace = 1;
        }

        public string GetTamanho()
        {
            return "Tamanho:"+ tamanho;
        }

        public string GetCor()
        {
            return "Cor:" + cor;
        }

        public void SetCor(string hotwheels)
        {
            cor = hotwheels;
        }
    }
}

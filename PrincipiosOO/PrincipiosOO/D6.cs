using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosOO
{
    class D6 : Dado
    {
        public D6()
        {
            this.cor = "branco";
            this.menorFace = 1;
            this.maiorFace = 6;
            this.tamanho = "normal";
        }

        protected override int rolarDado()
        {
            Random sorte = new Random();
            return sorte.Next(this.menorFace,this.maiorFace);
        }
    }
}

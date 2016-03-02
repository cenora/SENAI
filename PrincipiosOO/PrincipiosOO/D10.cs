using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosOO
{
    class D10 : Dado
    {
        public D10()
        {
            this.cor = "amarelo";
            this.menorFace = 1;
            this.maiorFace = 10;
            this.tamanho = "normal";
        }

        protected override int rolarDado()
        {
            Random sorte = new Random();
            return sorte.Next(this.menorFace, this.maiorFace);
        }
    }
}

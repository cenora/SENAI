using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosOO
{
    abstract class Dado
    {
        protected string tamanho;
        protected string cor;
        protected int maiorFace;
        protected int menorFace;
        abstract protected int rolarDado();
    }
}

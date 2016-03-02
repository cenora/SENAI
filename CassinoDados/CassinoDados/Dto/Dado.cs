using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassinoDados.Dto
{
    class Dado
    {
        int face;

        public int Face
        {
            get
            {
                return face;
            }
            set
            {
                face = value;
            }
        }
         public void sortear()
        {
            Random aleatorio = new Random();
            face = aleatorio.Next(1,6);
        }
    }
}

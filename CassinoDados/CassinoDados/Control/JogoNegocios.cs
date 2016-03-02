using CassinoDados.Dto;

namespace CassinoDados.Control
{
    class JogoNegocios
    {
        Dado dado1 = new Dado();
        Dado dado2 = new Dado();
        public void lancar()
        {
            dado1.sortear();
            dado2.sortear();
        }
        
        public bool verificar()
        {
            if ((dado1.Face + dado2.Face)==7)
            {
                return true;
            }
            return false;
        }
    }
}

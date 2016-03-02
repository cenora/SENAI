using System;
using System.Windows.Forms; //classe de formularios

namespace PrincipiosOO
{
    class TesteTempo
    {
        public static void Main()
        {
            //chama o construtor de Tempo
            Tempo relogio = new Tempo();
            string saida;

            //atribui a representação de string de tempo a saida
            saida = "O tempo no formato universal é: " +
                relogio.FormatoUniversal() +
                "\nO tempo no formato padrão é: " +
                relogio.FormatoPadrao();

            //tenta configurações de hora válidas
            relogio.DefinirTempo(13,27,6);

            //atribui a representação de string de tempo a saida
            saida += "O tempo no formato universal é: " +
                relogio.FormatoUniversal() +
                "\nO tempo no formato padrão é: " +
                relogio.FormatoPadrao();

            //tenta configurações de hora inválidas
            relogio.DefinirTempo(99, 99, 99);

            //atribui a representação de string de tempo a saida
            saida += "O tempo no formato universal é: " +
                relogio.FormatoUniversal() +
                "\nO tempo no formato padrão é: " +
                relogio.FormatoPadrao();

            MessageBox.Show(saida, "Teste de Tempo");
        } //Fim do método Main
    }//Fim da Classe
}

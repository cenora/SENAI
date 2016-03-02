using System;

namespace PrincipiosOO
{
    //Definição da Classe Tempo
    //[Visibilidade][class][NomeDaClasse]
    public class Tempo:Object 
        //Toda Classe herda automaticamente de Object
    {
        /*Atributos
        Normalmente colocamos todos aqui, fica mais organizado
        Todos os atributos colocados aqui, podem ser acessados 
        por todos os métodos*/

        //[Visibilidade][tipo][nome]
        private int hora; //0 a 23
        private int minuto; //0 a 59
        private int segundo; //0 a 59

        //o construtor de Tempo inicializa variáveis de instância
        //como zero para configurar a hora padrão como meia-noite
        public Tempo()
        {
            DefinirTempo(0, 0, 0);
        }

        //Construtores Sobrecarregados
        public Tempo(int hora)
        {
            DefinirTempo(hora, 0, 0);
        }

        public Tempo(int hora, int minuto)
        {
            DefinirTempo(hora,minuto, 0);
        }

        public Tempo(int hora, int minuto, int segundo)
        {
            DefinirTempo(hora, minuto, segundo);
        }


        /*Configura o novo valor de hora no formato de 24 horas
        Realiza verificações de validade nos dados. 
        Configura os valores inválidos como zero.*/
        public void DefinirTempo(int valorHora, int valorMinuto, int valorSegundo)
        {
            hora = (valorHora >= 0 && valorHora < 24) ? valorHora : 0;
            minuto = (valorMinuto >= 0 && valorMinuto < 59) ? valorMinuto : 0;
            segundo = (valorSegundo >= 0 && valorSegundo < 59) ? valorSegundo : 0;
        } //fim do método DefinirTempo

        //converte a hora para a string de formato de hora
        //universal (24 horas)
        public string FormatoUniversal()
        {
            return String.Format("{0:D2}:{1:D2}:{2:D2}",hora,minuto,segundo);
        }//fim do método FormatoUniversal

        //converte a hora para o formato de hora padrão (12 horas)
        public string FormatoPadrao()
        {
            return String.Format("{0}:{1:D2}:{2:D2} {3}", 
                ( (hora == 12 || hora == 0) ? 12 : hora % 12),
                minuto,segundo,(hora < 12 ? "AM" : "PM") );
        }//fim do método FormatoPadrao
    }//Fim da Classe Tempo
}

//Problema "tempo_de_jogo" (adaptado de URI 1046)
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo
//pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. 

namespace JogoCalculoDuracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracaoJogo;

            Console.Write("Hora inicial: ");
            horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial >= horaFinal)
            {
                duracaoJogo = (24 - horaInicial) + horaFinal;
            }
            else
            {
                duracaoJogo = horaFinal - horaInicial;
            }

            Console.WriteLine($"O JOGO DUROU {duracaoJogo} HORA(S)");
        }
    }
}

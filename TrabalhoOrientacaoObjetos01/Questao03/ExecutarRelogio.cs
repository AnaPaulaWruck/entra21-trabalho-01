using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    // Guilherme Dzesigaleski Mueller
    // Participação especial Amanda Bauler.
    public class ExecutarRelogio
    {
        public void Executar()
        {
            Console.Clear();
            var opcaoDesejada = 0;

            var relogio = new Relogio();

            while (opcaoDesejada != 5)
            {

                Console.WriteLine(@"-------MENU-------
            1 - OBTER HORA POR EXTENSO
            2 - OBTER MINUTO POR EXTENSO 
            3 - OBTER SEGUNDO POR EXTENSO
            4 - OBTER HORARIO COMPLETO POR EXTENSO
            5 - SAIR");

                Console.WriteLine("Escolha a opção desejada: ");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                if (opcaoDesejada == 1)
                {
                    Console.WriteLine("Digite um horario: ");
                    DateTime horaEscolhida = Convert.ToDateTime(Console.ReadLine());

                    relogio.Hora = horaEscolhida;

                    Console.WriteLine("A hora é: " + relogio.ObterHoraPorExtenso());
                }
                else if (opcaoDesejada == 2)
                {
                    Console.WriteLine("Digite um horario: ");
                    DateTime horaEscolhida = Convert.ToDateTime(Console.ReadLine());

                    relogio.Hora = horaEscolhida;

                    Console.WriteLine("O minuto é: " + relogio.ObterMinutoPorExtenso());
                }
                else if (opcaoDesejada == 3)
                {
                    Console.WriteLine("Digite um horario: ");
                    DateTime horaEscolhida = Convert.ToDateTime(Console.ReadLine());

                    relogio.Hora = horaEscolhida;

                    Console.WriteLine("O segundo é: " + relogio.ObterSegundoPorExtenso());
                }
                else if (opcaoDesejada == 4)
                {
                    Console.WriteLine("Digite um horario: ");
                    DateTime horaEscolhida = Convert.ToDateTime(Console.ReadLine());

                    relogio.Hora = horaEscolhida;

                    Console.WriteLine("Horario completo: " + relogio.ApresentarHoraPorExtenso());
                }

            }
        }
    }
}
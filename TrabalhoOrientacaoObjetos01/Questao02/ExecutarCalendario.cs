using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class ExecutarCalendario
    {
        public void Executar()
        {
            Console.Clear();
            var opcaoDesejada = 0;

            var calendario = new Calendario();       
            
            while (opcaoDesejada != 5)
            {
                
                Console.WriteLine(@"-------MENU-------
            1 - OBTER MÊS POR EXTENSO
            2 - OBTER DIA POR EXTENSO 
            3 - OBTER ANO POR EXTENSO
            4 - OBTER DATA COMPLETA POR EXTENSO
            5 - SAIR");

                Console.WriteLine("Escolha a opção desejada: ");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());


                if (opcaoDesejada == 1)
                {
                    Console.WriteLine("Digite uma data no formato: (YYYY/MM/DD) ");
                    DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                    calendario.Data = dataEscolhida;

                    Console.WriteLine("O mês é: " + calendario.ObterMesPorExtenso());
                }
                else if (opcaoDesejada == 2)
                {
                    Console.WriteLine("Digite uma data no formato: (YYYY/MM/DD) ");
                    DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                    calendario.Data = dataEscolhida;

                    Console.WriteLine("O dia é: " + calendario.ObterDiaPorExtenso());
                }
                else if (opcaoDesejada == 3)
                {
                    Console.WriteLine("Digite uma data no formato: (YYYY/MM/DD) ");
                    DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                    calendario.Data = dataEscolhida;

                    Console.WriteLine("O ano é: " + calendario.ObterAnoPorExtenso());
                }
                else if (opcaoDesejada == 4)
                {
                    Console.WriteLine("Digite uma data no formato: (YYYY/MM/DD) ");
                    DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                    calendario.Data = dataEscolhida;

                    Console.WriteLine("Data por extenso: " + calendario.ObterDataCompletaPorExtenso());
                }
            }
            
        }
    }
}

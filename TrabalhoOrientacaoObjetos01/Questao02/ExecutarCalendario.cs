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
            Console.WriteLine(@"-------MENU-------
            1 - OBTER MÊS POR EXTENSO
            2 - OBTER DIA POR EXTENSO 
            3 - OBTER ANO POR EXTENSO");

            Console.WriteLine("Escolha a opção desejada: ");
            var calendario = new Calendario();
            int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
            if(opcaoDesejada == 1)
            {
                Console.WriteLine("Digite uma data: ");
                DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                calendario.Data = dataEscolhida;

                Console.WriteLine("O mês é: " + calendario.ObterMesPorExtenso());
            }
            else if (opcaoDesejada == 2)
            {
                Console.WriteLine("Digite uma data: ");
                DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                calendario.Data = dataEscolhida;

                Console.WriteLine("O mês é: " + calendario.ObterDiaPorExtenso());
            }
            else if (opcaoDesejada == 3)
            {
                Console.WriteLine("Digite uma data: ");
                DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

                calendario.Data = dataEscolhida;

                Console.WriteLine("O mês é: " + calendario.ObterAnoPorExtenso());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao01
{
    // Ana Paula Wruck
    public class ExecutarNumero
    {
        public void Executar()
        {
            var numero = new Numero();
            numero.Valor = 0007.10;

            //Console.Clear();
            //var opcaoDesejada = 0;

            //var numero = new Numero();

            //while (opcaoDesejada != 5)
            //{

            //    Console.WriteLine(@"-------MENU-------
            //1 - OBTER MÊS POR EXTENSO
            //2 - OBTER DIA POR EXTENSO 
            //3 - OBTER ANO POR EXTENSO
            //4 - OBTER DATA COMPLETA POR EXTENSO
            //5 - SAIR");

            //    Console.WriteLine("Escolha a opção desejada: ");
            //    opcaoDesejada = Convert.ToInt32(Console.ReadLine());


            //    if (opcaoDesejada == 1)
            //    {
            //        Console.WriteLine("Digite uma data no formato: (YYYY/MM/DD) ");
            //        DateTime dataEscolhida = Convert.ToDateTime(Console.ReadLine());

            //        calendario.Data = dataEscolhida;

            //        Console.WriteLine("O mês é: " + calendario.ObterMesPorExtenso());
            //    }

                Console.WriteLine("\n" + numero.ApresentarMilharExtenso());

                //Console.WriteLine("Valor total: " + numero.ObterValorTotalExtenso());
            }
        }
    }
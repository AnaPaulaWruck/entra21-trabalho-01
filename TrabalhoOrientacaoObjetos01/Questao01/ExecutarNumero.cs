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
            Console.Clear();

            var opcaoDesejada = 0;
            var numero = new Numero();

            while (opcaoDesejada != 9)
            {

                Console.WriteLine(@"
----------MENU----------
1 - OBTER MILHAR POR EXTENSO
2 - OBTER CENTENA POR EXTENSO
3 - OBTER DEZENA POR EXTENSO
4 - OBTER UNIDADE POR EXTENSO
5 - OBTER DECIMAL POR EXTENSO
9 - SAIR");

                Console.Write("\nDigite a opção desejada: ");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                if (opcaoDesejada == 1)
                {
                    Console.Write("Digite um número entre 0,00 e 9999,99: ");
                    double numeroDigitado = Convert.ToDouble(Console.ReadLine());

                    numero.Valor = numeroDigitado;

                    Console.WriteLine("\nMilhar por extenso: " + numero.ApresentarMilharExtenso());
                }

                else if (opcaoDesejada == 2)
                {
                    Console.Write("Digite um número entre 0,00 e 9999,99: ");
                    double numeroDigitado = Convert.ToDouble(Console.ReadLine());

                    numero.Valor = numeroDigitado;

                    Console.WriteLine("\nCentena por extenso: " + numero.ApresentarCentenaExtenso());
                }

                else if (opcaoDesejada == 3)
                {
                    Console.Write("Digite um número entre 0,00 e 9999,99: ");
                    double numeroDigitado = Convert.ToDouble(Console.ReadLine());

                    numero.Valor = numeroDigitado;

                    Console.WriteLine("\nDezena por extenso: " + numero.ApresentarDezenaExtenso());
                }

                else if (opcaoDesejada == 4)
                {
                    Console.Write("Digite um número entre 0,00 e 9999,99: ");
                    double numeroDigitado = Convert.ToDouble(Console.ReadLine());

                    numero.Valor = numeroDigitado;

                    Console.WriteLine("\nUnidade por extenso: " + numero.ApresentarUnidadeExtenso());
                }

                else if (opcaoDesejada == 5)
                {
                    Console.Write("Digite um número entre 0,00 e 9999,99: ");
                    double numeroDigitado = Convert.ToDouble(Console.ReadLine());

                    numero.Valor = numeroDigitado;

                    Console.WriteLine("\nDecimal por extenso: " + numero.ApresentarDecimalExtenso());
                }

                //Console.Clear();
            }
        }
    }
}
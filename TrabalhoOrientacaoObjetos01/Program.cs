Console.WriteLine(@"-------MENU-------
1 - Questão 1
2 - Questão 2
3 - Questão 3
4 - Questão 4");

Console.Write("\nDigite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Questao01 questao01 = new Questao01();
    questao01.Executar();
}

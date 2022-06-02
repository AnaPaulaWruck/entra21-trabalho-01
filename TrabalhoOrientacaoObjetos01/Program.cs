using TrabalhoOrientacaoObjetos01.Questao01;
using TrabalhoOrientacaoObjetos01.Questao02;
using TrabalhoOrientacaoObjetos01.Questao03;

Console.WriteLine(@"-------MENU-------
1 - Questão 1
2 - Questão 2
3 - Questão 3
9 - Sair");

Console.Write("\nDigite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

while (opcaoDesejada != 9)
{
    //if (opcaoDesejada == 1)
    //{
    //    ExemploNumero questao01 = new ExemploNumero();
    //    questao01.Executar();
    //}
    //else if (opcaoDesejada == 2)
    //{
    //    ExemploCalendario questao02 = new ExemploCalendario();
    //    questao02.Executar();
    //}
    //else if (opcaoDesejada == 3)
    //{
    //    ExemploRelogio questao03 = new ExemploRelogio();
    //    questao03.Executar();
    if (opcaoDesejada == 1)
    {
        ExecutarNumero questao01 = new ExecutarNumero();
        questao01.Executar();
    }
    else if (opcaoDesejada == 2)
    {
        ExecutarCalendario questao02 = new ExecutarCalendario();
        questao02.Executar();
    }
    else if (opcaoDesejada == 3)
    {
        ExemploRelogio questao03 = new ExemploRelogio();
        questao03.Executar();
    }
}


using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoOrientacaoObjetos01.Questao01;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Testes.Questao01
{
    // Ana Paula Wruck
    public class NumeroTestes
    {
        [Theory]
        [InlineData(1546.55, "mil e quinhentos e quarenta e seis vírgula cinquenta e cinco")]
        [InlineData(2005.11, "dois mil e cinco vírgula onze")]
        [InlineData(3404.13, "três mil e quatrocentos e quatro vírgula treze")]
        [InlineData(4101.30, "quatro mil e cento e um vírgula trinta")]
        [InlineData(5870.01, "cinco mil e oitocentos e setenta vírgula zero um")]
        [InlineData(6521.33, "seis mil e quinhentos e vinte e um vírgula trinta e três")]
        [InlineData(7000.00, "sete mil vírgula zero")]
        [InlineData(8200.02, "oito mil e duzentos vírgula zero dois")]
        [InlineData(9052.24, "nove mil e cinquenta e dois vírgula vinte e quatro")]
        [InlineData(1658.80, "mil e seiscentos e cinquenta e oito vírgula oitenta")]
        public void Validar_ApresentarMilharExtenso(double numeroDigitado, string numeroExtensoEsperado)
        {
            //Arrange
            var numero = new Numero();
            numero.Valor = numeroDigitado;

            //Act
            string milharExtenso = numero.ApresentarMilharExtenso();

            //Assert
            milharExtenso.Should().Be(numeroExtensoEsperado);
        }

        [Theory]
        [InlineData(153.05, "cento e cinquenta e três vírgula zero cinco")]
        [InlineData(100.20, "cem vírgula vinte")]
        [InlineData(204.12, "duzentos e quatro vírgula doze")]
        [InlineData(368.51, "trezentos e sessenta e oito vírgula cinquenta e um")]
        [InlineData(417.00, "quatrocentos e dezessete vírgula zero")]
        [InlineData(520.15, "quinhentos e vinte vírgula quinze")]
        [InlineData(609.11, "seiscentos e nove vírgula onze")]
        [InlineData(710.70, "setecentos e dez vírgula setenta")]
        [InlineData(890.13, "oitocentos e noventa vírgula treze")]
        [InlineData(906.44, "novecentos e seis vírgula quarenta e quatro")]
        public void Validar_ApresentarCentenaExtenso(double numeroDigitado, string numeroExtensoEsperado)
        {
            //Arrange
            var numero = new Numero();
            numero.Valor = numeroDigitado;

            //Act
            string milharExtenso = numero.ApresentarCentenaExtenso();

            //Assert
            milharExtenso.Should().Be(numeroExtensoEsperado);
        }
    }
}

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
        // Cenário 02: Validar todos os números menores que 10
        [Theory]
        [InlineData(9, "nove vírgula zero")]
        [InlineData(8, "oito vírgula zero")]
        [InlineData(7, "sete vírgula zero")]
        [InlineData(6, "seis vírgula zero")]
        [InlineData(5, "cinco vírgula zero")]
        [InlineData(4, "quatro vírgula zero")]
        [InlineData(3, "três vírgula zero")]
        [InlineData(2, "dois vírgula zero")]
        [InlineData(1, "um vírgula zero")]
        [InlineData(0, "zero vírgula zero")]
        public void Validar_ApresentarUnidadeExtenso(double numeroDigitado, string numeroExtensoEsperado)
        {
            //Arrange
            var numero = new Numero();
            numero.Valor = numeroDigitado;

            //Act
            string milharExtenso = numero.ApresentarUnidadeExtenso();

            //Assert
            milharExtenso.Should().Be(numeroExtensoEsperado);
        }

        // Cenário 03: Validar todos os números menores que 100
        [Theory]
        [InlineData(99, "noventa e nove vírgula zero")]
        [InlineData(98, "noventa e oito vírgula zero")]
        [InlineData(97, "noventa e sete vírgula zero")]
        [InlineData(96, "noventa e seis vírgula zero")]
        [InlineData(95, "noventa e cinco vírgula zero")]
        [InlineData(94, "noventa e quatro vírgula zero")]
        [InlineData(93, "noventa e três vírgula zero")]
        [InlineData(92, "noventa e dois vírgula zero")]
        [InlineData(91, "noventa e um vírgula zero")]
        [InlineData(90, "noventa vírgula zero")]
        [InlineData(89, "oitenta e nove vírgula zero")]
        [InlineData(88, "oitenta e oito vírgula zero")]
        [InlineData(87, "oitenta e sete vírgula zero")]
        [InlineData(86, "oitenta e seis vírgula zero")]
        [InlineData(85, "oitenta e cinco vírgula zero")]
        [InlineData(84, "oitenta e quatro vírgula zero")]
        [InlineData(83, "oitenta e três vírgula zero")]
        [InlineData(82, "oitenta e dois vírgula zero")]
        [InlineData(81, "oitenta e um vírgula zero")]
        [InlineData(80, "oitenta vírgula zero")]
        [InlineData(79, "setenta e nove vírgula zero")]
        [InlineData(78, "setenta e oito vírgula zero")]
        [InlineData(77, "setenta e sete vírgula zero")]
        [InlineData(76, "setenta e seis vírgula zero")]
        [InlineData(75, "setenta e cinco vírgula zero")]
        [InlineData(74, "setenta e quatro vírgula zero")]
        [InlineData(73, "setenta e três vírgula zero")]
        [InlineData(72, "setenta e dois vírgula zero")]
        [InlineData(71, "setenta e um vírgula zero")]
        [InlineData(70, "setenta vírgula zero")]
        [InlineData(69, "sessenta e nove vírgula zero")]
        [InlineData(68, "sessenta e oito vírgula zero")]
        [InlineData(67, "sessenta e sete vírgula zero")]
        [InlineData(66, "sessenta e seis vírgula zero")]
        [InlineData(65, "sessenta e cinco vírgula zero")]
        [InlineData(64, "sessenta e quatro vírgula zero")]
        [InlineData(63, "sessenta e três vírgula zero")]
        [InlineData(62, "sessenta e dois vírgula zero")]
        [InlineData(61, "sessenta e um vírgula zero")]
        [InlineData(60, "sessenta vírgula zero")]
        [InlineData(59, "cinquenta e nove vírgula zero")]
        [InlineData(58, "cinquenta e oito vírgula zero")]
        [InlineData(57, "cinquenta e sete vírgula zero")]
        [InlineData(56, "cinquenta e seis vírgula zero")]
        [InlineData(55, "cinquenta e cinco vírgula zero")]
        [InlineData(54, "cinquenta e quatro vírgula zero")]
        [InlineData(53, "cinquenta e três vírgula zero")]
        [InlineData(52, "cinquenta e dois vírgula zero")]
        [InlineData(51, "cinquenta e um vírgula zero")]
        [InlineData(50, "cinquenta vírgula zero")]
        [InlineData(49, "quarenta e nove vírgula zero")]
        [InlineData(48, "quarenta e oito vírgula zero")]
        [InlineData(47, "quarenta e sete vírgula zero")]
        [InlineData(46, "quarenta e seis vírgula zero")]
        [InlineData(45, "quarenta e cinco vírgula zero")]
        [InlineData(44, "quarenta e quatro vírgula zero")]
        [InlineData(43, "quarenta e três vírgula zero")]
        [InlineData(42, "quarenta e dois vírgula zero")]
        [InlineData(41, "quarenta e um vírgula zero")]
        [InlineData(40, "quarenta vírgula zero")]
        [InlineData(39, "trinta e nove vírgula zero")]
        [InlineData(38, "trinta e oito vírgula zero")]
        [InlineData(37, "trinta e sete vírgula zero")]
        [InlineData(36, "trinta e seis vírgula zero")]
        [InlineData(35, "trinta e cinco vírgula zero")]
        [InlineData(34, "trinta e quatro vírgula zero")]
        [InlineData(33, "trinta e três vírgula zero")]
        [InlineData(32, "trinta e dois vírgula zero")]
        [InlineData(31, "trinta e um vírgula zero")]
        [InlineData(30, "trinta vírgula zero")]
        [InlineData(29, "vinte e nove vírgula zero")]
        [InlineData(28, "vinte e oito vírgula zero")]
        [InlineData(27, "vinte e sete vírgula zero")]
        [InlineData(26, "vinte e seis vírgula zero")]
        [InlineData(25, "vinte e cinco vírgula zero")]
        [InlineData(24, "vinte e quatro vírgula zero")]
        [InlineData(23, "vinte e três vírgula zero")]
        [InlineData(22, "vinte e dois vírgula zero")]
        [InlineData(21, "vinte e um vírgula zero")]
        [InlineData(20, "vinte vírgula zero")]
        [InlineData(19, "dezenove vírgula zero")]
        [InlineData(18, "dezoito vírgula zero")]
        [InlineData(17, "dezessete vírgula zero")]
        [InlineData(16, "dezesseis vírgula zero")]
        [InlineData(15, "quinze vírgula zero")]
        [InlineData(14, "catorze vírgula zero")]
        [InlineData(13, "treze vírgula zero")]
        [InlineData(12, "doze vírgula zero")]
        [InlineData(11, "onze vírgula zero")]
        [InlineData(10, "dez vírgula zero")]
        public void Validar_ApresentarDezenaExtenso(double numeroDigitado, string numeroExtensoEsperado)
        {
            //Arrange
            var numero = new Numero();
            numero.Valor = numeroDigitado;

            //Act
            string milharExtenso = numero.ApresentarDezenaExtenso();

            //Assert
            milharExtenso.Should().Be(numeroExtensoEsperado);
        }

        // Cenário 04: Validar 10 números, sendo um para cada centena
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

        // Cenário 05: Validar unidade de milhar, com dez números
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

        // Cenário 06: Validar o número completo por extenso, com 5 cenários
        [Theory]
        [InlineData(546.22, "quinhentos e quarenta e seis vírgula vinte e dois")]
        [InlineData(205.11, "duzentos e cinco vírgula onze")]
        [InlineData(8888.10, "oito mil e oitocentos e oitenta e oito vírgula dez")]
        [InlineData(41, "quarenta e um vírgula zero")]
        [InlineData(0.01, "zero vírgula zero um")]
        public void Validar_ApresentarMilharExtenso_NumerosDiversos(double numeroDigitado, string numeroExtensoEsperado)
        {
            //Arrange
            var numero = new Numero();
            numero.Valor = numeroDigitado;

            //Act
            string milharExtenso = numero.ApresentarMilharExtenso();

            //Assert
            milharExtenso.Should().Be(numeroExtensoEsperado);
        }
    }
}

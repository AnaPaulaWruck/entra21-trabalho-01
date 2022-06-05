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
        // Cenário 01: Validar todos os valores decimais de 0 até 99
        [Theory]
        [InlineData(0.00, "zero vírgula zero")]
        [InlineData(0.01, "zero vírgula zero um")]
        [InlineData(0.02, "zero vírgula zero dois")]
        [InlineData(0.03, "zero vírgula zero três")]
        [InlineData(0.04, "zero vírgula zero quatro")]
        [InlineData(0.05, "zero vírgula zero cinco")]
        [InlineData(0.06, "zero vírgula zero seis")]
        [InlineData(0.07, "zero vírgula zero sete")]
        [InlineData(0.08, "zero vírgula zero oito")]
        [InlineData(0.09, "zero vírgula zero nove")]
        [InlineData(0.10, "zero vírgula dez")]
        [InlineData(0.11, "zero vírgula onze")]
        [InlineData(0.12, "zero vírgula doze")]
        [InlineData(0.13, "zero vírgula treze")]
        [InlineData(0.14, "zero vírgula catorze")]
        [InlineData(0.15, "zero vírgula quinze")]
        [InlineData(0.16, "zero vírgula dezesseis")]
        [InlineData(0.17, "zero vírgula dezessete")]
        [InlineData(0.18, "zero vírgula dezoito")]
        [InlineData(0.19, "zero vírgula dezenove")]
        [InlineData(0.20, "zero vírgula vinte")]
        [InlineData(0.21, "zero vírgula vinte e um")]
        [InlineData(0.22, "zero vírgula vinte e dois")]
        [InlineData(0.23, "zero vírgula vinte e três")]
        [InlineData(0.24, "zero vírgula vinte e quatro")]
        [InlineData(0.25, "zero vírgula vinte e cinco")]
        [InlineData(0.26, "zero vírgula vinte e seis")]
        [InlineData(0.27, "zero vírgula vinte e sete")]
        [InlineData(0.28, "zero vírgula vinte e oito")]
        [InlineData(0.29, "zero vírgula vinte e nove")]
        [InlineData(0.30, "zero vírgula trinta")]
        [InlineData(0.31, "zero vírgula trinta e um")]
        [InlineData(0.32, "zero vírgula trinta e dois")]
        [InlineData(0.33, "zero vírgula trinta e três")]
        [InlineData(0.34, "zero vírgula trinta e quatro")]
        [InlineData(0.35, "zero vírgula trinta e cinco")]
        [InlineData(0.36, "zero vírgula trinta e seis")]
        [InlineData(0.37, "zero vírgula trinta e sete")]
        [InlineData(0.38, "zero vírgula trinta e oito")]
        [InlineData(0.39, "zero vírgula trinta e nove")]
        [InlineData(0.40, "zero vírgula quarenta")]
        [InlineData(0.41, "zero vírgula quarenta e um")]
        [InlineData(0.42, "zero vírgula quarenta e dois")]
        [InlineData(0.43, "zero vírgula quarenta e três")]
        [InlineData(0.44, "zero vírgula quarenta e quatro")]
        [InlineData(0.45, "zero vírgula quarenta e cinco")]
        [InlineData(0.46, "zero vírgula quarenta e seis")]
        [InlineData(0.47, "zero vírgula quarenta e sete")]
        [InlineData(0.48, "zero vírgula quarenta e oito")]
        [InlineData(0.49, "zero vírgula quarenta e nove")]
        [InlineData(0.50, "zero vírgula cinquenta")]
        [InlineData(0.51, "zero vírgula cinquenta e um")]
        [InlineData(0.52, "zero vírgula cinquenta e dois")]
        [InlineData(0.53, "zero vírgula cinquenta e três")]
        [InlineData(0.54, "zero vírgula cinquenta e quatro")]
        [InlineData(0.55, "zero vírgula cinquenta e cinco")]
        [InlineData(0.56, "zero vírgula cinquenta e seis")]
        [InlineData(0.57, "zero vírgula cinquenta e sete")]
        [InlineData(0.58, "zero vírgula cinquenta e oito")]
        [InlineData(0.59, "zero vírgula cinquenta e nove")]
        [InlineData(0.60, "zero vírgula sessenta")]
        [InlineData(0.61, "zero vírgula sessenta e um")]
        [InlineData(0.62, "zero vírgula sessenta e dois")]
        [InlineData(0.63, "zero vírgula sessenta e três")]
        [InlineData(0.64, "zero vírgula sessenta e quatro")]
        [InlineData(0.65, "zero vírgula sessenta e cinco")]
        [InlineData(0.66, "zero vírgula sessenta e seis")]
        [InlineData(0.67, "zero vírgula sessenta e sete")]
        [InlineData(0.68, "zero vírgula sessenta e oito")]
        [InlineData(0.69, "zero vírgula sessenta e nove")]
        [InlineData(0.70, "zero vírgula setenta")]
        [InlineData(0.71, "zero vírgula setenta e um")]
        [InlineData(0.72, "zero vírgula setenta e dois")]
        [InlineData(0.73, "zero vírgula setenta e três")]
        [InlineData(0.74, "zero vírgula setenta e quatro")]
        [InlineData(0.75, "zero vírgula setenta e cinco")]
        [InlineData(0.76, "zero vírgula setenta e seis")]
        [InlineData(0.77, "zero vírgula setenta e sete")]
        [InlineData(0.78, "zero vírgula setenta e oito")]
        [InlineData(0.79, "zero vírgula setenta e nove")]
        [InlineData(0.80, "zero vírgula oitenta")]
        [InlineData(0.81, "zero vírgula oitenta e um")]
        [InlineData(0.82, "zero vírgula oitenta e dois")]
        [InlineData(0.83, "zero vírgula oitenta e três")]
        [InlineData(0.84, "zero vírgula oitenta e quatro")]
        [InlineData(0.85, "zero vírgula oitenta e cinco")]
        [InlineData(0.86, "zero vírgula oitenta e seis")]
        [InlineData(0.87, "zero vírgula oitenta e sete")]
        [InlineData(0.88, "zero vírgula oitenta e oito")]
        [InlineData(0.89, "zero vírgula oitenta e nove")]
        [InlineData(0.90, "zero vírgula noventa")]
        [InlineData(0.91, "zero vírgula noventa e um")]
        [InlineData(0.92, "zero vírgula noventa e dois")]
        [InlineData(0.93, "zero vírgula noventa e três")]
        [InlineData(0.94, "zero vírgula noventa e quatro")]
        [InlineData(0.95, "zero vírgula noventa e cinco")]
        [InlineData(0.96, "zero vírgula noventa e seis")]
        [InlineData(0.97, "zero vírgula noventa e sete")]
        [InlineData(0.98, "zero vírgula noventa e oito")]
        [InlineData(0.99, "zero vírgula noventa e nove")]
        public void Validar_ApresentarDecimalExtenso(double numeroDigitado, string numeroExtensoEsperado)
        {
            //Arrange
            var numero = new Numero();
            numero.Valor = numeroDigitado;

            //Act
            string milharExtenso = numero.ApresentarDecimalExtenso();

            //Assert
            milharExtenso.Should().Be(numeroExtensoEsperado);
        }


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

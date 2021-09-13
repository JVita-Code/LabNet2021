using LabNet2021.Tp2.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LabNet2021.Tp2.Extensions.Tests
{
    [TestClass()]
    public class DoubleExtensionsTests
    {
        [TestMethod()]
        public void DivisionPrecisaTest_NumeradorDenominadorValidos_Resultado()
        {

            // Arrange
            double numerador = 10;
            double denominador = 5;
            var value = 0;
            var resultadoEsperado = 2;

            // Act
            var resultadoDivision = DoubleExtensions.DivisionPrecisa(value, numerador, denominador);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoDivision);
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void DivisionPrecisaTest_DatosFormatoInvalido_FormatException()
        {

            // Arrange
            var numerador = 10;
            var denominador = "e";
            var value = 0;

            // Act
            DoubleExtensions.DivisionPrecisa(value, numerador, double.Parse(denominador));
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionPrecisaTest_IntentaDividirPorCero_DivideByZeroException()
        {
            // Arrange
            var numerador = 10;
            var denominador = 0;
            var value = 0;

            // Act
            DoubleExtensions.DivisionPrecisa(value, numerador, denominador);
        }
    }
}
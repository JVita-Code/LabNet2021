using LabNet2021.Tp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LabNet2021.Tp2.Tests
{
    [TestClass()]
    public class DivisionesTests
    {

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionCero_IngresaNum_DivideByZeroExcepcion()
        {
            // Arrange
            int numerador = 10;
            
            // Act
            Divisiones.Division(numerador);          
        }


        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void DivisionCero_IngresaLetra_FormatExcepcion()
        {
            // Arrange
            var numerador = "e";

            // Act
            Divisiones.Division(int.Parse(numerador));
        }

        [TestMethod()]
        public void Division_NumeradorDenominadorValidos_Resultado()
        {

            // Arrange
            var numerador = 10;
            var denominador = 5;
            var resultadoEsperado = 2;

            // Act
            var resultadoDivision = Divisiones.Division(numerador, denominador);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoDivision);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]

        public void Division_DividePorCero_DivideByZeroExcepcion()
        {
            // Arrange
            var numerador = 10;
            var denominador = 0;

            // Act
            Divisiones.Division(numerador, denominador);            
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void Division_IngresaLetra_FormatException()
        {
            // Arrange
            var numerador = "e";
            var denominador = 5;

            // Act
            Divisiones.Division(int.Parse(numerador), denominador);           
        }
    }
}
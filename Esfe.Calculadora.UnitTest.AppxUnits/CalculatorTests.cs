using ESfe.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.Calculadora.UnitTest.AppxUnits
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 3.0;

            double result = calculator.Add(num1,num2);

            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectSum()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 3.0;

            double result = calculator.Subtract(num1, num2);

            Assert.Equal(2.0, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectSum()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 3.0;

            double result = calculator.Multiply(num1, num2);

            Assert.Equal(15.0, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectSum()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 15.0;
            double num2 = 3.0;

            double result = calculator.Divide(num1, num2);

            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldReturnCorrectSum()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 0.0;

            Assert.Throws<ArgumentException>(() => calculator.Divide(num1,num2 ));
        }

    }
}

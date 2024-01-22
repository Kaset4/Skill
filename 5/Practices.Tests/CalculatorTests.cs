using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Tests
{
    public class CalculatorTests
    {
        [Test] 
        public void AdditionalCalculatorTest()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Additional(5, 5), Is.EqualTo(10));
            
        }

        [Test]
        public void SubtractionCalculatorTest()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Subtraction(5, 5), Is.EqualTo(0));
        }

        [Test]
        public void MultiplicationCalculatorTest()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Miltiplication(5, 5), Is.EqualTo(25));
        }

        [Test]
        public void DivisionCalculatorTest()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Division(5, 5), Is.EqualTo(1));
        }
    }
}

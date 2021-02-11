using System;
using NUnit.Framework;
using Calc;

namespace Calculator_NUnit_Test
{
    [TestFixture]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add4and2Gives6()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Add(4, 2);

            //Assert
            Assert.That(test, Is.EqualTo(6));
        }

        [Test]
        public void AddPosAndNonInt_Expect2()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Add(4, 2.5);

            //Assert
            Assert.That(test, Is.EqualTo(6.5));
        }

        [Test]
        public void AddNegAndNeg_ExpectNeg6()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Add(-4.5, -2);

            //Assert
            Assert.That(test, Is.EqualTo(-6.5));
        }


        [Test]
        public void AddAndSubtract()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Add(4, 2);
            test = uut.Subtract(test, 3);

            //Assert
            Assert.That(test,Is.EqualTo(3));
        }

        [Test]
        public void Subtract4From59Expects55()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Subtract(59, 4);

            //Assert
            Assert.That(test, Is.EqualTo(55));
        }

        [Test]
        public void Multiply9With3Expects27()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Multiply(9, 3);

            //Assert
            Assert.That(test, Is.EqualTo(27));
        }

        [Test]
        public void TwoPowerOf4Expects16()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Power(2, 4);

            //Assert
            Assert.That(test, Is.EqualTo(16));
        }

        [Test]
        public void AccuPowerTest()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Power(2, 4);
            test = uut.Power(2);

            //Assert
            Assert.That(test, Is.EqualTo(256));
        }

        [Test]
        public void AccuPowerNegTest()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Power(2, 4);
            test = uut.Power(-2);

            //Assert
            Assert.That(test, Is.EqualTo(0.00390625));
        }

        [Test]
        public void AccuNegPowerTest()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Subtract(2, 4);
            test = uut.Power(3.4);

            //Assert
            Assert.That(test, Is.NaN);
        }

        [Test]
        public void ClearTest()
        {
            //Arrange
            var uut = new Calculator();

            //Act
            double test = uut.Multiply(2, 4);
            test = uut.Add(4);
            uut.Clear();
            test = uut.Add(2);

            //Assert
            Assert.That(test, Is.EqualTo(2));
        }
    }
}
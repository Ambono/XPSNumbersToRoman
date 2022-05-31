using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbersToRomanNumerals.Service.Tests
{
    [TestClass()]
    public class NumberConverterTests
    {
        [TestMethod()]
        public void ConvertASmallIntegerShouldSucceed()
        {
            //Arrange
            var num = 8;
            var roman = "VIII";
            NumberConverter nc = new NumberConverter();
            var numberModel = new NumberModel() { Input = num };
            //Act
            var response = nc.ConvertFromRomanToNumber(numberModel);
            //Assert

            Assert.AreEqual(response, roman);
        }
        
        [TestMethod()]
        public void ConvertABigIntegerShouldSucceed()
        {
            //Arrange
            var num = 10001;
            var roman = "MMMMMMMMMMI";
            NumberConverter nc = new NumberConverter();
            var numberModel = new NumberModel() { Input = num };
            //Act
            var response = nc.ConvertFromRomanToNumber(numberModel);
            //Assert

            Assert.AreEqual(response, roman);
        }

        [TestMethod()]
        public void ConvertADecimalShouldFail()
        {
            //Arrange
            var num = 0;
            var roman = "";
            NumberConverter nc = new NumberConverter();
            var numberModel = new NumberModel() { Input = num };
            //Act
            var response = nc.ConvertFromRomanToNumber(numberModel);
            //Assert

            Assert.AreEqual(response, roman);
        }

        [TestMethod()]
        [ExpectedException(typeof(System.IndexOutOfRangeException),
        "")]
        public void ConvertANegativeNumberShouldFail()
        {
            //Arrange
            var num = -3;
            
            NumberConverter nc = new NumberConverter();
            var numberModel = new NumberModel() { Input = num };
            //Act
            var response = nc.ConvertFromRomanToNumber(numberModel);
            //Assert

        }

    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbersToRomanNumerals.Service.Tests
{
    [TestClass()]
    public class NumberConverterTests
    {
        [TestMethod()]
        public void ConvertNumberTest()
        {
            //Arrange
            var num = 8;
            var roman = "VIII";
            NumberConverter nc = new NumberConverter();

            //Act
            var response = nc.ConvertNumber(num);
            //Assert

            Assert.AreEqual(response, roman);
        }
    }
}
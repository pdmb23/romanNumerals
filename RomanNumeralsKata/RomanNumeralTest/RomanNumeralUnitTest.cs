using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralTest
{
    [TestClass]
    public class RomanNumeralUnitTest
    {
        [TestMethod]
        public void ConvertDecimal1ToRomanNumeral_ShouldBe_I()
        {
            //ARRANGE
            RomanNumeralConverter converter = new RomanNumeralConverter();
            //ACT
            var actualResult = converter.Convert(1);
            //ASSERT
            var expectedResult = "I";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Decimal_3_Should_Should_Be_Roman_III()
        {
            //ARRANGE
            RomanNumeralConverter converter = new RomanNumeralConverter();
            //ACT
            var actualResult = converter.Convert(3);
            //ASSERT
            var expectedResult = "III";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Decimal_7_Should_Be_Roman_VII()
        {
            //ARRANGE
            RomanNumeralConverter converter = new RomanNumeralConverter();
            //ACT
            var actualResult = converter.Convert(7);
            //ASSERT
            var expectedResult = "VII";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Decimal_4_Should_Be_Roman_IV()
        {
            //ARRANGE
            RomanNumeralConverter converter = new RomanNumeralConverter();
            //ACT
            var actualResult = converter.Convert(4);
            //ASSERT
            var expectedResult = "IV";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Decimal_9_Should_Be_Roman_IX()
        {
            //ARRANGE
            RomanNumeralConverter converter = new RomanNumeralConverter();
            //ACT
            var actualResult = converter.Convert(9);
            //ASSERT
            var expectedResult = "IX";
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [TestMethod]
        public void Decimal_14_Should_Be_Roman_XIV()
        {
            //ARRANGE
            RomanNumeralConverter convert = new RomanNumeralConverter();
            //ACT 
            var actualResult = convert.Convert(14);
            //ASSERT
            var expectedResult = "XIV";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Decimal_1982_Should_Be_Roman_MCMLXXXII()
        {
            //ARRANGE
            RomanNumeralConverter convert = new RomanNumeralConverter();
            //ACT 
            var actualResult = convert.Convert(1982);
            //ASSERT
            var expectedResult = "MCMLXXXII";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

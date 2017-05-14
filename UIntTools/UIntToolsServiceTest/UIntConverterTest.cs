using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIntToolsService;

namespace UIntToolsServiceTest
{
    [TestClass]
    public class UIntConverterTest
    {
        private readonly IUIntConverter _uIntConverterService;

        public UIntConverterTest()
        {
            _uIntConverterService = new UIntConverter();
        }

        [TestMethod]
        [ExpectedException(typeof(UIntConverterException))]
        public void WhenValueIsZeroConvertToRomanNumeralThrowException()
        {
            _uIntConverterService.ConvertUIntToRomanNumeral(0);
        }

        [TestMethod]
        public void WhenValueContainsOneDigitCanConvertToRomanNumeral()
        {
            string result = _uIntConverterService.ConvertUIntToRomanNumeral(1);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(result));
            Assert.AreEqual(result, "I");
        }

        [TestMethod]
        public void WhenValueContainsTwoDigitCanConvertToRomanNumeral()
        {
            string result = _uIntConverterService.ConvertUIntToRomanNumeral(12);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(result));
            Assert.AreEqual(result, "XII");
        }

        [TestMethod]
        public void WhenValueContainsThreeDigitCanConvertToRomanNumeral()
        {
            string result = _uIntConverterService.ConvertUIntToRomanNumeral(139);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(result));
            Assert.AreEqual(result, "CXXXIX");
        }

        [TestMethod]
        public void WhenValueContainsMoreThanThreeDigitCanConvertToRomanNumeral()
        {
            string result = _uIntConverterService.ConvertUIntToRomanNumeral(10572);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(result));
            Assert.AreEqual(result, "MMMMMMMMMMDLXXII");
        }
    }
}

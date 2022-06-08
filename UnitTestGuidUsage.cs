using NUnit.Framework;
using GuidUsage;

namespace UnitTestGuidUsage
{
    public class Tests
    {
        NumericalSystemUtils utils;
        [SetUp]
        public void Setup()
        {
            utils = new NumericalSystemUtils();
        }

        [Test]
        public void BinaryToHexTest_BinaryGiven_ShouldReturnHex()
        {
            var res = utils.BinaryToHex("10101010");
            Assert.AreEqual(res, "AA");
        }

        [Test]
        public void BinaryToHexTest_BinaryGiven_ShouldReturnHex1()
        {
            var res = utils.BinaryToHex("11111111");
            Assert.AreEqual(res, "FF");
        }

        [Test]
        public void HexToDecimalTest_HexGiven_ShouldReturnDecimal()
        {
            var res = utils.HexToDecimal("112");
            Assert.AreEqual(res, "274");
        }

        [Test]
        public void HexToDecimalTest_HexGiven_ShouldReturnDecimal1()
        {
            var res = utils.HexToDecimal("243");
            Assert.AreEqual(res, "579");
        }

        [Test]
        public void HexToDecimalTest_HexGiven_ShouldReturnDecimal2()
        {
            var res = utils.HexToDecimal("A8");
            Assert.AreEqual(res, "168");
        }

        [Test]
        public void HexToBinaryTest_HexGiven_ShouldReturnBinary()
        {
            var res = utils.HexToBinary("5A");
            Assert.AreEqual(res, "01011010");
        }

        [Test]
        public void HexToBinaryTest_HexGiven_ShouldReturnBinary1()
        {
            var res = utils.HexToBinary("B7");
            Assert.AreEqual(res, "10110111");
        }

        [Test]
        public void HexToBinaryTest_HexGiven_ShouldReturnBinary2()
        {
            var res = utils.HexToBinary("8C");
            Assert.AreEqual(res, "10001100");
        }

        [Test]
        public void ReverseBitsTest_BinaryGiven_ShouldReturnBinaryWithResersedBits()
        {
            var res = utils.ReverseBits("5A");
            Assert.AreEqual(res, "5A");
        }

        [Test]
        public void ReverseBitsTest_BinaryGiven_ShouldReturnBinaryWithResersedBits1()
        {
            var res = utils.ReverseBits("B7");
            Assert.AreEqual(res, "ED");
        }

        [Test]
        public void ReverseBitsTest_BinaryGiven_ShouldReturnBinaryWithResersedBits2()
        {
            var res = utils.ReverseBits("8C");
            Assert.AreEqual(res, "31");
        }

        [Test]
        public void SumHexNumbersTest_TwoHexNumbersGiven_ShouldReturnSum()
        {
            var res = utils.SumHexNumbers("4F1A5", "B8D5");
            Assert.AreEqual(res, "5AA7A");
        }

        [Test]
        public void SumHexNumbersTest_TwoHexNumbersGiven_ShouldReturnSum1()
        {
            var res = utils.SumHexNumbers("1B90F", "C44E");
            Assert.AreEqual(res, "27D5D");
        }

        [Test]
        public void SubtructHexNumbersTest_TwoHexNumbersGiven_ShouldReturnDifference()
        {
            var res = utils.SubtructHexNumbers("4F1A5", "B8D5");
            Assert.AreEqual(res, "438D0");
        }

        [Test]
        public void SubtructHexNumbersTest_TwoHexNumbersGiven_ShouldReturnDifference1()
        {
            var res = utils.SubtructHexNumbers("F35D", "27E6");
            Assert.AreEqual(res, "CB77");
        }

        [Test]
        public void SubtructHexNumbersTest_TwoHexNumbersGiven_ShouldReturnDifference2()
        {
            var res = utils.SubtructHexNumbers("1B90F", "C44E");
            Assert.AreEqual(res, "0F4C1");
        }

        [Test]
        public void HexSignedToDecimalTest_SignedHexNumberGiven_ShouldReturnDecimal()
        {
            var res = utils.HexSignedToDecimal("29");
            Assert.AreEqual(res, "41");
        }

        [Test]
        public void HexSignedToDecimalTest_SignedHexNumberGiven_ShouldReturnDecimal1()
        {
            var res = utils.HexSignedToDecimal("D7");
            Assert.AreEqual(res, "-87");
        }

        [Test]
        public void HexSignedToDecimalTest_SignedHexNumberGiven_ShouldReturnDecimal2()
        {
            var res = utils.HexSignedToDecimal("EA");
            Assert.AreEqual(res, "-106");
        }

        [Test]
        public void HexChangeSignTest_SignedHexNumberGiven_ShouldReturnHexWithChangedSign()
        {
            var res = utils.HexChangeSign("3E");
            Assert.AreEqual(res, "BE");
        }

        [Test]
        public void HexChangeSignTest_SignedHexNumberGiven_ShouldReturnHexWithChangedSign1()
        {
            var res = utils.HexChangeSign("7F");
            Assert.AreEqual(res, "FF");
        }

        [Test]
        public void HexChangeSignTest_SignedHexNumberGiven_ShouldReturnHexWithChangedSign2()
        {
            var res = utils.HexChangeSign("C6");
            Assert.AreEqual(res, "46");
        }

        [Test]
        public void HexAdditionalToDecimalTest_HexInAdditionalCodeGiven_ShouldReturnDecimal()
        {
            var res = utils.HexAdditionalToDecimal("29");
            Assert.AreEqual(res, "41");
        }

        [Test]
        public void HexAdditionalToDecimalTest_HexInAdditionalCodeGiven_ShouldReturnDecimal1()
        {
            var res = utils.HexAdditionalToDecimal("D7");
            Assert.AreEqual(res, "-41");
        }

        [Test]
        public void HexAdditionalChangeSignTest_HexInAdditionalCodeGiven_ShouldReturnHexWithChangedSign()
        {
            var res = utils.HexAdditionalChangeSign("3E");
            Assert.AreEqual(res, "C2");
        }

        [Test]
        public void HexAdditionalChangeSignTest_HexInAdditionalCodeGiven_ShouldReturnHexWithChangedSign1()
        {
            var res = utils.HexAdditionalChangeSign("A3");
            Assert.AreEqual(res, "5D");
        }

        [Test]
        public void HexAdditionalChangeSignTest_HexInAdditionalCodeGiven_ShouldReturnHexWithChangedSign2()
        {
            var res = utils.HexAdditionalChangeSign("C6");
            Assert.AreEqual(res, "3A");
        }
    }
}

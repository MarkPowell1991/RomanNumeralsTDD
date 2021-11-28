
using NUnit.Framework;
using RomanNumeralsTDD;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class RomanNumeralsTests
    {

        [Test]
        public void GiveInt1_ReturnString1()
        {
            int input = 1;
            RomanNumerals rn = new RomanNumerals();

            Assert.AreEqual("I", rn.RomanNumeral1(input));
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        public void GiveInt2_ReturnString2(int input, string expected)
        {

            RomanNumerals rn = new RomanNumerals();
            string actual = rn.RomanNumeral2(input);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(650, "DCL")]
        [TestCase(313, "CCCXIII")]
        [TestCase(252, "CCLII")]
        [TestCase(1500, "MD")]
        [TestCase(650, "DCL")]
        public void GiveInt3_ReturnString3(int input, string expected)
        {

            RomanNumerals rn = new RomanNumerals();
            string actual = rn.RomanNumeral3(input);
            Assert.AreEqual(expected, actual);
        }

       


    }
}

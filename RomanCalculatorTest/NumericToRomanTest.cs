using RomanCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculatorTest
{
    [TestClass]
    public class NumericToRomanTest
    {

        [DataTestMethod()]
        [DataRow(1999, "MCMXCIX")]
        [DataRow(1833, "MDCCCXXXIII")]
        [DataRow(1118, "MCXVIII")]
        public void NumbericToRomanThousadsTest(int input, string output)
        {
            RomanParser parser = new RomanParser();
            string romanValue = parser.ConvertNumbericToRoman(input);

            Assert.AreEqual(output, romanValue);
        }


        [DataTestMethod()]
        [DataRow( 199, "CXCIX")]
        [DataRow(133, "CXXXIII")]
        [DataRow(114, "CXIV")]
        [DataRow(176, "CLXXVI")]
        [DataRow(119, "CXIX")]
        public void NumbericToRomanHundredsTest(int input, string output)
        {
            RomanParser parser = new RomanParser();
            string romanValue = parser.ConvertNumbericToRoman(input);

            Assert.AreEqual(output, romanValue);
        }

       
        
        [DataTestMethod()]
        [DataRow(19, "XIX")]
        [DataRow(13, "XIII")]
        [DataRow(15, "XV")]
        [DataRow( 16, "XVI")]
        [DataRow(19,"XIX")]
        public void NumbericToRomanTensTest(int input, string output)
        {
            RomanParser parser = new RomanParser();
            string romanValue = parser.ConvertNumbericToRoman(input);

            Assert.AreEqual(output, romanValue);
        }

        [DataTestMethod()]
        [DataRow( 9, "IX")]
        [DataRow( 3, "III")]
        [DataRow( 4, "IV")]
        [DataRow( 5, "V")]
        [DataRow( 6, "VI")]
        public void NumbericToRomanOneTest(int input, string output)
        {
            RomanParser parser = new RomanParser();
            string romanValue = parser.ConvertNumbericToRoman(input);

            Assert.AreEqual(output, romanValue);
        }
    }
}

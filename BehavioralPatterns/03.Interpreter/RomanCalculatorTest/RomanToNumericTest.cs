using RomanCalculator;

namespace RomanCalculatorTest
{
    [TestClass]
    public class RomanToNumericTest
    {   
        [DataTestMethod()]
        [DataRow("IX", 9)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI",6)]
        public void RomanCaculatorUnitPlaceTest(string roman, int output)
        {
            RomanParser client = new RomanParser();
            int received=client.ConvertRomanToNumeric(roman);

            Assert.AreEqual(output, received);
        }

        [DataTestMethod()]
        [DataRow("XIX", 19)]
        [DataRow("XIII", 13)]
        [DataRow("XIV", 14)]
        [DataRow("XV", 15)]
        [DataRow("XVI", 16)]
        [DataRow("XIX", 19)]
        public void RomanCaculatorTenPlaceTest(string roman, int output)
        {
            RomanParser client = new RomanParser();
            int received = client.ConvertRomanToNumeric(roman);

            Assert.AreEqual(output, received);

        }

        [DataTestMethod()]
        [DataRow("CXCIX", 199)]
        [DataRow("CXXXIII", 133)]
        [DataRow("CXIV", 114)]
        [DataRow("CLXXVI", 176)]         
        [DataRow("CXIX", 119)]
        public void RomanCaculatorHundredthPlaceTest(string roman, int output)
        {
            RomanParser client = new RomanParser();
            int received = client.ConvertRomanToNumeric(roman);

            Assert.AreEqual(output, received);
        }

        [DataTestMethod()]
        [DataRow("MCMXCIX", 1999)]
        [DataRow("MDCCCXXXIII", 1833)]
        [DataRow("MCXVIII", 1118)]        
        public void RomanCaculatorThousandthPlaceTest(string roman, int output)
        {
            RomanParser client = new RomanParser();
            int received = client.ConvertRomanToNumeric(roman);

            Assert.AreEqual(output, received);
        }

    }

}

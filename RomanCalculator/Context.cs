using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{

    // These contexts are just bukets to carry the value in and out. 
    public  class RomanToNumericContext
    {
        public RomanToNumericContext(string incoming) 
        {
            this.Input = incoming;            
        }

        public string Input { get; set; }
        public int Output { get; set; }
    }

    public class NumbericToRomanContext
    {
        public NumbericToRomanContext(int incoming)
        {
            this.Input = incoming;
        }

        public int Input { get; set; }
        public string Output { get; set; }
    }
}

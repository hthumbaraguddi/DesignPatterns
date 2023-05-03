using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    /// <summary>
    /// more info https://rextester.com/rundotnet?code=JJBYW89744
    /// </summary>
    public abstract class NumericToRomanExpressions
    {
        public void Interpret(NumbericToRomanContext context)
        {
            while(context.Input-9*Multiplier()>=0)
            {
                context.Output += NineValue();
                context.Input -= 9 * Multiplier();
            }

            while (context.Input - 5 * Multiplier() >= 0)
            {
                context.Output += FiveValue();
                context.Input -= 5 * Multiplier();
            }

            while (context.Input - 4 * Multiplier() >= 0)
            {
                context.Output += FourValue();
                context.Input -= 4 * Multiplier();
            }

            while (context.Input - 1 * Multiplier() >= 0)
            {
                context.Output += OneValue();
                context.Input -= 1 * Multiplier();
            }
        }

        public abstract string OneValue();
        public abstract string FourValue();
        public abstract string FiveValue();
        public abstract string NineValue();
        public abstract int Multiplier();

    }

    public class N2RThousadExpression : NumericToRomanExpressions
    {
        public override string OneValue() { return "M"; }
        public override string FourValue() { return "Mv"; }
        public override string FiveValue() { return "v"; }
        public override string NineValue() { return "Mx"; }
        public override int Multiplier() { return 1000; }
    }

    public class N2RHundredExpression : NumericToRomanExpressions
    {
        public override string OneValue() { return "C"; }
        public override string FourValue() { return "CD"; }
        public override string FiveValue() { return "D"; }
        public override string NineValue() { return "CM"; }
        public override int Multiplier() { return 100; }
    }

    public class N2RTenExpression : NumericToRomanExpressions
    {
        public override string OneValue() { return "X"; }
        public override string FourValue() { return "XL"; }
        public override string FiveValue() { return "L"; }
        public override string NineValue() { return "XC"; }
        public override int Multiplier() { return 10; }
    }

    public class N2ROneExpression : NumericToRomanExpressions
    {
        public override string OneValue() { return "I"; }
        public override string FourValue() { return "IV"; }
        public override string FiveValue() { return "V"; }
        public override string NineValue() { return "IX"; }
        public override int Multiplier() { return 1; }
    }
}

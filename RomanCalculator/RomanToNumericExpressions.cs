using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{

    public abstract class RomanToNumericExpressions
    {
        public void Interpret(RomanToNumericContext context)
        {
            if(context.Input.Length== 0)
            {
                return;
            }

            if(context.Input.StartsWith(NineValue()))
            {
                context.Output += (9 * Multiplier());
                // there is no 9 representation for thousandth place.
                // 9 representation for hundreth Place is CM
                // Tenth place is XC and unit place is IX. so remove 2 characters. 
                context.Input = context.Input.Substring(2);
            }
            else if(context.Input.StartsWith(FourValue()))
            {
                context.Output += (4 * Multiplier());
                // 4 represented as IV, XL and CD so Remove 2 characters
                context.Input = context.Input.Substring(2);
            }else if(context.Input.StartsWith(FiveValue())) 
            {
                context.Output += (5 * Multiplier());
                context.Input= context.Input.Substring(1);
            }

            // 1, 2, 3, 6, 7, 8 are repeated run in loop

            while(context.Input.StartsWith(OneValue()))
            {
                context.Output+= (1 * Multiplier());
                context.Input = context.Input.Substring(1); // keep removing one character. In the end, while will comes out.
            }
        }

        public abstract string OneValue();
        public abstract string FourValue();
        public abstract string FiveValue();
        public abstract string NineValue();

        public abstract int Multiplier();
    }

    public class R2NThousandValueExpression : RomanToNumericExpressions
    {
        public override string FiveValue()
        {
            return " ";
        }

        public override string FourValue()
        {
            return " ";
        }

        public override int Multiplier()
        {
            return 1000;
        }

        public override string NineValue()
        {
            return " "; 
        }

        public override string OneValue()
        {
            return "M";
        }
    }

    public class R2NHundredValueExpression : RomanToNumericExpressions
    {
        public override string FiveValue()
        {
            return "D";
        }

        public override string FourValue()
        {
            return "CD";
        }

        public override int Multiplier()
        {
            return 100;
        }

        public override string NineValue()
        {
            return "CM";
        }

        public override string OneValue()
        {
            return "C";
        }
    }

    public class R2NTenValueExpression : RomanToNumericExpressions
    {
        public override string FiveValue()
        {
            return "L";
        }

        public override string FourValue()
        {
            return "XL";
        }

        public override int Multiplier()
        {
            return 10;
        }

        public override string NineValue()
        {
            return "XC";
        }

        public override string OneValue()
        {
            return "X";
        }
    }

    public class R2NUnitPlaceValueExpression : RomanToNumericExpressions
    {
        public override string FiveValue()
        {
            return "V";
        }

        public override string FourValue()
        {
            return "IV";
        }

        public override int Multiplier()
        {
            return 1;
        }

        public override string NineValue()
        {
            return "IX";
        }

        public override string OneValue()
        {
            return "I";
        }
    }
}

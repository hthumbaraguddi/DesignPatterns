using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanCalculator
{
    public class RomanParser
    {

        public int ConvertRomanToNumeric(string romanValue)
        {
            RomanToNumericContext romanToNumericContext = new RomanToNumericContext(romanValue);

            List<RomanToNumericExpressions> Expressions = new List<RomanToNumericExpressions>()
            {
                new R2NThousandValueExpression(),
                new R2NHundredValueExpression(),
                new R2NTenValueExpression(),
                new R2NUnitPlaceValueExpression()
            };

            foreach (var expression in Expressions)
            {
                expression.Interpret(romanToNumericContext);
            }

            return romanToNumericContext.Output;            
        }

        public string ConvertNumbericToRoman(int NumericValue)
        {
            NumbericToRomanContext numbericToRomanContext = new NumbericToRomanContext(NumericValue);

            List<NumericToRomanExpressions> Expressions = new List<NumericToRomanExpressions>()
            {
                new N2RThousadExpression(),
                new N2RHundredExpression(),
                new N2RTenExpression(),
                new N2ROneExpression()
            };
            foreach (var expression in Expressions)
            {
                expression.Interpret(numbericToRomanContext);
            }

            return numbericToRomanContext.Output;

        }

    }
}

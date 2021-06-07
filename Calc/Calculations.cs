using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculations
    {
       public static double Calculator(string matExpression)
        {
            //matExpression.Replace("X", "*");
            int found0 = matExpression.LastIndexOf("+");
            if (found0 >= 0)
                return Calculator(matExpression.Substring(0, found0)) + Calculator(matExpression.Substring(found0 + 1));
            int found1 = matExpression.LastIndexOf("-");
            if (found1 >= 0)
                return Calculator(matExpression.Substring(0, found1)) - Calculator(matExpression.Substring(found1 + 1));
            int found2 = matExpression.LastIndexOf("x");
            if (found2 >= 0)
                return Calculator(matExpression.Substring(0, found2)) * Calculator(matExpression.Substring(found2 + 1));
            int found3 = matExpression.LastIndexOf(":");
            if (found3 >= 0)
                return Calculator(matExpression.Substring(0, found3)) / Calculator(matExpression.Substring(found3 + 1));
            int found4 = matExpression.LastIndexOf("^");
            if (found4 >= 0)
                return Math.Pow(Calculator(matExpression.Substring(0, found4)), Calculator(matExpression.Substring(found4 + 1)));
            return Convert.ToDouble(matExpression);
        }
    }
}

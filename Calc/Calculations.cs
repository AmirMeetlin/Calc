using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calculations
    {
       public static double Calculator(double a, double b,int index)
        {
            double res =0;
            switch (index)
            {
                case 0:
                    res = a + b;
                    return res;
                case 1:
                    res = a - b;
                    return res;
                case 2:
                    res = a * b;
                    return res;
                case 3:
                    res = a / b;
                    return res;
                case 4:
                    res = Math.Pow(a, b);
                    return res;
            }
            return res ;
        }
    }
}

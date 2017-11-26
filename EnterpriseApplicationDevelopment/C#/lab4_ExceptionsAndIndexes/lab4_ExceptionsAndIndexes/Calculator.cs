using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_ExceptionsAndIndexes
{
    class Calculator
    {
        public static float Divide(float num1, float num2)
        {
            float returnValue;
            if(num2 <= 0)
            {
                throw new ArgumentException
                    (String.Format("The second number cannot be less than or equal to zero."));
            }
            else
            {
                returnValue = num1 / num2;
                return returnValue;
            }
        }
    }
}

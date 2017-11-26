/*X-Number: X00119025
Date: 16/10/2017*/
using System;

namespace Lab4_Practice
{                                                                                               //My attempt
    //class Calculator
    //{
    //    public static float Divide(float number1, float number2)
    //    {
    //        if(number2 == 0)
    //        {
    //            throw new ArgumentException(String.Format("cannot divide a number by {0}", number2));           //throwing argument exception, and printing reason for occurance.
    //        }
    //        else
    //        {
    //            return number1 / number2;
    //        }
    //    }
    //}

    class Calculator
    {                                                                                           //My fixup using lecturer's solution
        public static double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException(String.Format("cannot divide a number by {0}", number2));           //throwing argument exception, and printing reason for occurance.
            }
            else
            {
                return number1 / number2;
            }
        }
    }
}

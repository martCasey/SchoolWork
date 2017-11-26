using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_ExceptionsAndIndexes
{
    class Test1
    {
        static void Main(string[] args)
        {/*
            //calculator object
            Calculator calc = new Calculator();

            //fields
            double num1, num2;
            //try catch
            try
            {
                Console.WriteLine("Please input the value for the first number.");
                //Convert input to double
                num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please input the value for the second number.");
                //Convert input to double
                num2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("The divided result of the two numbers is: " + Calculator.Divide(((float)num1), (float)num2));
            }
            catch(FormatException fex)
            {
                Console.WriteLine(String.Format("Error: " + fex));
            }
            Console.ReadLine();
            */
            //Test2
            try
            {
                ModuleCAResults results = new ModuleCAResults() { ModuleName = "oosdev2", NoCredits = 10, StudentName = "Jane Doe" };
                results[1] = 20;//new result for CA1
                results[2] = 40;
                results[3] = 60;
                results[1] = 25;//overwrite
                results[3] = 65;//overwrite
                results[4] = 99;

                Console.WriteLine(results);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}

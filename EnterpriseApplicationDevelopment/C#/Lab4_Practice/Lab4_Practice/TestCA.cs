/*X-Number: X00119025
Date: 16/10/2017*/
using System;

namespace Lab4_Practice
{
    //class TestCA                                                                                      //My attempt
    //{
    //    static void Main(string[] args)
    //    {
    //        ModuleCAResults caResults = new ModuleCAResults();
    //        try
    //        {
    //            caResults.ModuleName = "Computing";
    //            caResults.NumberOfCredits = 6;
    //            caResults.StudentName = "Martin";
    //            Console.WriteLine(caResults.ToString());
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    class TestCA                                                                                      //My fix up using the lecturer's solution
    {
        static void Main()
        {

            try
            {
                ModuleCAResults caResults = new ModuleCAResults() { ModuleName ="EAD", NumberOfCredits= 10, StudentName="Martin"};
                caResults[1] = 20;                    // new result for CA1
                caResults[2] = 40;
                caResults[3] = 60;
                caResults[1] = 25;                    // overwrite
                caResults[3] = 65;                    // overwrite
                caResults[4] = 99;

                Console.WriteLine(caResults);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

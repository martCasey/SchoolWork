/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_ExceptionsAndIndexes
{
    class Test2
    {
        static void Main (String[] args)
        {
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
*/
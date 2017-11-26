/*X-Number: X00119025
Date: 16/10/2017*/
using System;
using System.Collections.Generic;

namespace Lab4_Practice
{                                                                                                       //My attemp to create the class
    //class ModuleCAResults
    //{                                                                                       //auto implemented properties
    //    public string ModuleName { get; set; }
    //    public int NumberOfCredits { get; set; }
    //    public string StudentName { get; set; }

    //    List<string> scores = new List<string>();                                          //collection of CA results

    //    public override string ToString()
    //    {
    //        return "Module Name: " + this.ModuleName
    //                + "\nNumber of Credits: " + this.NumberOfCredits
    //                + "\nStudent Name: " + this.StudentName
    //                + "\nResults: " + scores;
    //    }

    //    public string this[int position]                                                   //indexer (index pointer
    //    {
    //        get
    //        {
    //            string returnType;
    //            return returnType = scores[position];
    //        }
    //        set
    //        {
    //            scores[position] = value;
    //        }
    //    }

    //    public void FillInGaps()                                                            //method to ensure there are no gaps in the collection
    //    {
    //        for(int i = 0; i < scores.Capacity; i++)
    //        {
    //            if(scores[i] == null)
    //            {
    //                for(int j = i; j < scores.Capacity; j++)
    //                {
    //                    scores[j] = scores[j++];
    //                }
    //            }
    //        }
    //    }
    //}

    class ModuleCAResults                                                                   //My fixup using lecturer's solution
    {                                                                                       //auto implemented properties
        public string ModuleName { get; set; }
        public int NumberOfCredits { get; set; }
        public string StudentName { get; set; }

        private const int max = 50;                                                         //The maximum number of entries in an array.  It must be declared
        private double[] results = new double[max];                                         //array
        private int next = 0;                                                               //The next free slot in the array

        public override string ToString()
        {
            string returnValue = "Module Name: " + this.ModuleName
                    + "\nNumber of Credits: " + this.NumberOfCredits
                    + "\nStudent Name: " + this.StudentName
                    + "\nResults:";
            for (int i = 0; i < next; i++)                                                  //Loop through array to return all results
            {
                returnValue += results[i] + " ";
            }
            return returnValue;
        }

        public double this[int position]                                                   //indexer based on CA results
        {
            get
            {
                int index = position - 1;                                                   //Position 1 is technically position 0, hence why we are doing this
                if((index >= 0) && (index < next))                                          //valid range, if index is ever more than next, an exception is generated
                {
                    return results[index];
                }
                else
                {
                    throw new Exception("Invalid CA number");
                }
            }
            set
            {                                                                               //Add result or change existing result
                int index = position - 1;
                if((index >= 0) && (index <= next) && (index < (max)))                        //No gaps allowed, either exising result is overwritten or is written at the very end, there must be a space in the array to do this
                {
                    results[index] = value;                                                 //Setting the value of the position in the array
                    if(index == next)
                    {
                        next++;                                                             //Increases in size, when it goes past the max and the index trys to follow it, an exception will be generated
                    }
                }
				else
                {
                    throw new Exception("Invalid CA number");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_ExceptionsAndIndexes
{
    class ModuleCAResults
    {
        //properties
        public string ModuleName { get; set; }
        public string StudentName { get; set; }
        public double NoCredits { get; set; }

        private const int MAX = 50;//max of 50 results
        private double[] results = new double[MAX];//create array
        private int next = 0;//next free slot for a result in the results array

        //return a string contain all module details including results
        public override string ToString()
        {
            String output = "Module: " + ModuleName + " Credits: " + NoCredits + " Student Name: " + StudentName + "\nResults ";
            for(int i = 0; i < next; i++)
            {
                output += results[i] + " ";
            }
            return output;
        }

        //indexer based on CA
        public double this[int CA]
        {
            get
            {
                int index = CA - 1;
                if((index >= 0) && (index < next))
                {
                    return results[index];
                }
                else
                {
                    throw new Exception("Invalid CA number");
                }
            }
            set
            {
                //add a result or change an existing result
                int index = CA - 1;
                //no gaps allowed, must overwrite existing result or add at end, and must have space in array
                if((index >= 0) && (index <= next) && (index < (MAX)))
                {
                    results[index] = value;//set the result
                    if(index == next)
                    {
                        next++;//that was a new result
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

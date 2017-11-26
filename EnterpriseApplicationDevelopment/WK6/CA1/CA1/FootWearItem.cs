/* X-Number: X00119025
 * Date: 19/10/2017
 */
using System;

namespace CA1
{
    class FootWearItem : ICartAble
    {
        int size;                                                               //Variables

        public string Code { get; set; }                                        //Properties
        public string Description { get; set; }
        public double Price { get; set; }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if(size <2 || size > 12)
                {
                    throw new Exception("Invalid Size. Size must be in the range of 2 to 12.");
                }
            }
        }
    }
}

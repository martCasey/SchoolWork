/* X-Number: X00119025
 * Date: 19/10/2017
 */
using System;

namespace CA1
{
    class CartItem : ICartAble
    {
        private string code;                                                    //Variables
        private string description;
        private double price;

        public string Code                                              //Properties
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
                if(!code.Length.Equals(5))
                {
                    throw new Exception("Invalid Code Lenght.  Code must be only 5 characters long.");
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Quantity { get; set; }

        public CartItem()                                               //Default Constructor
        {

        }

        //public string this[int codeSpace]
        //{
        //    get
        //    {

        //    }
        //}

        public override string ToString()                               //ToString method
        {
            return "Item Code: " + Code +
                  "\nItem Description: " + Description +
                  "\nItem Price: " + Price + 
                  "\nItem Quantity: " + Quantity;
        }
    }
}

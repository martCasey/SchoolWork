/* X-Number: X00119025
 * Date: 19/10/2017
 */
using System.Collections.Generic;

namespace CA1
{
    class ShoppingCart
    {
        private List<CartItem> cartCollection = new List<CartItem>();                                    //Collection

        public CartItem CartCollection { get; }                                                         //Property

        public void AddItem(CartItem item)                                                              //Method to add item
        {
            if(cartCollection.Contains(item))
            {
                item.Quantity = 1;
                cartCollection.Add(item);
            }
            else
            {
                for(int i = 0; i < cartCollection.Capacity; i++)
                {
                    if(cartCollection[i] == item)
                    {
                        cartCollection[i].Quantity++;                                                   //Increase quantiy by 1
                    }
                }
            }
        }

        public double TotalPrice()                                                                      //Return the total price of all items
        {
            double returnValue = 0;
            for(int i = 0; i < cartCollection.Capacity; i++)
            {
                returnValue += (cartCollection[i].Price * cartCollection[i].Quantity);
            }
            return returnValue;
        }
    }
}

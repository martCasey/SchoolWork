/* X-Number: X00119025
 * Date: 19/10/2017
 */
using System;

namespace CA1
{
    class Test
    {
        static void Main()
        {
            CartItem cartItem1 = new CartItem();                                        //Test CartItems
            cartItem1.Code = "A123P";
            cartItem1.Description = "Red Apple";
            cartItem1.Price = 1.50;
            cartItem1.Quantity = 5;
            Console.WriteLine(cartItem1.ToString());
            Console.ReadLine();
            Console.WriteLine();

            CartItem cartItem2 = new CartItem();
            cartItem1.Code = "A4567P";
            cartItem1.Description = "Green Apple";
            cartItem1.Price = 1.50;
            cartItem1.Quantity = 5;
            Console.WriteLine(cartItem1.ToString());
            Console.ReadLine();
            Console.WriteLine();

            FootWearItem footItem1 = new FootWearItem();                                //Test FootWearItems
            footItem1.Code = "R345N";
            footItem1.Description = "Runners";
            footItem1.Price = 46.99;
            footItem1.Size = 10;
            Console.WriteLine(footItem1.ToString());
            Console.ReadLine();
            Console.WriteLine();

            ShoppingCart shoppingCart = new ShoppingCart();                                //Test ShoppingCarts
            shoppingCart.AddItem(cartItem1);
            //cart1.AddItem(item2);
            Console.WriteLine(shoppingCart.TotalPrice());
            Console.WriteLine(shoppingCart);
            Console.ReadLine();
            Console.WriteLine();


        }
    }
}

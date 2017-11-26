/* X-Number: X00119025
* Date: 18/10/2017
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CurrencyUnit { Euro, Dollar, Yen}                                                       //Enums can be declared outside of a class

namespace Lab5_EnumsStructs
{


    class Test
    {
        static void Main(string[] args)                                                         //Test class
        {
            Money m1 = new Money(CurrencyUnit.Euro, 50);
            Money m2 = new Money(CurrencyUnit.Dollar, 70);
            Money m3 = m1 + m2;
            Console.WriteLine(m3);
            Money m4 = m3 + (new Money(CurrencyUnit.Dollar, 100));
            Console.WriteLine(m4);
            Console.ReadLine();
        }
    }

        public struct Money                                                                                        //Struct
        {
            private const double euroToDollarRate = 1.31;                                             //conversion rates
            private const double dollarToEuroRate = 0.76;

            public double Amount { get; set; }                                                             //Property
            public CurrencyUnit Currency{ get; set; }           //Enum property requires you to use the type ('Unit') you created earlier   

            public Money(CurrencyUnit currency, double amount) : this()                                       //Need to add this to the constructor to make a call to the default constructor.  Must be done when using properties in a constructor, in a struct
            {
                this.Currency = currency;
                this.Amount = amount;
            }

            public double ConvertCurrency(CurrencyUnit toCurrency)                                             //Convert currency from one format to another
            {
                if(Currency == toCurrency)              //no change done
                {
                    return Amount;
                }
                else
                {
                    if(toCurrency == CurrencyUnit.Dollar)
                    {
                        return Amount * euroToDollarRate;   //convert to dollar
                    }
                    else
                    {
                        return Amount * dollarToEuroRate;   //convert to euro
                    }
                }
            }

            public static Money operator +(Money cash1, Money cash2)                                            //Add money together
            {
                if(cash1.Currency == cash2.Currency)        //both are of the same currency type
                {
                    return new Money(cash1.Currency, cash1.Amount + cash2.Amount);     
                }
                else
                {
                    return new Money(cash1.Currency, cash1.Amount + cash2.ConvertCurrency(cash2.Currency));      //When both are two completely different currencies
                }
            }

            public override string ToString()
            {
                return this.Currency + ": " + this.Amount;
            }
        }
}
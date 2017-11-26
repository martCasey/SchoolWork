/* X-Number: X00119025
* Date: 18/10/2017
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_EnumsStructs
{


    class Program
    {
        static void Main(string[] args)                                                         //Test class
        {
            MoneyClass money = new MoneyClass();
            money.Equals(20);
            Console.WriteLine(money);
            Console.ReadLine();

        }
    }

    class MoneyClass
    {
        public struct Money                                                                                        //Struct
        {
            public double amount;
            public enum Unit { first = '€', second = '$', third = '¥' };

            const double euroToUS = 0.8498776176230623;                                             //conversion rates
            const double usToEuro = 1.17664;
            const double euroToYen = 0.0075752984667596;
            const double yenToEuro = 1.17664;
            const double yenToUS = 112.1728898316397;
            const double usToYen = 0.00891481;

            double Amount { get; set; }                                                             //Property
            Unit UnitProptery { get; set; }                                                         //Enum property requires you to use the type ('Unit') you created earlier   

            public Money(double amountIn, Unit unitIn) : this()                                       //Need to add this to the constructor to make a call to the default constructor.  Must be done when using properties in a constructor, in a struct
            {
                this.amount = amountIn;
                this.UnitProptery = unitIn;
            }

            public Money ConvertCurrency(Unit type, Money moneyIn)
            {
                if (type.Equals('€') && !moneyIn.UnitProptery.Equals('€'))
                {
                    if (moneyIn.UnitProptery.Equals('$'))                                                         //Converting dolar to euro
                    {
                        moneyIn.Amount = amount / euroToUS;
                        moneyIn.UnitProptery = Unit.first;
                    }
                    else
                    {
                        moneyIn.Amount = amount / euroToYen;                                                    //Converting Yen to euro
                        moneyIn.UnitProptery = Unit.first;
                    }
                    return moneyIn;
                }

                if (type.Equals('$') && !moneyIn.UnitProptery.Equals('$'))
                {
                    if (moneyIn.UnitProptery.Equals('€'))
                    {
                        moneyIn.Amount = amount / usToEuro;                                                     //Converting euro to dolar
                        moneyIn.UnitProptery = Unit.first;
                    }
                    else
                    {
                        moneyIn.Amount = amount / usToYen;                                                      //Converting yen to dolar
                        moneyIn.UnitProptery = Unit.second;
                    }
                    return moneyIn;
                }

                if (type.Equals('¥') && !moneyIn.UnitProptery.Equals('¥'))
                {
                    if (moneyIn.UnitProptery.Equals('€'))
                    {
                        moneyIn.Amount = amount / yenToEuro;                                                    //converting euro to yen
                        moneyIn.UnitProptery = Unit.third;
                    }
                    else
                    {
                        moneyIn.Amount = amount / yenToUS;                                                      //converting dolar to yen
                        moneyIn.UnitProptery = Unit.third;
                    }
                }
                return moneyIn;
            }

            public double AddMoney(Money money1, Money money2)
            {
                double returnValue;
                if (money1.UnitProptery != money2.UnitProptery)
                {
                    money2.ConvertCurrency(money1.UnitProptery, money2);
                }
                return returnValue = money1.Amount + money2.Amount;
            }
        }
    }
}
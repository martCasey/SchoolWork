using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate string EncryptText(string text);                          //delegate declaration
namespace Exercise6_Delegates
{
    class Ciphere
    {
        string plainText;

        public void UseCipheres()
        {
            EncryptText encryptText1 = CeaserCiphere;                    //Other method also added to delegate
            Console.WriteLine(encryptText1("Hello"));
            Console.ReadLine();
            EncryptText encryptText2 = ReverseCiphere;
            Console.WriteLine(encryptText1("Bye-Bye"));
            Console.ReadLine();
        }

        public static string CeaserCiphere(string ciphText)
        {
            string returnValue = "";
            List<char> tempList = new List<char>();
            int lastPosition = ciphText.Length - 1;
            char[] ciphereText = ciphText.ToCharArray();
            tempList.Add(ciphereText[lastPosition]);                        //Since we are shifting the positons in the array by one, the last positon must now become the first position
            for (int i = 0; i < lastPosition; i++)                           //Ensure the loop stops before it reaches the last positon
            {
                tempList.Add(ciphereText[i]);
            }

            for (int i = 0; i < tempList.Capacity; i++)                      //Now we loop again so we can return the ciphere text
            {
                ciphereText[i] = tempList[i];
                returnValue += ciphereText[i];
            }
            return returnValue;
        }

        public static string ReverseCiphere(string revText)
        {
            string returnValue = "";
            char[] reverseText = revText.ToCharArray();
            reverseText.Reverse();                                      //Reverse the order of values in the array
            for (int i = 0; i < reverseText.Length; i++)
            {
                returnValue += reverseText[i];
            }
            return returnValue;
        }

        class Test                                  //test class
        {
            static void Main(string[] args)
            {
                EncryptText encryptText = null;
                encryptText += CeaserCiphere;
                Console.WriteLine(encryptText("Word"));                     //This line inputs the word "Word" into the CesearCiphere
                Console.ReadLine();
                EncryptText encryptText2 = new EncryptText(ReverseCiphere);
                Console.WriteLine(encryptText2("Word2"));                  //This line inputs the word "Word2" into the ReverseCiphere, notice at the moment we needed to use a different delegate object
                Console.ReadLine();
            }
        }
    }
}

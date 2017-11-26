using System;
using System.Text;

delegate string EncryptionDelegate(string plainText);

namespace DelegatesSolution
{
    class Cipher
    {
        //simple Caeser cipher
        public static string Cipher1(String plainText)
        {
            const int key = 1;      //shift by 1 char
            StringBuilder ciphereText = new StringBuilder(plainText);       //Allows us to append more values onto a string

            //Unicode max value is (2 ^ 16) -1
            int wrap = (int)(char.MaxValue);        //casting an int to a char

            //shift each character forwards by key amount
            for(int i = 0; i < ciphereText.Length; i++)
            {
                ciphereText[i] = (char)((ciphereText[i] + key) % wrap);     //This is some how adding in different values from the alphabet
            }
            return ciphereText.ToString();
        }

        //simple cipher which reverses a string
        public static string Cipher2(String plainText)
        {
            char[] text = plainText.ToCharArray();
            string cipherText = String.Empty;
            for(int i = text.Length - 1; i >= 0; i--)
            {
                cipherText += text[i];
            }
            return cipherText;
        }
        static void Main()
        {
            EncryptionDelegate ed1 = null;
            ed1 += Cipher1;
            Console.WriteLine("Caeser Cipher:");
            Console.WriteLine(ed1("a secret message"));
            Console.ReadLine();
            EncryptionDelegate ed2 = new EncryptionDelegate(Cipher2);
            Console.WriteLine("Reverse Cipher:");
            Console.WriteLine(ed2("a secret message"));
            Console.ReadLine();
        }
    }
}

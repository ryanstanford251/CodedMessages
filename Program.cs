using System;

namespace CodedMesssages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message: ");
            string plainText = Console.ReadLine();
            if(int.TryParse(Console.ReadLine(), out int key))
            encrypt(plainText, key);
            

        }

        static void encrypt(string message, int key)
        {
            for (int i = 0; i < message.Length; i++)
            {
                int charToInt = (int)message[i];
                char[] intToChar = new char[message.Length];
                if (charToInt > 96 && charToInt < 123) //lowercase
                {
                    charToInt = ((int)message[i] - 96 + key % 26) + 96;
                    intToChar[i] = (char)charToInt;
                }
                else if (charToInt > 64 && charToInt < 91) //uppercase
                {
                    charToInt = ((int)message[i] - 64 + key % 26) + 64;
                    intToChar[i] = (char)charToInt;
                }
                else
                {
                    intToChar[i] = (char)charToInt;
                }
                
            }
        }
    }
}

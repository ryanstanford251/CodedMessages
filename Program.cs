using System;

namespace CodedMesssages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message: ");
            string plainText = Console.ReadLine();
            if (int.TryParse(Console.ReadLine(), out int key)) { };

            string s = new string(encrypt(plainText, key));
            Console.WriteLine($"Encrypted string {s}");

            string x = new string(decrypt(s, 1));
            Console.WriteLine($"plain text: {x}");
            

        }

        static char[] encrypt(string message, int key)
        {
            char[] intToChar = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                int charToInt = (int)message[i];
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
                return intToChar;
        }

        static char[] decrypt(string encryptedMessage, int key)           
        {
            char[] intToChar = new char[encryptedMessage.Length];
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                int charToInt = (int)encryptedMessage[i];
                if (charToInt > 96 && charToInt < 123) //lowercase
                {
                    charToInt = ((int)encryptedMessage[i] - 96 - key % 26) + 96;
                    intToChar[i] = (char)charToInt;
                }
                else if (charToInt > 64 && charToInt < 91) //uppercase
                {
                    charToInt = ((int)encryptedMessage[i] - 64 - key % 26) + 64;
                    intToChar[i] = (char)charToInt;
                }
                else
                {
                    intToChar[i] = (char)charToInt;
                }

            }
            return intToChar;
        }
    }
}

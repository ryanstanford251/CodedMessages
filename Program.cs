using System;
using static CodedMesssages.Cryptography;

namespace CodedMesssages
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter message: ");
            string plainText = Console.ReadLine();
            Console.Write("Enter key: ");
            if (int.TryParse(Console.ReadLine(), out int key)) { };

            string s = new string(letterShiftEncryption(plainText, key));
            Console.WriteLine($"Encrypted string {s}");

            string x = new string(letterShiftDecryption(s, 1));
            Console.WriteLine($"plain text: {x}");*/


            Console.Write("plaintext: ");
            string plainText = Console.ReadLine();
            Console.Write("Key: ");
            string key = Console.ReadLine();
            if (isValidSubstitutionKey(key))
            {
               Console.WriteLine(substitutionEncryption(key, plainText));
            }
            
            

        }

    }          
}

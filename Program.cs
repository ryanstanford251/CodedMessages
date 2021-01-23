using System;
using static CodedMesssages.Cryptography;

namespace CodedMesssages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message: ");
            string plainText = Console.ReadLine();
            if (int.TryParse(Console.ReadLine(), out int key)) { };

            string s = new string(letterShiftEncryption(plainText, key));
            Console.WriteLine($"Encrypted string {s}");

            string x = new string(letterShiftDecryption(s, 1));
            Console.WriteLine($"plain text: {x}");
            

        }

    }          
}

using System;
using static CodedMesssages.Cryptography;

namespace CodedMesssages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter message: ");
            string message = Console.ReadLine();
            int key;
            do
            {
                Console.Write("Enter encryption key: ");
                key = isValidLetterShiftKey(Console.ReadLine());

            } while (key < 1);
            string encryptedMessage = letterShiftEncryption(message, key);
            string decryptedMessage = letterShiftDecryption(encryptedMessage, key);
            Console.WriteLine($"Plaintext Message: {message}");
            Console.WriteLine($"Encrypted Message: {encryptedMessage}");
            Console.WriteLine($"Decrypted Message: {decryptedMessage}");
            
            


            //Console.Write("plaintext: ");
            //string plainText = Console.ReadLine();
            //Console.Write("Key: ");
            //string key = Console.ReadLine();
            //if (isValidSubstitutionKey(key))
            //{
            //    string result = new string(substitutionEncryption(key, plainText));
            //    Console.WriteLine($" Encrypted Text: {result}");
            //    string decryptedResult = new string(substitutionDecryption(key, result));
            //    Console.WriteLine($"Decrypted Text: {decryptedResult}");
            //}
            
            

        }

    }          
}

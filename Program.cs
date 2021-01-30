using System;
using static CodedMesssages.Cryptography;

namespace CodedMesssages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Letter Shift Encrytption\n");
            Console.Write("Enter message: ");
            string message = Console.ReadLine();
            int letterShiftKey;
            do
            {
                Console.Write("Enter encryption key: ");
                letterShiftKey = isValidLetterShiftKey(Console.ReadLine());

            } while (letterShiftKey < 1);
            string encryptedMessage = letterShiftEncryption(message, letterShiftKey);
            string decryptedMessage = letterShiftDecryption(encryptedMessage, letterShiftKey);
            Console.WriteLine($"\nPlaintext Message: {message}");
            Console.WriteLine($"Encrypted Message: {encryptedMessage}");
            Console.WriteLine($"Decrypted Message: {decryptedMessage}\n\n");



            Console.WriteLine("Substitution Encryption\n");
            Console.Write("Enter message: ");
            string plainText = Console.ReadLine();
            string substitutionKey;
            do
            {
                Console.Write("Key: ");
                substitutionKey = Console.ReadLine();

                if (isValidSubstitutionKey(substitutionKey))
                {
                    Console.WriteLine($"Plaintext: {plainText}");
                    string result = substitutionEncryption(substitutionKey, plainText);
                    Console.WriteLine($"Encrypted Text: {substitutionEncryption(substitutionKey, plainText)}");
                    string decryptedResult = new string(substitutionDecryption(substitutionKey, result));
                    Console.WriteLine($"Decrypted Text: {decryptedResult}");
                }
                else
                {
                    Console.WriteLine("Invalid key");
                }
            } while (isValidSubstitutionKey(substitutionKey) == false);



        }

    }          
}

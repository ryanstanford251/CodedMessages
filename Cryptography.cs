using System;
namespace CodedMesssages
{
    public class Cryptography
    {
        public Cryptography()
        {
        }

        public static int isValidLetterShiftKey()
        {
            string key = string.Empty;
            int numericKey;
            bool validateKey;
            do
            {
                key = Console.ReadLine();
                validateKey = int.TryParse(key, out numericKey);

            } while (validateKey == false);
            return numericKey;
            
        }
        public static char[] letterShiftEncryption(string message, int key)
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

        public static char[] letterShiftDecryption(string encryptedMessage, int key)
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

        public static bool isValidSubstitutionKey(string key)
        {
            if (key.Length == 26)
            {
                for (int i = 0; i < 26; i++)
                {
                    for (int x = i + 1; x < 26; x++)
                    {
                        if (key[i] == key[x])
                        {
                            Console.WriteLine("Invalid Key");
                            return false;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Key");
                return false;
            }
            return true;
        }

        public static char[] substitutionEncryption(string key, string plainText)
        {
            char[] encryptedMessage = new char[plainText.Length];
            char[] intToChar = key.ToCharArray();
            for (int i = 0; i < plainText.Length; i++)
            {
                int charToInt = (int)plainText[i];
                if (charToInt > 96 && charToInt < 123) //lowercase
                {
                    encryptedMessage[i] = intToChar[charToInt - 97];
                }
                else if (charToInt > 64 && charToInt < 91) //uppercase
                {
                    encryptedMessage[i] = intToChar[charToInt - 65];
                }
                else
                {
                    encryptedMessage[i] = plainText[i];
                }
            }
            return encryptedMessage;
        }

        public static char[] substitutionDecryption(string key, string encryptedText)
        {
            char[] decryptedText = new char[encryptedText.Length];

            for (int x = 0; x < key.Length; x++)         
            {
                for (int i = 0; i < encryptedText.Length; i++)
                {
                    int stringToInt = (int)encryptedText[i];
                    if (stringToInt > 96 && stringToInt < 123)//lowercase
                    {
                        if (key[x] == encryptedText[i])
                        {
                            stringToInt = x + 97;
                            decryptedText[i] = (char)stringToInt;
                        }
                    }
                    else if (stringToInt > 64 && stringToInt < 91)//uppercase
                    {
                        stringToInt = x + 65;
                        decryptedText[i] = (char)stringToInt;
                    }
                    else 
                    {
                        decryptedText[i] = encryptedText[i];
                    }
                }
            }
            return decryptedText;
        }
    }

}

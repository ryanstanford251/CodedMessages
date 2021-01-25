using System;
namespace CodedMesssages
{
    public class Cryptography
    {
        public Cryptography()
        {
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
            for (int i = 0; i < plainText.Length; i++)
            {
                int charToInt = (int)plainText[i];
                if (charToInt > 96 && charToInt < 123) //lowercase
                {
                    encryptedMessage[i] = key[charToInt - 96];
                }
                else if (charToInt > 64 && charToInt < 91) //uppercase
                {
                    encryptedMessage[i] = key[charToInt - 64];
                }
                else
                {
                    encryptedMessage[i] = plainText[i];
                }
            }
            return encryptedMessage;
        }

        /*public static char[] substitutionDecryption(string key, string ecryptedText)
        {

        }*/
    }

}

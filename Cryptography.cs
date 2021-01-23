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

        public static char[] substitutionEncryption()
        {

        }

        public static char[] substitutionDecryption()
        {

        }
    }

}

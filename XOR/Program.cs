using System;
using System.IO;
using System.Linq;

namespace XOR
{
    class Program
    {
        static void Main(string[] args)
        {
            XOR x = new XOR();

            string path = @"D:\GERASKIN\XOR\text.txt";
            var inputText = "";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    inputText = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Text: " + inputText);

            Console.Write("Enter Key: ");
            var password = Console.ReadLine();

            var encryptedText = x.Encrypt(inputText, password);

            Console.WriteLine("Result of encryption " + encryptedText);

            Console.WriteLine("Result of decryption " + x.Decrypt(encryptedText, password));

            Console.ReadLine();
        }
    }
}

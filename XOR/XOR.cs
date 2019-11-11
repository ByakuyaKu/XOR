using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XOR
{
    public class XOR
    {
        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }

        private string Cipher(string text, string secretKey)
        {
            var currentKey = GetRepeatKey(secretKey, text.Length);
            var res = "";

            //var ByteText = text.ToCharArray().Select(i => Convert.ToString(i, 2));
            //var BytecurrentKey = currentKey.ToCharArray().Select(i => Convert.ToString(i, 2));


            for (var i = 0; i < text.Count(); i++)
            {
                res +=Convert.ToChar((text[i] ^ currentKey[i])).ToString();
            }

            return res;
        }

        public string Encrypt(string plainText, string password)
        => Cipher(plainText, password);

        public string Decrypt(string encryptedText, string password)
            => Cipher(encryptedText, password);

    }
}

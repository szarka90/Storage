using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Storage
{
    class Encrypt
    {
        public static string HashString(string passwordString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in GetHash(passwordString))
            {
                stringBuilder.Append(b.ToString("X3"));
            }
            return stringBuilder.ToString();
        }
        public static byte[] GetHash(string passwordString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
            }
        }
    }
}

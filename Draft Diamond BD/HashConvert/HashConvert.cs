using System;
using System.Security.Cryptography;
using System.Text;

namespace Draft_Diamond_BD.HashPassword
{
    public class SimpleHash
    {
        public static byte[] HashSHA256(string input)
        {
            using (var sha256 = new SHA256Managed())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            }
        }
    }
}

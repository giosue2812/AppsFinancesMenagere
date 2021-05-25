using System;
using System.Security.Cryptography;

namespace GenerateKey
{
    class Program
    {
        static void Main(string[] args)
        {
            HMACSHA512 hmac = new HMACSHA512();
            string key = Convert.ToBase64String(hmac.Key);
            Console.WriteLine(key);
        }
    }
}

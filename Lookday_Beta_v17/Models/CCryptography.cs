﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Register_and_login_test
{
    public class CCryptography
    {
        public static byte[] GetSaltBytes(string saltString)
        {
            return Encoding.UTF8.GetBytes(saltString);
        }

        //temp funtion
        static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        public static string HashPasswordWithSalt(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                string saltString = "gugubird";
                byte[] saltBytes = GetSaltBytes(saltString);
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password).Concat(saltBytes).ToArray();
                byte[] hash = sha256.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash, string saltString)
        {
            string hashOfEnteredPassword = HashPasswordWithSalt(enteredPassword);
            return hashOfEnteredPassword == storedHash;
        }

    }

}

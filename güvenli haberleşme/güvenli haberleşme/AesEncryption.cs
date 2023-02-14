using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
namespace güvenli_haberleşme
{
    class AesEncryption
    {
        public string Encrypt(string plaintext, string password)
        {
            // Generate a random salt
            byte[] salt = GenerateRandomSalt();
            // Derive the key from the password and salt
            Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] key = keyGenerator.GetBytes(16);
            // Create an Aes object
            // This object represents the AES algorithm
            Aes aes = Aes.Create();
            // Set the key size to 128 bits (16 bytes)
            aes.KeySize = 128;
            aes.Key = key;
            // Set the IV (initialization vector)
            aes.IV = keyGenerator.GetBytes(16);
            // Create a decryptor to perform the encryption
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            // Create a memory stream to hold the encrypted data
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Create a crypto stream to process the data
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    // Convert the plaintext into a byte array
                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);
                    // Encrypt the plaintext
                    cryptoStream.Write(plaintextBytes, 0, plaintextBytes.Length);
                }
                // Return the encrypted data as a base64-encoded string
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
        public string Decrypt(string encrypted, string password)
        {
            // Convert the encrypted data from a base64-encoded string to a byte array
            byte[] encryptedBytes = Convert.FromBase64String(encrypted);
            // Extract the salt from the beginning of the encrypted data
            byte[] salt = new byte[8];
            Array.Copy(encryptedBytes, 0, salt, 0, 8);
            // Derive the key from the password and salt
            Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, salt, 1000);
            byte[] key = keyGenerator.GetBytes(16);
            // Create an Aes object
            // This object represents the AES algorithm
            Aes aes = Aes.Create();
            // Set the key size to 128 bits (16 bytes)
            aes.KeySize = 128;
            aes.Key = key;
            // Set the IV (initialization vector)
            aes.IV = keyGenerator.GetBytes(16);
            // Create a decryptor to perform the decryption
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            // Create a memory stream to hold the decrypted data
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Create a crypto stream to process the data
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Write))
                {
                    // Decrypt the encrypted data
                    cryptoStream.Write(encryptedBytes, 8, encryptedBytes.Length - 8);
                }
                // Return the decrypted data as a UTF-8 encoded string
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
        private static byte[] GenerateRandomSalt()
        {
            // Create a random number generator
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // Create a buffer to hold the salt
                byte[] salt = new byte[8];
                // Generate a random salt
                rng.GetBytes(salt);
                // Return the salt
                return salt;
            }
        }
    }
}
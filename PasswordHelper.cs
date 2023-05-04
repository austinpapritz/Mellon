using Konscious.Security.Cryptography;
using System;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public static class PasswordHelper
    {
        public static byte[] EncryptMasterPassword(string masterPassword)
        {
            using var hasher = new Argon2id(Encoding.UTF8.GetBytes(masterPassword));
            hasher.DegreeOfParallelism = 8; // higher values increase memory and CPU usage
            hasher.MemorySize = 65536; // higher values increase memory usage
            hasher.Iterations = 4; // higher values increase CPU usage

            byte[] salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            byte[] hash = hasher.GetBytes(32);

            byte[] encryptedMasterPassword = new byte[salt.Length + hash.Length];
            Buffer.BlockCopy(salt, 0, encryptedMasterPassword, 0, salt.Length);
            Buffer.BlockCopy(hash, 0, encryptedMasterPassword, salt.Length, hash.Length);

            return encryptedMasterPassword;
        }
    }
}

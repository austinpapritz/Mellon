using Konscious.Security.Cryptography;
using System;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public static class PasswordHelper
    {
        public static (byte[] hashedMasterPassword, byte[] salt) HashMasterPassword(string masterPassword, byte[] salt = null)
        {
            using var hasher = new Argon2id(Encoding.UTF8.GetBytes(masterPassword));
            hasher.DegreeOfParallelism = 8; // higher values increase memory and CPU usage
            hasher.MemorySize = 65536; // higher values increase memory usage
            hasher.Iterations = 4; // higher values increase CPU usage

            if (salt == null)
            {
                salt = new byte[16];
                RandomNumberGenerator.Fill(salt);
            }

            hasher.Salt = salt; 

            byte[] hash = hasher.GetBytes(32);

            return (hash, salt);
        }

    }
}

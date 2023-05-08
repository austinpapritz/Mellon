using System;
using System.IO;
using System.Security.Cryptography;

public static class EncryptionHelper
{
    public static byte[] Encrypt(byte[] key, byte[] data)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.GenerateIV();

            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(aes.IV, 0, aes.IV.Length);

                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(data, 0, data.Length);
                }

                return memoryStream.ToArray();
            }
        }
    }

    public static byte[] Decrypt(byte[] key, byte[] encryptedData)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;

            using (MemoryStream memoryStream = new MemoryStream(encryptedData))
            {
                byte[] iv = new byte[16];
                memoryStream.Read(iv, 0, iv.Length);
                aes.IV = iv;

                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedData = new byte[encryptedData.Length];
                    int bytesRead = cryptoStream.Read(decryptedData, 0, decryptedData.Length);

                    return new ReadOnlySpan<byte>(decryptedData, 0, bytesRead).ToArray();
                }
            }
        }
    }
}

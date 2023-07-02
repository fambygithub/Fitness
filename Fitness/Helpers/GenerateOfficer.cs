﻿using Fitness.Models;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Fitness.Helpers
{
    public static class GenerateOfficer
    {
        public static string GenerateOfficerId(string officerid)
        {
            string offid = "";

            int Id = Convert.ToInt32(officerid.Substring(8)) + 1;
            if (Id < 10)
            {
                offid = "OFFICER-00" + Id.ToString();
            }
            else if (Id < 100)
            {
                offid = "OFFICER-0" + Id.ToString();
            }
            else
            {
                offid = "OFFICER-" + Id.ToString();
            }

            return offid;
        }
        public static string Encryption(string password)
        {

            string EncryptionKey = "ZaniimzOxide";
            byte[] clearBytes = Encoding.Unicode.GetBytes(password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    password = Convert.ToBase64String(ms.ToArray());
                }
            }
            return password;
        }

        
    }
}

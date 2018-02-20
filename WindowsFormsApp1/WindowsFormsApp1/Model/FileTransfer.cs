using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Model
{
    class FileTransfer
    {
        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        byte[] key = Encoding.ASCII.GetBytes("12345678");
        byte[] iv = Encoding.ASCII.GetBytes("87654321");

        public FileTransfer()
        {
            des.Key = key;
            des.IV = iv;
        }

        public ICryptoTransform getEncryptor()
        {
            return des.CreateEncryptor();
        }

        public ICryptoTransform getDecryptor()
        {
            return des.CreateDecryptor();
        }
    }
}

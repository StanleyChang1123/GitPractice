using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void button_EncryptFile_Click(object sender, EventArgs e)
        {
            string sourceFilePath = string.Format(@"C:\Testing\LearningSystem\{0}.mp4", tB_FileName.Text);
            string encryptFilePath = string.Format(@"C:\Testing\LearningSystem\{0}-encrypt.mp4", tB_FileName.Text);

            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream encryptStream = new FileStream(encryptFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] dataByteArray = new byte[sourceStream.Length];
                sourceStream.Read(dataByteArray, 0, dataByteArray.Length);

                using (CryptoStream cs = new CryptoStream(encryptStream, new FileTransfer().getEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                }
            }

        }

        private void button_DecryptAndPlay_Click(object sender, EventArgs e)
        {
            string encryptFilePath = string.Format(@"C:\Testing\LearningSystem\{0}-encrypt.mp4", tB_FileName.Text);
            string decryptFilePath = @"C:\Testing\LearningSystem\Decrypt.mp4";

            using (FileStream encryptStream = new FileStream(encryptFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream decryptStream = new FileStream(decryptFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] dataByteArray = new byte[encryptStream.Length];
                encryptStream.Read(dataByteArray, 0, dataByteArray.Length);
                using (CryptoStream cs = new CryptoStream(decryptStream, new FileTransfer().getDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                }
            }

            axWindowsMediaPlayer1.URL = decryptFilePath;
        }

   
       


        #region example
        private void button_EncryptTextExample_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");
            des.Key = key;
            des.IV = iv;

            string source = tb_TextSourceExample.Text;
            byte[] dataByteArray = Encoding.UTF8.GetBytes(source);
            string encrypt = "";

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                    encrypt = Convert.ToBase64String(ms.ToArray());
                }
            }

            tB_EncryptExample.Text = encrypt;
        }

        private void button_DecryptTextExample_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");
            des.Key = key;
            des.IV = iv;

            string encrypt = tB_EncryptExample.Text;
            string decrypt = "";

            byte[] dataByteArray = Convert.FromBase64String(encrypt);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                    decrypt = Encoding.UTF8.GetString(ms.ToArray());
                }

                tB_DecryptExample.Text = decrypt;
            }
        }

        private void button_DecryptFileExample_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");

            des.Key = key;
            des.IV = iv;

            string encryptFilePath = @"C:\Testing\LearningSystem\1-1-encrypt.mp4";
            string decryptFilePath = @"C:\Testing\LearningSystem\1-1-decrypt.mp4";

            using (FileStream encryptStream = new FileStream(encryptFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream decryptStream = new FileStream(decryptFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] dataByteArray = new byte[encryptStream.Length];
                encryptStream.Read(dataByteArray, 0, dataByteArray.Length);
                using (CryptoStream cs = new CryptoStream(decryptStream, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                }
            }
        }
        #endregion example

    }
}

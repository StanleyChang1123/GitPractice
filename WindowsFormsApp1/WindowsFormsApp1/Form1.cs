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
            //Stanley add
            //try
            //{

            //}
            //catch (Exception ee)
            //{
            //    var a = ee;
            //    var b = 1;
            ////}
            //if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    axWindowsMediaPlayer1.fullScreen = true;
            //}

            //axWindowsMediaPlayer1.URL = @"C:\Users\iphon\Desktop\Gmail\Hu.mp4";
       
        }

        private byte[] getOriginalFileStream(string filePath)
        {
            long fileLength = 0;
            byte[] originalByteArray;

            using (FileStream fsSource = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                fileLength = fsSource.Length;
                originalByteArray = new byte[fileLength];

                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    int n = fsSource.Read(originalByteArray, numBytesRead, numBytesToRead);    // Read may return anything from 0 to numBytesToRead.
                    if (n == 0)  // Break when the end of the file is reached.
                        break;
                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = originalByteArray.Length;
            }

            return originalByteArray;
        }

        private byte[] writeEncryptFile(byte[] source, string pathEncrypt)
        {
            #region 加解密 key
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");
            des.Key = key;
            des.IV = iv;
            #endregion 加解密 key

            #region 加密
            int fileLength = source.Length;

            string encrypt = "";
            byte[] encryptByteArray = new byte[fileLength];

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(source, 0, source.Length);
                    cs.FlushFinalBlock();
                    encrypt = Convert.ToBase64String(ms.ToArray());
                    encryptByteArray = Convert.FromBase64String(encrypt);
                }
            }

            using (FileStream fsNew = new FileStream(pathEncrypt,
                    FileMode.Create, FileAccess.Write))
            {
                fsNew.Write(encryptByteArray, 0, (int)fileLength);
            }
            #endregion 加密
            return encryptByteArray;
        }

        private void writeDecryptFile(byte[] encrypt, int originalFileLength, string pathDecrypt)
        {
            #region 加解密 key
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");
            des.Key = key;
            des.IV = iv;
            #endregion 加解密 key

            //#region 解密
            byte[] decryptByteArray = new byte[originalFileLength];
            des.Key = Encoding.ASCII.GetBytes("12345678");
            des.IV = Encoding.ASCII.GetBytes("87654321");
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(encrypt, 0, encrypt.Length);
                    cs.FlushFinalBlock();
                    decryptByteArray = ms.ToArray();
                }
            }

            using (FileStream fsNew = new FileStream(pathDecrypt,
                FileMode.Create, FileAccess.Write))
            {
                fsNew.Write(decryptByteArray, 0, (int)originalFileLength);
            }
        }

        private void button_genEnDecryptFile(object sender, EventArgs e)
        {
            string pathSource = @"C:\Testing\LearningSystem\Original.mp4";
            byte[] originalByteArray = getOriginalFileStream(pathSource);

            string pathEncrypt = @"C:\Testing\LearningSystem\Encrypt.mp4";
            var encryptByteArray = writeEncryptFile(originalByteArray, pathEncrypt);
            string pathDecrypt = @"C:\Testing\LearningSystem\Decrypt.mp4";

            writeDecryptFile(encryptByteArray, originalByteArray.Length, pathDecrypt);

            //long fileLength = originalByteArray.Length;
          


          

            //#endregion 解密
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Testing\LearningSystem\Encrypt.mp4";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Testing\LearningSystem\Decrypt.mp4";
        }
    }
}

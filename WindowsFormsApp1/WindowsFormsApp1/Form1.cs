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
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region TryAgain

        #endregion TryAgain



        Dictionary<string, int> mappingFileNameLengh;

        public Form1()
        {
            InitializeComponent();
            //mappingFileNameLengh = RetrieveFileNameLengthMappingFromDB();

        }

        private Dictionary<string, int> RetrieveFileNameLengthMappingFromDB()
        {
            return new Dictionary<string, int>()  //future from DB
            {
                { "1-1", 2730297 }, { "1-2", 2730297 }
            };
        }
      
        //看到底哪邊不同

        private void button_genEncryptFile(object sender, EventArgs e)
        {
            string pathSource = @"C:\Testing\LearningSystem\"  + textBox_EncryptFile.Text +   ".mp4";
            byte[] originalByteArray = getOriginalFileStream(pathSource);

            string pathEncrypt = @"C:\Testing\LearningSystem\" + textBox_EncryptFile.Text + "_" + originalByteArray.Length + ".mp4";  
            var encryptByteArray = writeEncryptFile(originalByteArray, pathEncrypt);


             string pathDecrypt = @"C:\Testing\LearningSystem\Decrypt.mp4";
              writeDecryptFile(encryptByteArray, originalByteArray.Length, pathDecrypt);  //需要original byteArray
        }

        private void button_playFile_Click(object sender, EventArgs e)
        {
            string fileName = textBox_playFile.Text;
            int originalFilebyteLength =  mappingFileNameLengh[fileName];
            string pathFileToDecrypt = @"C:\Testing\LearningSystem\" + fileName + "_" + originalFilebyteLength + ".mp4";  
            byte[] byteArrayToDecrypt = getOriginalFileStream(pathFileToDecrypt);

            string pathDecrypt = @"C:\Testing\LearningSystem\Decrypt.mp4";

            writeDecryptFile(byteArrayToDecrypt, originalFilebyteLength, pathDecrypt);  

        }


       

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
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
            FileTransfer ft = new FileTransfer();

            #region 加密
            long fileLength = source.Length;
            byte[] encryptByteArray = new byte[fileLength];

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, ft.getEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(source, 0, source.Length);
                    cs.FlushFinalBlock();
                    encryptByteArray = ms.ToArray();
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

        private void writeDecryptFile(byte[] encrypt, long originalFileLength, string pathDecrypt)
        {
            //#region 解密
            FileTransfer ft = new FileTransfer();

            byte[] decryptByteArray = new byte[originalFileLength];
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, ft.getDecryptor(), CryptoStreamMode.Write))
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


        private void button_EncryptSource_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");
            des.Key = key;
            des.IV = iv;

            string source = tB_Source.Text;
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

            tB_Encrypt.Text = encrypt;
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");
            des.Key = key;
            des.IV = iv;

            string encrypt = tB_Encrypt.Text;
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

                tB_Decrypt.Text = decrypt;
            }
        }

        private void button_EncryptFile_Click(object sender, EventArgs e)
        {
            string sourceFilePath  = @"C:\Testing\LearningSystem\1-1.mp4";
            string encryptFilePath = @"C:\Testing\LearningSystem\1-1-encrypt.mp4";

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] key = Encoding.ASCII.GetBytes("12345678");
            byte[] iv = Encoding.ASCII.GetBytes("87654321");
            des.Key = key;
            des.IV = iv;

            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream encryptStream = new FileStream(encryptFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] dataByteArray = new byte[sourceStream.Length];
                sourceStream.Read(dataByteArray, 0, dataByteArray.Length);

                using (CryptoStream cs = new CryptoStream(encryptStream, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(dataByteArray, 0, dataByteArray.Length);
                    cs.FlushFinalBlock();
                }
            }

        }

        private void button_DecryptFile_Click(object sender, EventArgs e)
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



        //private void button2_Click(object sender, EventArgs e)
        //{
        //    axWindowsMediaPlayer1.URL = @"C:\Testing\LearningSystem\Encrypt.mp4";
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    axWindowsMediaPlayer1.URL = @"C:\Testing\LearningSystem\Decrypt.mp4";
        //}
    }
}

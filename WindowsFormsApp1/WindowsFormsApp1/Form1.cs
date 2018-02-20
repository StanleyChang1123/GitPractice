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
        public Form1()
        {
            InitializeComponent();
        }

        private void button_genEnDecryptFile(object sender, EventArgs e)
        {
            string pathSource = @"C:\Testing\LearningSystem\Original.mp4";
            byte[] originalByteArray = getOriginalFileStream(pathSource);

            string pathEncrypt = @"C:\Testing\LearningSystem\Encrypt.mp4";
            var encryptByteArray = writeEncryptFile(originalByteArray, pathEncrypt);

            string pathDecrypt = @"C:\Testing\LearningSystem\Decrypt.mp4";
            writeDecryptFile(encryptByteArray, originalByteArray.Length, pathDecrypt);
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
            int fileLength = source.Length;
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

        private void writeDecryptFile(byte[] encrypt, int originalFileLength, string pathDecrypt)
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

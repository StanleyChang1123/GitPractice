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
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialUIData();     
        }

        #region Initial UI Data
        private void InitialUIData()
        {
            var courses = initialCourseList();
            foreach (DropDownListCourse course in courses)
            {
                comboBoxForCourse.Items.Add(course);
            }
            comboBoxForCourse.SelectedIndex = 0;
        }
        private IList<DropDownListCourse> initialCourseList()
        {
            return getInitialCourse().Select(x => new DropDownListCourse() { DataName = x.Name, DataValue = x.Chapter }).ToList();
        }
        private IList<CourseModel> getInitialCourse()
        {
            return new CourseService().GetCourse(1);
        }
        #endregion Initial UI Data

        string FilePath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Environment.CurrentDirectory)) + "\\File";

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button_EncryptFile_Click(object sender, EventArgs e)
        {
            
            string sourceFilePath = string.Format("{0}\\{1}.mp4" ,  FilePath, comboBoxForCourse.Text);
            string encryptFilePath = string.Format("{0}\\{1}-encrypt.mp4", FilePath, comboBoxForCourse.Text);
            
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
            string encryptFilePath = string.Format(@"{0}\\{1}-encrypt.mp4", FilePath, comboBoxForCourse.Text);
            string decryptFilePath = string.Format(@"{0}\\{1}-decrypt.mp4", FilePath, comboBoxForCourse.Text);
           
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
        
    }
}

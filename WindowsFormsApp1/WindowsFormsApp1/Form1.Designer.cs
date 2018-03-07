namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tB_FileName = new System.Windows.Forms.TextBox();
            this.button_EncryptFile = new System.Windows.Forms.Button();
            this.button_DecryptAndPlay = new System.Windows.Forms.Button();
            this.comboBoxForCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 75);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(536, 302);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // tB_FileName
            // 
            this.tB_FileName.Location = new System.Drawing.Point(351, 38);
            this.tB_FileName.Name = "tB_FileName";
            this.tB_FileName.Size = new System.Drawing.Size(100, 22);
            this.tB_FileName.TabIndex = 4;
            // 
            // button_EncryptFile
            // 
            this.button_EncryptFile.Location = new System.Drawing.Point(270, 38);
            this.button_EncryptFile.Name = "button_EncryptFile";
            this.button_EncryptFile.Size = new System.Drawing.Size(75, 23);
            this.button_EncryptFile.TabIndex = 12;
            this.button_EncryptFile.Text = "Encrypt File";
            this.button_EncryptFile.UseVisualStyleBackColor = true;
            this.button_EncryptFile.Click += new System.EventHandler(this.button_EncryptFile_Click);
            // 
            // button_DecryptAndPlay
            // 
            this.button_DecryptAndPlay.Location = new System.Drawing.Point(12, 41);
            this.button_DecryptAndPlay.Name = "button_DecryptAndPlay";
            this.button_DecryptAndPlay.Size = new System.Drawing.Size(111, 23);
            this.button_DecryptAndPlay.TabIndex = 16;
            this.button_DecryptAndPlay.Text = "Decrypt and play";
            this.button_DecryptAndPlay.UseVisualStyleBackColor = true;
            this.button_DecryptAndPlay.Click += new System.EventHandler(this.button_DecryptAndPlay_Click);
            // 
            // comboBoxForCourse
            // 
            this.comboBoxForCourse.FormattingEnabled = true;
            this.comboBoxForCourse.Location = new System.Drawing.Point(129, 41);
            this.comboBoxForCourse.Name = "comboBoxForCourse";
            this.comboBoxForCourse.Size = new System.Drawing.Size(121, 20);
            this.comboBoxForCourse.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 389);
            this.Controls.Add(this.comboBoxForCourse);
            this.Controls.Add(this.button_DecryptAndPlay);
            this.Controls.Add(this.button_EncryptFile);
            this.Controls.Add(this.tB_FileName);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox tB_FileName;
        private System.Windows.Forms.Button button_EncryptFile;
        private System.Windows.Forms.Button button_DecryptAndPlay;
        private System.Windows.Forms.ComboBox comboBoxForCourse;


      
    }

   
    
}


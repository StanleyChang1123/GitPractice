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
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_playFile = new System.Windows.Forms.Button();
            this.textBox_playFile = new System.Windows.Forms.TextBox();
            this.tB_FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Source = new System.Windows.Forms.TextBox();
            this.button_EncryptSource = new System.Windows.Forms.Button();
            this.tB_Encrypt = new System.Windows.Forms.TextBox();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.tB_Decrypt = new System.Windows.Forms.TextBox();
            this.button_EncryptFile = new System.Windows.Forms.Button();
            this.button_DecryptFile = new System.Windows.Forms.Button();
            this.button_DecryptAndPlay = new System.Windows.Forms.Button();
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
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(764, 47);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.button_Encrypt.TabIndex = 15;
            // 
            // button_playFile
            // 
            this.button_playFile.Location = new System.Drawing.Point(764, 103);
            this.button_playFile.Name = "button_playFile";
            this.button_playFile.Size = new System.Drawing.Size(75, 23);
            this.button_playFile.TabIndex = 14;
            // 
            // textBox_playFile
            // 
            this.textBox_playFile.Location = new System.Drawing.Point(764, 132);
            this.textBox_playFile.Name = "textBox_playFile";
            this.textBox_playFile.Size = new System.Drawing.Size(100, 22);
            this.textBox_playFile.TabIndex = 3;
            // 
            // tB_FileName
            // 
            this.tB_FileName.Location = new System.Drawing.Point(145, 41);
            this.tB_FileName.Name = "tB_FileName";
            this.tB_FileName.Size = new System.Drawing.Size(100, 22);
            this.tB_FileName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source";
            // 
            // tB_Source
            // 
            this.tB_Source.Location = new System.Drawing.Point(616, 87);
            this.tB_Source.Name = "tB_Source";
            this.tB_Source.Size = new System.Drawing.Size(100, 22);
            this.tB_Source.TabIndex = 7;
            this.tB_Source.Text = "Hello";
            // 
            // button_EncryptSource
            // 
            this.button_EncryptSource.Location = new System.Drawing.Point(554, 122);
            this.button_EncryptSource.Name = "button_EncryptSource";
            this.button_EncryptSource.Size = new System.Drawing.Size(75, 23);
            this.button_EncryptSource.TabIndex = 8;
            this.button_EncryptSource.Text = "Encrypt";
            this.button_EncryptSource.UseVisualStyleBackColor = true;
            this.button_EncryptSource.Click += new System.EventHandler(this.button_EncryptSource_Click);
            // 
            // tB_Encrypt
            // 
            this.tB_Encrypt.Location = new System.Drawing.Point(635, 122);
            this.tB_Encrypt.Name = "tB_Encrypt";
            this.tB_Encrypt.Size = new System.Drawing.Size(97, 22);
            this.tB_Encrypt.TabIndex = 9;
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.Location = new System.Drawing.Point(554, 153);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.button_Decrypt.TabIndex = 10;
            this.button_Decrypt.Text = "Decrypt";
            this.button_Decrypt.UseVisualStyleBackColor = true;
            this.button_Decrypt.Click += new System.EventHandler(this.button_Decrypt_Click);
            // 
            // tB_Decrypt
            // 
            this.tB_Decrypt.Location = new System.Drawing.Point(635, 153);
            this.tB_Decrypt.Name = "tB_Decrypt";
            this.tB_Decrypt.Size = new System.Drawing.Size(100, 22);
            this.tB_Decrypt.TabIndex = 11;
            // 
            // button_EncryptFile
            // 
            this.button_EncryptFile.Location = new System.Drawing.Point(12, 12);
            this.button_EncryptFile.Name = "button_EncryptFile";
            this.button_EncryptFile.Size = new System.Drawing.Size(75, 23);
            this.button_EncryptFile.TabIndex = 12;
            this.button_EncryptFile.Text = "Encrypt File";
            this.button_EncryptFile.UseVisualStyleBackColor = true;
            this.button_EncryptFile.Click += new System.EventHandler(this.button_EncryptFile_Click);
            // 
            // button_DecryptFile
            // 
            this.button_DecryptFile.Location = new System.Drawing.Point(554, 253);
            this.button_DecryptFile.Name = "button_DecryptFile";
            this.button_DecryptFile.Size = new System.Drawing.Size(75, 23);
            this.button_DecryptFile.TabIndex = 13;
            this.button_DecryptFile.Text = "Decrypt File";
            this.button_DecryptFile.UseVisualStyleBackColor = true;
            this.button_DecryptFile.Click += new System.EventHandler(this.button_DecryptFile_Click);
            // 
            // button_DecryptAndPlay
            // 
            this.button_DecryptAndPlay.Location = new System.Drawing.Point(12, 41);
            this.button_DecryptAndPlay.Name = "button_DecryptAndPlay";
            this.button_DecryptAndPlay.Size = new System.Drawing.Size(111, 23);
            this.button_DecryptAndPlay.TabIndex = 16;
            this.button_DecryptAndPlay.Text = "Descript and play";
            this.button_DecryptAndPlay.UseVisualStyleBackColor = true;
            this.button_DecryptAndPlay.Click += new System.EventHandler(this.button_DecryptAndPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 389);
            this.Controls.Add(this.button_DecryptAndPlay);
            this.Controls.Add(this.button_DecryptFile);
            this.Controls.Add(this.button_EncryptFile);
            this.Controls.Add(this.tB_Decrypt);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.tB_Encrypt);
            this.Controls.Add(this.button_EncryptSource);
            this.Controls.Add(this.tB_Source);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_FileName);
            this.Controls.Add(this.textBox_playFile);
            this.Controls.Add(this.button_playFile);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_playFile;
        private System.Windows.Forms.TextBox textBox_playFile;
        private System.Windows.Forms.TextBox tB_FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Source;
        private System.Windows.Forms.Button button_EncryptSource;
        private System.Windows.Forms.TextBox tB_Encrypt;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.TextBox tB_Decrypt;
        private System.Windows.Forms.Button button_EncryptFile;
        private System.Windows.Forms.Button button_DecryptFile;
        private System.Windows.Forms.Button button_DecryptAndPlay;
    }
}


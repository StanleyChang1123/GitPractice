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
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.textBox_EncryptFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 75);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(752, 302);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(290, 42);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(170, 23);
            this.button_Encrypt.TabIndex = 1;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button_genEncryptFile);
            // 
            // button_playFile
            // 
            this.button_playFile.Location = new System.Drawing.Point(12, 44);
            this.button_playFile.Name = "button_playFile";
            this.button_playFile.Size = new System.Drawing.Size(154, 23);
            this.button_playFile.TabIndex = 2;
            this.button_playFile.Text = "Play Encrypt File not work";
            this.button_playFile.UseVisualStyleBackColor = true;
            this.button_playFile.Click += new System.EventHandler(this.button_PlayFile);
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(172, 43);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(100, 22);
            this.textBox_FileName.TabIndex = 3;
            // 
            // textBox_EncryptFile
            // 
            this.textBox_EncryptFile.Location = new System.Drawing.Point(466, 42);
            this.textBox_EncryptFile.Name = "textBox_EncryptFile";
            this.textBox_EncryptFile.Size = new System.Drawing.Size(100, 22);
            this.textBox_EncryptFile.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 389);
            this.Controls.Add(this.textBox_EncryptFile);
            this.Controls.Add(this.textBox_FileName);
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
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.TextBox textBox_EncryptFile;
    }
}


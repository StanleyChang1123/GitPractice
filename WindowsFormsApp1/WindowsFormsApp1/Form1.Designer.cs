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
            this.label1Example = new System.Windows.Forms.Label();
            this.tb_TextSourceExample = new System.Windows.Forms.TextBox();
            this.button_EncryptTextExample = new System.Windows.Forms.Button();
            this.tB_EncryptExample = new System.Windows.Forms.TextBox();
            this.button_DecryptTextExample = new System.Windows.Forms.Button();
            this.tB_DecryptExample = new System.Windows.Forms.TextBox();
            this.button_EncryptFile = new System.Windows.Forms.Button();
            this.button_DecryptFileExample = new System.Windows.Forms.Button();
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
            this.tB_FileName.Location = new System.Drawing.Point(646, 75);
            this.tB_FileName.Name = "tB_FileName";
            this.tB_FileName.Size = new System.Drawing.Size(100, 22);
            this.tB_FileName.TabIndex = 4;
            // 
            // label1Example
            // 
            this.label1Example.AutoSize = true;
            this.label1Example.Location = new System.Drawing.Point(603, 213);
            this.label1Example.Name = "label1Example";
            this.label1Example.Size = new System.Drawing.Size(37, 12);
            this.label1Example.TabIndex = 6;
            this.label1Example.Text = "Source";
            // 
            // tb_TextSourceExample
            // 
            this.tb_TextSourceExample.Location = new System.Drawing.Point(646, 210);
            this.tb_TextSourceExample.Name = "tb_TextSourceExample";
            this.tb_TextSourceExample.Size = new System.Drawing.Size(100, 22);
            this.tb_TextSourceExample.TabIndex = 7;
            this.tb_TextSourceExample.Text = "Hello";
            // 
            // button_EncryptTextExample
            // 
            this.button_EncryptTextExample.Location = new System.Drawing.Point(584, 245);
            this.button_EncryptTextExample.Name = "button_EncryptTextExample";
            this.button_EncryptTextExample.Size = new System.Drawing.Size(75, 23);
            this.button_EncryptTextExample.TabIndex = 8;
            this.button_EncryptTextExample.Text = "Encrypt";
            this.button_EncryptTextExample.UseVisualStyleBackColor = true;
            this.button_EncryptTextExample.Click += new System.EventHandler(this.button_EncryptTextExample_Click);
            // 
            // tB_EncryptExample
            // 
            this.tB_EncryptExample.Location = new System.Drawing.Point(665, 245);
            this.tB_EncryptExample.Name = "tB_EncryptExample";
            this.tB_EncryptExample.Size = new System.Drawing.Size(97, 22);
            this.tB_EncryptExample.TabIndex = 9;
            // 
            // button_DecryptTextExample
            // 
            this.button_DecryptTextExample.Location = new System.Drawing.Point(584, 276);
            this.button_DecryptTextExample.Name = "button_DecryptTextExample";
            this.button_DecryptTextExample.Size = new System.Drawing.Size(75, 23);
            this.button_DecryptTextExample.TabIndex = 10;
            this.button_DecryptTextExample.Text = "Decrypt";
            this.button_DecryptTextExample.UseVisualStyleBackColor = true;
            this.button_DecryptTextExample.Click += new System.EventHandler(this.button_DecryptTextExample_Click);
            // 
            // tB_DecryptExample
            // 
            this.tB_DecryptExample.Location = new System.Drawing.Point(665, 276);
            this.tB_DecryptExample.Name = "tB_DecryptExample";
            this.tB_DecryptExample.Size = new System.Drawing.Size(100, 22);
            this.tB_DecryptExample.TabIndex = 11;
            // 
            // button_EncryptFile
            // 
            this.button_EncryptFile.Location = new System.Drawing.Point(565, 75);
            this.button_EncryptFile.Name = "button_EncryptFile";
            this.button_EncryptFile.Size = new System.Drawing.Size(75, 23);
            this.button_EncryptFile.TabIndex = 12;
            this.button_EncryptFile.Text = "Encrypt File";
            this.button_EncryptFile.UseVisualStyleBackColor = true;
            this.button_EncryptFile.Click += new System.EventHandler(this.button_EncryptFile_Click);
            // 
            // button_DecryptFileExample
            // 
            this.button_DecryptFileExample.Location = new System.Drawing.Point(584, 305);
            this.button_DecryptFileExample.Name = "button_DecryptFileExample";
            this.button_DecryptFileExample.Size = new System.Drawing.Size(75, 23);
            this.button_DecryptFileExample.TabIndex = 13;
            this.button_DecryptFileExample.Text = "Decrypt File";
            this.button_DecryptFileExample.UseVisualStyleBackColor = true;
            this.button_DecryptFileExample.Click += new System.EventHandler(this.button_DecryptFileExample_Click);
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
            this.Controls.Add(this.button_DecryptFileExample);
            this.Controls.Add(this.button_EncryptFile);
            this.Controls.Add(this.tB_DecryptExample);
            this.Controls.Add(this.button_DecryptTextExample);
            this.Controls.Add(this.tB_EncryptExample);
            this.Controls.Add(this.button_EncryptTextExample);
            this.Controls.Add(this.tb_TextSourceExample);
            this.Controls.Add(this.label1Example);
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
        private System.Windows.Forms.Label label1Example;
        private System.Windows.Forms.TextBox tb_TextSourceExample;
        private System.Windows.Forms.Button button_EncryptTextExample;
        private System.Windows.Forms.TextBox tB_EncryptExample;
        private System.Windows.Forms.Button button_DecryptTextExample;
        private System.Windows.Forms.TextBox tB_DecryptExample;
        private System.Windows.Forms.Button button_EncryptFile;
        private System.Windows.Forms.Button button_DecryptFileExample;
        private System.Windows.Forms.Button button_DecryptAndPlay;
        private System.Windows.Forms.ComboBox comboBoxForCourse;
    }
}


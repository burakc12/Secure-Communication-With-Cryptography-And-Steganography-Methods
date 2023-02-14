
namespace güvenli_haberleşme
{
    partial class RsaEncode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCrytoMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQvalue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPValue = new System.Windows.Forms.TextBox();
            this.checkBoxGenerateOwnKey = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDocOpen = new System.Windows.Forms.Button();
            this.textBoxDocPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Metin Giriniz:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(106, 12);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxMessage.TabIndex = 12;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(629, 373);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(92, 32);
            this.buttonEncode.TabIndex = 11;
            this.buttonEncode.Text = "Metni Şifrele";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(116, 22);
            this.textBoxPublicKey.Multiline = true;
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.ReadOnly = true;
            this.textBoxPublicKey.Size = new System.Drawing.Size(125, 23);
            this.textBoxPublicKey.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Açık Şifreniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gizli Şifreniz:";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(116, 62);
            this.textBoxPrivateKey.Multiline = true;
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.ReadOnly = true;
            this.textBoxPrivateKey.Size = new System.Drawing.Size(125, 23);
            this.textBoxPrivateKey.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Şifreli Metniniz :";
            // 
            // textBoxCrytoMessage
            // 
            this.textBoxCrytoMessage.Location = new System.Drawing.Point(106, 221);
            this.textBoxCrytoMessage.Multiline = true;
            this.textBoxCrytoMessage.Name = "textBoxCrytoMessage";
            this.textBoxCrytoMessage.ReadOnly = true;
            this.textBoxCrytoMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxCrytoMessage.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "n değeri:";
            // 
            // textBoxNValue
            // 
            this.textBoxNValue.Location = new System.Drawing.Point(116, 96);
            this.textBoxNValue.Multiline = true;
            this.textBoxNValue.Name = "textBoxNValue";
            this.textBoxNValue.ReadOnly = true;
            this.textBoxNValue.Size = new System.Drawing.Size(125, 23);
            this.textBoxNValue.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Q Değeri:";
            // 
            // textBoxQvalue
            // 
            this.textBoxQvalue.Location = new System.Drawing.Point(101, 91);
            this.textBoxQvalue.Multiline = true;
            this.textBoxQvalue.Name = "textBoxQvalue";
            this.textBoxQvalue.ReadOnly = true;
            this.textBoxQvalue.Size = new System.Drawing.Size(125, 23);
            this.textBoxQvalue.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "P değeri:";
            // 
            // textBoxPValue
            // 
            this.textBoxPValue.Location = new System.Drawing.Point(99, 51);
            this.textBoxPValue.Multiline = true;
            this.textBoxPValue.Name = "textBoxPValue";
            this.textBoxPValue.ReadOnly = true;
            this.textBoxPValue.Size = new System.Drawing.Size(125, 23);
            this.textBoxPValue.TabIndex = 24;
            // 
            // checkBoxGenerateOwnKey
            // 
            this.checkBoxGenerateOwnKey.AutoSize = true;
            this.checkBoxGenerateOwnKey.Location = new System.Drawing.Point(43, 22);
            this.checkBoxGenerateOwnKey.Name = "checkBoxGenerateOwnKey";
            this.checkBoxGenerateOwnKey.Size = new System.Drawing.Size(232, 19);
            this.checkBoxGenerateOwnKey.TabIndex = 28;
            this.checkBoxGenerateOwnKey.Text = "Kendi Anahtarımı Belirlemek İstiyorum.";
            this.checkBoxGenerateOwnKey.UseVisualStyleBackColor = true;
            this.checkBoxGenerateOwnKey.CheckedChanged += new System.EventHandler(this.checkBoxGenerateOwnKey_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxGenerateOwnKey);
            this.groupBox1.Controls.Add(this.textBoxPValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxQvalue);
            this.groupBox1.Location = new System.Drawing.Point(513, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kendi Anahtarını Belirlemek İster misin ?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxPublicKey);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxPrivateKey);
            this.groupBox2.Controls.Add(this.textBoxNValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(513, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 123);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anahtar Değerleri";
            // 
            // buttonDocOpen
            // 
            this.buttonDocOpen.Location = new System.Drawing.Point(6, 22);
            this.buttonDocOpen.Name = "buttonDocOpen";
            this.buttonDocOpen.Size = new System.Drawing.Size(86, 47);
            this.buttonDocOpen.TabIndex = 22;
            this.buttonDocOpen.Text = "txt Dosyası Aç";
            this.buttonDocOpen.UseVisualStyleBackColor = true;
            this.buttonDocOpen.Click += new System.EventHandler(this.buttonDocOpen_Click);
            // 
            // textBoxDocPath
            // 
            this.textBoxDocPath.Location = new System.Drawing.Point(97, 29);
            this.textBoxDocPath.Name = "textBoxDocPath";
            this.textBoxDocPath.Size = new System.Drawing.Size(217, 23);
            this.textBoxDocPath.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDocOpen);
            this.groupBox3.Controls.Add(this.textBoxDocPath);
            this.groupBox3.Location = new System.Drawing.Point(512, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 81);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "txt Dosyasından Metin Girişi";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 473);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(880, 22);
            this.statusStrip.TabIndex = 27;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(178, 17);
            this.toolStripStatusLabel1.Text = "İşlem Yapılıyor Lütfen Bekleyiniz:";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(650, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // RsaEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 495);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCrytoMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RsaEncode";
            this.Text = "RsaEncode";
            this.Load += new System.EventHandler(this.RsaEncode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCrytoMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQvalue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPValue;
        private System.Windows.Forms.CheckBox checkBoxGenerateOwnKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDocOpen;
        private System.Windows.Forms.TextBox textBoxDocPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}
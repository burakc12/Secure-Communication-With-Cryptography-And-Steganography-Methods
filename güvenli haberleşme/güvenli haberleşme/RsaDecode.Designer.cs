
namespace güvenli_haberleşme
{
    partial class RsaDecode
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCrytoMessage = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDocOpen = new System.Windows.Forms.Button();
            this.textBoxDocPath = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Gizli Anahtarınız:";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(103, 22);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(125, 23);
            this.textBoxPrivateKey.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Metniniz :";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(135, 222);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxMessage.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Şifreli Metininizi Giriniz:";
            // 
            // textBoxCrytoMessage
            // 
            this.textBoxCrytoMessage.Location = new System.Drawing.Point(134, 12);
            this.textBoxCrytoMessage.Multiline = true;
            this.textBoxCrytoMessage.Name = "textBoxCrytoMessage";
            this.textBoxCrytoMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxCrytoMessage.TabIndex = 30;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(640, 205);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(110, 32);
            this.buttonDecode.TabIndex = 29;
            this.buttonDecode.Text = "Metini Deşifre Et";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "n değeri:";
            // 
            // textBoxNValue
            // 
            this.textBoxNValue.Location = new System.Drawing.Point(104, 57);
            this.textBoxNValue.Multiline = true;
            this.textBoxNValue.Name = "textBoxNValue";
            this.textBoxNValue.Size = new System.Drawing.Size(125, 23);
            this.textBoxNValue.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPrivateKey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNValue);
            this.groupBox1.Location = new System.Drawing.Point(543, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 100);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anahtar Değeri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDocOpen);
            this.groupBox3.Controls.Add(this.textBoxDocPath);
            this.groupBox3.Location = new System.Drawing.Point(543, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 81);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "txt Dosyasından Metin Girişi";
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 473);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(880, 22);
            this.statusStrip.TabIndex = 41;
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
            // RsaDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 495);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCrytoMessage);
            this.Controls.Add(this.buttonDecode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RsaDecode";
            this.Text = "RsaDecode";
            this.Load += new System.EventHandler(this.RsaDecode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCrytoMessage;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDocOpen;
        private System.Windows.Forms.TextBox textBoxDocPath;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}
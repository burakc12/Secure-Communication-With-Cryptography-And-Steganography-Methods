
namespace güvenli_haberleşme
{
    partial class AesDecode
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCrytoMessage = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDocOpen = new System.Windows.Forms.Button();
            this.textBoxDocPath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(59, 22);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(255, 23);
            this.textBoxKey.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Şifreniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Metniniz :";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(128, 233);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxMessage.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Şifreli Metininizi Giriniz:";
            // 
            // textBoxCrytoMessage
            // 
            this.textBoxCrytoMessage.Location = new System.Drawing.Point(127, 23);
            this.textBoxCrytoMessage.Multiline = true;
            this.textBoxCrytoMessage.Name = "textBoxCrytoMessage";
            this.textBoxCrytoMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxCrytoMessage.TabIndex = 42;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(633, 174);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(110, 32);
            this.buttonDecode.TabIndex = 41;
            this.buttonDecode.Text = "Metini Deşifre Et";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDocOpen);
            this.groupBox3.Controls.Add(this.textBoxDocPath);
            this.groupBox3.Location = new System.Drawing.Point(536, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 81);
            this.groupBox3.TabIndex = 48;
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
            // 
            // textBoxDocPath
            // 
            this.textBoxDocPath.Location = new System.Drawing.Point(97, 29);
            this.textBoxDocPath.Name = "textBoxDocPath";
            this.textBoxDocPath.Size = new System.Drawing.Size(217, 23);
            this.textBoxDocPath.TabIndex = 23;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(536, 216);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(320, 16);
            this.progressBar1.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(536, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 53);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anahtar Değeri";
            // 
            // AesDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCrytoMessage);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AesDecode";
            this.Text = "AesDecode";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCrytoMessage;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDocOpen;
        private System.Windows.Forms.TextBox textBoxDocPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
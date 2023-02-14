
namespace güvenli_haberleşme
{
    partial class AesEncode
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDocOpen = new System.Windows.Forms.Button();
            this.textBoxDocPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCrytoMessage = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDocOpen);
            this.groupBox3.Controls.Add(this.textBoxDocPath);
            this.groupBox3.Location = new System.Drawing.Point(510, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 81);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "txt Dosyasından Metin Girişi";
            // 
            // buttonDocOpen
            // 
            this.buttonDocOpen.Location = new System.Drawing.Point(19, 22);
            this.buttonDocOpen.Name = "buttonDocOpen";
            this.buttonDocOpen.Size = new System.Drawing.Size(86, 47);
            this.buttonDocOpen.TabIndex = 22;
            this.buttonDocOpen.Text = "txt Dosyası Aç";
            this.buttonDocOpen.UseVisualStyleBackColor = true;
            // 
            // textBoxDocPath
            // 
            this.textBoxDocPath.Location = new System.Drawing.Point(110, 29);
            this.textBoxDocPath.Name = "textBoxDocPath";
            this.textBoxDocPath.Size = new System.Drawing.Size(217, 23);
            this.textBoxDocPath.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxKey);
            this.groupBox2.Location = new System.Drawing.Point(516, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 55);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anahtar Değerleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şifreniz:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(56, 22);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(253, 23);
            this.textBoxKey.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Şifreli Metniniz :";
            // 
            // textBoxCrytoMessage
            // 
            this.textBoxCrytoMessage.Location = new System.Drawing.Point(104, 222);
            this.textBoxCrytoMessage.Multiline = true;
            this.textBoxCrytoMessage.Name = "textBoxCrytoMessage";
            this.textBoxCrytoMessage.ReadOnly = true;
            this.textBoxCrytoMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxCrytoMessage.TabIndex = 30;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(104, 13);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(400, 200);
            this.textBoxMessage.TabIndex = 28;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(619, 173);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(92, 32);
            this.buttonEncode.TabIndex = 27;
            this.buttonEncode.Text = "Metni Şifrele";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Metin Giriniz:";
            // 
            // AesEncode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCrytoMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AesEncode";
            this.Text = "AesEncode";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDocOpen;
        private System.Windows.Forms.TextBox textBoxDocPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCrytoMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Label label1;
    }
}
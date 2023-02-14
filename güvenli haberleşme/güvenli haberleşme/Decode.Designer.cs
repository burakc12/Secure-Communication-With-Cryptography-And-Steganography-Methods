
namespace güvenli_haberleşme
{
    partial class Decode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decode));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBluePixel = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenPixel = new System.Windows.Forms.CheckBox();
            this.checkBoxRedPixel = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Metininiz:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(374, 168);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(464, 210);
            this.textBoxMessage.TabIndex = 15;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(533, 130);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(143, 32);
            this.buttonDecode.TabIndex = 14;
            this.buttonDecode.Text = "Metni Resimden Çıkart";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(309, 30);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 13;
            this.buttonOpenFile.Text = "Resim Aç";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(392, 31);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(446, 23);
            this.textBoxFilePath.TabIndex = 12;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Location = new System.Drawing.Point(7, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(296, 275);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxBluePixel);
            this.groupBox1.Controls.Add(this.checkBoxGreenPixel);
            this.groupBox1.Controls.Add(this.checkBoxRedPixel);
            this.groupBox1.Location = new System.Drawing.Point(454, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 55);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hangi Renk Kanalına Metin Gömme İşlemi Yapıldı ?";
            // 
            // checkBoxBluePixel
            // 
            this.checkBoxBluePixel.AutoSize = true;
            this.checkBoxBluePixel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxBluePixel.Location = new System.Drawing.Point(222, 22);
            this.checkBoxBluePixel.Name = "checkBoxBluePixel";
            this.checkBoxBluePixel.Size = new System.Drawing.Size(55, 19);
            this.checkBoxBluePixel.TabIndex = 13;
            this.checkBoxBluePixel.Text = "Mavi ";
            this.checkBoxBluePixel.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreenPixel
            // 
            this.checkBoxGreenPixel.AutoSize = true;
            this.checkBoxGreenPixel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxGreenPixel.Location = new System.Drawing.Point(125, 22);
            this.checkBoxGreenPixel.Name = "checkBoxGreenPixel";
            this.checkBoxGreenPixel.Size = new System.Drawing.Size(52, 19);
            this.checkBoxGreenPixel.TabIndex = 13;
            this.checkBoxGreenPixel.Text = "Yeşil ";
            this.checkBoxGreenPixel.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedPixel
            // 
            this.checkBoxRedPixel.AutoSize = true;
            this.checkBoxRedPixel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxRedPixel.Location = new System.Drawing.Point(6, 22);
            this.checkBoxRedPixel.Name = "checkBoxRedPixel";
            this.checkBoxRedPixel.Size = new System.Drawing.Size(62, 19);
            this.checkBoxRedPixel.TabIndex = 12;
            this.checkBoxRedPixel.Text = "Kırmızı";
            this.checkBoxRedPixel.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 473);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(850, 22);
            this.statusStrip.TabIndex = 18;
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
            // Decode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 495);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Decode";
            this.Text = "Decode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxBluePixel;
        private System.Windows.Forms.CheckBox checkBoxGreenPixel;
        private System.Windows.Forms.CheckBox checkBoxRedPixel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}
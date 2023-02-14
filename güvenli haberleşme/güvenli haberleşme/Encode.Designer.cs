
namespace güvenli_haberleşme
{
    partial class Encode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encode));
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBluePixel = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenPixel = new System.Windows.Forms.CheckBox();
            this.checkBoxRedPixel = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDocOpen = new System.Windows.Forms.Button();
            this.textBoxDocPath = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEncode
            // 
            resources.ApplyResources(this.buttonEncode, "buttonEncode");
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonOpenFile
            // 
            resources.ApplyResources(this.buttonOpenFile, "buttonOpenFile");
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxFilePath
            // 
            resources.ApplyResources(this.textBoxFilePath, "textBoxFilePath");
            this.textBoxFilePath.Name = "textBoxFilePath";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "Resim Dosyası";
            // 
            // textBoxMessage
            // 
            resources.ApplyResources(this.textBoxMessage, "textBoxMessage");
            this.textBoxMessage.Name = "textBoxMessage";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxBluePixel);
            this.groupBox1.Controls.Add(this.checkBoxGreenPixel);
            this.groupBox1.Controls.Add(this.checkBoxRedPixel);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBoxBluePixel
            // 
            resources.ApplyResources(this.checkBoxBluePixel, "checkBoxBluePixel");
            this.checkBoxBluePixel.Name = "checkBoxBluePixel";
            this.checkBoxBluePixel.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreenPixel
            // 
            resources.ApplyResources(this.checkBoxGreenPixel, "checkBoxGreenPixel");
            this.checkBoxGreenPixel.Name = "checkBoxGreenPixel";
            this.checkBoxGreenPixel.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedPixel
            // 
            resources.ApplyResources(this.checkBoxRedPixel, "checkBoxRedPixel");
            this.checkBoxRedPixel.Name = "checkBoxRedPixel";
            this.checkBoxRedPixel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDocOpen);
            this.groupBox3.Controls.Add(this.textBoxDocPath);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // buttonDocOpen
            // 
            resources.ApplyResources(this.buttonDocOpen, "buttonDocOpen");
            this.buttonDocOpen.Name = "buttonDocOpen";
            this.buttonDocOpen.UseVisualStyleBackColor = true;
            this.buttonDocOpen.Click += new System.EventHandler(this.buttonDocOpen_Click);
            // 
            // textBoxDocPath
            // 
            resources.ApplyResources(this.textBoxDocPath, "textBoxDocPath");
            this.textBoxDocPath.Name = "textBoxDocPath";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // Encode
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encode";
            this.Load += new System.EventHandler(this.Encode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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

        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxBluePixel;
        private System.Windows.Forms.CheckBox checkBoxGreenPixel;
        private System.Windows.Forms.CheckBox checkBoxRedPixel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDocOpen;
        private System.Windows.Forms.TextBox textBoxDocPath;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}
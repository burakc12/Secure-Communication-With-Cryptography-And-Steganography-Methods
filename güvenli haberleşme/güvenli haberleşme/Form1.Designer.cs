
namespace güvenli_haberleşme
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.steganografiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metniResmeGömmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimdenMetinÇıkarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metniŞifrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metniDeşifreEtmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinŞifrelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metniDeşifreEtmeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelShowForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steganografiToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.aESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // steganografiToolStripMenuItem
            // 
            this.steganografiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metniResmeGömmeToolStripMenuItem,
            this.resimdenMetinÇıkarmaToolStripMenuItem});
            this.steganografiToolStripMenuItem.Name = "steganografiToolStripMenuItem";
            this.steganografiToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.steganografiToolStripMenuItem.Text = "Steganografi";
            // 
            // metniResmeGömmeToolStripMenuItem
            // 
            this.metniResmeGömmeToolStripMenuItem.Name = "metniResmeGömmeToolStripMenuItem";
            this.metniResmeGömmeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.metniResmeGömmeToolStripMenuItem.Text = "Metni Resme Gömme";
            this.metniResmeGömmeToolStripMenuItem.Click += new System.EventHandler(this.metniResmeGömmeToolStripMenuItem_Click);
            // 
            // resimdenMetinÇıkarmaToolStripMenuItem
            // 
            this.resimdenMetinÇıkarmaToolStripMenuItem.Name = "resimdenMetinÇıkarmaToolStripMenuItem";
            this.resimdenMetinÇıkarmaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.resimdenMetinÇıkarmaToolStripMenuItem.Text = "Resimden Metin Çıkarma";
            this.resimdenMetinÇıkarmaToolStripMenuItem.Click += new System.EventHandler(this.resimdenMetinÇıkarmaToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metniŞifrelemeToolStripMenuItem,
            this.metniDeşifreEtmeToolStripMenuItem});
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.rSAToolStripMenuItem.Text = "RSA";
            // 
            // metniŞifrelemeToolStripMenuItem
            // 
            this.metniŞifrelemeToolStripMenuItem.Name = "metniŞifrelemeToolStripMenuItem";
            this.metniŞifrelemeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.metniŞifrelemeToolStripMenuItem.Text = "Metni Şifreleme";
            this.metniŞifrelemeToolStripMenuItem.Click += new System.EventHandler(this.metniŞifrelemeToolStripMenuItem_Click);
            // 
            // metniDeşifreEtmeToolStripMenuItem
            // 
            this.metniDeşifreEtmeToolStripMenuItem.Name = "metniDeşifreEtmeToolStripMenuItem";
            this.metniDeşifreEtmeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.metniDeşifreEtmeToolStripMenuItem.Text = "Metni Deşifre Etme";
            this.metniDeşifreEtmeToolStripMenuItem.Click += new System.EventHandler(this.metniDeşifreEtmeToolStripMenuItem_Click);
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metinŞifrelemeToolStripMenuItem,
            this.metniDeşifreEtmeToolStripMenuItem1});
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.aESToolStripMenuItem.Text = "AES";
            this.aESToolStripMenuItem.Visible = false;
            // 
            // metinŞifrelemeToolStripMenuItem
            // 
            this.metinŞifrelemeToolStripMenuItem.Name = "metinŞifrelemeToolStripMenuItem";
            this.metinŞifrelemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.metinŞifrelemeToolStripMenuItem.Text = "Metin Şifreleme";
            this.metinŞifrelemeToolStripMenuItem.Click += new System.EventHandler(this.metinŞifrelemeToolStripMenuItem_Click);
            // 
            // metniDeşifreEtmeToolStripMenuItem1
            // 
            this.metniDeşifreEtmeToolStripMenuItem1.Name = "metniDeşifreEtmeToolStripMenuItem1";
            this.metniDeşifreEtmeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.metniDeşifreEtmeToolStripMenuItem1.Text = "Metni Deşifre Etme";
            this.metniDeşifreEtmeToolStripMenuItem1.Click += new System.EventHandler(this.metniDeşifreEtmeToolStripMenuItem1_Click);
            // 
            // panelShowForm
            // 
            this.panelShowForm.AutoSize = true;
            this.panelShowForm.BackColor = System.Drawing.Color.Transparent;
            this.panelShowForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShowForm.BackgroundImage")));
            this.panelShowForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelShowForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowForm.Location = new System.Drawing.Point(0, 24);
            this.panelShowForm.Name = "panelShowForm";
            this.panelShowForm.Size = new System.Drawing.Size(882, 475);
            this.panelShowForm.TabIndex = 7;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(882, 499);
            this.Controls.Add(this.panelShowForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenli Haberleşme";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem steganografiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metniResmeGömmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resimdenMetinÇıkarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metniŞifrelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metniDeşifreEtmeToolStripMenuItem;
        private System.Windows.Forms.Panel panelShowForm;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metinŞifrelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metniDeşifreEtmeToolStripMenuItem1;
    }
}


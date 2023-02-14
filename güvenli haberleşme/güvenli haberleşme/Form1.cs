using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace güvenli_haberleşme
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void metniResmeGömmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowForm.Controls.Clear();
            Encode Encode = new Encode() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowForm.Controls.Add(Encode);
            Encode.Show();
        }
        private void resimdenMetinÇıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowForm.Controls.Clear();
            Decode Decode = new Decode() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowForm.Controls.Add(Decode);
            Decode.Show();
        }
        private void metniŞifrelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowForm.Controls.Clear();
            RsaEncode encode = new RsaEncode() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowForm.Controls.Add(encode);
            encode.Show();
        }
        private void metniDeşifreEtmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowForm.Controls.Clear();
            RsaDecode decode = new RsaDecode() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowForm.Controls.Add(decode);
            decode.Show();
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
        }
        private void metinŞifrelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelShowForm.Controls.Clear();
            AesEncode encode = new AesEncode() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowForm.Controls.Add(encode);
            encode.Show();
        }
        private void metniDeşifreEtmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelShowForm.Controls.Clear();
            AesDecode decode = new AesDecode() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelShowForm.Controls.Add(decode);
            decode.Show();
        }
    }
}
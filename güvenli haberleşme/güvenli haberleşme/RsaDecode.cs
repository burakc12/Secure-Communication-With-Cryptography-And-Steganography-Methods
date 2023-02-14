using System;
using System.IO;
using System.Windows.Forms;
namespace güvenli_haberleşme
{
    public partial class RsaDecode : Form
    {
        public RsaDecode()
        {
            InitializeComponent();
            textBoxCrytoMessage.ScrollBars = ScrollBars.Both;
            textBoxDocPath.ScrollBars = ScrollBars.Both;
            textBoxMessage.ScrollBars = ScrollBars.Both;
        }
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string letter = string.Empty,yazılacakdosyaadresi;
                DialogResult sonuc;
                statusStrip.Visible = true;
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar1.MarqueeAnimationSpeed = 50;
                if (!string.IsNullOrEmpty(textBoxCrytoMessage.Text) && !string.IsNullOrEmpty(textBoxNValue.Text) && !string.IsNullOrEmpty(textBoxPrivateKey.Text))
                {
                    RsaEncryption rsa = new RsaEncryption();
                    letter = rsa.Decrypt(textBoxCrytoMessage.Text, textBoxPrivateKey.Text, textBoxNValue.Text);
                    textBoxMessage.Text = letter;
                    statusStrip.Visible = false;
                    sonuc = MessageBox.Show("Metni txt dosyasına kaydetmek ister misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            yazılacakdosyaadresi = saveFile.FileName.ToString();
                            File.WriteAllText(yazılacakdosyaadresi, textBoxCrytoMessage.Text);
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxCrytoMessage.Text))
                    {
                        MessageBox.Show("Şifrelenecek Metin Yazılmamıştır Lütfen Tekrar Deneyin", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(textBoxNValue.Text))
                    {
                        MessageBox.Show("N Değeri Yazılmamıştır Lütfen Tekrar Deneyin", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(textBoxPrivateKey.Text))
                    {
                        MessageBox.Show("Gizli Anahtar Yazılmamıştır Lütfen Tekrar Deneyin", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Yazılan Değerlerden Birisi Yanlış Formatta Lütfen Tekrar Deneyin", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void RsaDecode_Load(object sender, EventArgs e)
        {
        }
        private void buttonDocOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDocPath.Text = openFileDialog.FileName.ToString();
                if (File.Exists(textBoxDocPath.Text))
                {
                    textBoxCrytoMessage.Text = File.ReadAllText(textBoxDocPath.Text);
                }
                else
                {
                    MessageBox.Show("Dosya Bulunamadı","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
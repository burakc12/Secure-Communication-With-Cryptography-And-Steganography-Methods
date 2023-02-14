using System;
using System.Windows.Forms;
using System.IO;
namespace güvenli_haberleşme
{
    public partial class RsaEncode : Form
    {
        bool GenerateOwnKey = false;
        public RsaEncode()
        {
            InitializeComponent();
            textBoxCrytoMessage.ScrollBars = ScrollBars.Both;
            textBoxDocPath.ScrollBars = ScrollBars.Both;
            textBoxMessage.ScrollBars = ScrollBars.Both;
        }
        private void RsaEncode_Load(object sender, EventArgs e)
        {
        }
        private void buttonEncode_Click(object sender, EventArgs e)
        {
            string cypher = string.Empty,yazılacakdosyaadresi="";
            DialogResult sonuc;
            statusStrip.Visible = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar1.MarqueeAnimationSpeed = 50;
            if (!string.IsNullOrEmpty(textBoxMessage.Text))
            {
                var keypair = RSAKeys.GenerateKeyPair(GenerateOwnKey,textBoxPValue.Text,textBoxQvalue.Text);
                if (keypair.n == 1 && keypair.PrivateKey == 1 && keypair.PublicKey == 1)
                {
                    MessageBox.Show("Seçilen Sayılar Asal Değil","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    string a = Convert.ToString(keypair.n);
                    textBoxNValue.Text = a;
                    RsaEncryption rsa = new RsaEncryption();
                    textBoxPrivateKey.Text = Convert.ToString(keypair.PrivateKey);
                    textBoxPublicKey.Text = Convert.ToString(keypair.PublicKey);
                    cypher = Convert.ToString(rsa.Encrypt(textBoxMessage.Text, keypair.PublicKey, keypair.n));
                    textBoxCrytoMessage.Text = cypher;
                    statusStrip.Visible = false;
                    sonuc = MessageBox.Show("Şifreli Metni txt Dosyasına Kaydetmek İster Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            }
            else
            {
                MessageBox.Show("Şifrelenecek Metin Yazılmamıştır Lütfen Tekrar Deneyin", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void checkBoxGenerateOwnKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGenerateOwnKey.Checked)
            {
                GenerateOwnKey = true;
                textBoxPValue.ReadOnly = false;
                textBoxQvalue.ReadOnly = false;
            }
            else if (!checkBoxGenerateOwnKey.Checked)
            {
                GenerateOwnKey = false;
                textBoxPValue.ReadOnly = true;
                textBoxQvalue.ReadOnly = true;
            }
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
                    textBoxMessage.Text = File.ReadAllText(textBoxDocPath.Text);
                }
                else
                {
                    MessageBox.Show("Dosya Bulunamadı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
    }
}
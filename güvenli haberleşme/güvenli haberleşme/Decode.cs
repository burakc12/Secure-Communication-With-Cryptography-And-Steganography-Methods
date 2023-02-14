using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace güvenli_haberleşme
{
    public partial class Decode : Form
    {
        public Decode()
        {
            InitializeComponent();
            textBoxMessage.ScrollBars = ScrollBars.Both;
        }
        private void buttonDecode_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar1.MarqueeAnimationSpeed = 50;
            try
            {
                Bitmap img = new Bitmap(textBoxFilePath.Text);
                string message = "",yazılacakdosyaadresi;
                int l = 6,valuebyte = 0;
                bool end = false;
                DialogResult sonuc;
                if (!checkBoxRedPixel.Checked && !checkBoxGreenPixel.Checked && !checkBoxBluePixel.Checked)
                {
                    MessageBox.Show("Piksel Seçimi Yapılmamıştır Lütfen Tekrar Deneyiniz", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            if (end == false)
                            {
                                Color pixel = img.GetPixel(i, j);
                                if (checkBoxRedPixel.Checked)
                                {
                                    if (end == false)
                                    {
                                        if (l < 7)
                                        {
                                            int R = pixel.R;
                                            int value = R % 2;
                                            valuebyte = valuebyte + (int)(value * Math.Pow(2, l));
                                            l--;
                                        }
                                        if (l < 0)
                                        {
                                            l = 6;
                                            byte[] bytesConvert = new byte[1];
                                            bytesConvert[0] = Convert.ToByte(valuebyte);
                                            string letter = System.Text.Encoding.ASCII.GetString(bytesConvert);
                                            if (letter == "\n")
                                            {
                                                end = true;
                                            }
                                            else
                                            {
                                                message = message + letter;
                                                valuebyte = 0;
                                            }
                                        }
                                    }
                                }
                                if (checkBoxGreenPixel.Checked)
                                {
                                    if (end == false)
                                    {
                                        if (l < 7)
                                        {
                                            int G = pixel.G;
                                            int value = G % 2;
                                            valuebyte = valuebyte + (int)(value * Math.Pow(2, l));
                                            l--;
                                        }
                                        if (l < 0)
                                        {
                                            l = 6;
                                            byte[] bytesConvert = new byte[1];
                                            bytesConvert[0] = Convert.ToByte(valuebyte);
                                            string letter = System.Text.Encoding.ASCII.GetString(bytesConvert);
                                            if (letter == "\n")
                                            {
                                                end = true;
                                            }
                                            else
                                            {
                                                message = message + letter;
                                                valuebyte = 0;
                                            }
                                        }
                                    }
                                }
                                if (checkBoxBluePixel.Checked)
                                {
                                    if (end == false)
                                    {
                                        if (l < 7)
                                        {
                                            int B = pixel.B;
                                            int value = B % 2;
                                            valuebyte = valuebyte + (int)(value * Math.Pow(2, l));
                                            l--;
                                        }
                                        if (l < 0)
                                        {
                                            l = 6;
                                            byte[] bytesConvert = new byte[1];
                                            bytesConvert[0] = Convert.ToByte(valuebyte);
                                            string letter = System.Text.Encoding.ASCII.GetString(bytesConvert);
                                            if (letter == "\n")
                                            {
                                                end = true;
                                            }
                                            else
                                            {
                                                message = message + letter;
                                                valuebyte = 0;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    textBoxMessage.Text = message;
                    statusStrip.Visible = false;
                    sonuc = MessageBox.Show("Metni txt dosyasına kaydetmek ister misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            yazılacakdosyaadresi = saveFile.FileName.ToString();
                            File.WriteAllText(yazılacakdosyaadresi, textBoxMessage.Text);
                        }
                    }
                }
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Dosyaya Ulaşılamamıştır Lütfen Tekrar Deneyiniz", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png,*.jpg) | *.png; *.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.BackgroundImage = null;
                textBoxFilePath.Text = openFileDialog.FileName.ToString();
                pictureBox.ImageLocation = textBoxFilePath.Text;
            }
        }
    }
}
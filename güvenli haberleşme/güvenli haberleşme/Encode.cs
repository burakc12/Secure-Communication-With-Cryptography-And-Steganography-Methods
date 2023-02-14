using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace güvenli_haberleşme
{
    public partial class Encode : Form
    {
        public Encode()
        {
            InitializeComponent();
            textBoxDocPath.ScrollBars = ScrollBars.Both;
            textBoxFilePath.ScrollBars = ScrollBars.Both;
            textBoxMessage.ScrollBars = ScrollBars.Both;
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
        private void buttonEncode_Click(object sender, EventArgs e)
        {
            bool finishValubyte = true;
            int l = 0, value = 0;
            string valuebyte = "", text;
            char letter = 'a';
            int k = 0, m = 0, n = 0;
            Color a;
            statusStrip.Visible = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar1.MarqueeAnimationSpeed = 50;
            try
            {
                Bitmap img = new Bitmap(textBoxFilePath.Text);
                Bitmap yeniimg = new Bitmap(img.Width, img.Height);
                if (string.IsNullOrEmpty(textBoxMessage!.Text))
                {
                    MessageBox.Show("Şifrelenecek Metin Yazılmamıştır Lütfen Tekrar Deneyin", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    text = textBoxMessage.Text;
                    text = text + "\n";
                    if ((img.Width * img.Height) < text.Length * 7)
                    {
                        MessageBox.Show("Resim Metni Gömülmeye Uygun Boyutta Değil Lütfen Tekrar Deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!checkBoxRedPixel.Checked && !checkBoxGreenPixel.Checked && !checkBoxBluePixel.Checked)
                        {
                            MessageBox.Show("Piksel Seçimi Yapılmamıştır Lütfen Tekrar Deneyiniz", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                        else
                        {
                            for (int i = 0; i < img.Width; i++)
                            {
                                for (int j = 0; j < img.Height; j++)
                                {
                                    Color pixel = img.GetPixel(i, j);
                                    int R = pixel.R;
                                    int G = pixel.G;
                                    int B = pixel.B;
                                    if (k < text.Length * 7)
                                    {
                                        if (checkBoxRedPixel.Checked)
                                        {
                                            if (k < text.Length * 7)
                                            {
                                                if (l >= valuebyte.Length)
                                                {
                                                    finishValubyte = true;
                                                }
                                                if (finishValubyte == true)
                                                {
                                                    letter = Convert.ToChar(text.Substring(m, 1));
                                                    value = Convert.ToInt32(letter);
                                                    valuebyte = Convert.ToString(value, 2);
                                                    if (valuebyte.Length != 7)
                                                    {
                                                        for (n = valuebyte.Length; n < 7; n++)
                                                        {
                                                            valuebyte = "0" + valuebyte;
                                                        }
                                                    }
                                                    finishValubyte = false;
                                                    l = 0;
                                                    m++;
                                                }
                                                int intletter = Convert.ToInt32(valuebyte.Substring(l, 1));
                                                if (R % 2 == 0 && intletter == 1)
                                                {
                                                    R = R + 1;
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                                else if (R % 2 == 1 && intletter == 0)
                                                {
                                                    R = R - 1;
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                                else if ((R % 2 == 0 && intletter == 0) || (R % 2 == 1 && intletter == 1))
                                                {
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                            }
                                        }
                                        if (checkBoxGreenPixel.Checked)
                                        {
                                            if (k < text.Length * 7)
                                            {
                                                if (l >= valuebyte.Length)
                                                {
                                                    finishValubyte = true;
                                                }
                                                if (finishValubyte == true)
                                                {
                                                    letter = Convert.ToChar(text.Substring(m, 1));
                                                    value = Convert.ToInt32(letter);
                                                    valuebyte = Convert.ToString(value, 2);
                                                    if (valuebyte.Length != 7)
                                                    {
                                                        for (n = valuebyte.Length; n < 7; n++)
                                                        {
                                                            valuebyte = "0" + valuebyte;
                                                        }
                                                    }
                                                    finishValubyte = false;
                                                    l = 0;
                                                    m++;
                                                }
                                                int intletter = Convert.ToInt32(valuebyte.Substring(l, 1));
                                                if (G % 2 == 0 && intletter == 1)
                                                {
                                                    G = G + 1;
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                                else if (G % 2 == 1 && intletter == 0)
                                                {
                                                    G = G - 1;
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                                else if ((G % 2 == 0 && intletter == 0) || (G % 2 == 1 && intletter == 1))
                                                {
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                            }
                                        }
                                        if (checkBoxBluePixel.Checked)
                                        {
                                            if (k < text.Length * 7)
                                            {
                                                if (l >= valuebyte.Length)
                                                {
                                                    finishValubyte = true;
                                                }
                                                if (finishValubyte == true)
                                                {
                                                    letter = Convert.ToChar(text.Substring(m, 1));
                                                    value = Convert.ToInt32(letter);
                                                    valuebyte = Convert.ToString(value, 2);
                                                    if (valuebyte.Length != 7)
                                                    {
                                                        for (n = valuebyte.Length; n < 7; n++)
                                                        {
                                                            valuebyte = "0" + valuebyte;
                                                        }
                                                    }
                                                    finishValubyte = false;
                                                    l = 0;
                                                    m++;
                                                }
                                                int intletter = Convert.ToInt32(valuebyte.Substring(l, 1));
                                                if (B % 2 == 0 && intletter == 1)
                                                {
                                                    B = B + 1;
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                                else if (B % 2 == 1 && intletter == 0)
                                                {
                                                    B = B - 1;
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                                else if ((B % 2 == 0 && intletter == 0) || (B % 2 == 1 && intletter == 1))
                                                {
                                                    a = Color.FromArgb(R, G, B);
                                                    yeniimg.SetPixel(i, j, a);
                                                    l++;
                                                    k++;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        a = Color.FromArgb(R, G, B);
                                        yeniimg.SetPixel(i, j, a);
                                    }
                                }
                            }
                            statusStrip.Visible = false;
                            SaveFileDialog saveFile = new SaveFileDialog();
                            saveFile.Filter = "Image Files (*.png,*.jpg) | *.png; *.jpg";
                            if (saveFile.ShowDialog() == DialogResult.OK)
                            {
                                textBoxFilePath.Text = saveFile.FileName.ToString();
                                pictureBox.ImageLocation = textBoxFilePath.Text;
                                yeniimg.Save(textBoxFilePath.Text);
                            }
                        }
                    }
                }   
            }
            catch(System.ArgumentException)
            {
                MessageBox.Show("Dosyaya Ulaşılamamıştır Lütfen Tekrar Deneyiniz", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                    MessageBox.Show("Dosya Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Encode_Load(object sender, EventArgs e)
        {
        }
    }
}
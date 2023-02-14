using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace güvenli_haberleşme
{
    public partial class AesDecode : Form
    {
        public AesDecode()
        {
            InitializeComponent();
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
                // Get the encrypted text to decrypt
                string encrypted = textBoxCrytoMessage.Text;

                // Get the password used to encrypt the text
                string password = textBoxKey.Text;
            AesEncryption aes = new AesEncryption();
                // Decrypt the encrypted text
                string decrypted = aes.Decrypt(encrypted, password);

                // Display the decrypted text
                textBoxMessage.Text = decrypted;
        }
    }
}

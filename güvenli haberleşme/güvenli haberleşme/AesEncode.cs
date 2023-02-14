using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace güvenli_haberleşme
{
    public partial class AesEncode : Form
    {
        public AesEncode()
        {
            InitializeComponent();
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            // Get the plaintext to encrypt
            string plaintext = textBoxMessage.Text;

            // Get the password to use as the key
            string password = textBoxKey.Text;
            AesEncryption aes = new AesEncryption();
            // Encrypt the plaintext
            string encrypted = aes.Encrypt(plaintext, password);
            // Display the encrypted text
            textBoxCrytoMessage.Text = encrypted;

        }
    }
}

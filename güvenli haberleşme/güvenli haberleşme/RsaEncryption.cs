using System;
using System.Numerics;
using System.Text;
namespace güvenli_haberleşme
{
    public class RsaEncryption
    {       
        public string Encrypt(string plainText,BigInteger publicKey,BigInteger n)
        {
            string cryt = "";
            var bytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            for (int i = 0; i < bytes.Length; i++)
            {
                var bigbytes = BigInteger.Parse(Convert.ToString(bytes[i]));
                var crytletter = BigInteger.ModPow(bigbytes, publicKey, n);
                if (Convert.ToString(n).Length > Convert.ToString(crytletter).Length)
                {
                    for (int j = 0; j < Convert.ToString(n).Length - Convert.ToString(crytletter).Length; j++)
                    {
                        cryt = cryt + "0";
                    }
                    cryt = cryt + crytletter;
                }
                else
                {
                    cryt = cryt + crytletter;
                }
            }
            return cryt;
        }
        public string Decrypt(string cypherText,string privateKey,string n)
        {
            int a = 0;
            var bigprivatekey = BigInteger.Parse(privateKey);
            string message = "";
            var bign = BigInteger.Parse(n);
            while (a < cypherText.Length)
            {
                string subcyphertext = cypherText.Substring(a, n.Length);
                var bigcyphertext = BigInteger.Parse(subcyphertext);
                var bigdecryt = BigInteger.ModPow(bigcyphertext, bigprivatekey, bign);
                a = a + n.Length;
                byte[] bytesConvert = bigdecryt.ToByteArray();
                string messageletter = Encoding.ASCII.GetString(bytesConvert);
                message = message + messageletter;
            }
            return message;
        }
    }
}
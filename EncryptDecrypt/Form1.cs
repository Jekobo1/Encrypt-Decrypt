using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hash = "ZhElY0";
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            byte[] data = UTF32Encoding.UTF8.GetBytes(txt_value.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider()) 
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using(TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txt_encypt.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }

            txt_value.Clear();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            byte[] data =Convert.FromBase64String(txt_value.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txt_decrypt.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
            txt_value.Clear();
        }
    }
}

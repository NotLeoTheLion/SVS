using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SVS
{
    public partial class Save : Form
    {
        private static readonly byte[] encryptionKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");

        public Save()
        {
            InitializeComponent();
            button1.Click += btnSavePassword_Click;
            this.Load += Save_Load;
            label1.Click += label1_Click;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string title = textBox1.Text;
            string password = Encrypt(textBox2.Text);
            string url = textBox3.Text;
            string comment = textBox4.Text;

            string entry = $"{title},{password},{url},{comment}";

            File.AppendAllText("passwords.txt", entry + Environment.NewLine);

            MessageBox.Show("Password saved successfully.");
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private string Encrypt(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = encryptionKey;
                aes.IV = new byte[16];

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter writer = new StreamWriter(cs))
                    {
                        writer.Write(plainText);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private void Save_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Any label click handling code can go here.
        }
    }
}

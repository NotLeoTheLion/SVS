using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SVS
{
    public partial class Search : Form
    {
        private static readonly byte[] encryptionKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");

        public Search()
        {
            InitializeComponent();
            btnSearchPassword.Click += btnSearchPassword_Click;
            this.Load += Search_Load;
        }

        private void btnSearchPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchTitle.Text))
            {
                MessageBox.Show("Please enter a title to search for.");
                return;
            }

            string title = txtSearchTitle.Text;
            lstSearchResults.Items.Clear();

            if (File.Exists("passwords.txt"))
            {
                string[] lines = File.ReadAllLines("passwords.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0].Equals(title, StringComparison.OrdinalIgnoreCase))
                    {
                        lstSearchResults.Items.Add($"Title: {parts[0]}, Password: {Decrypt(parts[1])}, URL: {parts[2]}, Comment: {parts[3]}");
                    }
                }

                if (lstSearchResults.Items.Count == 0)
                {
                    MessageBox.Show("No passwords found for the given title.");
                }
            }
            else
            {
                MessageBox.Show("No passwords file found.");
            }
        }

        private string Decrypt(string cipherText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = encryptionKey;
                aes.IV = new byte[16];

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader reader = new StreamReader(cs))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here.
        }
    }
}

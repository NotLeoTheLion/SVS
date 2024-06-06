using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SVS
{
    public partial class Update : Form
    {
        private static readonly byte[] encryptionKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");

        public Update()
        {
            InitializeComponent();
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            this.Load += Update_Load;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpdateTitle.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNewURL.Text) ||
                string.IsNullOrWhiteSpace(txtNewComments.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string title = txtUpdateTitle.Text;
            string newPassword = Encrypt(txtNewPassword.Text);
            string newURL = txtNewURL.Text;
            string newComments = txtNewComments.Text;

            if (File.Exists("passwords.txt"))
            {
                string[] lines = File.ReadAllLines("passwords.txt");
                bool found = false;

                using (StreamWriter writer = new StreamWriter("passwords_temp.txt"))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0].Equals(title, StringComparison.OrdinalIgnoreCase))
                        {
                            writer.WriteLine($"{title},{newPassword},{newURL},{newComments}");
                            found = true;
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                File.Delete("passwords.txt");
                File.Move("passwords_temp.txt", "passwords.txt");

                if (found)
                {
                    MessageBox.Show("Password updated successfully.");
                }
                else
                {
                    MessageBox.Show("No passwords found for the given title.");
                }
            }
            else
            {
                MessageBox.Show("No passwords file found.");
            }
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

        private void Update_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here.
        }
    }
}

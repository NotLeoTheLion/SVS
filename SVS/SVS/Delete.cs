using System;
using System.IO;
using System.Windows.Forms;

namespace SVS
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
            btnDeletePassword.Click += btnDeletePassword_Click;
            this.Load += Delete_Load;
        }

        private void btnDeletePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeleteTitle.Text))
            {
                MessageBox.Show("Please enter a title to delete.");
                return;
            }

            string title = txtDeleteTitle.Text;

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
                            found = true;
                            continue;
                        }
                        writer.WriteLine(line);
                    }
                }

                File.Delete("passwords.txt");
                File.Move("passwords_temp.txt", "passwords.txt");

                if (found)
                {
                    MessageBox.Show("Password deleted successfully.");
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

        private void Delete_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here.
        }
    }
}

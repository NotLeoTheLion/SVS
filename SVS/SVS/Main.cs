using System;
using System.Windows.Forms;

namespace SVS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            btnSearch.Click += btnSearch_Click;
            btnDelete.Click += btnDelete_Click;
            btnUpdate.Click += btnUpdate_Click;
            this.Load += Main_Load;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save saveForm = new Save();
            saveForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search searchForm = new Search();
            searchForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete deleteForm = new Delete();
            deleteForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update();
            updateForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here.
        }
    }
}

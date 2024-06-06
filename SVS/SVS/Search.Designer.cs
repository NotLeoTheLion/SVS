namespace SVS
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Password";
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.Location = new System.Drawing.Point(5, 156);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(310, 95);
            this.lstSearchResults.TabIndex = 1;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(57, 79);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(113, 20);
            this.txtSearchTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // btnSearchPassword
            // 
            this.btnSearchPassword.Location = new System.Drawing.Point(70, 105);
            this.btnSearchPassword.Name = "btnSearchPassword";
            this.btnSearchPassword.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPassword.TabIndex = 4;
            this.btnSearchPassword.Text = "Search";
            this.btnSearchPassword.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 317);
            this.Controls.Add(this.btnSearchPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.lstSearchResults);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchPassword;
    }
}
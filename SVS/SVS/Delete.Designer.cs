namespace SVS
{
    partial class Delete
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
            this.txtDeleteTitle = new System.Windows.Forms.TextBox();
            this.btnDeletePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Password";
            // 
            // txtDeleteTitle
            // 
            this.txtDeleteTitle.Location = new System.Drawing.Point(43, 83);
            this.txtDeleteTitle.Name = "txtDeleteTitle";
            this.txtDeleteTitle.Size = new System.Drawing.Size(115, 20);
            this.txtDeleteTitle.TabIndex = 1;
            // 
            // btnDeletePassword
            // 
            this.btnDeletePassword.Location = new System.Drawing.Point(58, 126);
            this.btnDeletePassword.Name = "btnDeletePassword";
            this.btnDeletePassword.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePassword.TabIndex = 2;
            this.btnDeletePassword.Text = "Delete";
            this.btnDeletePassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeletePassword);
            this.Controls.Add(this.txtDeleteTitle);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeleteTitle;
        private System.Windows.Forms.Button btnDeletePassword;
        private System.Windows.Forms.Label label2;
    }
}
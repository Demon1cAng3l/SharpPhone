namespace SharpPhone
{
    partial class listPhones
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            btnAddPhone = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new Point(3, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(344, 484);
            listBox1.TabIndex = 0;
            // 
            // btnAddPhone
            // 
            btnAddPhone.Location = new Point(353, 12);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(94, 29);
            btnAddPhone.TabIndex = 1;
            btnAddPhone.Text = "+";
            btnAddPhone.UseVisualStyleBackColor = true;
            btnAddPhone.Click += button1_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(353, 47);
            btnModify.Name = "btnModify";
            btnModify.RightToLeft = RightToLeft.Yes;
            btnModify.Size = new Size(94, 29);
            btnModify.TabIndex = 2;
            btnModify.Text = "Aanpassen";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(353, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Verwijderen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listPhones
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 485);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAddPhone);
            Controls.Add(listBox1);
            Name = "listPhones";
            Text = "Voorraad";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnAddPhone;
        private Button btnModify;
        private Button btnDelete;
    }
}

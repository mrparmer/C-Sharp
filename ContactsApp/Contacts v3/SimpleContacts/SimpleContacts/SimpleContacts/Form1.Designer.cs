namespace SimpleContacts
{
    partial class AddressbBookV1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.contactsList = new System.Windows.Forms.ListBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtContacted = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.lastContactLabel = new System.Windows.Forms.Label();
            this.btnDateSort = new System.Windows.Forms.Button();
            this.ContactsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 16);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(14, 59);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Phone";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(14, 103);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 13);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 23);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 56);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 23);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 100);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(132, 23);
            this.txtAddress.TabIndex = 3;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(13, 308);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(125, 47);
            this.btnAddContact.TabIndex = 7;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // contactsList
            // 
            this.contactsList.FormattingEnabled = true;
            this.contactsList.ItemHeight = 16;
            this.contactsList.Location = new System.Drawing.Point(282, 45);
            this.contactsList.Margin = new System.Windows.Forms.Padding(4);
            this.contactsList.Name = "contactsList";
            this.contactsList.Size = new System.Drawing.Size(629, 308);
            this.contactsList.TabIndex = 99;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 145);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(121, 190);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(132, 23);
            this.txtComment.TabIndex = 5;
            // 
            // txtContacted
            // 
            this.txtContacted.Location = new System.Drawing.Point(121, 234);
            this.txtContacted.Margin = new System.Windows.Forms.Padding(4);
            this.txtContacted.Name = "txtContacted";
            this.txtContacted.Size = new System.Drawing.Size(132, 23);
            this.txtContacted.TabIndex = 6;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(14, 148);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(14, 193);
            this.commentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(67, 17);
            this.commentLabel.TabIndex = 12;
            this.commentLabel.Text = "Comment";
            // 
            // lastContactLabel
            // 
            this.lastContactLabel.AutoSize = true;
            this.lastContactLabel.Location = new System.Drawing.Point(14, 237);
            this.lastContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastContactLabel.Name = "lastContactLabel";
            this.lastContactLabel.Size = new System.Drawing.Size(103, 17);
            this.lastContactLabel.TabIndex = 13;
            this.lastContactLabel.Text = "Last Contacted";
            // 
            // btnDateSort
            // 
            this.btnDateSort.Location = new System.Drawing.Point(145, 308);
            this.btnDateSort.Name = "btnDateSort";
            this.btnDateSort.Size = new System.Drawing.Size(125, 47);
            this.btnDateSort.TabIndex = 101;
            this.btnDateSort.Text = "Sort by Contact Date";
            this.btnDateSort.UseVisualStyleBackColor = true;
            this.btnDateSort.Click += new System.EventHandler(this.btnDateSort_Click);
            // 
            // ContactsLbl
            // 
            this.ContactsLbl.AutoSize = true;
            this.ContactsLbl.Location = new System.Drawing.Point(282, 13);
            this.ContactsLbl.Name = "ContactsLbl";
            this.ContactsLbl.Size = new System.Drawing.Size(67, 17);
            this.ContactsLbl.TabIndex = 102;
            this.ContactsLbl.Text = "Contacts:";
            this.ContactsLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddressbBookV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 368);
            this.Controls.Add(this.ContactsLbl);
            this.Controls.Add(this.btnDateSort);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtContacted);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.lastContactLabel);
            this.Controls.Add(this.contactsList);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddressbBookV1";
            this.Text = "Addressbook v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.ListBox contactsList;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtContacted;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label lastContactLabel;
        private System.Windows.Forms.Button btnDateSort;
        private System.Windows.Forms.Label ContactsLbl;
    }
}


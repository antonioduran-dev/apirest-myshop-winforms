namespace MyShop.App.Views
{
    partial class FrmUsers
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
            pnlUsers = new Panel();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            btnCreate = new Button();
            btnBack = new Button();
            dgridUsers = new DataGridView();
            pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridUsers).BeginInit();
            SuspendLayout();
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = SystemColors.AppWorkspace;
            pnlUsers.Controls.Add(btnDeleteUser);
            pnlUsers.Controls.Add(btnUpdateUser);
            pnlUsers.Controls.Add(btnCreate);
            pnlUsers.Controls.Add(btnBack);
            pnlUsers.Controls.Add(dgridUsers);
            pnlUsers.Location = new Point(12, 12);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(776, 426);
            pnlUsers.TabIndex = 0;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(265, 367);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(184, 367);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(75, 23);
            btnUpdateUser.TabIndex = 5;
            btnUpdateUser.Text = "Edit";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(103, 367);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Add";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(22, 366);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgridUsers
            // 
            dgridUsers.AllowUserToAddRows = false;
            dgridUsers.AllowUserToDeleteRows = false;
            dgridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridUsers.Location = new Point(22, 24);
            dgridUsers.MultiSelect = false;
            dgridUsers.Name = "dgridUsers";
            dgridUsers.ReadOnly = true;
            dgridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridUsers.Size = new Size(739, 336);
            dgridUsers.TabIndex = 0;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlUsers);
            Name = "FrmUsers";
            Text = "Users";
            Load += FrmUsers_Load;
            pnlUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUsers;
        private Button btnBack;
        private DataGridView dgridUsers;
        private Button btnCreate;
        private Button btnUpdateUser;
        private Button btnDeleteUser;
    }
}
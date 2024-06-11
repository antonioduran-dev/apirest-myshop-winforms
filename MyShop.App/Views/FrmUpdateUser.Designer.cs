namespace MyShop.App.Views
{
    partial class FrmUpdateUser
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
            panel1 = new Panel();
            btnSaveUser = new Button();
            label6 = new Label();
            cmbUserType = new ComboBox();
            txtbEmail = new TextBox();
            label4 = new Label();
            txtbPhone = new TextBox();
            label3 = new Label();
            txtbAddress = new TextBox();
            label2 = new Label();
            txtbName = new TextBox();
            label1 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnSaveUser);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbUserType);
            panel1.Controls.Add(txtbEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtbPhone);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtbAddress);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 290);
            panel1.TabIndex = 0;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(114, 242);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(75, 23);
            btnSaveUser.TabIndex = 12;
            btnSaveUser.Text = "Save";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 216);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 11;
            label6.Text = "User Type";
            // 
            // cmbUserType
            // 
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Select..." });
            cmbUserType.Location = new Point(68, 213);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(121, 23);
            cmbUserType.TabIndex = 10;
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(68, 176);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(121, 23);
            txtbEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 176);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // txtbPhone
            // 
            txtbPhone.Location = new Point(68, 137);
            txtbPhone.Name = "txtbPhone";
            txtbPhone.Size = new Size(121, 23);
            txtbPhone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // txtbAddress
            // 
            txtbAddress.Location = new Point(68, 97);
            txtbAddress.Name = "txtbAddress";
            txtbAddress.Size = new Size(121, 23);
            txtbAddress.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // txtbName
            // 
            txtbName.Location = new Point(68, 59);
            txtbName.Name = "txtbName";
            txtbName.Size = new Size(121, 23);
            txtbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 59);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(114, 13);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 13;
            label5.Text = "Usuarios";
            // 
            // FrmUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 314);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += FrmUpdateUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtbName;
        private Label label1;
        private Label label6;
        private ComboBox cmbUserType;
        private TextBox txtbEmail;
        private Label label4;
        private TextBox txtbPhone;
        private Label label3;
        private TextBox txtbAddress;
        private Label label2;
        private Button btnSaveUser;
        private Label label5;
    }
}
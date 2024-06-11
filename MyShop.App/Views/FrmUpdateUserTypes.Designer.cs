namespace MyShop.App.Views
{
    partial class FrmUpdateUserTypes
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
            label2 = new Label();
            btnSaveUserType = new Button();
            txtbUserTypeN = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSaveUserType);
            panel1.Controls.Add(txtbUserTypeN);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 243);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 10);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 3;
            label2.Text = "Add new User Type";
            // 
            // btnSaveUserType
            // 
            btnSaveUserType.Location = new Point(80, 127);
            btnSaveUserType.Name = "btnSaveUserType";
            btnSaveUserType.Size = new Size(75, 23);
            btnSaveUserType.TabIndex = 2;
            btnSaveUserType.Text = "Save";
            btnSaveUserType.UseVisualStyleBackColor = true;
            btnSaveUserType.Click += btnSaveUserType_Click;
            // 
            // txtbUserTypeN
            // 
            txtbUserTypeN.Location = new Point(80, 89);
            txtbUserTypeN.Name = "txtbUserTypeN";
            txtbUserTypeN.Size = new Size(120, 23);
            txtbUserTypeN.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 89);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "User Type:";
            // 
            // FrmUpdateUserTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 267);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmUpdateUserTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Types";
            Load += FrmUpdateUserTypes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtbUserTypeN;
        private Label label1;
        private Label label2;
        private Button btnSaveUserType;
    }
}
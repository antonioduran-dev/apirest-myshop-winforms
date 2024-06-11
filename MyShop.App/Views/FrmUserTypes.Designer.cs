namespace MyShop.App.Views
{
    partial class FrmUserTypes
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
            btnUpdateUserType = new Button();
            btnAddType = new Button();
            btnBack = new Button();
            dgridUserTypes = new DataGridView();
            btnDeleteType = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridUserTypes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnDeleteType);
            panel1.Controls.Add(btnUpdateUserType);
            panel1.Controls.Add(btnAddType);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridUserTypes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 311);
            panel1.TabIndex = 0;
            // 
            // btnUpdateUserType
            // 
            btnUpdateUserType.Location = new Point(216, 256);
            btnUpdateUserType.Name = "btnUpdateUserType";
            btnUpdateUserType.Size = new Size(75, 23);
            btnUpdateUserType.TabIndex = 3;
            btnUpdateUserType.Text = "Edit";
            btnUpdateUserType.UseVisualStyleBackColor = true;
            btnUpdateUserType.Click += btnUpdateUserType_Click;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(135, 256);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(75, 23);
            btnAddType.TabIndex = 2;
            btnAddType.Text = "Add";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(54, 256);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgridUserTypes
            // 
            dgridUserTypes.AllowUserToAddRows = false;
            dgridUserTypes.AllowUserToDeleteRows = false;
            dgridUserTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridUserTypes.Location = new Point(54, 25);
            dgridUserTypes.MultiSelect = false;
            dgridUserTypes.Name = "dgridUserTypes";
            dgridUserTypes.ReadOnly = true;
            dgridUserTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridUserTypes.Size = new Size(607, 225);
            dgridUserTypes.TabIndex = 0;
            // 
            // btnDeleteType
            // 
            btnDeleteType.Location = new Point(297, 256);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(75, 23);
            btnDeleteType.TabIndex = 4;
            btnDeleteType.Text = "Delete";
            btnDeleteType.UseVisualStyleBackColor = true;
            btnDeleteType.Click += btnDeleteType_Click;
            // 
            // FrmUserTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 335);
            Controls.Add(panel1);
            Name = "FrmUserTypes";
            Text = "UserTypes";
            Load += FrmUserTypes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridUserTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgridUserTypes;
        private Button btnBack;
        private Button btnAddType;
        private Button btnUpdateUserType;
        private Button btnDeleteType;
    }
}
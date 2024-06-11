namespace MyShop.App.Views
{
    partial class FrmCategory
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
            btnUpdateCategory = new Button();
            btnAddCategory = new Button();
            btnBack = new Button();
            dgridCategory = new DataGridView();
            btnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdateCategory);
            panel1.Controls.Add(btnAddCategory);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridCategory);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 311);
            panel1.TabIndex = 0;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(220, 259);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(75, 23);
            btnUpdateCategory.TabIndex = 7;
            btnUpdateCategory.Text = "Edit";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(139, 259);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 23);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(58, 259);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgridCategory
            // 
            dgridCategory.AllowUserToAddRows = false;
            dgridCategory.AllowUserToDeleteRows = false;
            dgridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridCategory.Location = new Point(58, 28);
            dgridCategory.MultiSelect = false;
            dgridCategory.Name = "dgridCategory";
            dgridCategory.ReadOnly = true;
            dgridCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridCategory.Size = new Size(607, 225);
            dgridCategory.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(301, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 335);
            Controls.Add(panel1);
            Name = "FrmCategory";
            Text = "Categories";
            Load += FrmCategory_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpdateCategory;
        private Button btnAddCategory;
        private Button btnBack;
        private DataGridView dgridCategory;
        private Button btnDelete;
    }
}
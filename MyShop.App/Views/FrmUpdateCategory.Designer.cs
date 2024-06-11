namespace MyShop.App.Views
{
    partial class FrmUpdateCategory
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
            btnSaveCategory = new Button();
            txtbCategoryN = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnSaveCategory);
            panel1.Controls.Add(txtbCategoryN);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 243);
            panel1.TabIndex = 0;
            // 
            // btnSaveCategory
            // 
            btnSaveCategory.Location = new Point(119, 81);
            btnSaveCategory.Name = "btnSaveCategory";
            btnSaveCategory.Size = new Size(75, 23);
            btnSaveCategory.TabIndex = 5;
            btnSaveCategory.Text = "Save";
            btnSaveCategory.UseVisualStyleBackColor = true;
            btnSaveCategory.Click += btnSaveCategory_Click;
            // 
            // txtbCategoryN
            // 
            txtbCategoryN.Location = new Point(119, 52);
            txtbCategoryN.Name = "txtbCategoryN";
            txtbCategoryN.Size = new Size(120, 23);
            txtbCategoryN.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 55);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Category Name:";
            // 
            // FrmUpdateCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 267);
            Controls.Add(panel1);
            Name = "FrmUpdateCategory";
            Text = "FrmUpdateCategory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSaveCategory;
        private TextBox txtbCategoryN;
        private Label label1;
    }
}
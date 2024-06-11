namespace MyShop.App
{
    partial class Form1
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
            panel1 = new Panel();
            btnUserTypes = new Button();
            btnUsers = new Button();
            btnCategory = new Button();
            btnProducts = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnOrders = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnUserTypes);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnProducts);
            panel1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnUserTypes
            // 
            btnUserTypes.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUserTypes.Location = new Point(37, 64);
            btnUserTypes.Name = "btnUserTypes";
            btnUserTypes.Size = new Size(78, 29);
            btnUserTypes.TabIndex = 4;
            btnUserTypes.Text = "User Types";
            btnUserTypes.UseVisualStyleBackColor = true;
            btnUserTypes.Click += btnUserTypes_Click;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.Location = new Point(37, 29);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(78, 29);
            btnUsers.TabIndex = 3;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategory.Location = new Point(121, 64);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(78, 29);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Categories";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.Location = new Point(121, 29);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(78, 29);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.Location = new Point(205, 47);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(78, 29);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCategory;
        private Button btnProducts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnUsers;
        private Button btnUserTypes;
        private Button btnOrders;
    }
}

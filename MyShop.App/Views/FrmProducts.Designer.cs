namespace MyShop.App.Views
{
    partial class FrmProducts
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
            btnDeleteProduct = new Button();
            btnUpdateProduct = new Button();
            btnCreateProduct = new Button();
            btnBack = new Button();
            dgridProducts = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnDeleteProduct);
            panel1.Controls.Add(btnUpdateProduct);
            panel1.Controls.Add(btnCreateProduct);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgridProducts);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(262, 373);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 10;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(181, 373);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(75, 23);
            btnUpdateProduct.TabIndex = 9;
            btnUpdateProduct.Text = "Edit";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnCreateProduct
            // 
            btnCreateProduct.Location = new Point(100, 373);
            btnCreateProduct.Name = "btnCreateProduct";
            btnCreateProduct.Size = new Size(75, 23);
            btnCreateProduct.TabIndex = 8;
            btnCreateProduct.Text = "Add";
            btnCreateProduct.UseVisualStyleBackColor = true;
            btnCreateProduct.Click += btnCreateProduct_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 372);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgridProducts
            // 
            dgridProducts.AllowUserToAddRows = false;
            dgridProducts.AllowUserToDeleteRows = false;
            dgridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridProducts.Location = new Point(19, 30);
            dgridProducts.MultiSelect = false;
            dgridProducts.Name = "dgridProducts";
            dgridProducts.ReadOnly = true;
            dgridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridProducts.Size = new Size(739, 336);
            dgridProducts.TabIndex = 6;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmProducts";
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpdateProduct;
        private Button btnCreateProduct;
        private Button btnBack;
        private Button btnDeleteProduct;
        private DataGridView dgridProducts;
    }
}
namespace MyShop.App.Views
{
    partial class FrmUpdateProduct
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
            numStock = new NumericUpDown();
            numPrice = new NumericUpDown();
            btnSaveProduct = new Button();
            label6 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtbDescription = new TextBox();
            label2 = new Label();
            txtbNameProduct = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(numStock);
            panel1.Controls.Add(numPrice);
            panel1.Controls.Add(btnSaveProduct);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtbDescription);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbNameProduct);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 290);
            panel1.TabIndex = 0;
            // 
            // numStock
            // 
            numStock.Location = new Point(93, 147);
            numStock.Name = "numStock";
            numStock.Size = new Size(214, 23);
            numStock.TabIndex = 25;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(92, 109);
            numPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(215, 23);
            numPrice.TabIndex = 24;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Location = new Point(92, 215);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(75, 23);
            btnSaveProduct.TabIndex = 23;
            btnSaveProduct.Text = "Save";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 189);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 22;
            label6.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Select..." });
            cmbCategory.Location = new Point(92, 186);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(215, 23);
            cmbCategory.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 149);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 19;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 111);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 17;
            label3.Text = "Price";
            // 
            // txtbDescription
            // 
            txtbDescription.Location = new Point(92, 70);
            txtbDescription.Name = "txtbDescription";
            txtbDescription.Size = new Size(215, 23);
            txtbDescription.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 15;
            label2.Text = "Description";
            // 
            // txtbNameProduct
            // 
            txtbNameProduct.Location = new Point(92, 32);
            txtbNameProduct.Name = "txtbNameProduct";
            txtbNameProduct.Size = new Size(215, 23);
            txtbNameProduct.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // FrmUpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 314);
            Controls.Add(panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmUpdateProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            Load += FrmUpdateProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSaveProduct;
        private Label label6;
        private ComboBox cmbCategory;
        private Label label4;
        private Label label3;
        private TextBox txtbDescription;
        private Label label2;
        private TextBox txtbNameProduct;
        private Label label1;
        private NumericUpDown numStock;
        private NumericUpDown numPrice;
    }
}
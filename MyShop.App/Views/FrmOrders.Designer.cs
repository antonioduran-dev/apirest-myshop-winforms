namespace MyShop.App.Views
{
    partial class FrmOrders
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
            btnCreateOrder = new Button();
            dgridSelectProducts = new DataGridView();
            btnBack = new Button();
            label3 = new Label();
            cmbUserOrder = new ComboBox();
            label1 = new Label();
            Select = new DataGridViewCheckBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridSelectProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnCreateOrder);
            panel1.Controls.Add(dgridSelectProducts);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbUserOrder);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(686, 350);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(75, 23);
            btnCreateOrder.TabIndex = 9;
            btnCreateOrder.Text = "Buy";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // dgridSelectProducts
            // 
            dgridSelectProducts.AllowUserToAddRows = false;
            dgridSelectProducts.AllowUserToDeleteRows = false;
            dgridSelectProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridSelectProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewCheckBoxColumn { Name = "Select", HeaderText = "Select" },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Quantity", HeaderText = "Quantity", ValueType = typeof(int) }});
            dgridSelectProducts.Location = new Point(17, 140);
            dgridSelectProducts.Name = "dgridSelectProducts";
            dgridSelectProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridSelectProducts.Size = new Size(744, 204);
            dgridSelectProducts.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(17, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 112);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Products:";
            // 
            // cmbUserOrder
            // 
            cmbUserOrder.FormattingEnabled = true;
            cmbUserOrder.Location = new Point(73, 56);
            cmbUserOrder.Name = "cmbUserOrder";
            cmbUserOrder.Size = new Size(120, 23);
            cmbUserOrder.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 56);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // Select
            // 
            Select.HeaderText = "Select";
            Select.Name = "Select";
            Select.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FrmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmOrders";
            Text = "FrmOrders";
            Load += FrmOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgridSelectProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbUserOrder;
        private Label label1;
        private Label label3;
        private Button btnBack;
        private DataGridView dgridSelectProducts;
        private Button btnCreateOrder;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
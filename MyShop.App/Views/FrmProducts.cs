using MyShop.App.Controllers;
using MyShop.Controllers;
using MyShop.DTOs;
using MyShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CategoryController = MyShop.App.Controllers.CategoryController;
using ProductController = MyShop.App.Controllers.ProductController;

namespace MyShop.App.Views
{
    public partial class FrmProducts : Form
    {
        private ProductController _productController;
        private CategoryController _categoryController;

        private List<CategoryDTO> _categories = new List<CategoryDTO>();
        public FrmProducts()
        {
            InitializeComponent();
            _productController = new ProductController();
            _categoryController = new CategoryController();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        public async void GetProducts()
        {
            List<ProductDTO> products = await _productController.GetProducts();
            List<ProductModel> productModel = new List<ProductModel>();
            _categories = await _categoryController.GetCategories();

            if (products != null)
            {
                foreach (var product in products)
                {
                    // Crea un nuevo UserModel y lo agrega a la lista
                    productModel.Add(new ProductModel
                    {
                        IdProduct = product.IdProduct,
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price,
                        Stock = product.Stock,
                        Category = _categories.Find(c => c.IdCategory == product.IdCategory)!.CategoryName
                    });
                }
                // create a new data grid view row
                dgridProducts.DataSource = productModel;
            }
            else
            {
                MessageBox.Show("No se pudo mostrar la Información", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            FrmUpdateProduct frm = new FrmUpdateProduct();
            frm.ShowDialog();
            GetProducts(); // refresh the data grid
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                FrmUpdateProduct frm = new FrmUpdateProduct(id);
                frm.ShowDialog();
                GetProducts(); // refresh the data grid
            }
        }

        private int? GetId()
        {
            try
            {
                // get the first element of row selected that contains the id.
                return int.Parse(dgridProducts.Rows[dgridProducts.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _productController.DeleteProduct((int)id);
                    GetProducts();
                }
            }
        }
    }
}


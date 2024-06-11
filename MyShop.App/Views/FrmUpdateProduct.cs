using MyShop.DTOs;
using MyShop.Models;
using CategoryController = MyShop.App.Controllers.CategoryController;
using ProductController = MyShop.App.Controllers.ProductController;

namespace MyShop.App.Views
{
    public partial class FrmUpdateProduct : Form
    {
        private int? _id;
        private CategoryController _categoryController;
        private ProductController _productController;
        private List<CategoryDTO> _categories = new List<CategoryDTO>(); 
        public FrmUpdateProduct(int? id = null)
        {
            InitializeComponent();
            _id = id;
            _categoryController = new CategoryController();
            _productController = new ProductController();

            if (_id != null)
                LoadData();
        }

        private void FrmUpdateProduct_Load(object sender, EventArgs e)
        {
            SetCategories();
            cmbCategory.SelectedIndex = 0;
        }

        private async void SetCategories()
        {
            _categories = await _categoryController.GetCategories();

            if (_categories != null)
            {
                foreach (var category in _categories)
                {
                    cmbCategory.Items.Add(category.CategoryName);
                }
            }
        }

        private async void LoadData()
        {
            ProductDTO product = await _productController.GetProductById((int)_id!);
            var category = await _categoryController.GetCategoryById((int)product.IdCategory!);

            txtbNameProduct.Text = product.Name;
            txtbDescription.Text = product.Description;
            numPrice.Value = product.Price;
            numStock.Value = product.Stock;
            cmbCategory.SelectedItem = category.CategoryName;
        }

        private async void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string name = txtbNameProduct.Text;
            string description = txtbDescription.Text;
            decimal price = numPrice.Value;
            int stock = Convert.ToInt32(numStock.Value);
            var category = _categories.Find(t => t.CategoryName == cmbCategory.SelectedItem!.ToString());

            if (_id == null)
            {

                if (name.Trim() != "" && description.Trim() != "" && price != 0 && stock != 0 && cmbCategory.SelectedIndex != 0)
                {
                    ProductDTO product = new ProductDTO()
                    {
                        Name = name,
                        Description = description,
                        Price = price,
                        Stock = stock,
                        IdCategory = category.IdCategory
                    };

                    await _productController.CreateProduct(product);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Complpete los campos Correctamente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (name.Trim() != "" && description.Trim() != "" && price != 0 && stock != 0 && cmbCategory.SelectedIndex != 0)
                {
                    ProductDTO product = new ProductDTO()
                    {
                        IdProduct = (int)_id,
                        Name = name,
                        Description = description,
                        Price = price,
                        Stock = stock,
                        IdCategory = category.IdCategory
                    };

                    await _productController.UpdateProduct(product);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Complpete los campos Correctamente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

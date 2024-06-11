using MyShop.App.Controllers;
using MyShop.Controllers;
using MyShop.DTOs;

using ProductController = MyShop.App.Controllers.ProductController;
using UserController = MyShop.App.Controllers.UserController;

namespace MyShop.App.Views
{
    public partial class FrmOrders : Form
    {
        private int _id;
        private SellController _sellController;
        private ProductController _productController;
        private UserController _userController;
        private List<ProductDTO> _products;
        private List<OrderDetailDTO> _orderDetails;
        private List<UserDTO> _users;
        public FrmOrders()
        {
            InitializeComponent();
            _sellController = new SellController();
            _productController = new ProductController();
            _userController = new UserController();
            _products = new List<ProductDTO>();
            _orderDetails = new List<OrderDetailDTO>();
            _users = new List<UserDTO>();
            
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            GetProducts();
            SetUsers();
        }

        private async void GetProducts()
        {
            try
            {
                _products = await _productController.GetProducts();
                dgridSelectProducts.DataSource = _products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
        }

        private async void SetUsers()
        {
            _users = await _userController.GetUsers();

            if (_users != null)
            {
                foreach (var user in _users)
                {
                    cmbUserOrder.Items.Add($"{user.IdUser}: " + user.Name);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgridSelectProducts.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    var product = (ProductDTO)row.DataBoundItem;
                    var quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    _orderDetails.Add(new OrderDetailDTO
                    {
                        IdProduct = product.IdProduct,
                        Quantity = quantity
                    });
                }
            }

            GenerateSell();
        }

        private async void GenerateSell()
        {
            var id = cmbUserOrder.SelectedItem;

            try
            {
                if (id != null)
                {
                    var order = new OrderDTO
                    {
                        Date = DateTime.Now,
                        IdUser = Convert.ToInt32(id.ToString()!.Substring(0, 1)),
                        OrderDetails = _orderDetails
                    };

                    var response = await _sellController.CreateOrder(order);

                    if (response != null)
                    {
                        MessageBox.Show("Venta realizada con éxito");
                        _orderDetails.Clear();
                        GetProducts();
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar la venta!");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccine un Cliente!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al realizar la venta! " + ex.Message);
            }

            
        }
    }
}

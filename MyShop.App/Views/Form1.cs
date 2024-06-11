using MyShop.App.Views;

namespace MyShop.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers userForm = new FrmUsers();
            this.Hide();
            userForm.Show();
        }

        private void btnUserTypes_Click(object sender, EventArgs e)
        {
            FrmUserTypes frmUserTypes = new FrmUserTypes();
            frmUserTypes.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory form = new FrmCategory();
            this.Hide();
            form.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            this.Hide();
            frm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            FrmOrders frm = new FrmOrders();
            this.Hide();
            frm.Show();
        }
    }
}

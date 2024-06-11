using MyShop.App.Controllers;
using MyShop.Controllers;
using MyShop.DTOs;
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

namespace MyShop.App.Views
{
    public partial class FrmCategory : Form
    {
        private CategoryController _categoryController;
        private List<CategoryDTO> _categories = new List<CategoryDTO>();
        public FrmCategory()
        {
            InitializeComponent();
            _categoryController = new CategoryController();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        public async void GetCategories()
        {
            _categories = await _categoryController.GetCategories();

            if (_categories != null)
            {
                // create a new data grid view row
                dgridCategory.DataSource = _categories;
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
            frm.Show();
            this.Hide();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FrmUpdateCategory frm = new FrmUpdateCategory();
            frm.ShowDialog();
            GetCategories();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmUpdateCategory frm = new FrmUpdateCategory(id);
                frm.ShowDialog();
                GetCategories();
            }
        }

        private int? GetId()
        {
            try
            {
                // get the first element of row selected yhat contains the id.
                return int.Parse(dgridCategory.Rows[dgridCategory.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _categoryController.DeleteCategory((int)id);
                    GetCategories();
                }
            }
        }
    }
}

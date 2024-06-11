using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FrmUpdateCategory : Form
    {
        private int? _id;
        private CategoryController _categoryController;
        public FrmUpdateCategory(int? id = null)
        {
            InitializeComponent();
            _id = id;
            _categoryController = new CategoryController();
            if (_id != null)
                LoadData();
        }

        private async void LoadData()
        {
            CategoryDTO category = await _categoryController.GetCategoryById((int)_id);

            txtbCategoryN.Text = category.CategoryName;
        }

        private async void btnSaveCategory_Click(object sender, EventArgs e)
        {
            string name = txtbCategoryN.Text;
            if(_id == null)
            {
                if (name.Trim() != "")
                {
                    CategoryDTO cat = new CategoryDTO()
                    {
                        CategoryName = name
                    };

                    await _categoryController.CreateCategory(cat);

                    FrmCategory frm = new FrmCategory();

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
                if (name.Trim() != "")
                {
                    CategoryDTO cat = new CategoryDTO()
                    {
                        IdCategory = (int)_id,
                        CategoryName = name
                    };

                    await _categoryController.UpdateCategory(cat);

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

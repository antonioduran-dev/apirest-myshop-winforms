using MyShop.App.Controllers;
using MyShop.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShop.App.Views
{
    public partial class FrmUpdateUserTypes : Form
    {
        private int? _id;
        private UserTypeController _userTypeController;
        public FrmUpdateUserTypes(int? id = null)
        {
            InitializeComponent();
            _id = id;
            _userTypeController = new UserTypeController();

            if (_id != null)
                LoadData();
        }

        private async void LoadData()
        {
            UserTypeDTO type = await _userTypeController.GetUserTypeById((int)_id);

            txtbUserTypeN.Text = type.Name;
        }

        private async void btnSaveUserType_Click(object sender, EventArgs e)
        {
            string typeName = txtbUserTypeN.Text;

            if (_id == null)
            {
                if (typeName.Trim() != "")
                {
                    UserTypeDTO type = new UserTypeDTO()
                    {
                        Name = typeName
                    };

                    await _userTypeController.CreateType(type);

                    FrmUserTypes frm = new FrmUserTypes();

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
                if (typeName.Trim() != "")
                {
                    UserTypeDTO type = new UserTypeDTO()
                    {
                        IdType = (int)_id,
                        Name = typeName
                    };

                    await _userTypeController.UpdateUserType(type);

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Complpete los campos Correctamente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmUpdateUserTypes_Load(object sender, EventArgs e)
        {

        }
    }
}

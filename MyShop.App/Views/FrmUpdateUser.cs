using MyShop.App.Controllers;
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

namespace MyShop.App.Views
{
    public partial class FrmUpdateUser : Form
    {
        private int? _id;
        UserTypeController _userTypeController;
        UserController _userController;
        List<UserTypeDTO> userTypes = new List<UserTypeDTO>();
        public FrmUpdateUser(int? id = null)
        {
            InitializeComponent();
            _userTypeController = new UserTypeController();
            _userController = new UserController();
            _id = id;

            if (_id != null)
                LoadData();
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {
            SetTypes();
            cmbUserType.SelectedIndex = 0;
        }

        private async void SetTypes()
        {
            userTypes = await _userTypeController.GetUserTypes();
            
            if (userTypes != null)
            {
                foreach (var type in userTypes)
                {
                    cmbUserType.Items.Add(type.Name);
                }
            }
        }

        private async void LoadData()
        {
            UserDTO user = await _userController.GetUserById((int)_id);
            var type = await _userTypeController.GetUserTypeById((int)user.IdType);

            txtbName.Text = user.Name;
            txtbAddress.Text = user.Address;
            txtbPhone.Text = user.Phone;
            txtbEmail.Text = user.Email;
            cmbUserType.SelectedItem = type.Name;
        }

        private async void btnSaveUser_Click(object sender, EventArgs e)
        {
            var name = txtbName.Text;
            var address = txtbAddress.Text;
            var phone = txtbPhone.Text;
            var email = txtbEmail.Text;
            var type = userTypes.Find(t => t.Name == cmbUserType.SelectedItem!.ToString());

            if (_id == null)
            {

                if (name.Trim() != "" && address.Trim() != "" && phone.Trim() != "" && email.Trim() != "" && cmbUserType.SelectedIndex != 0)
                {
                    UserDTO user = new UserDTO()
                    {
                        Name = name,
                        Address = address,
                        Phone = phone,
                        Email = email,
                        IdType = type.IdType
                    };

                    await _userController.CreateUser(user);

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
                if (name.Trim() != "" && address.Trim() != "" && phone.Trim() != "" && email.Trim() != "" && cmbUserType.SelectedIndex != 0)
                {
                    UserDTO user = new UserDTO()
                    {
                        IdUser = (int)_id,
                        Name = name,
                        Address = address,
                        Phone = phone,
                        Email = email,
                        IdType = type.IdType
                    };

                    await _userController.UpdateUser(user);

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

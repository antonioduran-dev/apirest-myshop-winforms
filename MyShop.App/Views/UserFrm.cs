
using MyShop.DTOs;
using MyShop.Models;

using UserController = MyShop.App.Controllers.UserController;
using UserTypeController = MyShop.App.Controllers.UserTypeController;

namespace MyShop.App.Views
{
    public partial class FrmUsers : Form
    {
        private UserController _userController;
        private UserTypeController _userTypeController;

        private List<UserTypeDTO> _types = new List<UserTypeDTO>();

        public FrmUsers()
        {
            InitializeComponent();
            _userController = new UserController();
            _userTypeController = new UserTypeController();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        public async void GetUsers()
        {
            List<UserDTO> users = await _userController.GetUsers();
            List<UserModel> usersModel = new List<UserModel>();
            _types = await _userTypeController.GetUserTypes();

            if (users != null)
            {
                foreach (var user in users)
                {
                    // Crea un nuevo UserModel y lo agrega a la lista
                    usersModel.Add(new UserModel
                    {
                        IdUser = user.IdUser,
                        Name = user.Name,
                        Address = user.Address,
                        Phone = user.Phone,
                        Email = user.Email,
                        UserType = _types.Find(t => t.IdType == user.IdType)!.Name
                    });
                }
                // create a new data grid view row
                dgridUsers.DataSource = usersModel;
            }
            else
            {
                MessageBox.Show("No se pudo mostrar la Información", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmUpdateUser frm = new FrmUpdateUser();
            frm.ShowDialog();
            GetUsers();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int? id = GetId();

            if (id != null)
            {
                FrmUpdateUser frm = new FrmUpdateUser(id);
                frm.ShowDialog();
                GetUsers();
            }
        }

        private int? GetId()
        {
            try
            {
                // get the first element of row selected that contains the id.
                return int.Parse(dgridUsers.Rows[dgridUsers.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _userController.DeleteUser((int)id);
                    GetUsers();
                }
            }
        }
    }
}


using MyShop.DTOs;

using UserTypeController = MyShop.App.Controllers.UserTypeController;

namespace MyShop.App.Views
{
    public partial class FrmUserTypes : Form
    {
        private UserTypeController _userTypeController;
        private List<UserTypeDTO> _types = new List<UserTypeDTO>();
        public FrmUserTypes()
        {
            InitializeComponent();
            _userTypeController = new UserTypeController();
        }

        private void FrmUserTypes_Load(object sender, EventArgs e)
        {
            GetTypes();
        }

        public async void GetTypes()
        {
            _types = await _userTypeController.GetUserTypes();

            if (_types != null)
            {
                // create a new data grid view row
                dgridUserTypes.DataSource = _types;
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

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FrmUpdateUserTypes frm = new FrmUpdateUserTypes();
            frm.ShowDialog();
            GetTypes();
        }

        private void btnUpdateUserType_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmUpdateUserTypes frm = new FrmUpdateUserTypes(id);
                frm.ShowDialog();
                GetTypes();
            }
        }

        // Get the id of element selected
        private int? GetId()
        {
            try
            {
                // get the first element of row selected yhat contains the id.
                return int.Parse(dgridUserTypes.Rows[dgridUserTypes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async void btnDeleteType_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                // creates Message box with yes, no options to delete element
                var result = MessageBox.Show("¿Desea eliminar el elemento?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await _userTypeController.DeleteUserType((int)id);
                    GetTypes();
                }
            }
        }
    }
}

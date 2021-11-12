using BusinessLayer.Service;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class ContactsForm : Form
    {
        public static ContactsForm Instance { get; } = new ContactsForm();

        private ContactService _contactService;

        public int? selectedContact = null;

        public ContactsForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _contactService = new ContactService(connection);
        }

        #region Events

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void ContactsForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Show();
        }

        private void MsItemLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void DgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedContact = int.Parse(DgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        #endregion

        #region Methods

        private void LoadContacts()
        {
            DgvContacts.DataSource = _contactService.GetAll((int)LoginService.Instance.IdLogedUser);
            DgvContacts.ClearSelection();
        }

        private void Logout()
        {
            LoginService.Instance.IdLogedUser = -1;
            CloseForm();
        }

        private void AddContact()
        {
            AddContactForm newAddContactForm = new AddContactForm();
            newAddContactForm.Show();
            this.Hide();
        }

        private void EditContact()
        {
            AddContactForm newAddContactForm = new AddContactForm();
            newAddContactForm.Show();
            this.Hide();
        }

        private void DeleteContact()
        {
            if (selectedContact != null)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete this contact?",
                    "Warning!", MessageBoxButtons.OKCancel);

                if (response == DialogResult.OK)
                {
                    bool result = _contactService.Delete((int)selectedContact);

                    if (result)
                    {
                        MessageBox.Show("Contact deleted successfully.", "Notification!");
                    }
                    else
                    {
                        MessageBox.Show("There was a problem, try again later.", "Error!");
                    }

                    LoadContacts();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact.", "Warning!");
            }
        }

        private void CloseForm()
        {
            LoginForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}

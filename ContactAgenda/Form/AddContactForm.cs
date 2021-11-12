using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class AddContactForm : Form
    {
        private ContactService _contactService;

        public AddContactForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _contactService = new ContactService(connection);
        }

        #region Events

        private void AddContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContactsForm.Instance.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void AddContact()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string address = TxtBxAddress.Text;
            string phoneNumber = TxtBxPhoneNumber.Text;
            string workNumber = TxtBxWorkNumber.Text;
            int idUser = LoginForm.Instance.idLogedUser;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(phoneNumber) || String.IsNullOrEmpty(workNumber))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!");
            }
            else
            {
                Contact newContact = new Contact()
                {
                    Name = name,
                    LastName = lastName,
                    Address = address,
                    PhoneNumber = phoneNumber,
                    WorkNumber = workNumber,
                    IdUser = idUser
                };

                bool result = _contactService.Add(newContact);

                if (result)
                {
                    DialogResult response = MessageBox.Show("Contact created successfully.", "Notification!", MessageBoxButtons.OK);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the contact, try again later.", "Error!");
                }
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}

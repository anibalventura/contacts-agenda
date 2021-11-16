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

        // Disable window close button.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;  // CS_NOCLOSE
                return parms;
            }
        }

        #region Events

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            LoadContactToEdit();
        }

        private void AddContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContactsForm.Instance.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (LoginRepository.Instance.IdSelectedContact != null)
            {
                EditContact();
            }
            else
            {
                AddContact();
            }
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
            int idUser = (int)LoginRepository.Instance.IdLogedUser;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(address) || !TxtBxPhoneNumber.MaskCompleted || !TxtBxWorkNumber.MaskCompleted)
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

        private void LoadContactToEdit()
        {
            if(LoginRepository.Instance.IdSelectedContact != null)
            {
                Contact contact = _contactService.GetById((int)LoginRepository.Instance.IdSelectedContact);

                TxtBxName.Text = contact.Name;
                TxtBxLastName.Text = contact.LastName;
                TxtBxAddress.Text = contact.Address;
                TxtBxPhoneNumber.Text = contact.PhoneNumber;
                TxtBxWorkNumber.Text = contact.WorkNumber;
            }
        }

        private void EditContact()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string address = TxtBxAddress.Text;
            string phoneNumber = TxtBxPhoneNumber.Text;
            string workNumber = TxtBxWorkNumber.Text;
            int idUser = (int)LoginRepository.Instance.IdLogedUser;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(address) || !TxtBxPhoneNumber.MaskCompleted || !TxtBxWorkNumber.MaskCompleted)
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!");
            }
            else
            {
                Contact updatedContact = new Contact()
                {
                    Id = (int)LoginRepository.Instance.IdSelectedContact,
                    Name = name,
                    LastName = lastName,
                    Address = address,
                    PhoneNumber = phoneNumber,
                    WorkNumber = workNumber,
                    IdUser = idUser
                };

                bool result = _contactService.Edit(updatedContact);

                if (result)
                {
                    DialogResult response = MessageBox.Show("Contact edited successfully.", "Notification!", MessageBoxButtons.OK);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem editing the contact, try again later.", "Error!");
                }
            }
        }

        private void CloseForm()
        {
            LoginRepository.Instance.IdSelectedContact = null;
            this.Close();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class ContactsForm : Form
    {
        public static ContactsForm Instance { get; } = new ContactsForm();

        public ContactsForm()
        {
            InitializeComponent();
        }

        #region Events

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

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        private void Logout()
        {
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

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}

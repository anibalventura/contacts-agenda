using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        #region Events

        private void AddContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContactsForm.Instance.Show();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
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
            CloseForm();
        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}

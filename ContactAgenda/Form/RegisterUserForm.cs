using System;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        #region Events

        private void RegisterUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterNewUser();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void RegisterNewUser()
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

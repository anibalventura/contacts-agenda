using System;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class LoginForm : Form
    {
        public static LoginForm Instance { get; } = new LoginForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        #region Events

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterNewUser();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        #endregion

        #region Methods

        private void RegisterNewUser()
        {
            RegisterUserForm newRegisterForm = new RegisterUserForm();
            newRegisterForm.Show();
            this.Hide();
        }

        private void LoginUser()
        {
            ContactsForm newContactsForm = new ContactsForm();
            newContactsForm.Show();
            this.Hide();
        }

        #endregion
    }
}

using BusinessLayer.Service;
using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class RegisterUserForm : Form
    {
        private UserService _userService;

        public RegisterUserForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _userService = new UserService(connection);
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
            string name = TxtBxName.Text;
            string lastName = TxtBxLastname.Text;
            string username = TxtBxUsername.Text;
            string password = TxtBxPassword.Text;
            string confirmPassword = TxtBxConfirmPassword.Text;

            bool userCreated = _userService.CheckUsername(username);

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!");
            }
            else if (userCreated)
            {
                MessageBox.Show("Username is registered, please use another username", "Warning!");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords are not the same.", "Warning!");
            }
            else
            {
                User newUser = new User()
                {
                    Name = name,
                    LastName = lastName,
                    Username = username,
                    Password = password,
                };

                bool result = _userService.Add(newUser);

                if(result)
                {
                    DialogResult response = MessageBox.Show("User created successfully.", "Notification!", MessageBoxButtons.OK);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the user, try again later.", "Error!");
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

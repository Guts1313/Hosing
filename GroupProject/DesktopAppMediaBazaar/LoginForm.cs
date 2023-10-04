using ClassLibrary.Classes;
using ClassLibrary.Controllers;
using ClassLibrary.DBHelpers;
using DataAccessLayer;

namespace DesktopAppMediaBazaar
{
    public partial class LoginForm : Form
    {
        public EmployeeController EmployeeController { get; private set; } = new(new DALEmployeeController());
        public Employee? LoggedInEmployee { get; private set; } = null;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = txbUsername.Text;
            string _password = txbPassword.Text;

            if (EmployeeController.Login(_username, _password) == null)
            {
                MessageBox.Show("Incorrect login details, try again.");
                return;
            }
            else
            {
                LoggedInEmployee = EmployeeController.Login(_username, _password);

                if (EmployeeController.IsAdmin(LoggedInEmployee))
                {
                    AdminLandingForm form = new AdminLandingForm(LoggedInEmployee);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }

                else if (EmployeeController.IsManager(LoggedInEmployee))
                {
                    ManagerLandingForm form = new ManagerLandingForm(LoggedInEmployee);
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("You do not have permission to access the application.");
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
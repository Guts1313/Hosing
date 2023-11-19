using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DesktopAppMediaBazaar.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar
{
    public partial class ResetPassword : Form
    {
        private EmployeeController _employeeController;
        private string _email;
        public ResetPassword(string email)
        {
            InitializeComponent();
            _employeeController = new EmployeeController(new DALEmployeeController());
            _email = email;
        }

        private void rbConfirm_Click(object sender, EventArgs e)
        {
            if (ctbxNewPassword.Text != ctbxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            try
            {
                if (_employeeController.ChangePassword(_email, ctbxNewPassword.Text))
                {
                    RJMessageBox.Show("Password reset was successful");

                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                    Close();
                }
            }
            catch (SqlNullValueException ex)
            {
                RJMessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                RJMessageBox.Show(ex.Message);
            }
            catch (TimeoutException ex)
            {
                RJMessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                RJMessageBox.Show(ex.Message);
            }
        }
    }
}

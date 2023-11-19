using BussinessLayer.Controllers;
using DataAccessLayer.DAL;
using DesktopAppMediaBazaar.CustomElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppMediaBazaar
{
    public partial class ForgotPassword : Form
    {
        private EmailSendController emailSendController;
        private EmployeeController employeeController;
        public ForgotPassword()
        {
            InitializeComponent();
            employeeController = new EmployeeController(new DALEmployeeController());
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void rbSendEmail_Click(object sender, EventArgs e)
        {
            if (tbxEmail.Text == string.Empty)
            {
                RJMessageBox.Show("Enter email address");
                return;
            }

            if (!employeeController.FindEmail(tbxEmail.Text))
            {
                RJMessageBox.Show("Email does not exist");
                return;
            }

            try
            {
                emailSendController = new EmailSendController(tbxEmail.Text);

                if (emailSendController.SendEmail())
                {
                    RJMessageBox.Show("Email send successfully");
                }
            }
            catch (SmtpFailedRecipientsException ex) { RJMessageBox.Show(ex.Message); }
            catch (SmtpFailedRecipientException ex) { RJMessageBox.Show(ex.Message); }
            catch (SmtpException ex) { RJMessageBox.Show(ex.Message); }
            catch (ArgumentException ex) { RJMessageBox.Show(ex.Message); }
            catch (Exception ex) { RJMessageBox.Show(ex.Message); }
        }

        private void rbEnterCode_Click(object sender, EventArgs e)
        {
            if (tbxCode.Text == string.Empty)
            {
                RJMessageBox.Show("Enter code");
                return;
            }

            if (!int.TryParse(tbxCode.Text, out int code))
            {
                RJMessageBox.Show("Invalid code");
                return;
            }

            if (!emailSendController.CheckCode(code))
            {
                RJMessageBox.Show("Wrong code");
                return;
            }

            ResetPassword resetPassword = new ResetPassword(tbxEmail.Text);

            this.Hide();
            resetPassword.ShowDialog();
            this.Close();
        }
    }
}

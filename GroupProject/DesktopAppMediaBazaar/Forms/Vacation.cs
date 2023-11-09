using DataItems.LogicItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppMediaBazaar.CustomElements;

namespace DesktopAppMediaBazaar.Forms
{
    public partial class Vacation : Form
    {
        private Employee _loggedInEmployee;
        public Vacation(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("ADD CRAP HERE LATER");
        }
    }
}

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

namespace DesktopAppMediaBazaar.Forms
{
    public partial class Shifts : Form
    {
        private Employee _loggedInEmployee;
        public Shifts(Employee loggedInEmployee)
        {
            InitializeComponent();
            _loggedInEmployee = loggedInEmployee;
        }
    }
}

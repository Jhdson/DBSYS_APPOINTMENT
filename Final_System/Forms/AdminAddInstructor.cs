using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_System.Forms
{
    public partial class AdminAddInstructor : Form
    {
        public AdminAddInstructor()
        {
            InitializeComponent();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            pnlInstructor.BringToFront();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnlUsers.BringToFront();
        }
    }
}

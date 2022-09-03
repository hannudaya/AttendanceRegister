using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttendanceRegister
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            frmStudents frmstudent = new frmStudents();
            frmstudent.Show();
            this.Hide();
        }

        private void BtnClassAllocation_Click(object sender, EventArgs e)
        {
            frmClassAllocation frmclassalloc = new frmClassAllocation();
            frmclassalloc.Show();
            this.Hide();
        }
    }
}

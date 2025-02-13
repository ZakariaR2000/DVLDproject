using DVLD.Applications.Application_Types;
using DVLD.Applications.Local_Driving_License;
using DVLD.Drivers;
using DVLD.Global_Classes;
using DVLD.Licenses.Detain_License;
using DVLD.Login;
using DVLD.People;
using DVLD.Test.Test_Type;
using DVLD.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }
        

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;

            _frmLogin.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog(); 
        }

        private void manageLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frm =
                new frmListLocalDrivingLicenseApplications();

            frm.ShowDialog();

        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frm =
                new frmListLocalDrivingLicenseApplications();

            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }
    }
}

using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _LocalDrivingLicenseApplicationID = -1;

        private int _LicenseID;

        public int LocalDrivingLicenseApplicationID
        {
            get
            {
                return _LocalDrivingLicenseApplicationID;
            }
        }

        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);


            if(_LocalDrivingLicenseApplication==null)
            {
                _ResetLocalDrivingLicneseApplicationInfo();

                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicenseApplicationInfo();

        }

        public void LoadApplicationByApplicationID(int ApplicationID)
        {
            _LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByApplicationID(ApplicationID);


            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicneseApplicationInfo();

                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicationID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
          //  _LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();

            llShowLicneseInfo.Enabled = (_LicenseID != -1);

            lblLocalDrivingLicenseApplicationID.Text =
                _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();

            //lblAppliedForLicense.Text =
            //    clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;

            //  lblPassedTests.Text = _LocalDrivingLicenseApplication.GetPassedTestCount().ToString() + "/3";

            ctrlApplicationBasicInfo1.LoadApplicatonInfo(_LocalDrivingLicenseApplication.ApplicationID);
        }

        private void _ResetLocalDrivingLicneseApplicationInfo()
        {
            _LocalDrivingLicenseApplicationID = -1;
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
            lblLocalDrivingLicenseApplicationID.Text = "[????]";
            lblAppliedForLicense.Text = "[????]";
        }

        private void llShowLicneseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}

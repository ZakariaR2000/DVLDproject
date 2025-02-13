using DVLD.Properties;
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

namespace DVLD.Test
{
    public partial class frmListTestAppointments : Form
    {

        private DataTable _dtLicneseTestAppointment;
        private int _LocalDrivingLicneseApplicationID;
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;
        public frmListTestAppointments(int LocalDrivingLicneseApplicationID , clsTestType.enTestType TestType)
        {
            InitializeComponent();

            _LocalDrivingLicneseApplicationID = LocalDrivingLicneseApplicationID;
            _TestType = TestType;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _LoadTestTypeImageAndTitle()
        {
            switch(_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        lblTitle.Text = "Vision Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.icons8_vision_48;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        lblTitle.Text = "Written Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.icons8_writing_down_48;
                        break;
                    }

                case clsTestType.enTestType.StreetTest:
                    {
                        lblTitle.Text = "Street Test Appointments";
                        this.Text = lblTitle.Text;
                        pbTestTypeImage.Image = Resources.icons8_curvy_street_48;
                        break;
                    }
            }
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();

            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicneseApplicationID);
            _dtLicneseTestAppointment =
                clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_LocalDrivingLicneseApplicationID , _TestType);

            dgvLicenseTestAppointments.DataSource = _dtLicneseTestAppointment;

            lblNumberOfRecords.Text = dgvLicenseTestAppointments.Rows.Count.ToString();

            if(dgvLicenseTestAppointments.Rows.Count >0)
            {
                dgvLicenseTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvLicenseTestAppointments.Columns[0].Width = 150;

                dgvLicenseTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvLicenseTestAppointments.Columns[1].Width = 200;

                dgvLicenseTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvLicenseTestAppointments.Columns[2].Width = 150;

                dgvLicenseTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvLicenseTestAppointments.Columns[3].Width = 100;
            }
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicneseApplicationID);

            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

            frmScheduleTest frm =
                new frmScheduleTest(_LocalDrivingLicneseApplicationID, _TestType, TestAppointmentID);
            frm.ShowDialog();

            frmListTestAppointments_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvLicenseTestAppointments.CurrentRow.Cells[0].Value;

        }
    }
}

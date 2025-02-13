namespace DVLD.Test.Controls
{
    partial class ctrlScheduleTest
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.gbTestType = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDrivingClass = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicenseAppID = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.gbRetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.lblRetakeAppFees = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRetakeTestAppID = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.gbTestType.SuspendLayout();
            this.gbRetakeTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(146, 201);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Schedule Test";
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(12, 258);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(481, 24);
            this.lblUserMessage.TabIndex = 2;
            this.lblUserMessage.Text = "Cannot Schedule , Vision Test Should be Passed First";
            // 
            // gbTestType
            // 
            this.gbTestType.Controls.Add(this.btnSave);
            this.gbTestType.Controls.Add(this.gbRetakeTestInfo);
            this.gbTestType.Controls.Add(this.dtpTestDate);
            this.gbTestType.Controls.Add(this.lblFees);
            this.gbTestType.Controls.Add(this.lblTrial);
            this.gbTestType.Controls.Add(this.lblFullName);
            this.gbTestType.Controls.Add(this.lblDrivingClass);
            this.gbTestType.Controls.Add(this.lblLocalDrivingLicenseAppID);
            this.gbTestType.Controls.Add(this.label7);
            this.gbTestType.Controls.Add(this.label8);
            this.gbTestType.Controls.Add(this.label5);
            this.gbTestType.Controls.Add(this.label6);
            this.gbTestType.Controls.Add(this.label4);
            this.gbTestType.Controls.Add(this.label3);
            this.gbTestType.Controls.Add(this.pbTestTypeImage);
            this.gbTestType.Controls.Add(this.lblUserMessage);
            this.gbTestType.Controls.Add(this.lblTitle);
            this.gbTestType.Location = new System.Drawing.Point(15, 3);
            this.gbTestType.Name = "gbTestType";
            this.gbTestType.Size = new System.Drawing.Size(499, 742);
            this.gbTestType.TabIndex = 3;
            this.gbTestType.TabStop = false;
            this.gbTestType.Text = "Test Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "D.L.App ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(33, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "D. Class :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(61, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trial :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(51, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(59, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fees :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(58, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date :";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTrial.Location = new System.Drawing.Point(128, 424);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(40, 21);
            this.lblTrial.TabIndex = 12;
            this.lblTrial.Text = "[??]";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFullName.Location = new System.Drawing.Point(128, 388);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(80, 21);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "[???????]";
            // 
            // lblDrivingClass
            // 
            this.lblDrivingClass.AutoSize = true;
            this.lblDrivingClass.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDrivingClass.Location = new System.Drawing.Point(128, 355);
            this.lblDrivingClass.Name = "lblDrivingClass";
            this.lblDrivingClass.Size = new System.Drawing.Size(80, 21);
            this.lblDrivingClass.TabIndex = 10;
            this.lblDrivingClass.Text = "[???????]";
            // 
            // lblLocalDrivingLicenseAppID
            // 
            this.lblLocalDrivingLicenseAppID.AutoSize = true;
            this.lblLocalDrivingLicenseAppID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblLocalDrivingLicenseAppID.Location = new System.Drawing.Point(128, 319);
            this.lblLocalDrivingLicenseAppID.Name = "lblLocalDrivingLicenseAppID";
            this.lblLocalDrivingLicenseAppID.Size = new System.Drawing.Size(40, 21);
            this.lblLocalDrivingLicenseAppID.TabIndex = 9;
            this.lblLocalDrivingLicenseAppID.Text = "[??]";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFees.Location = new System.Drawing.Point(128, 494);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(51, 21);
            this.lblFees.TabIndex = 13;
            this.lblFees.Text = "[$$$]";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTestDate.Location = new System.Drawing.Point(132, 458);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(149, 24);
            this.dtpTestDate.TabIndex = 14;
            // 
            // gbRetakeTestInfo
            // 
            this.gbRetakeTestInfo.Controls.Add(this.lblTotalFees);
            this.gbRetakeTestInfo.Controls.Add(this.label19);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeTestAppID);
            this.gbRetakeTestInfo.Controls.Add(this.label17);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeAppFees);
            this.gbRetakeTestInfo.Controls.Add(this.label15);
            this.gbRetakeTestInfo.Location = new System.Drawing.Point(6, 556);
            this.gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            this.gbRetakeTestInfo.Size = new System.Drawing.Size(487, 113);
            this.gbRetakeTestInfo.TabIndex = 15;
            this.gbRetakeTestInfo.TabStop = false;
            this.gbRetakeTestInfo.Text = "Retake Test Info";
            // 
            // lblRetakeAppFees
            // 
            this.lblRetakeAppFees.AutoSize = true;
            this.lblRetakeAppFees.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRetakeAppFees.Location = new System.Drawing.Point(151, 33);
            this.lblRetakeAppFees.Name = "lblRetakeAppFees";
            this.lblRetakeAppFees.Size = new System.Drawing.Size(51, 21);
            this.lblRetakeAppFees.TabIndex = 18;
            this.lblRetakeAppFees.Text = "[$$$]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.Location = new System.Drawing.Point(27, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 21);
            this.label15.TabIndex = 17;
            this.label15.Text = "R.App.Fees :";
            // 
            // lblRetakeTestAppID
            // 
            this.lblRetakeTestAppID.AutoSize = true;
            this.lblRetakeTestAppID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRetakeTestAppID.Location = new System.Drawing.Point(151, 77);
            this.lblRetakeTestAppID.Name = "lblRetakeTestAppID";
            this.lblRetakeTestAppID.Size = new System.Drawing.Size(40, 21);
            this.lblRetakeTestAppID.TabIndex = 20;
            this.lblRetakeTestAppID.Text = "[??]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label17.Location = new System.Drawing.Point(27, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 21);
            this.label17.TabIndex = 19;
            this.label17.Text = "R.Test.App.ID :";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTotalFees.Location = new System.Drawing.Point(412, 33);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(51, 21);
            this.lblTotalFees.TabIndex = 22;
            this.lblTotalFees.Text = "[$$$]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label19.Location = new System.Drawing.Point(300, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 21);
            this.label19.TabIndex = 21;
            this.label19.Text = "Total Fees :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Image = global::DVLD.Properties.Resources.save_file_10057642__1_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(391, 675);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 53);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.Image = global::DVLD.Properties.Resources.icons8_writing_down_48;
            this.pbTestTypeImage.Location = new System.Drawing.Point(152, 23);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(190, 163);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTestTypeImage.TabIndex = 0;
            this.pbTestTypeImage.TabStop = false;
            // 
            // crlScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTestType);
            this.Name = "crlScheduleTest";
            this.Size = new System.Drawing.Size(529, 761);
            this.gbTestType.ResumeLayout(false);
            this.gbTestType.PerformLayout();
            this.gbRetakeTestInfo.ResumeLayout(false);
            this.gbRetakeTestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.GroupBox gbTestType;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDrivingClass;
        private System.Windows.Forms.Label lblLocalDrivingLicenseAppID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbRetakeTestInfo;
        private System.Windows.Forms.Label lblRetakeAppFees;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblRetakeTestAppID;
        private System.Windows.Forms.Label label17;
    }
}

namespace DVLD.Test
{
    partial class frmTakeTest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlSecheduledTest1 = new DVLD.Test.Controls.ctrlSecheduledTest();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlSecheduledTest1
            // 
            this.ctrlSecheduledTest1.Location = new System.Drawing.Point(7, 12);
            this.ctrlSecheduledTest1.Name = "ctrlSecheduledTest1";
            this.ctrlSecheduledTest1.Size = new System.Drawing.Size(463, 530);
            this.ctrlSecheduledTest1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(27, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result :";
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbPass.Location = new System.Drawing.Point(101, 543);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(65, 25);
            this.rbPass.TabIndex = 2;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbFail.Location = new System.Drawing.Point(172, 543);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(57, 25);
            this.rbFail.TabIndex = 3;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(27, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notes :";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(97, 580);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(350, 76);
            this.txtNotes.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.Image = global::DVLD.Properties.Resources.cancel_189678;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(237, 662);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 42);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.Image = global::DVLD.Properties.Resources.save_file_10057642__1_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(345, 662);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(238, 547);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(214, 18);
            this.lblUserMessage.TabIndex = 20;
            this.lblUserMessage.Text = "You Cannot Change The Result";
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 712);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlSecheduledTest1);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlSecheduledTest ctrlSecheduledTest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserMessage;
    }
}
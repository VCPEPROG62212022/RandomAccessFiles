namespace RandomAccessFile
{
    partial class frmStudent
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAssign = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRecordNum = new System.Windows.Forms.Label();
            this.lblStudNum = new System.Windows.Forms.Label();
            this.btnSearchRec = new System.Windows.Forms.Button();
            this.btnSearchNum = new System.Windows.Forms.Button();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.txtStudNum = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 41);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(87, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Student Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student Name:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 126);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Test Result:";
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Location = new System.Drawing.Point(12, 169);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(97, 13);
            this.lblAssign.TabIndex = 3;
            this.lblAssign.Text = "Assignment Result:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(124, 41);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(124, 126);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 20);
            this.txtTest.TabIndex = 6;
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(124, 169);
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(100, 20);
            this.txtAssignment.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(124, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRecordNum
            // 
            this.lblRecordNum.AutoSize = true;
            this.lblRecordNum.Location = new System.Drawing.Point(230, 44);
            this.lblRecordNum.Name = "lblRecordNum";
            this.lblRecordNum.Size = new System.Drawing.Size(113, 13);
            this.lblRecordNum.TabIndex = 9;
            this.lblRecordNum.Text = "Enter Record Number:";
            // 
            // lblStudNum
            // 
            this.lblStudNum.AutoSize = true;
            this.lblStudNum.Location = new System.Drawing.Point(230, 129);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(115, 13);
            this.lblStudNum.TabIndex = 10;
            this.lblStudNum.Text = "Enter Student Number:";
            // 
            // btnSearchRec
            // 
            this.btnSearchRec.Location = new System.Drawing.Point(354, 67);
            this.btnSearchRec.Name = "btnSearchRec";
            this.btnSearchRec.Size = new System.Drawing.Size(116, 23);
            this.btnSearchRec.TabIndex = 11;
            this.btnSearchRec.Text = "SEARCH";
            this.btnSearchRec.UseVisualStyleBackColor = true;
            this.btnSearchRec.Click += new System.EventHandler(this.btnSearchRec_Click);
            // 
            // btnSearchNum
            // 
            this.btnSearchNum.Location = new System.Drawing.Point(354, 149);
            this.btnSearchNum.Name = "btnSearchNum";
            this.btnSearchNum.Size = new System.Drawing.Size(116, 23);
            this.btnSearchNum.TabIndex = 12;
            this.btnSearchNum.Text = "SEARCH";
            this.btnSearchNum.UseVisualStyleBackColor = true;
            this.btnSearchNum.Click += new System.EventHandler(this.btnSearchNum_Click);
            // 
            // txtRecord
            // 
            this.txtRecord.Location = new System.Drawing.Point(354, 41);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(116, 20);
            this.txtRecord.TabIndex = 13;
            // 
            // txtStudNum
            // 
            this.txtStudNum.Location = new System.Drawing.Point(354, 123);
            this.txtStudNum.Name = "txtStudNum";
            this.txtStudNum.Size = new System.Drawing.Size(116, 20);
            this.txtStudNum.TabIndex = 14;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(248, 178);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(222, 23);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "SHOW ALL";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.Location = new System.Drawing.Point(248, 209);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(222, 147);
            this.lstReport.TabIndex = 16;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 371);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtStudNum);
            this.Controls.Add(this.txtRecord);
            this.Controls.Add(this.btnSearchNum);
            this.Controls.Add(this.btnSearchRec);
            this.Controls.Add(this.lblStudNum);
            this.Controls.Add(this.lblRecordNum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblAssign);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmStudent";
            this.Text = "Student Form (Random Access Files)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAssign;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRecordNum;
        private System.Windows.Forms.Label lblStudNum;
        private System.Windows.Forms.Button btnSearchRec;
        private System.Windows.Forms.Button btnSearchNum;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.TextBox txtStudNum;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lstReport;
    }
}


namespace School_Management_System.UI.Student
{
    partial class StudentCreateForm
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
            this.btnStdCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStdcrtphoneNo = new System.Windows.Forms.TextBox();
            this.cmbStdCrtMedium = new System.Windows.Forms.ComboBox();
            this.dtpStdCrtAddDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStdcrtDoB = new System.Windows.Forms.DateTimePicker();
            this.rdoStdCrtMale = new System.Windows.Forms.RadioButton();
            this.rdoStdCrtFemale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labStuCrtGender = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStdcrtaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStdcrtNic = new System.Windows.Forms.TextBox();
            this.txtStdCrtGrdId = new System.Windows.Forms.TextBox();
            this.txtStdcrtLname = new System.Windows.Forms.TextBox();
            this.txtStdcrtfullName = new System.Windows.Forms.TextBox();
            this.txtStdcrtfname = new System.Windows.Forms.TextBox();
            this.txtStdcrtAddmisNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStdcrtCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStdCreate
            // 
            this.btnStdCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStdCreate.BackColor = System.Drawing.SystemColors.Control;
            this.btnStdCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdCreate.Location = new System.Drawing.Point(228, 18);
            this.btnStdCreate.Name = "btnStdCreate";
            this.btnStdCreate.Size = new System.Drawing.Size(105, 45);
            this.btnStdCreate.TabIndex = 14;
            this.btnStdCreate.Text = "Save";
            this.btnStdCreate.UseVisualStyleBackColor = false;
            this.btnStdCreate.Click += new System.EventHandler(this.btnStdCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStdcrtphoneNo);
            this.groupBox1.Controls.Add(this.cmbStdCrtMedium);
            this.groupBox1.Controls.Add(this.dtpStdCrtAddDate);
            this.groupBox1.Controls.Add(this.dtpStdcrtDoB);
            this.groupBox1.Controls.Add(this.rdoStdCrtMale);
            this.groupBox1.Controls.Add(this.rdoStdCrtFemale);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labStuCrtGender);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStdcrtaddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStdcrtNic);
            this.groupBox1.Controls.Add(this.txtStdCrtGrdId);
            this.groupBox1.Controls.Add(this.txtStdcrtLname);
            this.groupBox1.Controls.Add(this.txtStdcrtfullName);
            this.groupBox1.Controls.Add(this.txtStdcrtfname);
            this.groupBox1.Controls.Add(this.txtStdcrtAddmisNo);
            this.groupBox1.Location = new System.Drawing.Point(4, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 565);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtStdcrtphoneNo
            // 
            this.txtStdcrtphoneNo.Location = new System.Drawing.Point(172, 323);
            this.txtStdcrtphoneNo.Multiline = true;
            this.txtStdcrtphoneNo.Name = "txtStdcrtphoneNo";
            this.txtStdcrtphoneNo.Size = new System.Drawing.Size(273, 36);
            this.txtStdcrtphoneNo.TabIndex = 9;
            // 
            // cmbStdCrtMedium
            // 
            this.cmbStdCrtMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStdCrtMedium.FormattingEnabled = true;
            this.cmbStdCrtMedium.Items.AddRange(new object[] {
            "Tamil",
            "English",
            "Sinhala"});
            this.cmbStdCrtMedium.Location = new System.Drawing.Point(172, 408);
            this.cmbStdCrtMedium.Name = "cmbStdCrtMedium";
            this.cmbStdCrtMedium.Size = new System.Drawing.Size(272, 33);
            this.cmbStdCrtMedium.TabIndex = 11;
            // 
            // dtpStdCrtAddDate
            // 
            this.dtpStdCrtAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStdCrtAddDate.Location = new System.Drawing.Point(172, 449);
            this.dtpStdCrtAddDate.Name = "dtpStdCrtAddDate";
            this.dtpStdCrtAddDate.Size = new System.Drawing.Size(272, 30);
            this.dtpStdCrtAddDate.TabIndex = 12;
            // 
            // dtpStdcrtDoB
            // 
            this.dtpStdcrtDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStdcrtDoB.Location = new System.Drawing.Point(172, 235);
            this.dtpStdcrtDoB.Name = "dtpStdcrtDoB";
            this.dtpStdcrtDoB.Size = new System.Drawing.Size(272, 30);
            this.dtpStdcrtDoB.TabIndex = 7;
            // 
            // rdoStdCrtMale
            // 
            this.rdoStdCrtMale.Location = new System.Drawing.Point(172, 192);
            this.rdoStdCrtMale.Name = "rdoStdCrtMale";
            this.rdoStdCrtMale.Size = new System.Drawing.Size(84, 35);
            this.rdoStdCrtMale.TabIndex = 5;
            this.rdoStdCrtMale.TabStop = true;
            this.rdoStdCrtMale.Text = "Male";
            this.rdoStdCrtMale.UseVisualStyleBackColor = true;
            // 
            // rdoStdCrtFemale
            // 
            this.rdoStdCrtFemale.Location = new System.Drawing.Point(279, 192);
            this.rdoStdCrtFemale.Name = "rdoStdCrtFemale";
            this.rdoStdCrtFemale.Size = new System.Drawing.Size(114, 35);
            this.rdoStdCrtFemale.TabIndex = 6;
            this.rdoStdCrtFemale.TabStop = true;
            this.rdoStdCrtFemale.Text = "Female";
            this.rdoStdCrtFemale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 495);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Addimission Date";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "DOB";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "NIC Number";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "Medium";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Grade ID";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // labStuCrtGender
            // 
            this.labStuCrtGender.BackColor = System.Drawing.Color.White;
            this.labStuCrtGender.Location = new System.Drawing.Point(8, 192);
            this.labStuCrtGender.Name = "labStuCrtGender";
            this.labStuCrtGender.Size = new System.Drawing.Size(152, 26);
            this.labStuCrtGender.TabIndex = 2;
            this.labStuCrtGender.Text = "Gender";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name";
            // 
            // txtStdcrtaddress
            // 
            this.txtStdcrtaddress.Location = new System.Drawing.Point(172, 489);
            this.txtStdcrtaddress.Multiline = true;
            this.txtStdcrtaddress.Name = "txtStdcrtaddress";
            this.txtStdcrtaddress.Size = new System.Drawing.Size(272, 66);
            this.txtStdcrtaddress.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Addmission No";
            // 
            // txtStdcrtNic
            // 
            this.txtStdcrtNic.Location = new System.Drawing.Point(172, 277);
            this.txtStdcrtNic.Multiline = true;
            this.txtStdcrtNic.Name = "txtStdcrtNic";
            this.txtStdcrtNic.Size = new System.Drawing.Size(272, 35);
            this.txtStdcrtNic.TabIndex = 8;
            // 
            // txtStdCrtGrdId
            // 
            this.txtStdCrtGrdId.Location = new System.Drawing.Point(172, 365);
            this.txtStdCrtGrdId.Multiline = true;
            this.txtStdCrtGrdId.Name = "txtStdCrtGrdId";
            this.txtStdCrtGrdId.Size = new System.Drawing.Size(272, 35);
            this.txtStdCrtGrdId.TabIndex = 10;
            // 
            // txtStdcrtLname
            // 
            this.txtStdcrtLname.Location = new System.Drawing.Point(172, 108);
            this.txtStdcrtLname.Multiline = true;
            this.txtStdcrtLname.Name = "txtStdcrtLname";
            this.txtStdcrtLname.Size = new System.Drawing.Size(272, 35);
            this.txtStdcrtLname.TabIndex = 3;
            // 
            // txtStdcrtfullName
            // 
            this.txtStdcrtfullName.Location = new System.Drawing.Point(172, 151);
            this.txtStdcrtfullName.Multiline = true;
            this.txtStdcrtfullName.Name = "txtStdcrtfullName";
            this.txtStdcrtfullName.Size = new System.Drawing.Size(272, 35);
            this.txtStdcrtfullName.TabIndex = 4;
            // 
            // txtStdcrtfname
            // 
            this.txtStdcrtfname.Location = new System.Drawing.Point(172, 65);
            this.txtStdcrtfname.Multiline = true;
            this.txtStdcrtfname.Name = "txtStdcrtfname";
            this.txtStdcrtfname.Size = new System.Drawing.Size(272, 35);
            this.txtStdcrtfname.TabIndex = 2;
            // 
            // txtStdcrtAddmisNo
            // 
            this.txtStdcrtAddmisNo.Location = new System.Drawing.Point(172, 22);
            this.txtStdcrtAddmisNo.Multiline = true;
            this.txtStdcrtAddmisNo.Name = "txtStdcrtAddmisNo";
            this.txtStdcrtAddmisNo.Size = new System.Drawing.Size(272, 35);
            this.txtStdcrtAddmisNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Create";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStdcrtCancel);
            this.groupBox2.Controls.Add(this.btnStdCreate);
            this.groupBox2.Location = new System.Drawing.Point(4, 615);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnStdcrtCancel
            // 
            this.btnStdcrtCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStdcrtCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnStdcrtCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdcrtCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStdcrtCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdcrtCancel.Location = new System.Drawing.Point(339, 18);
            this.btnStdcrtCancel.Name = "btnStdcrtCancel";
            this.btnStdcrtCancel.Size = new System.Drawing.Size(106, 45);
            this.btnStdcrtCancel.TabIndex = 15;
            this.btnStdcrtCancel.Text = "Cancel";
            this.btnStdcrtCancel.UseVisualStyleBackColor = false;
            this.btnStdcrtCancel.Click += new System.EventHandler(this.btnStdcrtCancel_Click);
            // 
            // StudentCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 691);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "StudentCreateForm";
            this.Text = "StudentCreateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStdCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStdcrtAddmisNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStdcrtCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStdcrtLname;
        private System.Windows.Forms.TextBox txtStdcrtfname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labStuCrtGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStdcrtNic;
        private System.Windows.Forms.TextBox txtStdcrtfullName;
        private System.Windows.Forms.RadioButton rdoStdCrtFemale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStdcrtaddress;
        private System.Windows.Forms.RadioButton rdoStdCrtMale;
        private System.Windows.Forms.ComboBox cmbStdCrtMedium;
        private System.Windows.Forms.DateTimePicker dtpStdcrtDoB;
        private System.Windows.Forms.DateTimePicker dtpStdCrtAddDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStdCrtGrdId;
        private System.Windows.Forms.TextBox txtStdcrtphoneNo;
    }
}
﻿namespace School_Management_System.UI.Student
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStdcrtLname = new System.Windows.Forms.TextBox();
            this.btnStdcrtfname = new System.Windows.Forms.TextBox();
            this.btnStdcrtAddmisNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStdcrtCancel = new System.Windows.Forms.Button();
            this.btnStdcrtfullName = new System.Windows.Forms.TextBox();
            this.btnStdcrtNic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStdcrtphoneNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStdcrtaddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rdoStdCrtFemale = new System.Windows.Forms.RadioButton();
            this.rdoStdCrtMale = new System.Windows.Forms.RadioButton();
            this.dtpStdcrtDoB = new System.Windows.Forms.DateTimePicker();
            this.cmbStdCrtGrdId = new System.Windows.Forms.ComboBox();
            this.dtpStdCrtAddDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStdCreate
            // 
            this.btnStdCreate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStdCreate.Location = new System.Drawing.Point(278, 20);
            this.btnStdCreate.Name = "btnStdCreate";
            this.btnStdCreate.Size = new System.Drawing.Size(75, 40);
            this.btnStdCreate.TabIndex = 0;
            this.btnStdCreate.Text = "Save";
            this.btnStdCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStdCrtGrdId);
            this.groupBox1.Controls.Add(this.dtpStdCrtAddDate);
            this.groupBox1.Controls.Add(this.dtpStdcrtDoB);
            this.groupBox1.Controls.Add(this.rdoStdCrtMale);
            this.groupBox1.Controls.Add(this.rdoStdCrtFemale);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnStdcrtaddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnStdcrtNic);
            this.groupBox1.Controls.Add(this.btnStdcrtphoneNo);
            this.groupBox1.Controls.Add(this.btnStdcrtLname);
            this.groupBox1.Controls.Add(this.btnStdcrtfullName);
            this.groupBox1.Controls.Add(this.btnStdcrtfname);
            this.groupBox1.Controls.Add(this.btnStdcrtAddmisNo);
            this.groupBox1.Location = new System.Drawing.Point(5, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 512);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Addmission No";
            // 
            // btnStdcrtLname
            // 
            this.btnStdcrtLname.Location = new System.Drawing.Point(172, 107);
            this.btnStdcrtLname.Multiline = true;
            this.btnStdcrtLname.Name = "btnStdcrtLname";
            this.btnStdcrtLname.Size = new System.Drawing.Size(272, 35);
            this.btnStdcrtLname.TabIndex = 3;
            // 
            // btnStdcrtfname
            // 
            this.btnStdcrtfname.Location = new System.Drawing.Point(172, 64);
            this.btnStdcrtfname.Multiline = true;
            this.btnStdcrtfname.Name = "btnStdcrtfname";
            this.btnStdcrtfname.Size = new System.Drawing.Size(272, 35);
            this.btnStdcrtfname.TabIndex = 3;
            // 
            // btnStdcrtAddmisNo
            // 
            this.btnStdcrtAddmisNo.Location = new System.Drawing.Point(172, 21);
            this.btnStdcrtAddmisNo.Multiline = true;
            this.btnStdcrtAddmisNo.Name = "btnStdcrtAddmisNo";
            this.btnStdcrtAddmisNo.Size = new System.Drawing.Size(272, 35);
            this.btnStdcrtAddmisNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Create";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStdcrtCancel);
            this.groupBox2.Controls.Add(this.btnStdCreate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnStdcrtCancel
            // 
            this.btnStdcrtCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStdcrtCancel.Location = new System.Drawing.Point(369, 20);
            this.btnStdcrtCancel.Name = "btnStdcrtCancel";
            this.btnStdcrtCancel.Size = new System.Drawing.Size(75, 40);
            this.btnStdcrtCancel.TabIndex = 0;
            this.btnStdcrtCancel.Text = "Cancel";
            this.btnStdcrtCancel.UseVisualStyleBackColor = true;
            // 
            // btnStdcrtfullName
            // 
            this.btnStdcrtfullName.Location = new System.Drawing.Point(172, 150);
            this.btnStdcrtfullName.Multiline = true;
            this.btnStdcrtfullName.Name = "btnStdcrtfullName";
            this.btnStdcrtfullName.Size = new System.Drawing.Size(272, 35);
            this.btnStdcrtfullName.TabIndex = 3;
            // 
            // btnStdcrtNic
            // 
            this.btnStdcrtNic.Location = new System.Drawing.Point(172, 275);
            this.btnStdcrtNic.Multiline = true;
            this.btnStdcrtNic.Name = "btnStdcrtNic";
            this.btnStdcrtNic.Size = new System.Drawing.Size(272, 35);
            this.btnStdcrtNic.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Full Name";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 35);
            this.label7.TabIndex = 2;
            this.label7.Text = "DOB";
            // 
            // btnStdcrtphoneNo
            // 
            this.btnStdcrtphoneNo.Location = new System.Drawing.Point(172, 322);
            this.btnStdcrtphoneNo.Multiline = true;
            this.btnStdcrtphoneNo.Name = "btnStdcrtphoneNo";
            this.btnStdcrtphoneNo.Size = new System.Drawing.Size(272, 35);
            this.btnStdcrtphoneNo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 35);
            this.label8.TabIndex = 2;
            this.label8.Text = "Phone No";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 35);
            this.label9.TabIndex = 2;
            this.label9.Text = "Grade ID";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 35);
            this.label10.TabIndex = 2;
            this.label10.Text = "NIC Number";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 35);
            this.label11.TabIndex = 2;
            this.label11.Text = "Addimission Date";
            // 
            // btnStdcrtaddress
            // 
            this.btnStdcrtaddress.Location = new System.Drawing.Point(172, 445);
            this.btnStdcrtaddress.Multiline = true;
            this.btnStdcrtaddress.Name = "btnStdcrtaddress";
            this.btnStdcrtaddress.Size = new System.Drawing.Size(272, 65);
            this.btnStdcrtaddress.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 35);
            this.label12.TabIndex = 2;
            this.label12.Text = "Address";
            // 
            // rdoStdCrtFemale
            // 
            this.rdoStdCrtFemale.Location = new System.Drawing.Point(279, 193);
            this.rdoStdCrtFemale.Name = "rdoStdCrtFemale";
            this.rdoStdCrtFemale.Size = new System.Drawing.Size(99, 35);
            this.rdoStdCrtFemale.TabIndex = 4;
            this.rdoStdCrtFemale.TabStop = true;
            this.rdoStdCrtFemale.Text = "Female";
            this.rdoStdCrtFemale.UseVisualStyleBackColor = true;
            // 
            // rdoStdCrtMale
            // 
            this.rdoStdCrtMale.Location = new System.Drawing.Point(172, 193);
            this.rdoStdCrtMale.Name = "rdoStdCrtMale";
            this.rdoStdCrtMale.Size = new System.Drawing.Size(84, 35);
            this.rdoStdCrtMale.TabIndex = 4;
            this.rdoStdCrtMale.TabStop = true;
            this.rdoStdCrtMale.Text = "Male";
            this.rdoStdCrtMale.UseVisualStyleBackColor = true;
            // 
            // dtpStdcrtDoB
            // 
            this.dtpStdcrtDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStdcrtDoB.Location = new System.Drawing.Point(172, 236);
            this.dtpStdcrtDoB.Name = "dtpStdcrtDoB";
            this.dtpStdcrtDoB.Size = new System.Drawing.Size(272, 30);
            this.dtpStdcrtDoB.TabIndex = 5;
            // 
            // cmbStdCrtGrdId
            // 
            this.cmbStdCrtGrdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStdCrtGrdId.FormattingEnabled = true;
            this.cmbStdCrtGrdId.Location = new System.Drawing.Point(172, 365);
            this.cmbStdCrtGrdId.Name = "cmbStdCrtGrdId";
            this.cmbStdCrtGrdId.Size = new System.Drawing.Size(272, 33);
            this.cmbStdCrtGrdId.TabIndex = 6;
            // 
            // dtpStdCrtAddDate
            // 
            this.dtpStdCrtAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStdCrtAddDate.Location = new System.Drawing.Point(172, 408);
            this.dtpStdCrtAddDate.Name = "dtpStdCrtAddDate";
            this.dtpStdCrtAddDate.Size = new System.Drawing.Size(272, 30);
            this.dtpStdCrtAddDate.TabIndex = 5;
            // 
            // StudentCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
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
        private System.Windows.Forms.TextBox btnStdcrtAddmisNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStdcrtCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btnStdcrtLname;
        private System.Windows.Forms.TextBox btnStdcrtfname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btnStdcrtNic;
        private System.Windows.Forms.TextBox btnStdcrtphoneNo;
        private System.Windows.Forms.TextBox btnStdcrtfullName;
        private System.Windows.Forms.RadioButton rdoStdCrtFemale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox btnStdcrtaddress;
        private System.Windows.Forms.RadioButton rdoStdCrtMale;
        private System.Windows.Forms.ComboBox cmbStdCrtGrdId;
        private System.Windows.Forms.DateTimePicker dtpStdcrtDoB;
        private System.Windows.Forms.DateTimePicker dtpStdCrtAddDate;
    }
}
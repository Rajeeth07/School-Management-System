namespace School_Management_System.UI
{
    partial class DashboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStdDashStudent = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStdDashGrade = new System.Windows.Forms.Button();
            this.btnStdDashSubject = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "School Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnStdDashStudent);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnStdDashGrade);
            this.groupBox1.Controls.Add(this.btnStdDashSubject);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Grade Detail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Detail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Detail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.graduated1;
            this.pictureBox1.Location = new System.Drawing.Point(125, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStdDashStudent
            // 
            this.btnStdDashStudent.BackColor = System.Drawing.Color.Teal;
            this.btnStdDashStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdDashStudent.ForeColor = System.Drawing.Color.White;
            this.btnStdDashStudent.Image = global::School_Management_System.Properties.Resources._09876;
            this.btnStdDashStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdDashStudent.Location = new System.Drawing.Point(167, 118);
            this.btnStdDashStudent.Name = "btnStdDashStudent";
            this.btnStdDashStudent.Size = new System.Drawing.Size(141, 38);
            this.btnStdDashStudent.TabIndex = 1;
            this.btnStdDashStudent.Text = "Student ";
            this.btnStdDashStudent.UseVisualStyleBackColor = false;
            this.btnStdDashStudent.Click += new System.EventHandler(this.btnStdDashStudent_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::School_Management_System.Properties.Resources._09876543;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(230, 272);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 33);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStdDashGrade
            // 
            this.btnStdDashGrade.BackColor = System.Drawing.Color.Teal;
            this.btnStdDashGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdDashGrade.ForeColor = System.Drawing.Color.White;
            this.btnStdDashGrade.Image = global::School_Management_System.Properties.Resources._34;
            this.btnStdDashGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdDashGrade.Location = new System.Drawing.Point(167, 210);
            this.btnStdDashGrade.Name = "btnStdDashGrade";
            this.btnStdDashGrade.Size = new System.Drawing.Size(141, 38);
            this.btnStdDashGrade.TabIndex = 3;
            this.btnStdDashGrade.Text = "Grade";
            this.btnStdDashGrade.UseVisualStyleBackColor = false;
            this.btnStdDashGrade.Click += new System.EventHandler(this.btnStdDashGrade_Click);
            // 
            // btnStdDashSubject
            // 
            this.btnStdDashSubject.BackColor = System.Drawing.Color.Teal;
            this.btnStdDashSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdDashSubject.ForeColor = System.Drawing.Color.White;
            this.btnStdDashSubject.Image = global::School_Management_System.Properties.Resources._23e;
            this.btnStdDashSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdDashSubject.Location = new System.Drawing.Point(167, 164);
            this.btnStdDashSubject.Name = "btnStdDashSubject";
            this.btnStdDashSubject.Size = new System.Drawing.Size(141, 38);
            this.btnStdDashSubject.TabIndex = 2;
            this.btnStdDashSubject.Text = "Subject";
            this.btnStdDashSubject.UseVisualStyleBackColor = false;
            this.btnStdDashSubject.Click += new System.EventHandler(this.btnStdDashSubject_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(373, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStdDashGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStdDashSubject;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStdDashStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
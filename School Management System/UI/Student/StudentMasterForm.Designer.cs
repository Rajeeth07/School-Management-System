namespace School_Management_System.UI.Student
{
    partial class StudentMasterForm
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
            this.btnStdExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStuSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStdRefresh = new System.Windows.Forms.Button();
            this.btnStdDelete = new System.Windows.Forms.Button();
            this.btnStdAdd = new System.Windows.Forms.Button();
            this.btnStdEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStdExit
            // 
            this.btnStdExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdExit.Image = global::School_Management_System.Properties.Resources.Back_removebg_preview;
            this.btnStdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdExit.Location = new System.Drawing.Point(517, 12);
            this.btnStdExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdExit.Name = "btnStdExit";
            this.btnStdExit.Size = new System.Drawing.Size(60, 31);
            this.btnStdExit.TabIndex = 0;
            this.btnStdExit.Text = "Exit";
            this.btnStdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStdExit.UseVisualStyleBackColor = false;
            this.btnStdExit.Click += new System.EventHandler(this.btnStdExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStd
            // 
            this.dgvStd.AllowUserToAddRows = false;
            this.dgvStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStd.Location = new System.Drawing.Point(4, 42);
            this.dgvStd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStd.Name = "dgvStd";
            this.dgvStd.RowHeadersWidth = 62;
            this.dgvStd.RowTemplate.Height = 28;
            this.dgvStd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStd.Size = new System.Drawing.Size(579, 184);
            this.dgvStd.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStuSearch);
            this.groupBox1.Controls.Add(this.dgvStd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(593, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Image = global::School_Management_System.Properties.Resources.search_icon_sl7;
            this.label2.Location = new System.Drawing.Point(363, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 4;
            // 
            // txtStuSearch
            // 
            this.txtStuSearch.Location = new System.Drawing.Point(389, 15);
            this.txtStuSearch.Multiline = true;
            this.txtStuSearch.Name = "txtStuSearch";
            this.txtStuSearch.Size = new System.Drawing.Size(192, 25);
            this.txtStuSearch.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStdRefresh);
            this.groupBox2.Controls.Add(this.btnStdDelete);
            this.groupBox2.Controls.Add(this.btnStdAdd);
            this.groupBox2.Controls.Add(this.btnStdEdit);
            this.groupBox2.Controls.Add(this.btnStdExit);
            this.groupBox2.Location = new System.Drawing.Point(-1, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(583, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnStdRefresh
            // 
            this.btnStdRefresh.BackColor = System.Drawing.Color.Black;
            this.btnStdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdRefresh.ForeColor = System.Drawing.Color.White;
            this.btnStdRefresh.Image = global::School_Management_System.Properties.Resources._360_F_603559966_0VO4rK4OyPO4i89jEDfH1XEbI5fQDaCK_removebg_preview1;
            this.btnStdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdRefresh.Location = new System.Drawing.Point(222, 12);
            this.btnStdRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdRefresh.Name = "btnStdRefresh";
            this.btnStdRefresh.Size = new System.Drawing.Size(84, 31);
            this.btnStdRefresh.TabIndex = 0;
            this.btnStdRefresh.Text = "Refresh";
            this.btnStdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStdRefresh.UseVisualStyleBackColor = false;
            // 
            // btnStdDelete
            // 
            this.btnStdDelete.BackColor = System.Drawing.Color.White;
            this.btnStdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdDelete.ForeColor = System.Drawing.Color.Red;
            this.btnStdDelete.Image = global::School_Management_System.Properties.Resources._11;
            this.btnStdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdDelete.Location = new System.Drawing.Point(310, 12);
            this.btnStdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdDelete.Name = "btnStdDelete";
            this.btnStdDelete.Size = new System.Drawing.Size(75, 31);
            this.btnStdDelete.TabIndex = 0;
            this.btnStdDelete.Text = "Delete";
            this.btnStdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStdDelete.UseVisualStyleBackColor = false;
            // 
            // btnStdAdd
            // 
            this.btnStdAdd.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdAdd.ForeColor = System.Drawing.Color.White;
            this.btnStdAdd.Image = global::School_Management_System.Properties.Resources.add_icocons__softiconsm_5;
            this.btnStdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdAdd.Location = new System.Drawing.Point(389, 12);
            this.btnStdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdAdd.Name = "btnStdAdd";
            this.btnStdAdd.Size = new System.Drawing.Size(60, 31);
            this.btnStdAdd.TabIndex = 0;
            this.btnStdAdd.Text = "Add";
            this.btnStdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStdAdd.UseVisualStyleBackColor = false;
            this.btnStdAdd.Click += new System.EventHandler(this.btnStdAdd_Click);
            // 
            // btnStdEdit
            // 
            this.btnStdEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdEdit.ForeColor = System.Drawing.Color.White;
            this.btnStdEdit.Image = global::School_Management_System.Properties.Resources.image1111s__1__removebg_preview;
            this.btnStdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEdit.Location = new System.Drawing.Point(453, 12);
            this.btnStdEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEdit.Name = "btnStdEdit";
            this.btnStdEdit.Size = new System.Drawing.Size(60, 31);
            this.btnStdEdit.TabIndex = 0;
            this.btnStdEdit.Text = "Edit";
            this.btnStdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStdEdit.UseVisualStyleBackColor = false;
            this.btnStdEdit.Click += new System.EventHandler(this.btnStdEdit_Click);
            // 
            // StudentMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(593, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentMasterForm";
            this.Text = "StudentMasterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentMasterForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentMasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStdExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStdRefresh;
        private System.Windows.Forms.Button btnStdDelete;
        private System.Windows.Forms.Button btnStdAdd;
        private System.Windows.Forms.Button btnStdEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStuSearch;
    }
}
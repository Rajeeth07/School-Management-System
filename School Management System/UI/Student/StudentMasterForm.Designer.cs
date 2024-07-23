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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStdRefresh = new System.Windows.Forms.Button();
            this.btnStdDelete = new System.Windows.Forms.Button();
            this.btnStdAdd = new System.Windows.Forms.Button();
            this.btnStdEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStdExit
            // 
            this.btnStdExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdExit.Location = new System.Drawing.Point(512, 12);
            this.btnStdExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdExit.Name = "btnStdExit";
            this.btnStdExit.Size = new System.Drawing.Size(65, 31);
            this.btnStdExit.TabIndex = 0;
            this.btnStdExit.Text = "Exit";
            this.btnStdExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(583, 218);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(582, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            this.btnStdRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdRefresh.Location = new System.Drawing.Point(235, 12);
            this.btnStdRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdRefresh.Name = "btnStdRefresh";
            this.btnStdRefresh.Size = new System.Drawing.Size(65, 31);
            this.btnStdRefresh.TabIndex = 0;
            this.btnStdRefresh.Text = "Refresh";
            this.btnStdRefresh.UseVisualStyleBackColor = false;
            // 
            // btnStdDelete
            // 
            this.btnStdDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdDelete.Location = new System.Drawing.Point(304, 12);
            this.btnStdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdDelete.Name = "btnStdDelete";
            this.btnStdDelete.Size = new System.Drawing.Size(65, 31);
            this.btnStdDelete.TabIndex = 0;
            this.btnStdDelete.Text = "Delete";
            this.btnStdDelete.UseVisualStyleBackColor = false;
            // 
            // btnStdAdd
            // 
            this.btnStdAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdAdd.Location = new System.Drawing.Point(373, 12);
            this.btnStdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdAdd.Name = "btnStdAdd";
            this.btnStdAdd.Size = new System.Drawing.Size(65, 31);
            this.btnStdAdd.TabIndex = 0;
            this.btnStdAdd.Text = "Add";
            this.btnStdAdd.UseVisualStyleBackColor = false;
            this.btnStdAdd.Click += new System.EventHandler(this.btnStdAdd_Click);
            // 
            // btnStdEdit
            // 
            this.btnStdEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStdEdit.Location = new System.Drawing.Point(443, 12);
            this.btnStdEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnStdEdit.Name = "btnStdEdit";
            this.btnStdEdit.Size = new System.Drawing.Size(65, 31);
            this.btnStdEdit.TabIndex = 0;
            this.btnStdEdit.Text = "Edit";
            this.btnStdEdit.UseVisualStyleBackColor = false;
            this.btnStdEdit.Click += new System.EventHandler(this.btnStdEdit_Click);
            // 
            // StudentMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentMasterForm";
            this.Text = "StudentMasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStdExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStdRefresh;
        private System.Windows.Forms.Button btnStdDelete;
        private System.Windows.Forms.Button btnStdAdd;
        private System.Windows.Forms.Button btnStdEdit;
    }
}
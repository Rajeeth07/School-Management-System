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
            this.btnStdExit.Location = new System.Drawing.Point(768, 19);
            this.btnStdExit.Name = "btnStdExit";
            this.btnStdExit.Size = new System.Drawing.Size(98, 48);
            this.btnStdExit.TabIndex = 0;
            this.btnStdExit.Text = "Exit";
            this.btnStdExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(874, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 347);
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
            this.groupBox2.Location = new System.Drawing.Point(-1, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnStdRefresh
            // 
            this.btnStdRefresh.Location = new System.Drawing.Point(352, 19);
            this.btnStdRefresh.Name = "btnStdRefresh";
            this.btnStdRefresh.Size = new System.Drawing.Size(98, 48);
            this.btnStdRefresh.TabIndex = 0;
            this.btnStdRefresh.Text = "Refresh";
            this.btnStdRefresh.UseVisualStyleBackColor = true;
            // 
            // btnStdDelete
            // 
            this.btnStdDelete.Location = new System.Drawing.Point(456, 19);
            this.btnStdDelete.Name = "btnStdDelete";
            this.btnStdDelete.Size = new System.Drawing.Size(98, 48);
            this.btnStdDelete.TabIndex = 0;
            this.btnStdDelete.Text = "Delete";
            this.btnStdDelete.UseVisualStyleBackColor = true;
            // 
            // btnStdAdd
            // 
            this.btnStdAdd.Location = new System.Drawing.Point(560, 19);
            this.btnStdAdd.Name = "btnStdAdd";
            this.btnStdAdd.Size = new System.Drawing.Size(98, 48);
            this.btnStdAdd.TabIndex = 0;
            this.btnStdAdd.Text = "Add";
            this.btnStdAdd.UseVisualStyleBackColor = true;
            // 
            // btnStdEdit
            // 
            this.btnStdEdit.Location = new System.Drawing.Point(664, 19);
            this.btnStdEdit.Name = "btnStdEdit";
            this.btnStdEdit.Size = new System.Drawing.Size(98, 48);
            this.btnStdEdit.TabIndex = 0;
            this.btnStdEdit.Text = "Edit";
            this.btnStdEdit.UseVisualStyleBackColor = true;
            // 
            // StudentMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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
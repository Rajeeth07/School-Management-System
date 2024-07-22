namespace School_Management_System.UI.Grade
{
    partial class GradeMasterForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGrdExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGrd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGrdRefresh = new System.Windows.Forms.Button();
            this.btnGrdAdd = new System.Windows.Forms.Button();
            this.btnGrdEdit = new System.Windows.Forms.Button();
            this.btnGrdSave = new System.Windows.Forms.Button();
            this.btnGrdCancel = new System.Windows.Forms.Button();
            this.btnGrdDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 36);
            this.textBox1.TabIndex = 10;
            // 
            // btnGrdExit
            // 
            this.btnGrdExit.Location = new System.Drawing.Point(824, 23);
            this.btnGrdExit.Name = "btnGrdExit";
            this.btnGrdExit.Size = new System.Drawing.Size(96, 49);
            this.btnGrdExit.TabIndex = 9;
            this.btnGrdExit.Text = "Exit";
            this.btnGrdExit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGrd);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(534, 313);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // dgvGrd
            // 
            this.dgvGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrd.Location = new System.Drawing.Point(0, 13);
            this.dgvGrd.Name = "dgvGrd";
            this.dgvGrd.RowHeadersWidth = 62;
            this.dgvGrd.Size = new System.Drawing.Size(534, 300);
            this.dgvGrd.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(545, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 313);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 87);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 36);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 131);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 36);
            this.textBox3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(933, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grade Master";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGrdRefresh);
            this.groupBox3.Controls.Add(this.btnGrdAdd);
            this.groupBox3.Controls.Add(this.btnGrdEdit);
            this.groupBox3.Controls.Add(this.btnGrdSave);
            this.groupBox3.Controls.Add(this.btnGrdCancel);
            this.groupBox3.Controls.Add(this.btnGrdDelete);
            this.groupBox3.Controls.Add(this.btnGrdExit);
            this.groupBox3.Location = new System.Drawing.Point(5, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(928, 80);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnGrdRefresh
            // 
            this.btnGrdRefresh.Location = new System.Drawing.Point(200, 23);
            this.btnGrdRefresh.Name = "btnGrdRefresh";
            this.btnGrdRefresh.Size = new System.Drawing.Size(96, 49);
            this.btnGrdRefresh.TabIndex = 9;
            this.btnGrdRefresh.Text = "Refresh";
            this.btnGrdRefresh.UseVisualStyleBackColor = true;
            // 
            // btnGrdAdd
            // 
            this.btnGrdAdd.Location = new System.Drawing.Point(408, 23);
            this.btnGrdAdd.Name = "btnGrdAdd";
            this.btnGrdAdd.Size = new System.Drawing.Size(96, 49);
            this.btnGrdAdd.TabIndex = 9;
            this.btnGrdAdd.Text = "Add";
            this.btnGrdAdd.UseVisualStyleBackColor = true;
            // 
            // btnGrdEdit
            // 
            this.btnGrdEdit.Location = new System.Drawing.Point(512, 23);
            this.btnGrdEdit.Name = "btnGrdEdit";
            this.btnGrdEdit.Size = new System.Drawing.Size(96, 49);
            this.btnGrdEdit.TabIndex = 9;
            this.btnGrdEdit.Text = "Edit";
            this.btnGrdEdit.UseVisualStyleBackColor = true;
            // 
            // btnGrdSave
            // 
            this.btnGrdSave.Location = new System.Drawing.Point(616, 23);
            this.btnGrdSave.Name = "btnGrdSave";
            this.btnGrdSave.Size = new System.Drawing.Size(96, 49);
            this.btnGrdSave.TabIndex = 9;
            this.btnGrdSave.Text = "Save";
            this.btnGrdSave.UseVisualStyleBackColor = true;
            // 
            // btnGrdCancel
            // 
            this.btnGrdCancel.Location = new System.Drawing.Point(720, 23);
            this.btnGrdCancel.Name = "btnGrdCancel";
            this.btnGrdCancel.Size = new System.Drawing.Size(96, 49);
            this.btnGrdCancel.TabIndex = 9;
            this.btnGrdCancel.Text = "Cancel";
            this.btnGrdCancel.UseVisualStyleBackColor = true;
            // 
            // btnGrdDelete
            // 
            this.btnGrdDelete.Location = new System.Drawing.Point(304, 23);
            this.btnGrdDelete.Name = "btnGrdDelete";
            this.btnGrdDelete.Size = new System.Drawing.Size(96, 49);
            this.btnGrdDelete.TabIndex = 9;
            this.btnGrdDelete.Text = "Delete";
            this.btnGrdDelete.UseVisualStyleBackColor = true;
            // 
            // GradeMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GradeMasterForm";
            this.Text = "GradeMasterForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGrdExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGrd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGrdRefresh;
        private System.Windows.Forms.Button btnGrdAdd;
        private System.Windows.Forms.Button btnGrdEdit;
        private System.Windows.Forms.Button btnGrdSave;
        private System.Windows.Forms.Button btnGrdCancel;
        private System.Windows.Forms.Button btnGrdDelete;
    }
}
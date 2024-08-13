namespace School_Management_System.UI.GradeSubject
{
    partial class GradeSubjectForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGrdSubSub = new System.Windows.Forms.ComboBox();
            this.cmbGrdSubgrd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btngrdsubRefresh = new System.Windows.Forms.Button();
            this.btngrdsubAdd = new System.Windows.Forms.Button();
            this.btngrdsubEdit = new System.Windows.Forms.Button();
            this.btngrdsubSave = new System.Windows.Forms.Button();
            this.btngrdsubCancel = new System.Windows.Forms.Button();
            this.btngrdsubDelete = new System.Windows.Forms.Button();
            this.btngrdsubExit = new System.Windows.Forms.Button();
            this.dgvSubGrd = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtgrdsubSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGrdSubSub);
            this.groupBox2.Controls.Add(this.cmbGrdSubgrd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(642, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 389);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // cmbGrdSubSub
            // 
            this.cmbGrdSubSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrdSubSub.FormattingEnabled = true;
            this.cmbGrdSubSub.Location = new System.Drawing.Point(174, 120);
            this.cmbGrdSubSub.Name = "cmbGrdSubSub";
            this.cmbGrdSubSub.Size = new System.Drawing.Size(199, 37);
            this.cmbGrdSubSub.TabIndex = 13;
            // 
            // cmbGrdSubgrd
            // 
            this.cmbGrdSubgrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrdSubgrd.FormattingEnabled = true;
            this.cmbGrdSubgrd.Location = new System.Drawing.Point(174, 69);
            this.cmbGrdSubgrd.Name = "cmbGrdSubgrd";
            this.cmbGrdSubgrd.Size = new System.Drawing.Size(199, 37);
            this.cmbGrdSubgrd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "grade";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "subject";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btngrdsubRefresh);
            this.groupBox3.Controls.Add(this.btngrdsubAdd);
            this.groupBox3.Controls.Add(this.btngrdsubEdit);
            this.groupBox3.Controls.Add(this.btngrdsubSave);
            this.groupBox3.Controls.Add(this.btngrdsubCancel);
            this.groupBox3.Controls.Add(this.btngrdsubDelete);
            this.groupBox3.Controls.Add(this.btngrdsubExit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1045, 80);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btngrdsubRefresh
            // 
            this.btngrdsubRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrdsubRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btngrdsubRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrdsubRefresh.ForeColor = System.Drawing.Color.Black;
            this.btngrdsubRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrdsubRefresh.Location = new System.Drawing.Point(276, 18);
            this.btngrdsubRefresh.Name = "btngrdsubRefresh";
            this.btngrdsubRefresh.Size = new System.Drawing.Size(123, 49);
            this.btngrdsubRefresh.TabIndex = 4;
            this.btngrdsubRefresh.Text = "Refresh";
            this.btngrdsubRefresh.UseVisualStyleBackColor = false;
            this.btngrdsubRefresh.Click += new System.EventHandler(this.btnGrdRefresh_Click);
            // 
            // btngrdsubAdd
            // 
            this.btngrdsubAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrdsubAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btngrdsubAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrdsubAdd.ForeColor = System.Drawing.Color.Black;
            this.btngrdsubAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrdsubAdd.Location = new System.Drawing.Point(522, 18);
            this.btngrdsubAdd.Name = "btngrdsubAdd";
            this.btngrdsubAdd.Size = new System.Drawing.Size(92, 49);
            this.btngrdsubAdd.TabIndex = 6;
            this.btngrdsubAdd.Text = "Add";
            this.btngrdsubAdd.UseVisualStyleBackColor = false;
            this.btngrdsubAdd.Click += new System.EventHandler(this.btngrdsubAdd_Click);
            // 
            // btngrdsubEdit
            // 
            this.btngrdsubEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrdsubEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btngrdsubEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrdsubEdit.ForeColor = System.Drawing.Color.Black;
            this.btngrdsubEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrdsubEdit.Location = new System.Drawing.Point(619, 18);
            this.btngrdsubEdit.Name = "btngrdsubEdit";
            this.btngrdsubEdit.Size = new System.Drawing.Size(88, 49);
            this.btngrdsubEdit.TabIndex = 7;
            this.btngrdsubEdit.Text = "Edit";
            this.btngrdsubEdit.UseVisualStyleBackColor = false;
            this.btngrdsubEdit.Click += new System.EventHandler(this.btngrdsubEdit_Click);
            // 
            // btngrdsubSave
            // 
            this.btngrdsubSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrdsubSave.BackColor = System.Drawing.SystemColors.Control;
            this.btngrdsubSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrdsubSave.ForeColor = System.Drawing.Color.Black;
            this.btngrdsubSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrdsubSave.Location = new System.Drawing.Point(714, 18);
            this.btngrdsubSave.Name = "btngrdsubSave";
            this.btngrdsubSave.Size = new System.Drawing.Size(100, 49);
            this.btngrdsubSave.TabIndex = 8;
            this.btngrdsubSave.Text = "Save";
            this.btngrdsubSave.UseVisualStyleBackColor = false;
            this.btngrdsubSave.Click += new System.EventHandler(this.btngrdsubSave_Click);
            // 
            // btngrdsubCancel
            // 
            this.btngrdsubCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrdsubCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btngrdsubCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrdsubCancel.ForeColor = System.Drawing.Color.Black;
            this.btngrdsubCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrdsubCancel.Location = new System.Drawing.Point(820, 18);
            this.btngrdsubCancel.Name = "btngrdsubCancel";
            this.btngrdsubCancel.Size = new System.Drawing.Size(110, 49);
            this.btngrdsubCancel.TabIndex = 9;
            this.btngrdsubCancel.Text = "Cancel";
            this.btngrdsubCancel.UseVisualStyleBackColor = false;
            this.btngrdsubCancel.Click += new System.EventHandler(this.btngrdsubCancel_Click);
            // 
            // btngrdsubDelete
            // 
            this.btngrdsubDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrdsubDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btngrdsubDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrdsubDelete.ForeColor = System.Drawing.Color.Black;
            this.btngrdsubDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrdsubDelete.Location = new System.Drawing.Point(404, 18);
            this.btngrdsubDelete.Name = "btngrdsubDelete";
            this.btngrdsubDelete.Size = new System.Drawing.Size(111, 49);
            this.btngrdsubDelete.TabIndex = 5;
            this.btngrdsubDelete.Text = "Delete";
            this.btngrdsubDelete.UseVisualStyleBackColor = false;
            this.btngrdsubDelete.Click += new System.EventHandler(this.btngrdsubDelete_Click);
            // 
            // btngrdsubExit
            // 
            this.btngrdsubExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btngrdsubExit.BackColor = System.Drawing.SystemColors.Control;
            this.btngrdsubExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrdsubExit.ForeColor = System.Drawing.Color.Black;
            this.btngrdsubExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrdsubExit.Location = new System.Drawing.Point(936, 18);
            this.btngrdsubExit.Name = "btngrdsubExit";
            this.btngrdsubExit.Size = new System.Drawing.Size(92, 49);
            this.btngrdsubExit.TabIndex = 10;
            this.btngrdsubExit.Text = "Exit";
            this.btngrdsubExit.UseVisualStyleBackColor = false;
            this.btngrdsubExit.Click += new System.EventHandler(this.btngrdsubExit_Click);
            // 
            // dgvSubGrd
            // 
            this.dgvSubGrd.AllowUserToAddRows = false;
            this.dgvSubGrd.AllowUserToDeleteRows = false;
            this.dgvSubGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrd.Location = new System.Drawing.Point(16, 88);
            this.dgvSubGrd.Name = "dgvSubGrd";
            this.dgvSubGrd.RowHeadersWidth = 62;
            this.dgvSubGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubGrd.Size = new System.Drawing.Size(606, 298);
            this.dgvSubGrd.TabIndex = 0;
            this.dgvSubGrd.SelectionChanged += new System.EventHandler(this.dgvSubGrd_SelectionChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Image = global::School_Management_System.Properties.Resources.search_icon_sl7;
            this.label5.Location = new System.Drawing.Point(331, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 42);
            this.label5.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtgrdsubSearch);
            this.groupBox1.Controls.Add(this.dgvSubGrd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1045, 469);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtgrdsubSearch
            // 
            this.txtgrdsubSearch.Location = new System.Drawing.Point(376, 38);
            this.txtgrdsubSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtgrdsubSearch.Multiline = true;
            this.txtgrdsubSearch.Name = "txtgrdsubSearch";
            this.txtgrdsubSearch.Size = new System.Drawing.Size(246, 42);
            this.txtgrdsubSearch.TabIndex = 1;
            this.txtgrdsubSearch.TextChanged += new System.EventHandler(this.txtgrdsubSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1045, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "Grade Subject";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "GradeSubjectForm";
            this.Text = "GradeSubjectForm";
            this.Load += new System.EventHandler(this.GradeSubjectForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btngrdsubRefresh;
        private System.Windows.Forms.Button btngrdsubAdd;
        private System.Windows.Forms.Button btngrdsubEdit;
        private System.Windows.Forms.Button btngrdsubSave;
        private System.Windows.Forms.Button btngrdsubCancel;
        private System.Windows.Forms.Button btngrdsubDelete;
        private System.Windows.Forms.Button btngrdsubExit;
        private System.Windows.Forms.DataGridView dgvSubGrd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgrdsubSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrdSubSub;
        private System.Windows.Forms.ComboBox cmbGrdSubgrd;
    }
}
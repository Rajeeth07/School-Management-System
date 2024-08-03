namespace School_Management_System.UI.Subject
{
    partial class SubjectMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectMasterForm));
            this.btnSubRefresh = new System.Windows.Forms.Button();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.btnSubEdit = new System.Windows.Forms.Button();
            this.btnSubSave = new System.Windows.Forms.Button();
            this.btnSubDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSubCancel = new System.Windows.Forms.Button();
            this.btnSubExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.txtSubindex = new System.Windows.Forms.TextBox();
            this.txtSubOrder = new System.Windows.Forms.TextBox();
            this.dgvSub = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubSearch = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubRefresh
            // 
            this.btnSubRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnSubRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubRefresh.Location = new System.Drawing.Point(324, 22);
            this.btnSubRefresh.Name = "btnSubRefresh";
            this.btnSubRefresh.Size = new System.Drawing.Size(123, 49);
            this.btnSubRefresh.TabIndex = 5;
            this.btnSubRefresh.Text = "Refresh";
            this.btnSubRefresh.UseVisualStyleBackColor = false;
            this.btnSubRefresh.Click += new System.EventHandler(this.btnSubRefresh_Click);
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubAdd.ForeColor = System.Drawing.Color.Black;
            this.btnSubAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAdd.Location = new System.Drawing.Point(570, 22);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(90, 49);
            this.btnSubAdd.TabIndex = 7;
            this.btnSubAdd.Text = "Add";
            this.btnSubAdd.UseVisualStyleBackColor = false;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // btnSubEdit
            // 
            this.btnSubEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubEdit.ForeColor = System.Drawing.Color.Black;
            this.btnSubEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEdit.Location = new System.Drawing.Point(666, 22);
            this.btnSubEdit.Name = "btnSubEdit";
            this.btnSubEdit.Size = new System.Drawing.Size(86, 49);
            this.btnSubEdit.TabIndex = 8;
            this.btnSubEdit.Text = "Edit";
            this.btnSubEdit.UseVisualStyleBackColor = false;
            this.btnSubEdit.Click += new System.EventHandler(this.btnSubEdit_Click);
            // 
            // btnSubSave
            // 
            this.btnSubSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubSave.ForeColor = System.Drawing.Color.Black;
            this.btnSubSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubSave.Location = new System.Drawing.Point(758, 22);
            this.btnSubSave.Name = "btnSubSave";
            this.btnSubSave.Size = new System.Drawing.Size(105, 49);
            this.btnSubSave.TabIndex = 9;
            this.btnSubSave.Text = "Save";
            this.btnSubSave.UseVisualStyleBackColor = false;
            this.btnSubSave.Click += new System.EventHandler(this.btnSubSave_Click);
            // 
            // btnSubDelete
            // 
            this.btnSubDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubDelete.ForeColor = System.Drawing.Color.Black;
            this.btnSubDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubDelete.Location = new System.Drawing.Point(453, 22);
            this.btnSubDelete.Name = "btnSubDelete";
            this.btnSubDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSubDelete.Size = new System.Drawing.Size(111, 49);
            this.btnSubDelete.TabIndex = 6;
            this.btnSubDelete.Text = "Delete";
            this.btnSubDelete.UseVisualStyleBackColor = false;
            this.btnSubDelete.Click += new System.EventHandler(this.btnSubDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubRefresh);
            this.groupBox3.Controls.Add(this.btnSubAdd);
            this.groupBox3.Controls.Add(this.btnSubEdit);
            this.groupBox3.Controls.Add(this.btnSubSave);
            this.groupBox3.Controls.Add(this.btnSubCancel);
            this.groupBox3.Controls.Add(this.btnSubDelete);
            this.groupBox3.Controls.Add(this.btnSubExit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1098, 80);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btnSubCancel
            // 
            this.btnSubCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCancel.ForeColor = System.Drawing.Color.Black;
            this.btnSubCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCancel.Location = new System.Drawing.Point(868, 22);
            this.btnSubCancel.Name = "btnSubCancel";
            this.btnSubCancel.Size = new System.Drawing.Size(114, 49);
            this.btnSubCancel.TabIndex = 10;
            this.btnSubCancel.Text = "Cancel";
            this.btnSubCancel.UseVisualStyleBackColor = false;
            this.btnSubCancel.Click += new System.EventHandler(this.btnSubCancel_Click);
            // 
            // btnSubExit
            // 
            this.btnSubExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubExit.ForeColor = System.Drawing.Color.Black;
            this.btnSubExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubExit.Location = new System.Drawing.Point(988, 22);
            this.btnSubExit.Name = "btnSubExit";
            this.btnSubExit.Size = new System.Drawing.Size(93, 49);
            this.btnSubExit.TabIndex = 11;
            this.btnSubExit.Text = "Exit";
            this.btnSubExit.UseVisualStyleBackColor = false;
            this.btnSubExit.Click += new System.EventHandler(this.btnSubExit_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1098, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subject Master";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Index";
            // 
            // txtSubNumber
            // 
            this.txtSubNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubNumber.Location = new System.Drawing.Point(124, 131);
            this.txtSubNumber.Multiline = true;
            this.txtSubNumber.Name = "txtSubNumber";
            this.txtSubNumber.Size = new System.Drawing.Size(258, 36);
            this.txtSubNumber.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSubName);
            this.groupBox2.Controls.Add(this.txtSubindex);
            this.groupBox2.Controls.Add(this.txtSubOrder);
            this.groupBox2.Controls.Add(this.txtSubNumber);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(694, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 337);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Order";
            // 
            // txtSubName
            // 
            this.txtSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName.Location = new System.Drawing.Point(124, 43);
            this.txtSubName.Multiline = true;
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(258, 36);
            this.txtSubName.TabIndex = 1;
            // 
            // txtSubindex
            // 
            this.txtSubindex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubindex.Location = new System.Drawing.Point(124, 88);
            this.txtSubindex.Multiline = true;
            this.txtSubindex.Name = "txtSubindex";
            this.txtSubindex.Size = new System.Drawing.Size(258, 36);
            this.txtSubindex.TabIndex = 2;
            // 
            // txtSubOrder
            // 
            this.txtSubOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubOrder.Location = new System.Drawing.Point(124, 175);
            this.txtSubOrder.Multiline = true;
            this.txtSubOrder.Name = "txtSubOrder";
            this.txtSubOrder.Size = new System.Drawing.Size(258, 36);
            this.txtSubOrder.TabIndex = 4;
            // 
            // dgvSub
            // 
            this.dgvSub.AllowUserToAddRows = false;
            this.dgvSub.AllowUserToDeleteRows = false;
            this.dgvSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSub.Location = new System.Drawing.Point(16, 97);
            this.dgvSub.Name = "dgvSub";
            this.dgvSub.RowHeadersWidth = 62;
            this.dgvSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSub.Size = new System.Drawing.Size(672, 274);
            this.dgvSub.TabIndex = 3;
            this.dgvSub.SelectionChanged += new System.EventHandler(this.dgvSub_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSubSearch);
            this.groupBox1.Controls.Add(this.dgvSub);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1098, 452);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Image = global::School_Management_System.Properties.Resources.search_icon_sl7;
            this.label6.Location = new System.Drawing.Point(372, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 35);
            this.label6.TabIndex = 5;
            // 
            // txtSubSearch
            // 
            this.txtSubSearch.Location = new System.Drawing.Point(414, 58);
            this.txtSubSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubSearch.Multiline = true;
            this.txtSubSearch.Name = "txtSubSearch";
            this.txtSubSearch.Size = new System.Drawing.Size(272, 33);
            this.txtSubSearch.TabIndex = 4;
            this.txtSubSearch.TextChanged += new System.EventHandler(this.txtSubSearch_TextChanged);
            // 
            // SubjectMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubjectMasterForm";
            this.Text = "SubjectMasterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectMasterForm_FormClosing);
            this.Load += new System.EventHandler(this.SubjectMasterForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSub)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubRefresh;
        private System.Windows.Forms.Button btnSubAdd;
        private System.Windows.Forms.Button btnSubEdit;
        private System.Windows.Forms.Button btnSubSave;
        private System.Windows.Forms.Button btnSubDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubCancel;
        private System.Windows.Forms.Button btnSubExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.TextBox txtSubindex;
        private System.Windows.Forms.DataGridView dgvSub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubSearch;
    }
}
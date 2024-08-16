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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeMasterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrdName = new System.Windows.Forms.TextBox();
            this.btnGrdExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrdSearch = new System.Windows.Forms.TextBox();
            this.dgvGrd = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGrdRefresh = new System.Windows.Forms.Button();
            this.btnGrdAdd = new System.Windows.Forms.Button();
            this.btnGrdEdit = new System.Windows.Forms.Button();
            this.btnGrdSave = new System.Windows.Forms.Button();
            this.btnGrdCancel = new System.Windows.Forms.Button();
            this.btnGrdDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGrdGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrdOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // txtGrdName
            // 
            this.txtGrdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrdName.Location = new System.Drawing.Point(126, 71);
            this.txtGrdName.Multiline = true;
            this.txtGrdName.Name = "txtGrdName";
            this.txtGrdName.Size = new System.Drawing.Size(247, 42);
            this.txtGrdName.TabIndex = 1;
            // 
            // btnGrdExit
            // 
            this.btnGrdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdExit.ForeColor = System.Drawing.Color.Black;
            this.btnGrdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdExit.Location = new System.Drawing.Point(938, 18);
            this.btnGrdExit.Name = "btnGrdExit";
            this.btnGrdExit.Size = new System.Drawing.Size(92, 49);
            this.btnGrdExit.TabIndex = 10;
            this.btnGrdExit.Text = "Exit";
            this.btnGrdExit.UseVisualStyleBackColor = false;
            this.btnGrdExit.Click += new System.EventHandler(this.btnGrdExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGrdSearch);
            this.groupBox1.Controls.Add(this.dgvGrd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(622, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Image = global::School_Management_System.Properties.Resources.search_icon_sl7;
            this.label5.Location = new System.Drawing.Point(303, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 40);
            this.label5.TabIndex = 2;
            // 
            // txtGrdSearch
            // 
            this.txtGrdSearch.Location = new System.Drawing.Point(348, 42);
            this.txtGrdSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrdSearch.Multiline = true;
            this.txtGrdSearch.Name = "txtGrdSearch";
            this.txtGrdSearch.Size = new System.Drawing.Size(246, 36);
            this.txtGrdSearch.TabIndex = 1;
            this.txtGrdSearch.TextChanged += new System.EventHandler(this.txtGrdSearch_TextChanged);
            // 
            // dgvGrd
            // 
            this.dgvGrd.AllowUserToAddRows = false;
            this.dgvGrd.AllowUserToDeleteRows = false;
            this.dgvGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrd.Location = new System.Drawing.Point(16, 88);
            this.dgvGrd.Name = "dgvGrd";
            this.dgvGrd.RowHeadersWidth = 62;
            this.dgvGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrd.Size = new System.Drawing.Size(580, 275);
            this.dgvGrd.TabIndex = 0;
            this.dgvGrd.SelectionChanged += new System.EventHandler(this.dgvGrd_SelectionChanged);
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
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1040, 80);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnGrdRefresh
            // 
            this.btnGrdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnGrdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdRefresh.Location = new System.Drawing.Point(278, 18);
            this.btnGrdRefresh.Name = "btnGrdRefresh";
            this.btnGrdRefresh.Size = new System.Drawing.Size(123, 49);
            this.btnGrdRefresh.TabIndex = 4;
            this.btnGrdRefresh.Text = "Refresh";
            this.btnGrdRefresh.UseVisualStyleBackColor = false;
            this.btnGrdRefresh.Click += new System.EventHandler(this.btnGrdRefresh_Click);
            // 
            // btnGrdAdd
            // 
            this.btnGrdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdAdd.ForeColor = System.Drawing.Color.Black;
            this.btnGrdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdAdd.Location = new System.Drawing.Point(524, 18);
            this.btnGrdAdd.Name = "btnGrdAdd";
            this.btnGrdAdd.Size = new System.Drawing.Size(92, 49);
            this.btnGrdAdd.TabIndex = 6;
            this.btnGrdAdd.Text = "Add";
            this.btnGrdAdd.UseVisualStyleBackColor = false;
            this.btnGrdAdd.Click += new System.EventHandler(this.btnGrdAdd_Click);
            // 
            // btnGrdEdit
            // 
            this.btnGrdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdEdit.ForeColor = System.Drawing.Color.Black;
            this.btnGrdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdEdit.Location = new System.Drawing.Point(621, 18);
            this.btnGrdEdit.Name = "btnGrdEdit";
            this.btnGrdEdit.Size = new System.Drawing.Size(88, 49);
            this.btnGrdEdit.TabIndex = 7;
            this.btnGrdEdit.Text = "Edit";
            this.btnGrdEdit.UseVisualStyleBackColor = false;
            this.btnGrdEdit.Click += new System.EventHandler(this.btnGrdEdit_Click);
            // 
            // btnGrdSave
            // 
            this.btnGrdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdSave.ForeColor = System.Drawing.Color.Black;
            this.btnGrdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdSave.Location = new System.Drawing.Point(716, 18);
            this.btnGrdSave.Name = "btnGrdSave";
            this.btnGrdSave.Size = new System.Drawing.Size(100, 49);
            this.btnGrdSave.TabIndex = 8;
            this.btnGrdSave.Text = "Save";
            this.btnGrdSave.UseVisualStyleBackColor = false;
            this.btnGrdSave.Click += new System.EventHandler(this.btnGrdSave_Click);
            // 
            // btnGrdCancel
            // 
            this.btnGrdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdCancel.ForeColor = System.Drawing.Color.Black;
            this.btnGrdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdCancel.Location = new System.Drawing.Point(822, 18);
            this.btnGrdCancel.Name = "btnGrdCancel";
            this.btnGrdCancel.Size = new System.Drawing.Size(110, 49);
            this.btnGrdCancel.TabIndex = 9;
            this.btnGrdCancel.Text = "Cancel";
            this.btnGrdCancel.UseVisualStyleBackColor = false;
            this.btnGrdCancel.Click += new System.EventHandler(this.btnGrdCancel_Click);
            // 
            // btnGrdDelete
            // 
            this.btnGrdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdDelete.ForeColor = System.Drawing.Color.Black;
            this.btnGrdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdDelete.Location = new System.Drawing.Point(406, 18);
            this.btnGrdDelete.Name = "btnGrdDelete";
            this.btnGrdDelete.Size = new System.Drawing.Size(111, 49);
            this.btnGrdDelete.TabIndex = 5;
            this.btnGrdDelete.Text = "Delete";
            this.btnGrdDelete.UseVisualStyleBackColor = false;
            this.btnGrdDelete.Click += new System.EventHandler(this.btnGrdDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGrdGroup);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtGrdName);
            this.groupBox2.Controls.Add(this.txtGrdOrder);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(622, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 384);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // txtGrdGroup
            // 
            this.txtGrdGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrdGroup.Location = new System.Drawing.Point(126, 122);
            this.txtGrdGroup.Multiline = true;
            this.txtGrdGroup.Name = "txtGrdGroup";
            this.txtGrdGroup.Size = new System.Drawing.Size(247, 42);
            this.txtGrdGroup.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group";
            // 
            // txtGrdOrder
            // 
            this.txtGrdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrdOrder.Location = new System.Drawing.Point(126, 172);
            this.txtGrdOrder.Multiline = true;
            this.txtGrdOrder.Name = "txtGrdOrder";
            this.txtGrdOrder.Size = new System.Drawing.Size(247, 42);
            this.txtGrdOrder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1040, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grade Master";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GradeMasterForm";
            this.Text = "GradeMasterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GradeMasterForm_FormClosing);
            this.Load += new System.EventHandler(this.GradeMasterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrdName;
        private System.Windows.Forms.Button btnGrdExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGrd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrdOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGrdRefresh;
        private System.Windows.Forms.Button btnGrdAdd;
        private System.Windows.Forms.Button btnGrdEdit;
        private System.Windows.Forms.Button btnGrdSave;
        private System.Windows.Forms.Button btnGrdCancel;
        private System.Windows.Forms.Button btnGrdDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrdSearch;
        private System.Windows.Forms.TextBox txtGrdGroup;
    }
}
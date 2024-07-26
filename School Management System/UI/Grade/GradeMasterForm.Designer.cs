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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrdGroup = new System.Windows.Forms.TextBox();
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
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // txtGrdName
            // 
            this.txtGrdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrdName.Location = new System.Drawing.Point(69, 28);
            this.txtGrdName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrdName.Multiline = true;
            this.txtGrdName.Name = "txtGrdName";
            this.txtGrdName.Size = new System.Drawing.Size(166, 25);
            this.txtGrdName.TabIndex = 1;
            // 
            // btnGrdExit
            // 
            this.btnGrdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGrdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdExit.ForeColor = System.Drawing.Color.Black;
            this.btnGrdExit.Image = global::School_Management_System.Properties.Resources.Back_removebg_preview;
            this.btnGrdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdExit.Location = new System.Drawing.Point(677, 12);
            this.btnGrdExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrdExit.Name = "btnGrdExit";
            this.btnGrdExit.Size = new System.Drawing.Size(61, 32);
            this.btnGrdExit.TabIndex = 10;
            this.btnGrdExit.Text = "Exit";
            this.btnGrdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrdExit.UseVisualStyleBackColor = false;
            this.btnGrdExit.Click += new System.EventHandler(this.btnGrdExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGrdSearch);
            this.groupBox1.Controls.Add(this.dgvGrd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(503, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Image = global::School_Management_System.Properties.Resources.search_icon_sl7;
            this.label5.Location = new System.Drawing.Point(295, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 23);
            this.label5.TabIndex = 2;
            // 
            // txtGrdSearch
            // 
            this.txtGrdSearch.Location = new System.Drawing.Point(325, 28);
            this.txtGrdSearch.Multiline = true;
            this.txtGrdSearch.Name = "txtGrdSearch";
            this.txtGrdSearch.Size = new System.Drawing.Size(165, 25);
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
            this.dgvGrd.Location = new System.Drawing.Point(11, 57);
            this.dgvGrd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGrd.Name = "dgvGrd";
            this.dgvGrd.RowHeadersWidth = 62;
            this.dgvGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrd.Size = new System.Drawing.Size(386, 186);
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
            this.groupBox3.Location = new System.Drawing.Point(0, 280);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(745, 52);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnGrdRefresh
            // 
            this.btnGrdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdRefresh.BackColor = System.Drawing.Color.Black;
            this.btnGrdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdRefresh.ForeColor = System.Drawing.Color.White;
            this.btnGrdRefresh.Image = global::School_Management_System.Properties.Resources._360_F_603559966_0VO4rK4OyPO4i89jEDfH1XEbI5fQDaCK_removebg_preview1;
            this.btnGrdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdRefresh.Location = new System.Drawing.Point(237, 12);
            this.btnGrdRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrdRefresh.Name = "btnGrdRefresh";
            this.btnGrdRefresh.Size = new System.Drawing.Size(82, 32);
            this.btnGrdRefresh.TabIndex = 4;
            this.btnGrdRefresh.Text = "Refresh";
            this.btnGrdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrdRefresh.UseVisualStyleBackColor = false;
            this.btnGrdRefresh.Click += new System.EventHandler(this.btnGrdRefresh_Click);
            // 
            // btnGrdAdd
            // 
            this.btnGrdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdAdd.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGrdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdAdd.ForeColor = System.Drawing.Color.White;
            this.btnGrdAdd.Image = global::School_Management_System.Properties.Resources.add_icocons__softiconsm_5;
            this.btnGrdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdAdd.Location = new System.Drawing.Point(401, 12);
            this.btnGrdAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrdAdd.Name = "btnGrdAdd";
            this.btnGrdAdd.Size = new System.Drawing.Size(61, 32);
            this.btnGrdAdd.TabIndex = 6;
            this.btnGrdAdd.Text = "Add";
            this.btnGrdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrdAdd.UseVisualStyleBackColor = false;
            this.btnGrdAdd.Click += new System.EventHandler(this.btnGrdAdd_Click);
            // 
            // btnGrdEdit
            // 
            this.btnGrdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGrdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdEdit.ForeColor = System.Drawing.Color.White;
            this.btnGrdEdit.Image = global::School_Management_System.Properties.Resources._1111111111;
            this.btnGrdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdEdit.Location = new System.Drawing.Point(466, 12);
            this.btnGrdEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrdEdit.Name = "btnGrdEdit";
            this.btnGrdEdit.Size = new System.Drawing.Size(59, 32);
            this.btnGrdEdit.TabIndex = 7;
            this.btnGrdEdit.Text = "Edit";
            this.btnGrdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrdEdit.UseVisualStyleBackColor = false;
            this.btnGrdEdit.Click += new System.EventHandler(this.btnGrdEdit_Click);
            // 
            // btnGrdSave
            // 
            this.btnGrdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGrdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdSave.ForeColor = System.Drawing.Color.White;
            this.btnGrdSave.Image = global::School_Management_System.Properties.Resources._12345;
            this.btnGrdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdSave.Location = new System.Drawing.Point(529, 12);
            this.btnGrdSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrdSave.Name = "btnGrdSave";
            this.btnGrdSave.Size = new System.Drawing.Size(67, 32);
            this.btnGrdSave.TabIndex = 8;
            this.btnGrdSave.Text = "Save";
            this.btnGrdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrdSave.UseVisualStyleBackColor = false;
            this.btnGrdSave.Click += new System.EventHandler(this.btnGrdSave_Click);
            // 
            // btnGrdCancel
            // 
            this.btnGrdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdCancel.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGrdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdCancel.ForeColor = System.Drawing.Color.White;
            this.btnGrdCancel.Image = global::School_Management_System.Properties.Resources._76543;
            this.btnGrdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdCancel.Location = new System.Drawing.Point(600, 12);
            this.btnGrdCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrdCancel.Name = "btnGrdCancel";
            this.btnGrdCancel.Size = new System.Drawing.Size(73, 32);
            this.btnGrdCancel.TabIndex = 9;
            this.btnGrdCancel.Text = "Cancel";
            this.btnGrdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrdCancel.UseVisualStyleBackColor = false;
            this.btnGrdCancel.Click += new System.EventHandler(this.btnGrdCancel_Click);
            // 
            // btnGrdDelete
            // 
            this.btnGrdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrdDelete.BackColor = System.Drawing.Color.White;
            this.btnGrdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrdDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGrdDelete.Image = global::School_Management_System.Properties.Resources._11;
            this.btnGrdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrdDelete.Location = new System.Drawing.Point(323, 12);
            this.btnGrdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrdDelete.Name = "btnGrdDelete";
            this.btnGrdDelete.Size = new System.Drawing.Size(74, 32);
            this.btnGrdDelete.TabIndex = 5;
            this.btnGrdDelete.Text = "Delete";
            this.btnGrdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrdDelete.UseVisualStyleBackColor = false;
            this.btnGrdDelete.Click += new System.EventHandler(this.btnGrdDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtGrdName);
            this.groupBox2.Controls.Add(this.txtGrdGroup);
            this.groupBox2.Controls.Add(this.txtGrdOrder);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(503, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(242, 257);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group";
            // 
            // txtGrdGroup
            // 
            this.txtGrdGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrdGroup.Location = new System.Drawing.Point(69, 57);
            this.txtGrdGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrdGroup.Multiline = true;
            this.txtGrdGroup.Name = "txtGrdGroup";
            this.txtGrdGroup.Size = new System.Drawing.Size(166, 25);
            this.txtGrdGroup.TabIndex = 2;
            // 
            // txtGrdOrder
            // 
            this.txtGrdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrdOrder.Location = new System.Drawing.Point(69, 85);
            this.txtGrdOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrdOrder.Multiline = true;
            this.txtGrdOrder.Name = "txtGrdOrder";
            this.txtGrdOrder.Size = new System.Drawing.Size(166, 25);
            this.txtGrdOrder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(745, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grade Master";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradeMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(745, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtGrdGroup;
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
    }
}
﻿namespace School_Management_System.UI.Student
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
            this.btnStdExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnStdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdExit.ForeColor = System.Drawing.Color.Black;
            this.btnStdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdExit.Location = new System.Drawing.Point(770, 19);
            this.btnStdExit.Name = "btnStdExit";
            this.btnStdExit.Size = new System.Drawing.Size(90, 48);
            this.btnStdExit.TabIndex = 0;
            this.btnStdExit.Text = "Exit";
            this.btnStdExit.UseVisualStyleBackColor = false;
            this.btnStdExit.Click += new System.EventHandler(this.btnStdExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStd
            // 
            this.dgvStd.AllowUserToAddRows = false;
            this.dgvStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStd.Location = new System.Drawing.Point(6, 65);
            this.dgvStd.Name = "dgvStd";
            this.dgvStd.RowHeadersWidth = 62;
            this.dgvStd.RowTemplate.Height = 28;
            this.dgvStd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStd.Size = new System.Drawing.Size(870, 283);
            this.dgvStd.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStuSearch);
            this.groupBox1.Controls.Add(this.dgvStd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 430);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::School_Management_System.Properties.Resources.search_icon_sl7;
            this.label2.Location = new System.Drawing.Point(548, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 38);
            this.label2.TabIndex = 4;
            // 
            // txtStuSearch
            // 
            this.txtStuSearch.Location = new System.Drawing.Point(588, 23);
            this.txtStuSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStuSearch.Multiline = true;
            this.txtStuSearch.Name = "txtStuSearch";
            this.txtStuSearch.Size = new System.Drawing.Size(286, 36);
            this.txtStuSearch.TabIndex = 3;
            this.txtStuSearch.TextChanged += new System.EventHandler(this.txtStuSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnStdRefresh);
            this.groupBox2.Controls.Add(this.btnStdDelete);
            this.groupBox2.Controls.Add(this.btnStdAdd);
            this.groupBox2.Controls.Add(this.btnStdEdit);
            this.groupBox2.Controls.Add(this.btnStdExit);
            this.groupBox2.Location = new System.Drawing.Point(5, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnStdRefresh
            // 
            this.btnStdRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnStdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnStdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdRefresh.Location = new System.Drawing.Point(327, 19);
            this.btnStdRefresh.Name = "btnStdRefresh";
            this.btnStdRefresh.Size = new System.Drawing.Size(126, 48);
            this.btnStdRefresh.TabIndex = 0;
            this.btnStdRefresh.Text = "Refresh";
            this.btnStdRefresh.UseVisualStyleBackColor = false;
            this.btnStdRefresh.Click += new System.EventHandler(this.btnStdRefresh_Click);
            // 
            // btnStdDelete
            // 
            this.btnStdDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnStdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdDelete.ForeColor = System.Drawing.Color.Black;
            this.btnStdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdDelete.Location = new System.Drawing.Point(459, 19);
            this.btnStdDelete.Name = "btnStdDelete";
            this.btnStdDelete.Size = new System.Drawing.Size(112, 48);
            this.btnStdDelete.TabIndex = 0;
            this.btnStdDelete.Text = "Delete";
            this.btnStdDelete.UseVisualStyleBackColor = false;
            this.btnStdDelete.Click += new System.EventHandler(this.btnStdDelete_Click);
            // 
            // btnStdAdd
            // 
            this.btnStdAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnStdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdAdd.ForeColor = System.Drawing.Color.Black;
            this.btnStdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdAdd.Location = new System.Drawing.Point(578, 19);
            this.btnStdAdd.Name = "btnStdAdd";
            this.btnStdAdd.Size = new System.Drawing.Size(90, 48);
            this.btnStdAdd.TabIndex = 0;
            this.btnStdAdd.Text = "Add";
            this.btnStdAdd.UseVisualStyleBackColor = false;
            this.btnStdAdd.Click += new System.EventHandler(this.btnStdAdd_Click);
            // 
            // btnStdEdit
            // 
            this.btnStdEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnStdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdEdit.ForeColor = System.Drawing.Color.Black;
            this.btnStdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdEdit.Location = new System.Drawing.Point(674, 19);
            this.btnStdEdit.Name = "btnStdEdit";
            this.btnStdEdit.Size = new System.Drawing.Size(90, 48);
            this.btnStdEdit.TabIndex = 0;
            this.btnStdEdit.Text = "Edit";
            this.btnStdEdit.UseVisualStyleBackColor = false;
            this.btnStdEdit.Click += new System.EventHandler(this.btnStdEdit_Click);
            // 
            // StudentMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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
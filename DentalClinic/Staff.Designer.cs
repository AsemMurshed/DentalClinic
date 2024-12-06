namespace DentalClinic
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataStaff = new System.Windows.Forms.DataGridView();
            this.BtnِADD = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.comboSearchBy = new System.Windows.Forms.ComboBox();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.navigationDrawer1 = new DentalClinic.NavigationDrawer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusEmployee});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Logged in: ";
            // 
            // statusEmployee
            // 
            this.statusEmployee.Name = "statusEmployee";
            this.statusEmployee.Size = new System.Drawing.Size(12, 17);
            this.statusEmployee.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "بحث باستخدام:";
            // 
            // dataStaff
            // 
            this.dataStaff.AllowUserToAddRows = false;
            this.dataStaff.AllowUserToDeleteRows = false;
            this.dataStaff.AllowUserToResizeColumns = false;
            this.dataStaff.AllowUserToResizeRows = false;
            this.dataStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataStaff.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStaff.Location = new System.Drawing.Point(51, 70);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.ReadOnly = true;
            this.dataStaff.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStaff.Size = new System.Drawing.Size(757, 309);
            this.dataStaff.TabIndex = 3;
            // 
            // BtnِADD
            // 
            this.BtnِADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnِADD.Location = new System.Drawing.Point(15, 70);
            this.BtnِADD.Name = "BtnِADD";
            this.BtnِADD.Size = new System.Drawing.Size(90, 30);
            this.BtnِADD.TabIndex = 4;
            this.BtnِADD.Text = "إضافة";
            this.BtnِADD.UseVisualStyleBackColor = true;
            this.BtnِADD.Click += new System.EventHandler(this.BtnِADD_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(15, 106);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(90, 30);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaffID.BackColor = System.Drawing.SystemColors.Window;
            this.txtStaffID.Location = new System.Drawing.Point(892, 0);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(42, 20);
            this.txtStaffID.TabIndex = 72;
            // 
            // comboSearchBy
            // 
            this.comboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchBy.FormattingEnabled = true;
            this.comboSearchBy.Items.AddRange(new object[] {
            "الاسم",
            "الرقم"});
            this.comboSearchBy.Location = new System.Drawing.Point(319, 30);
            this.comboSearchBy.Name = "comboSearchBy";
            this.comboSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboSearchBy.Size = new System.Drawing.Size(150, 28);
            this.comboSearchBy.TabIndex = 2;
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffSearch.Location = new System.Drawing.Point(163, 30);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStaffSearch.Size = new System.Drawing.Size(150, 26);
            this.txtStaffSearch.TabIndex = 1;
            this.txtStaffSearch.TextChanged += new System.EventHandler(this.txtStaffSearch_TextChanged);
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.BackColor = System.Drawing.Color.DodgerBlue;
            this.navigationDrawer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 0);
            this.navigationDrawer1.MaximumSize = new System.Drawing.Size(200, 4000);
            this.navigationDrawer1.MinimumSize = new System.Drawing.Size(45, 600);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationDrawer1.Size = new System.Drawing.Size(45, 600);
            this.navigationDrawer1.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnِADD);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(814, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 539);
            this.panel1.TabIndex = 76;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(15, 142);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 30);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigationDrawer1);
            this.Controls.Add(this.txtStaffSearch);
            this.Controls.Add(this.comboSearchBy);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.dataStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Staff";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "واجهة الموظفين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_FormClosing);
            this.Load += new System.EventHandler(this.Staff_Load);
            this.SizeChanged += new System.EventHandler(this.Staff_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataStaff;
        private System.Windows.Forms.Button BtnِADD;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.ComboBox comboSearchBy;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private NavigationDrawer navigationDrawer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDelete;
    }
}
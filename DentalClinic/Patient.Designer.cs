namespace DentalClinic
{
    partial class frmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientSearch = new System.Windows.Forms.TextBox();
            this.dataPatient = new System.Windows.Forms.DataGridView();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPatientRecord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navigationDrawer1 = new DentalClinic.NavigationDrawer();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusEmployee});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 0;
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
            // txtPatientID
            // 
            this.txtPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatientID.Location = new System.Drawing.Point(833, 0);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(51, 20);
            this.txtPatientID.TabIndex = 24;
            // 
            // txtPatientSearch
            // 
            this.txtPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientSearch.Location = new System.Drawing.Point(164, 30);
            this.txtPatientSearch.Name = "txtPatientSearch";
            this.txtPatientSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientSearch.Size = new System.Drawing.Size(150, 26);
            this.txtPatientSearch.TabIndex = 1;
            this.txtPatientSearch.TextChanged += new System.EventHandler(this.txtPatientSearch_TextChanged_1);
            this.txtPatientSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientSearch_KeyPress);
            // 
            // dataPatient
            // 
            this.dataPatient.AllowUserToAddRows = false;
            this.dataPatient.AllowUserToDeleteRows = false;
            this.dataPatient.AllowUserToResizeColumns = false;
            this.dataPatient.AllowUserToResizeRows = false;
            this.dataPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPatient.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataPatient.Location = new System.Drawing.Point(55, 70);
            this.dataPatient.Name = "dataPatient";
            this.dataPatient.ReadOnly = true;
            this.dataPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPatient.ShowCellErrors = false;
            this.dataPatient.Size = new System.Drawing.Size(652, 435);
            this.dataPatient.TabIndex = 3;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "الاسم",
            "الرقم"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(320, 30);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSearchBy.Size = new System.Drawing.Size(150, 28);
            this.comboBoxSearchBy.TabIndex = 2;
            // 
            // DelBtn
            // 
            this.DelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.Location = new System.Drawing.Point(15, 155);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(90, 30);
            this.DelBtn.TabIndex = 6;
            this.DelBtn.Text = "حذف";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(15, 119);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(90, 30);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(15, 83);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 30);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "إضافة مريض";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "بحث باستخدام:";
            this.label2.UseMnemonic = false;
            // 
            // BtnPatientRecord
            // 
            this.BtnPatientRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPatientRecord.Location = new System.Drawing.Point(15, 205);
            this.BtnPatientRecord.Name = "BtnPatientRecord";
            this.BtnPatientRecord.Size = new System.Drawing.Size(90, 30);
            this.BtnPatientRecord.TabIndex = 7;
            this.BtnPatientRecord.Text = "سجل المريض";
            this.BtnPatientRecord.UseVisualStyleBackColor = true;
            this.BtnPatientRecord.Click += new System.EventHandler(this.BtnPatientRecord_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.BtnPatientRecord);
            this.panel1.Controls.Add(this.DelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(764, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 555);
            this.panel1.TabIndex = 38;
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.BackColor = System.Drawing.Color.DodgerBlue;
            this.navigationDrawer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 0);
            this.navigationDrawer1.MaximumSize = new System.Drawing.Size(200, 4000);
            this.navigationDrawer1.MinimumSize = new System.Drawing.Size(40, 600);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationDrawer1.Size = new System.Drawing.Size(40, 600);
            this.navigationDrawer1.TabIndex = 37;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigationDrawer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientSearch);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.dataPatient);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "واجهة المرضى";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployee_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.SizeChanged += new System.EventHandler(this.frmEmployee_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusEmployee;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientSearch;
        private System.Windows.Forms.DataGridView dataPatient;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPatientRecord;
        private NavigationDrawer navigationDrawer1;
        private System.Windows.Forms.Panel panel1;
    }
}
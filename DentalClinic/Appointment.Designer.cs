namespace DentalClinic
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDentist = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataAppointment = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnCancelAppointment = new System.Windows.Forms.Button();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSortBy = new System.Windows.Forms.ComboBox();
            this.navigationDrawer1 = new DentalClinic.NavigationDrawer();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusDentist});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Logged in: ";
            // 
            // statusDentist
            // 
            this.statusDentist.Name = "statusDentist";
            this.statusDentist.Size = new System.Drawing.Size(63, 17);
            this.statusDentist.Text = "Dr. Cuevas";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dataAppointment);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(629, 397);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة المواعيد";
            // 
            // dataAppointment
            // 
            this.dataAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataAppointment.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAppointment.Location = new System.Drawing.Point(6, 33);
            this.dataAppointment.Name = "dataAppointment";
            this.dataAppointment.ReadOnly = true;
            this.dataAppointment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataAppointment.Size = new System.Drawing.Size(611, 358);
            this.dataAppointment.TabIndex = 2;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(15, 103);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(90, 30);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "تعديل";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCancelAppointment
            // 
            this.BtnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelAppointment.Location = new System.Drawing.Point(15, 139);
            this.BtnCancelAppointment.Name = "BtnCancelAppointment";
            this.BtnCancelAppointment.Size = new System.Drawing.Size(90, 30);
            this.BtnCancelAppointment.TabIndex = 4;
            this.BtnCancelAppointment.Text = "إلغاء موعد";
            this.BtnCancelAppointment.UseVisualStyleBackColor = true;
            this.BtnCancelAppointment.Click += new System.EventHandler(this.BtnCancelAppointment_Click);
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppointmentID.BackColor = System.Drawing.SystemColors.Window;
            this.txtAppointmentID.Location = new System.Drawing.Point(767, 12);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(26, 20);
            this.txtAppointmentID.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnCancelAppointment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(685, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 499);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "عرض:";
            // 
            // comboSortBy
            // 
            this.comboSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSortBy.FormattingEnabled = true;
            this.comboSortBy.Items.AddRange(new object[] {
            "مواعيد اليوم",
            "مواعيد هذا الأسبوع",
            "مواعيد هذا الشهر",
            "المواعيد الفائتة",
            "كل المواعيد"});
            this.comboSortBy.Location = new System.Drawing.Point(128, 30);
            this.comboSortBy.Name = "comboSortBy";
            this.comboSortBy.Size = new System.Drawing.Size(150, 28);
            this.comboSortBy.TabIndex = 1;
            this.comboSortBy.SelectedIndexChanged += new System.EventHandler(this.comboSortBy_SelectedIndexChanged);
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.BackColor = System.Drawing.Color.DodgerBlue;
            this.navigationDrawer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationDrawer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 0);
            this.navigationDrawer1.MaximumSize = new System.Drawing.Size(200, 600);
            this.navigationDrawer1.MinimumSize = new System.Drawing.Size(40, 600);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.navigationDrawer1.Size = new System.Drawing.Size(40, 600);
            this.navigationDrawer1.TabIndex = 10;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 521);
            this.Controls.Add(this.comboSortBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAppointmentID);
            this.Controls.Add(this.navigationDrawer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appointment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "قائمة المواعيد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDentist_FormClosing);
            this.Load += new System.EventHandler(this.frmDentist_Load);
            this.SizeChanged += new System.EventHandler(this.frmDentist_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAppointment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusDentist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataAppointment;
        private NavigationDrawer navigationDrawer1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnCancelAppointment;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSortBy;
    }
}
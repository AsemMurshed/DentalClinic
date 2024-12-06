namespace DentalClinic
{
    partial class PatientRecord
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultID = new System.Windows.Forms.TextBox();
            this.BtnDetails = new System.Windows.Forms.Button();
            this.labPateintName = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtDentistID = new System.Windows.Forms.TextBox();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.BtnAddConsult = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBill = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataConsultation = new System.Windows.Forms.DataGridView();
            this.navigationDrawer1 = new DentalClinic.NavigationDrawer();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المريض:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "الاستشارات السابقة";
            // 
            // txtConsultID
            // 
            this.txtConsultID.BackColor = System.Drawing.SystemColors.Window;
            this.txtConsultID.Location = new System.Drawing.Point(5, 12);
            this.txtConsultID.Name = "txtConsultID";
            this.txtConsultID.Size = new System.Drawing.Size(20, 20);
            this.txtConsultID.TabIndex = 4;
            // 
            // BtnDetails
            // 
            this.BtnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetails.Location = new System.Drawing.Point(15, 63);
            this.BtnDetails.Name = "BtnDetails";
            this.BtnDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDetails.Size = new System.Drawing.Size(100, 50);
            this.BtnDetails.TabIndex = 3;
            this.BtnDetails.Text = "تفاصيل الاستشارة";
            this.BtnDetails.UseVisualStyleBackColor = true;
            this.BtnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // labPateintName
            // 
            this.labPateintName.AutoSize = true;
            this.labPateintName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPateintName.Location = new System.Drawing.Point(147, 24);
            this.labPateintName.Name = "labPateintName";
            this.labPateintName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labPateintName.Size = new System.Drawing.Size(60, 24);
            this.labPateintName.TabIndex = 6;
            this.labPateintName.Text = "label3";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(15, 155);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDelete.Size = new System.Drawing.Size(100, 30);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "حذف استشارة";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // txtDentistID
            // 
            this.txtDentistID.BackColor = System.Drawing.SystemColors.Window;
            this.txtDentistID.Location = new System.Drawing.Point(5, 38);
            this.txtDentistID.Name = "txtDentistID";
            this.txtDentistID.Size = new System.Drawing.Size(20, 20);
            this.txtDentistID.TabIndex = 8;
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAppointment.Location = new System.Drawing.Point(15, 191);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddAppointment.Size = new System.Drawing.Size(100, 30);
            this.BtnAddAppointment.TabIndex = 6;
            this.BtnAddAppointment.Text = "إضافة موعد";
            this.BtnAddAppointment.UseVisualStyleBackColor = true;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // BtnAddConsult
            // 
            this.BtnAddConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddConsult.Location = new System.Drawing.Point(15, 27);
            this.BtnAddConsult.Name = "BtnAddConsult";
            this.BtnAddConsult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnAddConsult.Size = new System.Drawing.Size(100, 30);
            this.BtnAddConsult.TabIndex = 2;
            this.BtnAddConsult.Text = "إضافة استشارة";
            this.BtnAddConsult.UseVisualStyleBackColor = true;
            this.BtnAddConsult.Click += new System.EventHandler(this.BtnAddConsult_Click_1);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(15, 227);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnBack.Size = new System.Drawing.Size(100, 30);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "خروج";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnBill);
            this.panel1.Controls.Add(this.BtnDetails);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnAddConsult);
            this.panel1.Controls.Add(this.BtnAddAppointment);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 435);
            this.panel1.TabIndex = 40;
            // 
            // BtnBill
            // 
            this.BtnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBill.Location = new System.Drawing.Point(15, 119);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnBill.Size = new System.Drawing.Size(100, 30);
            this.BtnBill.TabIndex = 4;
            this.BtnBill.Text = "تفاصيل الفاتورة";
            this.BtnBill.UseVisualStyleBackColor = true;
            this.BtnBill.Click += new System.EventHandler(this.BtnBill_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.dataConsultation);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(751, 456);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // dataConsultation
            // 
            this.dataConsultation.AllowUserToAddRows = false;
            this.dataConsultation.AllowUserToDeleteRows = false;
            this.dataConsultation.AllowUserToResizeRows = false;
            this.dataConsultation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataConsultation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataConsultation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataConsultation.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataConsultation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultation.Location = new System.Drawing.Point(143, 3);
            this.dataConsultation.Name = "dataConsultation";
            this.dataConsultation.ReadOnly = true;
            this.dataConsultation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataConsultation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataConsultation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConsultation.Size = new System.Drawing.Size(605, 435);
            this.dataConsultation.TabIndex = 1;
            this.dataConsultation.SelectionChanged += new System.EventHandler(this.dataConsultation_SelectionChanged);
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
            this.navigationDrawer1.Size = new System.Drawing.Size(40, 619);
            this.navigationDrawer1.TabIndex = 9;
            // 
            // PatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.navigationDrawer1);
            this.Controls.Add(this.txtDentistID);
            this.Controls.Add(this.labPateintName);
            this.Controls.Add(this.txtConsultID);
            this.Controls.Add(this.label1);
            this.Name = "PatientRecord";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "سجل المريض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientRecord_FormClosing);
            this.Load += new System.EventHandler(this.PatientRecord_Load);
            this.SizeChanged += new System.EventHandler(this.PatientRecord_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultID;
        private System.Windows.Forms.Button BtnDetails;
        private System.Windows.Forms.Label labPateintName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox txtDentistID;
        private NavigationDrawer navigationDrawer1;
       
        private System.Windows.Forms.Button BtnAddAppointment;
       
        private System.Windows.Forms.Button BtnAddConsult;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataConsultation;
        private System.Windows.Forms.Button BtnBill;
    }
}
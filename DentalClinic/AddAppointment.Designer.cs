namespace DentalClinic
{
    partial class AddAppointment
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
            this.comboBoxDentistNames = new System.Windows.Forms.ComboBox();
            this.checkFee = new System.Windows.Forms.CheckBox();
            this.comboAppointmentStatus = new System.Windows.Forms.ComboBox();
            this.comboAppointmentType = new System.Windows.Forms.ComboBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DateTimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.txtDentistID = new System.Windows.Forms.TextBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxDentistNames);
            this.groupBox2.Controls.Add(this.checkFee);
            this.groupBox2.Controls.Add(this.comboAppointmentStatus);
            this.groupBox2.Controls.Add(this.comboAppointmentType);
            this.groupBox2.Controls.Add(this.txtPatientName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnCancel);
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Controls.Add(this.DateTimeAppointment);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(506, 224);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "موعد جديد";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBoxDentistNames
            // 
            this.comboBoxDentistNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDentistNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDentistNames.FormattingEnabled = true;
            this.comboBoxDentistNames.Location = new System.Drawing.Point(23, 23);
            this.comboBoxDentistNames.Name = "comboBoxDentistNames";
            this.comboBoxDentistNames.Size = new System.Drawing.Size(161, 28);
            this.comboBoxDentistNames.TabIndex = 22;
            this.comboBoxDentistNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxDentistNames_SelectedIndexChanged);
            // 
            // checkFee
            // 
            this.checkFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkFee.AutoSize = true;
            this.checkFee.Location = new System.Drawing.Point(118, 110);
            this.checkFee.Name = "checkFee";
            this.checkFee.Size = new System.Drawing.Size(64, 24);
            this.checkFee.TabIndex = 21;
            this.checkFee.Text = "مدفوعة";
            this.checkFee.UseVisualStyleBackColor = true;
            // 
            // comboAppointmentStatus
            // 
            this.comboAppointmentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAppointmentStatus.FormattingEnabled = true;
            this.comboAppointmentStatus.Items.AddRange(new object[] {
            "ساري",
            "فائت",
            "مؤجل"});
            this.comboAppointmentStatus.Location = new System.Drawing.Point(63, 60);
            this.comboAppointmentStatus.Name = "comboAppointmentStatus";
            this.comboAppointmentStatus.Size = new System.Drawing.Size(121, 28);
            this.comboAppointmentStatus.TabIndex = 20;
            // 
            // comboAppointmentType
            // 
            this.comboAppointmentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAppointmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAppointmentType.FormattingEnabled = true;
            this.comboAppointmentType.Items.AddRange(new object[] {
            "جديد",
            "عودة"});
            this.comboAppointmentType.Location = new System.Drawing.Point(310, 60);
            this.comboAppointmentType.Name = "comboAppointmentType";
            this.comboAppointmentType.Size = new System.Drawing.Size(121, 28);
            this.comboAppointmentType.TabIndex = 19;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientName.Location = new System.Drawing.Point(290, 19);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(136, 26);
            this.txtPatientName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "التاريخ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "الرسوم";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "حالة الموعد";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "نوع الموعد";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "اسم الطبيب";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "اسم المريض:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(310, 172);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 30);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(406, 172);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 30);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "حفظ";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DateTimeAppointment
            // 
            this.DateTimeAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeAppointment.CustomFormat = "DD/MM/YYY";
            this.DateTimeAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimeAppointment.Location = new System.Drawing.Point(290, 104);
            this.DateTimeAppointment.Name = "DateTimeAppointment";
            this.DateTimeAppointment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateTimeAppointment.RightToLeftLayout = true;
            this.DateTimeAppointment.Size = new System.Drawing.Size(159, 26);
            this.DateTimeAppointment.TabIndex = 0;
            // 
            // txtDentistID
            // 
            this.txtDentistID.BackColor = System.Drawing.SystemColors.Control;
            this.txtDentistID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDentistID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDentistID.Location = new System.Drawing.Point(95, 12);
            this.txtDentistID.Name = "txtDentistID";
            this.txtDentistID.Size = new System.Drawing.Size(46, 13);
            this.txtDentistID.TabIndex = 24;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPatientID.Enabled = false;
            this.txtPatientID.Location = new System.Drawing.Point(195, 42);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(46, 20);
            this.txtPatientID.TabIndex = 5;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.txtDentistID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPatientID);
            this.Name = "AddAppointment";
            this.Text = "موعد جديد";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAppointment_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxDentistNames;
        private System.Windows.Forms.CheckBox checkFee;
        private System.Windows.Forms.ComboBox comboAppointmentStatus;
        private System.Windows.Forms.ComboBox comboAppointmentType;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.DateTimePicker DateTimeAppointment;
        private System.Windows.Forms.TextBox txtDentistID;
    }
}
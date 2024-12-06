namespace DentalClinic
{
    partial class Consultation
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
            this.labDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTxtHistory = new System.Windows.Forms.RichTextBox();
            this.richTxtDiagnosis = new System.Windows.Forms.RichTextBox();
            this.richTxtTreatment = new System.Windows.Forms.RichTextBox();
            this.dateTimeConsult = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnBill = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.comboBoxDentistNames = new System.Windows.Forms.ComboBox();
            this.txtDentistID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.richTxtPastDentalHistory = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.richTxtChiefComplaint = new System.Windows.Forms.RichTextBox();
            this.listConsultImages = new System.Windows.Forms.ListView();
            this.BtnAddImage = new System.Windows.Forms.Button();
            this.BtnDeleteImage = new System.Windows.Forms.Button();
            this.navigationDrawer1 = new DentalClinic.NavigationDrawer();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المريض";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الطبيب";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(525, 33);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(45, 20);
            this.labDate.TabIndex = 2;
            this.labDate.Text = "التاريخ";
            this.labDate.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "التاريخ المرضي";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "التشخيص";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "المعالجة";
            // 
            // richTxtHistory
            // 
            this.richTxtHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtHistory.EnableAutoDragDrop = true;
            this.richTxtHistory.Location = new System.Drawing.Point(12, 145);
            this.richTxtHistory.Name = "richTxtHistory";
            this.richTxtHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTxtHistory.Size = new System.Drawing.Size(677, 96);
            this.richTxtHistory.TabIndex = 3;
            this.richTxtHistory.Text = "";
            this.richTxtHistory.WordWrap = false;
            this.richTxtHistory.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTxtHistory_ContentsResized);
            // 
            // richTxtDiagnosis
            // 
            this.richTxtDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtDiagnosis.EnableAutoDragDrop = true;
            this.richTxtDiagnosis.Location = new System.Drawing.Point(12, 389);
            this.richTxtDiagnosis.Name = "richTxtDiagnosis";
            this.richTxtDiagnosis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTxtDiagnosis.Size = new System.Drawing.Size(677, 96);
            this.richTxtDiagnosis.TabIndex = 5;
            this.richTxtDiagnosis.Text = "";
            this.richTxtDiagnosis.WordWrap = false;
            this.richTxtDiagnosis.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTxtDiagnosis_ContentsResized);
            // 
            // richTxtTreatment
            // 
            this.richTxtTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtTreatment.Location = new System.Drawing.Point(12, 511);
            this.richTxtTreatment.Name = "richTxtTreatment";
            this.richTxtTreatment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTxtTreatment.Size = new System.Drawing.Size(677, 96);
            this.richTxtTreatment.TabIndex = 6;
            this.richTxtTreatment.Text = "";
            this.richTxtTreatment.WordWrap = false;
            this.richTxtTreatment.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTxtTreatment_ContentsResized);
            // 
            // dateTimeConsult
            // 
            this.dateTimeConsult.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimeConsult.Enabled = false;
            this.dateTimeConsult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeConsult.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeConsult.Location = new System.Drawing.Point(576, 28);
            this.dateTimeConsult.Name = "dateTimeConsult";
            this.dateTimeConsult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeConsult.RightToLeftLayout = true;
            this.dateTimeConsult.Size = new System.Drawing.Size(150, 26);
            this.dateTimeConsult.TabIndex = 9;
            this.dateTimeConsult.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(770, 100);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(95, 30);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnBill
            // 
            this.BtnBill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBill.Location = new System.Drawing.Point(770, 203);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.Size = new System.Drawing.Size(95, 30);
            this.BtnBill.TabIndex = 11;
            this.BtnBill.Text = "تفاصيل فاتورة";
            this.BtnBill.UseVisualStyleBackColor = true;
            this.BtnBill.Visible = false;
            this.BtnBill.Click += new System.EventHandler(this.BtnBill_Click);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(132, 30);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPatientName.Size = new System.Drawing.Size(150, 26);
            this.txtPatientName.TabIndex = 12;
            // 
            // comboBoxDentistNames
            // 
            this.comboBoxDentistNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDentistNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDentistNames.FormattingEnabled = true;
            this.comboBoxDentistNames.Location = new System.Drawing.Point(360, 30);
            this.comboBoxDentistNames.Name = "comboBoxDentistNames";
            this.comboBoxDentistNames.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDentistNames.Size = new System.Drawing.Size(150, 28);
            this.comboBoxDentistNames.TabIndex = 1;
            this.comboBoxDentistNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxDentistNames_SelectedIndexChanged);
            // 
            // txtDentistID
            // 
            this.txtDentistID.BackColor = System.Drawing.SystemColors.Window;
            this.txtDentistID.Location = new System.Drawing.Point(1, 12);
            this.txtDentistID.Name = "txtDentistID";
            this.txtDentistID.Size = new System.Drawing.Size(41, 20);
            this.txtDentistID.TabIndex = 16;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(770, 136);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(95, 30);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // richTxtPastDentalHistory
            // 
            this.richTxtPastDentalHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtPastDentalHistory.EnableAutoDragDrop = true;
            this.richTxtPastDentalHistory.Location = new System.Drawing.Point(12, 267);
            this.richTxtPastDentalHistory.Name = "richTxtPastDentalHistory";
            this.richTxtPastDentalHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTxtPastDentalHistory.Size = new System.Drawing.Size(677, 96);
            this.richTxtPastDentalHistory.TabIndex = 4;
            this.richTxtPastDentalHistory.Text = "";
            this.richTxtPastDentalHistory.WordWrap = false;
            this.richTxtPastDentalHistory.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTxtPastDentalHistory_ContentsResized);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "المعالجة السنية السابقة";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.richTxtChiefComplaint);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.richTxtHistory);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.richTxtPastDentalHistory);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.richTxtDiagnosis);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.richTxtTreatment);
            this.flowLayoutPanel1.Controls.Add(this.listConsultImages);
            this.flowLayoutPanel1.Controls.Add(this.BtnAddImage);
            this.flowLayoutPanel1.Controls.Add(this.BtnDeleteImage);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(55, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(709, 558);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "الشكوى الرئيسية";
            // 
            // richTxtChiefComplaint
            // 
            this.richTxtChiefComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtChiefComplaint.AutoWordSelection = true;
            this.richTxtChiefComplaint.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTxtChiefComplaint.Location = new System.Drawing.Point(12, 23);
            this.richTxtChiefComplaint.Name = "richTxtChiefComplaint";
            this.richTxtChiefComplaint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTxtChiefComplaint.Size = new System.Drawing.Size(677, 96);
            this.richTxtChiefComplaint.TabIndex = 2;
            this.richTxtChiefComplaint.Text = "";
            this.richTxtChiefComplaint.WordWrap = false;
            this.richTxtChiefComplaint.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTxtChiefComplaint_ContentsResized);
            // 
            // listConsultImages
            // 
            this.listConsultImages.HideSelection = false;
            this.listConsultImages.Location = new System.Drawing.Point(12, 613);
            this.listConsultImages.Name = "listConsultImages";
            this.listConsultImages.Size = new System.Drawing.Size(677, 200);
            this.listConsultImages.TabIndex = 25;
            this.listConsultImages.UseCompatibleStateImageBehavior = false;
            this.listConsultImages.DoubleClick += new System.EventHandler(this.listConsultImages_DoubleClick);
            // 
            // BtnAddImage
            // 
            this.BtnAddImage.Location = new System.Drawing.Point(599, 819);
            this.BtnAddImage.Name = "BtnAddImage";
            this.BtnAddImage.Size = new System.Drawing.Size(90, 30);
            this.BtnAddImage.TabIndex = 7;
            this.BtnAddImage.Text = "إضافة صورة";
            this.BtnAddImage.UseVisualStyleBackColor = true;
            this.BtnAddImage.Click += new System.EventHandler(this.BtnAddImage_Click);
            // 
            // BtnDeleteImage
            // 
            this.BtnDeleteImage.Enabled = false;
            this.BtnDeleteImage.Location = new System.Drawing.Point(503, 819);
            this.BtnDeleteImage.Name = "BtnDeleteImage";
            this.BtnDeleteImage.Size = new System.Drawing.Size(90, 30);
            this.BtnDeleteImage.TabIndex = 8;
            this.BtnDeleteImage.Text = "حذف الصورة";
            this.BtnDeleteImage.UseVisualStyleBackColor = true;
            this.BtnDeleteImage.Click += new System.EventHandler(this.BtnDeleteImage_Click);
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
            this.navigationDrawer1.Size = new System.Drawing.Size(40, 681);
            this.navigationDrawer1.TabIndex = 18;
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 681);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.navigationDrawer1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txtDentistID);
            this.Controls.Add(this.comboBoxDentistNames);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.BtnBill);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dateTimeConsult);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Consultation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultation_FormClosing);
            this.Load += new System.EventHandler(this.Consultation_Load);
            this.SizeChanged += new System.EventHandler(this.Consultation_SizeChanged);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTxtHistory;
        private System.Windows.Forms.RichTextBox richTxtDiagnosis;
        private System.Windows.Forms.RichTextBox richTxtTreatment;
        private System.Windows.Forms.DateTimePicker dateTimeConsult;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnBill;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.ComboBox comboBoxDentistNames;
        private System.Windows.Forms.TextBox txtDentistID;
        private System.Windows.Forms.Button BtnCancel;
        private NavigationDrawer navigationDrawer1;
        private System.Windows.Forms.RichTextBox richTxtPastDentalHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTxtChiefComplaint;
        private System.Windows.Forms.ListView listConsultImages;
        private System.Windows.Forms.Button BtnAddImage;
        private System.Windows.Forms.Button BtnDeleteImage;
    }
}
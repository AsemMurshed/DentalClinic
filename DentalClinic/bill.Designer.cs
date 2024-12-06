namespace DentalClinic
{
    partial class bill
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPaidFor = new System.Windows.Forms.TextBox();
            this.comboPaymentStatus = new System.Windows.Forms.ComboBox();
            this.dataPayment = new System.Windows.Forms.DataGridView();
            this.BtnAddPayment = new System.Windows.Forms.Button();
            this.BtnEditPayment = new System.Windows.Forms.Button();
            this.BtnDeletePayment = new System.Windows.Forms.Button();
            this.txtConsultID = new System.Windows.Forms.TextBox();
            this.txtBillDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemainAmount = new System.Windows.Forms.TextBox();
            this.BtnEditBill = new System.Windows.Forms.Button();
            this.navigationDrawer1 = new DentalClinic.NavigationDrawer();
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "المبلغ الكلي";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "الخصم";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "مقابل";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "حالة الفاتورة";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalAmount.Location = new System.Drawing.Point(543, 24);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(136, 26);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(367, 24);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 26);
            this.txtDiscount.TabIndex = 6;
            // 
            // txtPaidFor
            // 
            this.txtPaidFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidFor.Location = new System.Drawing.Point(367, 60);
            this.txtPaidFor.Multiline = true;
            this.txtPaidFor.Name = "txtPaidFor";
            this.txtPaidFor.Size = new System.Drawing.Size(312, 45);
            this.txtPaidFor.TabIndex = 8;
            // 
            // comboPaymentStatus
            // 
            this.comboPaymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaymentStatus.FormattingEnabled = true;
            this.comboPaymentStatus.Items.AddRange(new object[] {
            "جارية",
            "منتهية"});
            this.comboPaymentStatus.Location = new System.Drawing.Point(156, 24);
            this.comboPaymentStatus.Name = "comboPaymentStatus";
            this.comboPaymentStatus.Size = new System.Drawing.Size(122, 28);
            this.comboPaymentStatus.TabIndex = 9;
            // 
            // dataPayment
            // 
            this.dataPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataPayment.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPayment.Location = new System.Drawing.Point(156, 26);
            this.dataPayment.Name = "dataPayment";
            this.dataPayment.ReadOnly = true;
            this.dataPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataPayment.Size = new System.Drawing.Size(596, 304);
            this.dataPayment.TabIndex = 10;
            // 
            // BtnAddPayment
            // 
            this.BtnAddPayment.Location = new System.Drawing.Point(20, 26);
            this.BtnAddPayment.Name = "BtnAddPayment";
            this.BtnAddPayment.Size = new System.Drawing.Size(90, 30);
            this.BtnAddPayment.TabIndex = 11;
            this.BtnAddPayment.Text = "إضافة دفعة";
            this.BtnAddPayment.UseVisualStyleBackColor = true;
            this.BtnAddPayment.Click += new System.EventHandler(this.BtnAddPayment_Click);
            // 
            // BtnEditPayment
            // 
            this.BtnEditPayment.Location = new System.Drawing.Point(20, 62);
            this.BtnEditPayment.Name = "BtnEditPayment";
            this.BtnEditPayment.Size = new System.Drawing.Size(90, 30);
            this.BtnEditPayment.TabIndex = 12;
            this.BtnEditPayment.Text = "تعديل";
            this.BtnEditPayment.UseVisualStyleBackColor = true;
            this.BtnEditPayment.Click += new System.EventHandler(this.BtnEditPayment_Click);
            // 
            // BtnDeletePayment
            // 
            this.BtnDeletePayment.Location = new System.Drawing.Point(20, 98);
            this.BtnDeletePayment.Name = "BtnDeletePayment";
            this.BtnDeletePayment.Size = new System.Drawing.Size(90, 30);
            this.BtnDeletePayment.TabIndex = 13;
            this.BtnDeletePayment.Text = "حذف";
            this.BtnDeletePayment.UseVisualStyleBackColor = true;
            this.BtnDeletePayment.Click += new System.EventHandler(this.BtnDeletePayment_Click);
            // 
            // txtConsultID
            // 
            this.txtConsultID.BackColor = System.Drawing.SystemColors.Window;
            this.txtConsultID.Location = new System.Drawing.Point(1, 26);
            this.txtConsultID.Name = "txtConsultID";
            this.txtConsultID.Size = new System.Drawing.Size(36, 20);
            this.txtConsultID.TabIndex = 14;
            // 
            // txtBillDate
            // 
            this.txtBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBillDate.Location = new System.Drawing.Point(156, 74);
            this.txtBillDate.Name = "txtBillDate";
            this.txtBillDate.Size = new System.Drawing.Size(116, 26);
            this.txtBillDate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "تاريخ الفاتورة";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPaymentID.Location = new System.Drawing.Point(1, 0);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(36, 20);
            this.txtPaymentID.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataPayment);
            this.groupBox1.Controls.Add(this.BtnAddPayment);
            this.groupBox1.Controls.Add(this.BtnEditPayment);
            this.groupBox1.Controls.Add(this.BtnDeletePayment);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 351);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الدفع";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPaidAmount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRemainAmount);
            this.groupBox2.Controls.Add(this.BtnEditBill);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBillDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotalAmount);
            this.groupBox2.Controls.Add(this.comboPaymentStatus);
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.txtPaidFor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(51, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 160);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات الدفع";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "المدفوع";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidAmount.Location = new System.Drawing.Point(579, 125);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(100, 26);
            this.txtPaidAmount.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "المبلغ المتبقي";
            // 
            // txtRemainAmount
            // 
            this.txtRemainAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemainAmount.Location = new System.Drawing.Point(337, 122);
            this.txtRemainAmount.Name = "txtRemainAmount";
            this.txtRemainAmount.Size = new System.Drawing.Size(100, 26);
            this.txtRemainAmount.TabIndex = 19;
            // 
            // BtnEditBill
            // 
            this.BtnEditBill.Location = new System.Drawing.Point(20, 25);
            this.BtnEditBill.Name = "BtnEditBill";
            this.BtnEditBill.Size = new System.Drawing.Size(90, 30);
            this.BtnEditBill.TabIndex = 17;
            this.BtnEditBill.Text = "تعديل";
            this.BtnEditBill.UseVisualStyleBackColor = true;
            this.BtnEditBill.Click += new System.EventHandler(this.BtnEditBill_Click);
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
            this.navigationDrawer1.TabIndex = 20;
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 561);
            this.Controls.Add(this.navigationDrawer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPaymentID);
            this.Controls.Add(this.txtConsultID);
            this.Name = "bill";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "واجهة الفواتير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bill_FormClosing);
            this.Load += new System.EventHandler(this.bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPayment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPaidFor;
        private System.Windows.Forms.ComboBox comboPaymentStatus;
        private System.Windows.Forms.DataGridView dataPayment;
        private System.Windows.Forms.Button BtnAddPayment;
        private System.Windows.Forms.Button BtnEditPayment;
        private System.Windows.Forms.Button BtnDeletePayment;
        private System.Windows.Forms.TextBox txtConsultID;
        private System.Windows.Forms.TextBox txtBillDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEditBill;
        private NavigationDrawer navigationDrawer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemainAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaidAmount;
    }
}
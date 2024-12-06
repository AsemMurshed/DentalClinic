namespace DentalClinic
{
    partial class AddBill
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
            this.txtPaidFor = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddBill = new System.Windows.Forms.Button();
            this.txtConsultID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPaidFor
            // 
            this.txtPaidFor.Location = new System.Drawing.Point(26, 54);
            this.txtPaidFor.Multiline = true;
            this.txtPaidFor.Name = "txtPaidFor";
            this.txtPaidFor.Size = new System.Drawing.Size(312, 45);
            this.txtPaidFor.TabIndex = 14;
            this.txtPaidFor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidFor_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(26, 18);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 13;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(202, 18);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(136, 20);
            this.txtTotalAmount.TabIndex = 12;
            this.txtTotalAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "مقابل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "الخصم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "المبلغ الكلي";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Location = new System.Drawing.Point(30, 126);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddBill
            // 
            this.BtnAddBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddBill.Location = new System.Drawing.Point(111, 126);
            this.BtnAddBill.Name = "BtnAddBill";
            this.BtnAddBill.Size = new System.Drawing.Size(75, 23);
            this.BtnAddBill.TabIndex = 17;
            this.BtnAddBill.Text = "إضافة";
            this.BtnAddBill.UseVisualStyleBackColor = true;
            this.BtnAddBill.Click += new System.EventHandler(this.BtnAddBill_Click);
            // 
            // txtConsultID
            // 
            this.txtConsultID.BackColor = System.Drawing.SystemColors.Control;
            this.txtConsultID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsultID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtConsultID.Location = new System.Drawing.Point(0, 1);
            this.txtConsultID.Name = "txtConsultID";
            this.txtConsultID.Size = new System.Drawing.Size(28, 13);
            this.txtConsultID.TabIndex = 19;
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.txtConsultID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddBill);
            this.Controls.Add(this.txtPaidFor);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(450, 220);
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "AddBill";
            this.Text = "إضافة فاتورة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaidFor;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddBill;
        private System.Windows.Forms.TextBox txtConsultID;
    }
}
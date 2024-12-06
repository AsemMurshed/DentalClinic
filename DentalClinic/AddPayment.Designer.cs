namespace DentalClinic
{
    partial class AddPayment
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddAmount = new System.Windows.Forms.Button();
            this.txtPaidBy = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(34, 115);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "إلغاء";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddAmount
            // 
            this.BtnAddAmount.Location = new System.Drawing.Point(115, 115);
            this.BtnAddAmount.Name = "BtnAddAmount";
            this.BtnAddAmount.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAmount.TabIndex = 15;
            this.BtnAddAmount.Text = "إضافة";
            this.BtnAddAmount.UseVisualStyleBackColor = true;
            this.BtnAddAmount.Click += new System.EventHandler(this.BtnAddAmount_Click);
            // 
            // txtPaidBy
            // 
            this.txtPaidBy.Location = new System.Drawing.Point(33, 71);
            this.txtPaidBy.Name = "txtPaidBy";
            this.txtPaidBy.Size = new System.Drawing.Size(183, 20);
            this.txtPaidBy.TabIndex = 14;
            this.txtPaidBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidBy_KeyPress);
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(33, 28);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(183, 20);
            this.txtPayAmount.TabIndex = 12;
            this.txtPayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayAmount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 78);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "مدفوعة من قبل:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "المبلغ:";
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddAmount);
            this.Controls.Add(this.txtPaidBy);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPayment";
            this.Text = "إضافة دفعة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddAmount;
        private System.Windows.Forms.TextBox txtPaidBy;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
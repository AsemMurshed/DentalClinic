using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class bill : Form
    {
        string BillID;
        string ConsultID;
        string PatientID;

        int RemainAmount=0;
        int total;
        int discount;
        int paid = 0;
      
        public bill(string ConsultID,string PatientID)
        {
            InitializeComponent();
            this.ConsultID = ConsultID;
            this.PatientID = PatientID;
            BillUdate();
            PaymentUpdate();           
        }

        public bill(string ConsultID)
        {
            InitializeComponent();
            this.ConsultID = ConsultID;
            BillUdate();
            PaymentUpdate();
        }

        void BillUdate()
        {           
            string comand = "select * from Bill where ConsultationID='" + ConsultID + "'";
            DataTable dt = globals.FillDataGridView(comand);

            BillID = dt.Rows[0]["BillID"].ToString();
            txtTotalAmount.Text = dt.Rows[0]["TotalAmount"].ToString();
            txtDiscount.Text = dt.Rows[0]["DisCount"].ToString();
            txtPaidFor.Text = dt.Rows[0]["PaidFor"].ToString();
            if(dt.Rows[0]["PaymentStatus"].ToString() == "سارية")
            {comboPaymentStatus.SelectedIndex = 0;}
            else
            {comboPaymentStatus.SelectedIndex = 1;}
            txtBillDate.Text = dt.Rows[0]["BillDate"].ToString();

            PaymentUpdate();
            total = int.Parse(txtTotalAmount.Text);
            discount = int.Parse(txtDiscount.Text);
            
        }


       void PaymentUpdate()
        {
            string comand = "select PaymentID, Amount as 'المبلغ' " +
                ",PaidBy as 'دفعت من قبل',PaymentDate as 'تاريخ الدفع' from Payment where BillID="+BillID+"";
            DataTable dt = globals.FillDataGridView(comand);
            
            dataPayment.DataSource = dt;
            txtPaymentID.DataBindings.Clear();
            txtPaymentID.DataBindings.Add("text", dt, "PaymentID");

            int sum = 0;
            
            foreach(DataRow r in dt.Rows)
            {
                sum += int.Parse(r["المبلغ"].ToString());
            }
            paid = sum;
            txtPaidAmount.Text = paid.ToString();
            RemainAmount = (total * (100 - discount) / 100) - paid;
            txtRemainAmount.Text = RemainAmount.ToString();

            if(RemainAmount <= 0)
            {globals.SwichBillStatus(BillID);}
            
        }

        private void BtnEditBill_Click(object sender, EventArgs e)
        {
            WinForms.AddBill(ConsultID, BillID, txtTotalAmount.Text, txtDiscount.Text,
                txtPaidFor.Text, comboPaymentStatus.Text).ShowDialog();            
            BillUdate();
        }

        private void BtnAddPayment_Click(object sender, EventArgs e)
        {
            WinForms.AddPayment(BillID).ShowDialog();            
            BillUdate();
            PaymentUpdate();
        }

        private void BtnDeletePayment_Click(object sender, EventArgs e)
        {
            if(txtPaymentID.Text != "")
            {
                globals.DeleteSqlComand("Payment", "PaymentID", txtPaymentID.Text);
                PaymentUpdate();
            }            
        }

        private void bill_Load(object sender, EventArgs e)
        {
            if (globals.isAdministrator())
            {
                BtnEditBill.Visible = true;
                BtnEditPayment.Visible = true;
                BtnDeletePayment.Visible = true;
            }
            else
            {
                BtnEditBill.Visible = false;
                BtnEditPayment.Visible = false;
                BtnDeletePayment.Visible = false;
            }                
        }

        private void BtnEditPayment_Click(object sender, EventArgs e)
        {
            if(txtPaymentID.Text != "")
            {
                var amount = dataPayment.Rows[0].Cells[0].Value.ToString();
                var paidBy = dataPayment.Rows[0].Cells[1].Value.ToString();
                WinForms.AddPayment(txtPaymentID.Text,amount, paidBy).ShowDialog();
            }            
        }

        private void bill_FormClosing(object sender, FormClosingEventArgs e)
        {            
            WinForms.PatientRecord(PatientID).Show();
            this.Hide();
            e.Cancel = true;
        }
    }
}

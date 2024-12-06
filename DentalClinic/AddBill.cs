using System;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class AddBill : Form
    {
        string ConsultID = "";
        string BillID = "";
        string PatientID = "";

        public AddBill(string Cid, string Pid)
        {
            InitializeComponent();
            this.ConsultID = Cid;
            this.PatientID = Pid;
            txtConsultID.Text = ConsultID;
        }

        public AddBill(string ConsultID, string BillID, string TotalAmount, string Discount, string PaidFor, string PaymentStatus)
        {
            InitializeComponent();          
            this.Size = MaximumSize;
            this.ConsultID = ConsultID;
            txtConsultID.Text = ConsultID;
            this.BillID = BillID;

            txtTotalAmount.Text = TotalAmount;
            txtDiscount.Text = Discount;
            txtPaidFor.Text = PaidFor;
            
        }

        private void BtnAddBill_Click(object sender, EventArgs e)
        {
            if (BillID == "")
            {addBill();}
            else
            {editBill();}            
        }


        private void addBill()
        {            
            if (txtTotalAmount.Text != "" && txtDiscount.Text != "" && txtPaidFor.Text != "")
            {                
                string command ="INSERT INTO Bill (ConsultationID,BillDate,TotalAmount,PaidFor,Discount,PaymentStatus)" +
                    " VALUES ('" + ConsultID + "','" + DateTime.Now + "','" + txtTotalAmount.Text + "'" +
                    ",'" + txtPaidFor.Text + "','" + txtDiscount.Text + "','سارية')";
                                
                globals.InsertUpdateSqlComand(command);
                this.DialogResult = DialogResult.OK;
                
                WinForms.Bill(ConsultID,PatientID).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }


        private void editBill()
        {                        
            if (txtTotalAmount.Text != "" && txtDiscount.Text != "" && txtPaidFor.Text != "")
            {               
                string command =
                    "UPDATE Bill SET TotalAmount=" + txtTotalAmount.Text + ", PaidFor='" + txtPaidFor.Text + "', " +
                    "Discount="+ txtDiscount.Text +" WHERE BillID="+ BillID +"";

                globals.InsertUpdateSqlComand(command);
                this.Hide();                
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPaidFor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}

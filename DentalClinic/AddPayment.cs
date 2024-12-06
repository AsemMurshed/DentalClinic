using System;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class AddPayment : Form
    {
        string BillID = "";
        string PayID = "";

        public AddPayment(string BillID)
        {
            InitializeComponent();
            this.BillID = BillID;
        }

        public AddPayment(string PayID ,string Amount, string PaidBy)
        {
            InitializeComponent();
            this.PayID = PayID;
            txtPayAmount.Text = Amount;
            txtPaidBy.Text = PaidBy;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAddAmount_Click(object sender, EventArgs e)
        {            
            if(BillID != "")
            {addPayment();}
            else
            {editPayment();}
        }

        void addPayment()
        {
            if (txtPayAmount.Text != "" && txtPaidBy.Text != "")
            {
                string Command =
                    "INSERT INTO Payment (BillID,PaymentDate,Amount,PaidBy)" +
                    " VALUES ('" + BillID + "','" + DateTime.Now + "','" + txtPayAmount.Text + "'" +
                    ",'" + txtPaidBy.Text + "')";

                globals.InsertUpdateSqlComand(Command);
                this.Hide();                               
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }

        void editPayment()
        {
            if (txtPayAmount.Text != "" && txtPaidBy.Text != "")
            {
                string Command = "UPDATE Payment SET Amount='" + txtPayAmount.Text + "', " +
                    "PaidBy='" + txtPaidBy.Text + "' WHERE PaymentID='" + PayID + "'";

                globals.InsertUpdateSqlComand(Command);
                this.Hide();
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
            }
        }

        private void txtPayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPaidBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}

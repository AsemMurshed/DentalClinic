using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            update();
            comboSearchBy.SelectedIndex = 0;
        }    


        void update()
        {                  
            string comand = "select StaffID, S_Fname as 'الاسم الأول' ,S_Mname as 'الاسم الأوسط',S_LName as 'اللقب'" +
                ",S_Add as 'العنوان'," +"S_contact as 'رقم الجوال',S_Username as 'المستخدم',S_Password as 'كلمة السر'" +
                ",S_Restriction as 'نوع القيد' from Staff";
            DataTable dt = globals.FillDataGridView(comand);
           
            dataStaff.DataSource = dt;
            txtStaffID.DataBindings.Clear();
            txtStaffID.DataBindings.Add("text", dt, "StaffID");            
        }


        private void Staff_Load(object sender, EventArgs e)
        {
            
        }
                  

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("هل تريد إغلاق البرنامج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.ExitThread();
                }
                else { e.Cancel = true; }
            }
            else { e.Cancel = true; }
        }
                   

        private void BtnِADD_Click(object sender, EventArgs e)
        {
            WinForms.AddStaff().ShowDialog();
            //AddStaff = new Signup();
            //AddStaff.ShowDialog();
            update();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(dataStaff.Rows.Count > 0)
            {
                var id = txtStaffID.Text;
                var fname = dataStaff.SelectedRows[0].Cells[0].Value.ToString();
                var mname = dataStaff.SelectedRows[0].Cells[1].Value.ToString();
                var lname = dataStaff.SelectedRows[0].Cells[2].Value.ToString();
                var addrress = dataStaff.SelectedRows[0].Cells[3].Value.ToString();
                var contact = dataStaff.SelectedRows[0].Cells[4].Value.ToString();
                var user = dataStaff.SelectedRows[0].Cells[5].Value.ToString().ToLower();
                var pass = dataStaff.SelectedRows[0].Cells[6].Value.ToString().ToLower();
                var restriction = dataStaff.SelectedRows[0].Cells[7].Value.ToString();

                WinForms.AddStaff(txtStaffID.Text).ShowDialog();
                //EditStaff = new Signup(id, fname, mname, lname, addrress, contact, user, pass, restriction);
                //EditStaff.ShowDialog();
                update();
            }            
        }

        private void txtStaffSearch_TextChanged(object sender, EventArgs e)
        {
            string comand = "";
            if (comboSearchBy.Text == "الاسم")
            {
                comand ="select StaffID, S_Fname as 'الاسم الأول' ,S_Mname as 'الاسم الأوسط',S_LName as 'اللقب'" +
                    ",S_Add as 'العنوان',S_contact as 'رقم الجوال',S_Username as 'المستخدم'" +
                    ",S_Password as 'كلمة السر',S_Restriction as 'نوع القيد' from Staff " +
                    "where CONCAT_WS('',S_Fname,' ', S_Mname,' ',S_LName) like '"+txtStaffSearch.Text+"%'";                
            }
            else if (comboSearchBy.Text == "الرقم")
            {
                comand ="select StaffID, S_Fname as 'الاسم الأول' ,S_Mname as 'الاسم الأوسط',S_LName as 'اللقب'" +
                    ",S_Add as 'العنوان',S_contact as 'رقم الجوال',S_Username as 'المستخدم'" +
                    ",S_Password as 'كلمة السر',S_Restriction as 'نوع القيد' from Staff " +
                    "where S_Contact like '" + txtStaffSearch.Text + "%'";                           
            }
            DataTable dt = globals.FillDataGridView(comand);
            dataStaff.DataSource = dt;
        }

        private void Staff_SizeChanged(object sender, EventArgs e)
        {
             var width = this.Width;
             dataStaff.Width = (int)(width * 0.8);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            globals.DeleteSqlComand("Staff", "StaffID", txtStaffID.Text);
            update();
        }
    }

}

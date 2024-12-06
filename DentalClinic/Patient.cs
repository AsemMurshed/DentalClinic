using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class frmEmployee : Form
    {

        string PatientID="";
        public frmEmployee()
        {
            InitializeComponent();          
            comboBoxSearchBy.SelectedIndex = 0;            
            update();
        }
      
              
        public void update()
        {                                
            string comand = "select PatientID, P_FName as 'الاسم الأول' ,P_MName as 'الاسم الأوسط',P_LName as 'اللقب'" +
                ",P_BirthDate as 'تاريخ الميلاد',P_Sex as 'الجنس',P_Add as 'العنوان',P_contact as 'رقم الجوال' from Patient";            
            DataTable dt = globals.FillDataGridView(comand);            
            dataPatient.DataSource = dt;
            txtPatientID.DataBindings.Clear();
            txtPatientID.DataBindings.Add("text", dt, "PatientID");                    
        }

        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("هل تريد إغلاق البرنامج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.ExitThread();
                    e.Cancel = false;                    
                }
                else { e.Cancel = true; }
            }
            else { e.Cancel = true; }
        }
       

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            update();
            if (globals.isAdministrator())
            {DelBtn.Visible = true;}
            else
                DelBtn.Visible = false;
        }    
                                                            

        private void EditBtn_Click(object sender, EventArgs e)
        {   
            if(dataPatient.Rows.Count > 0)
            {
                //var FName = dataPatient.SelectedRows[0].Cells[0].Value.ToString();
                //var MName = dataPatient.SelectedRows[0].Cells[1].Value.ToString();
                //var LName = dataPatient.SelectedRows[0].Cells[2].Value.ToString();
                //var date = dataPatient.SelectedRows[0].Cells[3].Value.ToString();
                //var birthDate = DateTime.Parse(date);
                //var Sex = dataPatient.SelectedRows[0].Cells[4].Value.ToString();
                //var Address = dataPatient.SelectedRows[0].Cells[5].Value.ToString();
                //var Contact = dataPatient.SelectedRows[0].Cells[6].Value.ToString();

                //EditPatient = new AddEditPatient(txtPatientID.Text, FName, MName, LName, birthDate, Sex, Address, int.Parse(Contact));                
                //EditPatient.ShowDialog();
                WinForms.AddEditPatient(txtPatientID.Text).ShowDialog();
                update();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            WinForms.AddEditPatient().ShowDialog();
            //AddEditPatient = new AddEditPatient();            
            //AddEditPatient.ShowDialog();
            update();
        }            
              

        private void txtPatientSearch_TextChanged_1(object sender, EventArgs e)
        {
            string comand = "";
            if (comboBoxSearchBy.Text == "الاسم")
            {
                comand = "select PatientID, P_FName as 'الاسم الأول' ,P_MName as 'الاسم الأوسط'" +
                    ",P_LName as 'اللقب',P_BirthDate as 'تاريخ الميلاد',P_Sex as 'الجنس',P_Add as 'العنوان'" +
                    ",P_contact as 'رقم الجوال' from Patient " +
                    "where CONCAT_WS('',P_FName,' ', P_MName,' ',P_LName) like '"+txtPatientSearch.Text+"%'";                    
            }
            else if (comboBoxSearchBy.Text == "الرقم")
            {
                comand = "select PatientID, P_FName as 'الاسم الأول' ,P_MName as 'الاسم الأوسط'" +
                    ",P_LName as 'اللقب',P_BirthDate as 'تاريخ الميلاد',P_Sex as 'الجنس',P_Add as 'العنوان'" +
                    ",P_contact as 'رقم الجوال' from Patient where P_Contact like '"+txtPatientSearch.Text+"%'";                               
            }             
            DataTable dt = globals.FillDataGridView(comand);                      
                dataPatient.DataSource = dt;             
        }

     
        private void BtnPatientRecord_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text != "")
            {
                WinForms.PatientRecord(txtPatientID.Text).Show();                
                this.Hide();
            }            
        }
       

        private void txtPatientSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back 
                || e.KeyChar == (char)Keys.Space || char.IsDigit(e.KeyChar));
        }

        private void frmEmployee_SizeChanged(object sender, EventArgs e)
        {
            var width = this.Width;
            dataPatient.Width = (int)(width * 0.8);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if(txtPatientID.Text != "")
            {
                globals.DeleteSqlComand("Patient", "PatientID", txtPatientID.Text);
                update();
            }            
        }
    }
}

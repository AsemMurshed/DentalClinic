using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class AddEditPatient : Form
    {
        string PatientID = "";

        bool dateChanged = false;

        public AddEditPatient()
        {
            InitializeComponent();
            cboPatientSex.SelectedIndex = 0;            
        }

        //string Id,string Fname, string Mname, string Lname,DateTime birthDate,string sex, string address,int contact 
        public AddEditPatient(string Id )
        {
            InitializeComponent();
            string comand = "select PatientID,P_FName,P_MName,P_LName,P_BirthDate,P_Sex,P_Add,P_contact" +
                " from Patient where PatientID="+Id+"";
            DataTable dt = globals.FillDataGridView(comand);

            PatientID = dt.Rows[0]["PatientID"].ToString();
            txtPatientFName.Text = dt.Rows[0]["P_FName"].ToString();
            txtPatientLName.Text = dt.Rows[0]["P_LName"].ToString();
            txtPatientContact.Text = dt.Rows[0]["P_contact"].ToString();
            txtPatientAdd.Text = dt.Rows[0]["P_Add"].ToString();
            txtPatientMName.Text = dt.Rows[0]["P_MName"].ToString();
            cboPatientSex.Text = dt.Rows[0]["P_Sex"].ToString();
            dateTimePatientBirthDate.Value = (DateTime)dt.Rows[0]["P_BirthDate"];            
        }
       

        private void addPatient()
        {           
            if (txtPatientFName.Text != "" && txtPatientLName.Text != "" && txtPatientMName.Text != "" && dateChanged == true && cboPatientSex.Text != "" && txtPatientAdd.Text != "" && txtPatientContact.Text != "")
            {                
                string command = "INSERT INTO Patient (P_LName,P_FName,P_MName,P_BirthDate,P_Sex,P_Add,P_Contact)" +
                    " VALUES ('"+txtPatientLName.Text+"','"+txtPatientFName.Text+"','"+txtPatientMName.Text+"'"+
                    ",'"+dateTimePatientBirthDate.Value+"','"+cboPatientSex.Text+"','"+txtPatientAdd.Text+"'"+
                    "," + int.Parse(txtPatientContact.Text) + ")";

                globals.InsertUpdateSqlComand(command);                    
                this.Hide();                          
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
                if (dateChanged == false)
                {
                    dateTimePatientBirthDate.Focus();
                }
                foreach (Control txtBox in this.Controls)
                {
                    if(txtBox is TextBox)
                    {
                      if(txtBox.Text == "")
                        {
                            txtBox.Focus();                            
                            break;
                        }                         
                    }                    
                }                 
            }
        }


        private void editPatient()
        {            
            if (txtPatientFName.Text != "" && txtPatientLName.Text != "" && txtPatientMName.Text != "" && cboPatientSex.Text != "" && txtPatientAdd.Text != "" && txtPatientContact.Text != "")
            {                
                string comand = "UPDATE Patient SET P_FName='" + txtPatientFName.Text + "', " +
                    "P_LName='" + txtPatientLName.Text + "', P_MName='" + txtPatientMName.Text + "', " +
                    "P_BirthDate = '" + dateTimePatientBirthDate.Value + "', P_Sex='" + cboPatientSex.Text +
                    "', P_Add ='" + txtPatientAdd.Text + "', P_Contact=" + txtPatientContact.Text + " " +
                    "WHERE PatientID=" + PatientID + "";

                globals.InsertUpdateSqlComand(comand);
                this.Hide();                
            }
            else
            {
                MessageBox.Show("هناك حقول فارغة");
                foreach (Control txtBox in this.Controls)
                {
                    if (txtBox is TextBox)
                    {
                        if (txtBox.Text == "")
                        {
                            txtBox.Focus();
                            break;
                        }
                    }
                }
            }
        }

        private void clear()
        {            
            txtPatientFName.Text = "";
            txtPatientLName.Text = "";
            txtPatientContact.Text = "";
            txtPatientAdd.Text = "";
            txtPatientMName.Text = "";
            cboPatientSex.Text = "";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (PatientID == "")
            {
                addPatient();
            }
            else
            {
                editPatient();
            }           
        }

        private void cancel_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void AddEditPatient_Load(object sender, EventArgs e)
        {

        }

        private void AddEditPatient_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtPatientFName_KeyPress(object sender, KeyPressEventArgs e)
        {           
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtPatientMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtPatientLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtPatientAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtPatientContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void dateTimePatientBirthDate_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }
    }
}

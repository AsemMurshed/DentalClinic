using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class AddStaff : Form
    {

        string StaffID = "";

        public AddStaff()
        {
            InitializeComponent();            
        }

        public AddStaff(string id/*,string fname,string mname,string lname,string address,string contact,string user,string pass ,string restriction*/)
        {
            InitializeComponent();            

            string comand = "select StaffID, S_Fname,S_Mname,S_LName" +
                ",S_Add,S_contact,S_Username,S_Password" +
                ",S_Restriction from Staff whrer StaffID= "+id+"";
            DataTable dt = globals.FillDataGridView(comand);

            StaffID = id;
            txtEmpFName.Text = dt.Rows[0]["S_Fname"].ToString(); 
            txtEmpMName.Text = dt.Rows[0]["S_Mname"].ToString();
            txtEmpLName.Text = dt.Rows[0]["S_LName"].ToString();
            txtEmpAdd.Text = dt.Rows[0]["S_Add"].ToString();
            txtEmpContact.Text = dt.Rows[0]["S_contact"].ToString();
            txtEmpUser.Text = dt.Rows[0]["S_Username"].ToString();
            txtEmpPass.Text = dt.Rows[0]["S_Password"].ToString();
            cboEmpRestriction.Text = dt.Rows[0]["S_Restriction"].ToString();
        }
 
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(StaffID == "")
            { addStaff(); }
            else
            {  EditStaff(); }           
        }

        private void addStaff()
        {         
            if (txtEmpFName.Text != "" && txtEmpLName.Text != "" && txtEmpMName.Text != "" && txtEmpAdd.Text != "" && txtEmpContact.Text != "" && txtEmpUser.Text != "" && txtEmpPass.Text != "" && cboEmpRestriction.Text != "")
            {
                string comand = "INSERT INTO Staff (S_LName,S_Fname,S_Mname,S_Add,S_Contact,S_Username,S_Password,S_Restriction) " +
                    "VALUES ( '" + txtEmpLName.Text + "','" + txtEmpFName.Text + "' , '" + txtEmpMName.Text + "' , '" + txtEmpAdd.Text + "' " +
                    ", " + txtEmpContact.Text + " , '" + txtEmpUser.Text + "' ,'" + txtEmpPass.Text + "' ,'" + cboEmpRestriction.Text + "')";
                
                try
                {
                    globals.InsertUpdateSqlComand(comand);                                                 
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ");
                }
                finally
                {                    
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("توجد حقول فارغة");
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


        private void EditStaff()
        {           
            if (txtEmpFName.Text != "" && txtEmpLName.Text != "" && txtEmpMName.Text != "" && txtEmpAdd.Text != "" && txtEmpContact.Text != "" && txtEmpUser.Text != "" && txtEmpPass.Text != "" && cboEmpRestriction.Text != "")
            {
                string comand = "UPDATE Staff SET S_Fname='" + txtEmpFName.Text + "', S_LName='" + txtEmpLName.Text + "', S_Mname='"
                    + txtEmpMName.Text + "', S_Add = '" + txtEmpAdd.Text+ "', S_Contact=" + txtEmpContact.Text + "" +
                    ",S_Username='" + txtEmpUser.Text + "', S_Password='" + txtEmpPass.Text + "', S_Restriction='" 
                    + cboEmpRestriction.Text +  "' WHERE StaffID=" + StaffID + "";                

                try
                {
                    globals.InsertUpdateSqlComand(comand);                                        
                }
                catch (Exception e)
                {                  
                    MessageBox.Show(e.Message);
                }
                finally
                {                    
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("توجد حقول فارغة");
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

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;            
        }
        

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            cboEmpRestriction.SelectedIndex = 0;
        }

        private void cboEmpRestriction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear()
        {            
            txtEmpFName.Text = "";
            txtEmpMName.Text = "";
            txtEmpLName.Text = "";
            txtEmpAdd.Text = "";
            txtEmpContact.Text = "";
            txtEmpUser.Text = "";
            txtEmpPass.Text = "";
            cboEmpRestriction.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtEmpFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEmpMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEmpLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEmpAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEmpContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtEmpUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEmpPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar > 1569 || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

/*

DentistID,D_LName,D_FName,D_MName,D_Add,D_Contact,D_Username,D_Password
*/

//Provider=Microsoft.ACE.OLEDB.12.0;Data Source= B:\warehouse\dental clinic\other\DentalClinic-master\DentalClinic-master\DentalClinic\DentalClinic\DentalClinic.accdb;
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Family\Source\Repos\DentalClinic\DentalClinic\DentalClinic\DentalClinic.accdb
//string connString = @"Data Source=MKT106-SC-19;Initial Catalog=DentalClinic;Integrated Security=True";
//protected string DBFileName = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + Path.GetFullPath(".\\") + "DentalClinic.accdb";
//public void insertData(int sID, string sLast, string sFirst, int sAge, int sContact, string sUser, string sPass, string sRestrict)
//{
////    OleDbConnection DBConnection = new OleDbConnection(DBFileName);
////    MessageBox.Show(DBFileName);
////    //DBConnection.ConnectionString = DBFileName;

////    OleDbCommand DBCommand = new OleDbCommand("INSERT into Staff (StaffID, S_LName, S_FName, S_Age, S_Contact, S_Username, S_Password, S_Restriction) Values(@sID, @sLast, @sFirst, @sAge, @sContact, @sUser, @sPass, @sRestrict)",DBConnection);
////    //DBCommand.Connection = DBConnection;
////    DBConnection.Open();
////    if (DBConnection.State == ConnectionState.Open)
////    {
////        DBCommand.Parameters.Add("@StaffID", OleDbType.Integer).Value = sID;
////        DBCommand.Parameters.Add("@S_LName", OleDbType.VarChar).Value = sLast;
////        DBCommand.Parameters.Add("@S_FName", OleDbType.VarChar).Value = sFirst;
////        DBCommand.Parameters.Add("@S_Age", OleDbType.Integer).Value = sAge;
////        DBCommand.Parameters.Add("@S_Contact", OleDbType.Integer).Value = sContact;
////        DBCommand.Parameters.Add("@S_Username", OleDbType.VarChar).Value = sUser;
////        DBCommand.Parameters.Add("@S_Password", OleDbType.VarChar).Value = sPass;
////        DBCommand.Parameters.Add("@S_Restriction", OleDbType.VarChar).Value = sRestrict;
////        try
////        {
////            DBCommand.ExecuteNonQuery();
////            MessageBox.Show("Data Added successfully!");
////            DBConnection.Close();

////        }
////        catch (OleDbException DB_Exception)
////        {
////            MessageBox.Show(DB_Exception.Source + "\n" + DB_Exception.Message);
////        }
////        finally
////        {
////            DBConnection.Close();
////        }
////    }
////    else
////    {
////        MessageBox.Show("Something's wrong with Database connection, Check Directory.");
////    }
//}
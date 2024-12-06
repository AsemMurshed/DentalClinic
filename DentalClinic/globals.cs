using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

using SQLib;
using System.IO;

namespace DentalClinic
{
    public class globals : Internals.Credentials
    {
        private static string dataProvider = "AsemAlmoliki";
        public static string DataProvider
        {
            get { return dataProvider; }
            set { dataProvider = value; }
        }

        private static string dataSource = "DentalClinic";
        public static string DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }

        public static SQLLib sQuery = new SQLLib(DataProvider, DataSource);
       
       

        /// <summary>
        /// Check from database if exist
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="primaryKeyField"></param>
        /// <param name="primaryKeyValue"></param>
        /// <param name="targetFieldName"></param>
        /// <param name="stringToMatch"></param>
        /// <returns></returns>
        public static bool isExist(string tableName, string primaryKeyField, string primaryKeyValue, string targetFieldName, string stringToMatch)
        {
            sQuery.Command = @"SELECT * FROM " + tableName + " WHERE " + primaryKeyField + " = '" + primaryKeyValue + "'";
            bool result = false;
            string str1 = "", str2 = "";
            str1 = sQuery.getData(tableName, primaryKeyField, primaryKeyValue, targetFieldName);
            str2 = stringToMatch;
            if (str1 == str2)
            {
                result = true;
            }
            else
            { result = false; }
            return result;
        }

        /// <summary>
        /// Check if Administrator
        /// </summary>
        /// <returns></returns>
        public static bool isAdministrator()
        {
            bool result = false;
            if (globals.Restriction != null) { 
            if (globals. Restriction.Equals("مسؤول"))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            }
            return result;
        }

        /// <summary>
        /// Check if Appointment
        /// </summary>
        /// <returns></returns>
        public static bool isDentist()
        {
            bool result = false;
            if (Restriction.Contains("Appointment") || Restriction.Contains("Appointment".ToLower()) || Restriction.Contains("Appointment".ToUpper()))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Check if Assistant
        /// </summary>
        /// <returns></returns>
        public static bool isAssistant()
        {
            bool result = false;
            if (Restriction.Contains("Assistant") || Restriction.Contains("Assistant".ToLower()) || Restriction.Contains("Assistant".ToUpper()))
            { result = true; }
            else if (Restriction.Contains("Employee") || Restriction.Contains("Employee".ToLower()) || Restriction.Contains("Employee".ToUpper()))
            { result = true; }
            else if (Restriction.Contains("Staff") || Restriction.Contains("Staff".ToUpper()) || Restriction.Contains("Staff".ToLower()))
            { result = true; }
            else
            { result = false; }
            return result;
        }

        /// <summary>
        /// Store credentials to accessible global variables
        /// </summary>
        /// <param name="_username"></param>
        /// <param name="_password"></param>
        /// <param name="_restriction"></param>
        public static void setCredentials(string _username, string _password, string _restriction, string _staffID)
        {
            Username = _username;
            Password = _password;
            Restriction = _restriction;
            StaffID = _staffID;
        }



        /// <summary>
        /// Exeute sql query and return datatable
        /// </summary>
        /// <param name="comand"></param>       
        /// <returns></returns>
        public static DataTable FillDataGridView(string comand)
        {
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            adapt = new SqlDataAdapter(comand, con);
            dt = new DataTable();
            adapt.Fill(dt);
            dt.Columns[0].ColumnMapping = MappingType.Hidden;
            con.Close();
            return dt;
        }


        /// <summary>
        /// Exeute sql Delete comand
        /// </summary>
        /// <param name="tableName"></param>       
        /// <param name="primaryKey"></param> 
        /// <param name="id"></param> 
        public static void DeleteSqlComand(string tableName, string primaryKey, string id)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + tableName + " WHERE "+primaryKey+" ='" + id + "'", con);

            try 
            {
                var count = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           finally
            {
                con.Close();
            }
              
        }


        /// <summary>
        /// Exeute insert & update sql comands
        /// </summary>
        /// <param name="comand"></param>       
      
        public static string InsertUpdateSqlComand(string comand)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            con.Open();
            SqlCommand cmd = new SqlCommand(comand+ "SELECT SCOPE_IDENTITY();", con);
            var result = "";
            try
            {
                result = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;

        }


        /// <summary>
        /// Change Record "PaymentStatus" in Bill table
        /// </summary>
        /// <param name="BillID"></param>       

        public static void SwichBillStatus(string BillID)
        {
            SqlConnection con = new SqlConnection(sQuery.ConnectString());
            string command ="UPDATE Bill SET PaymentStatus = 'منتهية' WHERE BillID="+ BillID +"";
            con.Open();
            SqlCommand cmd = new SqlCommand(command , con);
            
            try
            {
                cmd.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }           

        }

        /// <summary>
        /// clear deleted images from project files
        /// </summary>
         
        public static void clearDeletedImgs()
        {
            DataTable paths = new DataTable();
            DirectoryInfo imgs = new DirectoryInfo("../../ConsultationImages/");
            FileInfo[] fileInfo = imgs.GetFiles();
            foreach (FileInfo file in fileInfo)
            {
                string comand = "select ImageID,Path from Image where Path= '" + file.Name.ToString() + "'";
                paths.Clear();
                paths = globals.FillDataGridView(comand);
                if (paths.Rows.Count > 0)
                { }
                else
                { File.Delete(file.FullName); }
            }
        }

    }
}

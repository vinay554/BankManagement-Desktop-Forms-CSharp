using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace BankingApplication
{
    internal class BankIntermediary
    {
        //property to hold last error
        public string LastError { get; set; }

        //function for creating new account for a customer by collecting all data
        public int AddCustomer (decimal accountno, String name,System.DateTime dob,String number,
           String address,String city, String state,String gender, String maritalstatus, String mother, String father, decimal bal, String date)
        {
            BankDataClass bankdata = new BankDataClass();

            string sqlQuery = "Insert into UserAcc values (@Account_No,@Name,@DOB,@PhoneNo,@Address,@City,@State,@Gender,@Marital_Status,@Mother_name,@Father_Name,@Balance,@Date);";
            

            SqlParameter param1 = new SqlParameter("@Account_No",SqlDbType.Decimal);
            param1.Value = accountno;            
            SqlParameter param2 = new SqlParameter("@Name", SqlDbType.NVarChar);
            param2.Value = name;
            SqlParameter param3 = new SqlParameter("@DOB", SqlDbType.DateTime);
            param3.Value = dob;
            SqlParameter param4 = new SqlParameter("@PhoneNo", SqlDbType.NVarChar);
            param4.Value = number;
            SqlParameter param5 = new SqlParameter("@Address", SqlDbType.NVarChar);
            param5.Value = address;
            SqlParameter param6 = new SqlParameter("@City", SqlDbType.NVarChar);
            param6.Value = city;
            SqlParameter param7 = new SqlParameter("@State", SqlDbType.NVarChar);
            param7.Value = state;
            SqlParameter param8 = new SqlParameter("@Gender", SqlDbType.NVarChar);
            param8.Value = gender;
            SqlParameter param9 = new SqlParameter("@Marital_Status", SqlDbType.NVarChar);
            param9.Value = maritalstatus;
            SqlParameter param10 = new SqlParameter("@Mother_name", SqlDbType.NVarChar);
            param10.Value = mother;
            SqlParameter param11 = new SqlParameter("@Father_Name",SqlDbType.NVarChar);
            param11.Value = father;
            SqlParameter param12 = new SqlParameter("@Balance", SqlDbType.Decimal);
            param12.Value = bal;
            SqlParameter param13 = new SqlParameter("@Date", SqlDbType.NVarChar);
            param13.Value = date;
            

            try
            {
                //instantiate class
                return bankdata.ExecNonQuery(sqlQuery, System.Data.CommandType.Text, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
            }//try
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }//catch
        }//AddCustomer()

        //function to display all customers list
        public DataTable GetAllCustomers()
        {
            BankDataClass bankdata = new BankDataClass();
            string sqlstring = "select * from UserAcc;";
            try
            {
                DataSet customersDataSet = bankdata.GetDataSet(sqlstring);
                return customersDataSet.Tables[0];
            }//try
            catch (Exception ex)
            {
                LastError=ex.Message;
                return null;
            }//catch
        }//GetAllCustomers()
        //function to update the customer data
        public int ModifyCustomer(decimal accountno, String name, System.DateTime dob, String number,
           String address, String city, String state, String gender, String maritalstatus, String mother, String father, decimal bal, String date)
        {
            BankDataClass bankdata = new BankDataClass();

            string sqlQuery = "UPDATE UserAcc SET Name='" + name + "',DOB='" + dob + "',PhoneNo='" + number + "',Address='" + address + "',City='" + city + "',State='" + state + "',Gender='" + gender + "',Marital_Status='" + maritalstatus + "',Mother_name='" + mother + "',Father_Name='" + father + "',Balance='" + bal + "',Date='" + date + "' WHERE Account_No='" + accountno + "'";


            SqlParameter param1 = new SqlParameter("@Account_No", SqlDbType.Decimal);
            param1.Value = accountno;
            SqlParameter param2 = new SqlParameter("@Name", SqlDbType.NVarChar);
            param2.Value = name;
            SqlParameter param3 = new SqlParameter("@DOB", SqlDbType.DateTime);
            param3.Value = dob;
            SqlParameter param4 = new SqlParameter("@PhoneNo", SqlDbType.NVarChar);
            param4.Value = number;
            SqlParameter param5 = new SqlParameter("@Address", SqlDbType.NVarChar);
            param5.Value = address;
            SqlParameter param6 = new SqlParameter("@City", SqlDbType.NVarChar);
            param6.Value = city;
            SqlParameter param7 = new SqlParameter("@State", SqlDbType.NVarChar);
            param7.Value = state;
            SqlParameter param8 = new SqlParameter("@Gender", SqlDbType.NVarChar);
            param8.Value = gender;
            SqlParameter param9 = new SqlParameter("@Marital_Status", SqlDbType.NVarChar);
            param9.Value = maritalstatus;
            SqlParameter param10 = new SqlParameter("@Mother_name", SqlDbType.NVarChar);
            param10.Value = mother;
            SqlParameter param11 = new SqlParameter("@Father_Name", SqlDbType.NVarChar);
            param11.Value = father;
            SqlParameter param12 = new SqlParameter("@Balance", SqlDbType.Decimal);
            param12.Value = bal;
            SqlParameter param13 = new SqlParameter("@Date", SqlDbType.NVarChar);
            param13.Value = date;


            try
            {
                return bankdata.ExecNonQuery(sqlQuery, System.Data.CommandType.Text, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13);
            }//try
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }//catch
        }//ModifyCustomer()

        //function to deposit an amount into an existing account
        public int Deposit(decimal acno, string name, decimal bal, string mode, decimal dep, string date)
        {
            BankDataClass bankdata = new BankDataClass();

            string sqlQuery1 = "INSERT into Deposit(AccountNo,Name,OldBalance,Mode,DepAmount,Date) values('" + acno + "','" + name + "','" + bal + "','" + mode + "','" + dep + "','" + date + "')";
            string sqlQuery2 = "UPDATE UserAcc SET Balance='" + (bal + dep) + "' WHERE Account_No='" + acno + "'";



            try
            {
                return bankdata.ExecNonQuery(sqlQuery1, System.Data.CommandType.Text) & bankdata.ExecNonQuery(sqlQuery2, System.Data.CommandType.Text);
            }//try
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }//catch
            

            
        }//Deposit()

        public int Withdraw(decimal acno, string name, decimal bal, string mode, decimal deb, string date)
        {
            BankDataClass bankdata = new BankDataClass();

            string sqlQuery1 = "INSERT into debit(AccountNo,Name,OldBalance,Mode,DebAmount,Date) values('" + acno + "','" + name + "','" + bal + "','" + mode + "','" + deb + "','" + date + "')";
            string sqlQuery2 = "UPDATE UserAcc SET Balance='" + (bal - deb) + "' WHERE Account_No='" + acno + "'";



            try
            {
                return bankdata.ExecNonQuery(sqlQuery1, System.Data.CommandType.Text) & bankdata.ExecNonQuery(sqlQuery2, System.Data.CommandType.Text);
            }//try
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }//catch



        }//Withdraw()

        public int Transfer(decimal fromacno, string fromname, decimal toacno, string toname, decimal bal, decimal tra, string date, decimal dbal)
        {
            BankDataClass bankdata = new BankDataClass();

            string sqlQuery1 = "INSERT into Transfer(Date,FromAccount,FromName,Balance,ToAccount,ToName) values('" + date + "','" + fromacno + "','" + fromname + "','" + tra + "','" + toacno + "','" + toname + "')";
            string sqlQuery2 = "UPDATE UserAcc SET Balance='" + (bal - tra) + "' WHERE Account_No='" + fromacno + "'";
            string sqlQuery3 = "UPDATE UserAcc SET Balance='" + (dbal + tra) + "' WHERE Account_No='" + toacno + "'";



            try
            {
                return bankdata.ExecNonQuery(sqlQuery1, System.Data.CommandType.Text) & bankdata.ExecNonQuery(sqlQuery2, System.Data.CommandType.Text) & bankdata.ExecNonQuery(sqlQuery3, System.Data.CommandType.Text);
            }//try
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }//catch
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DatabaseNamespace
    {
        public class DatabaseHandler
        {
            //connection string
            MySql.Data.MySqlClient.MySqlConnection conn;

            //Connecting to the database and open the connection
            public void ConnectDatabase()
            {
                string myConnectionString = "server=35.184.196.71;uid=cs358;" +
                     "pwd=cs358;database=cs358database;";

                try
                {
                    conn = new MySql.Data.MySqlClient.MySqlConnection();
                    conn.ConnectionString = myConnectionString;
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //load bank account numbers to combobox
            public List<string> loadAccountNumbers()
            {
                List<String> accountList = new List<string>();
                try
                {
                    //connect database and open connection
                    ConnectDatabase();
                    //get all account numbers from database
                    string sql = "SELECT accountNumber FROM AccountInformation";
                    //submit the sql query 
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    //execute the sql query 
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    //add account numbers to cbxAccountNumber
                    while (rdr.Read())
                    {
                        
                        accountList.Add(rdr.GetString("accountNumber"));
                        
                    }
                    rdr.Close();//dispose the reader object

                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                }
                return accountList;
            }//end method loadAccountNumbers()


        //update balance using update statement
        public void updateBalance(decimal newbalance, string accountNum)
        {
            try
            {
                //connect database and open connection
                ConnectDatabase();
                //update balance in database
                string sql = "UPDATE AccountInformation SET balance = " + newbalance
                + " WHERE accountNumber = '" + accountNum + "'";
                //MySqlCommand constructor
                //Submit the sql query
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //execute sql query
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        //retrieve account information using select statement
        public void retrieveAccountInformation(string accountNum, out string pin, out string first, out decimal balance)
            {
                pin = null;
                first = null;
                balance = 0;
                try
                {
                    //connect database and open connection
                    ConnectDatabase();
                    //get account information
                    string sql = "SELECT pin, firstName, balance FROM AccountInformation " +
                                 "WHERE accountNumber = '" + accountNum + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    //get pin, first name and balance from rdr
                    while (rdr.Read())
                    {
                        pin = rdr.GetString("pin");
                        first = rdr.GetString("firstName"); 
                        balance = rdr.GetDecimal("balance");
                    }
                    rdr.Close();//dispose the reader object rdr 
                

                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                }
                
            }

           

           /*
            //create a database
            public void CreateDatabase()
            {
                    ConnectDatabase();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `CS358Database`;";
                    cmd.ExecuteNonQuery();
            }

            //create a table in database
            public void CreateTableATM()
            {
                try
                {
                    ConnectDatabase();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS `AccountInformation` (" +
                    "`accountNumber` VARCHAR(255)," +
                    "`pin` VARCHAR(255)," +
                    "`firstName` VARCHAR(255)," +
                    "`balance` DECIMAL," +
                    "PRIMARY KEY(accountNumber));";

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                }
            }

            //import data to table AccountInformation   
            public void ImportDataATM()
            {
                ExcecuteCommand("LOAD DATA LOCAL INFILE 'C:/Users/hui/Desktop/atm.txt' INTO TABLE AccountInformation COLUMNS TERMINATED BY '\t';");
            }
            */
            

        }
    }





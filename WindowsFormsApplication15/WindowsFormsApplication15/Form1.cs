using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseNamespace;
using System.Media;

namespace WindowsFormsApplication15
{


    

    
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer um = new System.Media.SoundPlayer();
        //create a DatabaseHandler object (to call methods in DatabaseHandler
        DatabaseHandler handler = new DatabaseHandler();


        //account number 
        string accountNum = "";


        //declare three more variables to store pin, first name and balance
        string pin = "";
        string firstname = "";
        decimal balance = 0.0m;
        bool withdrawl;




        public Form1()
        {
            InitializeComponent();
            //handler.ConnectDatabase();
        }
        public void disablekeys(bool value)
        {
            button1.Enabled = value;
            button2.Enabled = value;
            button3.Enabled = value;
            button4.Enabled = value;
            button5.Enabled = value;
            button6.Enabled = value;
            button7.Enabled = value;
            button8.Enabled = value;
            button9.Enabled = value;
            button10.Enabled = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Call method in database.cs to connect to the database
            /*try
            {
                handler.ConnectDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            //call method in database.cs to load account numbers
            try
            {
                List<string> accountList = handler.loadAccountNumbers();

                //add accounts to the combobox
                foreach (string eachaccount in accountList)
                {
                    cbxAccounts.Items.Add(eachaccount);
                }

                //update status
                //lbStatus.Text = lbStatus.Text + " Accounts Loaded";
            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            //Call method in database.cs to connect to the database
            //handler.ConnectDatabase();

            //update status
            //lbStatus.Text = lbStatus.Text + " Successfully Connected";
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
           
        }

        private void cbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //retrieve account number from the combobox
            accountNum = cbxAccounts.Text;
            tbxAccData.Text = "Please enter your Pin Number:";
            //MessageBox.Show(accountNum);

            /*//call a method in database.cs to retrieve more account information
            handler.retrieveAccountInformation(accountNum, out pin, out firstname, out balance);
            //display the retreived account information in textbox
            tbxAccData.Text = "Pin: " + pin + "\r\nFirst: " + firstname + "\r\nBalance: " + balance;

            //ask for pin number
            tbxAccData.Text = "Please enter your Pin Number:";
            if (pin != null)
            {
                tbxAccData.Text = "Pin: " + pin + "\r\nFirst: " + firstname + "\r\nBalance: " + balance;
            }*/


        }

        private void button11_Click(object sender, EventArgs e)
        {
            //retreive the new balance from the next box 
            

            //call from the method in database.cs to update the balance
            //

            //update status

            //lbStatus.Text = lbStatus.Text + " Balance Updated";
        }


        
        private void tbxData_Click(object sender, EventArgs e)
        {
            
            //display the retreived account information in textbox
            tbxAccData.Text = "Pin: " + pin + "\r\nFirst: " + firstname + "\r\nBalance: " + balance;

            //ask for pin number
            tbxPin.Text = "Please enter your Pin Number:";
            //while (true)
            //{
                //string input = pin;
                //if (input != pin) 
                //{
                    //tbxAccData.Text = "The pin number you entered is not correct. Please try again";
                //}
            //}
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            tbxPin.AppendText(bt.Text);
        }

        private void tbxNewBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            
            if (withdrawl == false)
            {


                //call a method in database.cs to retrieve more account information
                handler.retrieveAccountInformation(accountNum, out pin, out firstname, out balance);

                if (tbxPin.Text == pin)
                {
                    tbxAccData.Text = "Welcome, " + firstname;
                    //"Pin: " + pin + "\r\nFirst: " + firstname + "\r\nBalance: " + balance;
                }
                if (tbxPin.Text != pin)
                {
                    tbxAccData.Text = "You have entered a wrong pin. Please try again";
                }
            }
            else if (withdrawl == true)
            {
                btEnter.Enabled = false;
                tbxPin.Enabled = false;
                disablekeys(false);
                decimal amount = decimal.Parse(tbxPin.Text);
                balance = balance - amount;
                tbxAccData.Text = "Your new balance is: " + balance;
                handler.updateBalance(balance, accountNum);
            }

        }

        private void tbxAccData_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBalance_Click(object sender, EventArgs e)
        {
            tbxAccData.Text = "\r\nYour balance is: " + balance;
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            tbxPin.Clear();
            tbxAccData.Text = "Please enter the amount you want to withdraw: ";
            withdrawl = true;
            handler.updateBalance(balance, accountNum);
            
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            tbxPin.Clear();
        }
    }
}

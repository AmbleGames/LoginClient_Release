using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetaLoginClient_MySQL_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                //MySQL Connection String
                string myConnection = "server=SERVER;uid=USERNAME;pwd=PASSWORD";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                //Tabellen Verbindung
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("SELECT * DATABASE.TABLE", myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("Connected!");
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                //MySQL Connection String
                string myConnection = "server=SERVER;uid=USERNAME;pwd=PASSWORD";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("SELECT * from DATABASE.TABLE WHERE username='" + this.txtusername.Text + "' AND password='" + this.txtpassword.Text + "' ;", myConn);
                
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;

                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password is correct");
                    
                    Form Success = new Success();
                    Success.Show();

                    this.Hide();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password! Access denied!");

                }
                else
                    MessageBox.Show("Username and Password is not correct! Please try again!");
                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            this.AcceptButton = btnlogin;
        }
    }
}

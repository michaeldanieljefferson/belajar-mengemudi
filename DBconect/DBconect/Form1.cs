using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace DBconect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost; port=3306; username=root; password="; //initial database
                MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
                myDataAdapter.SelectCommand = new MySqlCommand("select * rentalpro.user;", myConn);// sql syntax
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter); //build data adapter
                myConn.Open();// start connection

                DataSet ds = new DataSet();

                MessageBox.Show("Conected");

                myConn.Close();// end connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from rentalpro.user where username= '"+this.textBox_username.Text + "' and password='"+ this.textBox_password.Text +"' ;",myConn);
                MySqlDataReader myReader;
                myConn.Open();

                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if(count == 1)
                {
                    // MessageBox.Show("WELCOME");
                    Insert ins = new Insert();
                    ins.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

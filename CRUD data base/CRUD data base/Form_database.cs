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

namespace CRUD_data_base
{
    public partial class Form_database : Form
    {
        DataTable dbdataset = new DataTable();
        public Form_database()
        {
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=";    //initial database
                MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
                myDataAdapter.SelectCommand = new MySqlCommand("select * phonebook.customer;", myConn);// sql syntax
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

        private void button_insert_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "insert into phonebook.customer (customer_ID, customer_name,customer_phone) values('','" + this.textBox_name.Text + " ',' " + this.textBox_phone.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Data Inserted Successfuly");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM phonebook.customer;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                //DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView_all.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_all_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_all.Rows[e.RowIndex];

            textBox_ID.Text = row.Cells["customer_ID"].Value.ToString();
            textBox_name.Text = row.Cells["customer_name"].Value.ToString();
            textBox_phone.Text = row.Cells["customer_phone"].Value.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = " UPDATE phonebook.customer  SET customer_name = '" + textBox_name.Text + "', customer_phone	= '" + textBox_phone.Text + "' WHERE customer_ID = '" + textBox_ID.Text + "'; ";

            //string Query = "insert into phonebook.customer (customer_ID, customer_name,customer_phone) values('','" + this.textBox_name.Text + " ',' " + this.textBox_phone.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Data Inserted Successfuly");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan menghapus data : " + textBox_name.Text + "?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string Query = " DELETE from phonebook.customer where customer_ID = '" + this.textBox_ID.Text + "'; ";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("Data Deleted Successfuly");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("customer_name LIKE '%{0}%'", textBox1.Text);
            dataGridView_all.DataSource = DV;
        }
    }
}

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

namespace jago_mengemudi
{
    public partial class Form_transaksi_teacher : Form
    {
        public Form_transaksi_teacher()
        {
            InitializeComponent();
        }
        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM jago_mengemudi.db_transaksi where  teacher_name='" + label_nama_guru.Text + "';", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridfinish.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridfinish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow isi = this.dataGridfinish.Rows[e.RowIndex];
                label_transaksiid.Text = isi.Cells["transaksi_id"].Value.ToString();
                label_studentid.Text = isi.Cells["student_id"].Value.ToString();
                label_nama_Student.Text = isi.Cells["student_name"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh_table();
        }


        private void button_finished_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = " UPDATE jago_mengemudi.db_transaksi SET status= 'Accepted' where teacher_name='" + label_nama_guru.Text + "' and transaksi_id='" + label_id_guru.Text + "'; ";

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
    }
}

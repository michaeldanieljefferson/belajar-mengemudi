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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "insert into rentalpro.db_customer (id_customer,nama,no_ktp,no_hp,alamat_customer) values('','" + this.tb_nama.Text + "','" + this.tb_KTP.Text + "','" + this.tb_HP.Text + "','" + this.tb_Alamat.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Inserted");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_table();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE rentalpro.db_customer SET nama= '" + this.update_nama.Text + "',no_ktp='" + this.update_KTP.Text + "',no_hp='" + this.update_HP.Text + "',alamat_customer='" + this.update_Alamat.Text + "' WHERE id_customer= '" + this.update_id.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_table();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "DELETE from rentalpro.db_customer WHERE id_customer= '" + this.update_id.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh_table();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            refresh_table();
        }

        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from rentalpro.db_customer;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView_DTcustomer.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_DTcustomer.Rows[e.RowIndex];

                update_id.Text = row.Cells["id_customer"].Value.ToString();
                update_nama.Text = row.Cells["nama"].Value.ToString();
                update_Alamat.Text = row.Cells["alamat_customer"].Value.ToString();
                update_KTP.Text = row.Cells["no_ktp"].Value.ToString();
                update_HP.Text = row.Cells["no_hp"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buton_transaksi_Click(object sender, EventArgs e)
        {
            Transaksi form_transaksi = new Transaksi();
            form_transaksi.TopLevel = false;
            panel_all_form.Controls.Add(form_transaksi);
            form_transaksi.BringToFront();
            form_transaksi.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button_data_transaksi_Click(object sender, EventArgs e)
        {
            DataTransaksi form_data_transaksi = new DataTransaksi();
            form_data_transaksi.TopLevel = false;
            panel_all_form.Controls.Add(form_data_transaksi);
            form_data_transaksi.BringToFront();
            form_data_transaksi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD_mobil form_crudmobil = new CRUD_mobil();
            form_crudmobil.TopLevel = false;
            panel_all_form.Controls.Add(form_crudmobil);
            form_crudmobil.BringToFront();
            form_crudmobil.Show();
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }
    }
}

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

    public partial class Transaksi : Form
    {
        DataTable datacustomer = new DataTable();
        public Transaksi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert ins = new Insert();
            ins.Show();
        }

        private void button_sewa_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
           
            string Query = "INSERT INTO rentalpro.db_data_transaksi (id_transaksi, id_mobil, id_customer, Status, mulai_sewa, selesai_sewa, denda_sewa, total_sewa,user)  VALUES(NULL, '"+ lbl_id_mobil.Text + "', '" + label_id_customer.Text + "', '1', '" + dateTimePicker_mulai.Value.Date.ToString("yyyy-MM-dd") + "', '" + dateTimePicker_selesai.Value.Date.ToString("yyyy-MM-dd") + "', '0', '" + label_total.Text + "', ' 1 '); ";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader; 

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Thank You");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // int data_id_mobil = Convert.ToInt32(id_mobil.Text);
            status_mobil_off(Convert.ToInt32(lbl_id_mobil.Text));
            refresh_table();
        }

        void status_mobil_off(int id_mobil)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE rentalpro.db_mobil SET status= '1' WHERE  id_mobil='"+id_mobil+"';";
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
        }

        void status_mobil_on(int id_mobil)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE rentalpro.db_mobil SET status= '0' WHERE  id_mobil='" + id_mobil + "';";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_table();
        }

        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT merek , no_polisi , biaya_harian , warna , id_mobil , tahun_pembuatan , jenis_model , Status FROM rentalpro.db_mobil WHERE status=0;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
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
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lbl_id_mobil.Text = row.Cells["id_mobil"].Value.ToString();
                label_nomorpolisi.Text = row.Cells["no_polisi"].Value.ToString();
                label_merk.Text = row.Cells["merek"].Value.ToString();
                label_th_pembuatan.Text = row.Cells["tahun_pembuatan"].Value.ToString();
                label_jenis_model.Text = row.Cells["jenis_model"].Value.ToString();
                label_status.Text = row.Cells["status"].Value.ToString();
                label_biayaharian.Text = row.Cells["biaya_harian"].Value.ToString();
                label_warna.Text = row.Cells["warna"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            FillCombo();
            refresh_table();
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        void FillCombo()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "SELECT * FROM rentalpro.db_customer;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader.GetString("nama");
                    comboBox_search.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_selesai_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int total = 0;
                DateTime tanggal1;
                DateTime tanggal2;
                TimeSpan ts = new TimeSpan();

                tanggal1 = dateTimePicker_mulai.Value;
                tanggal2 = dateTimePicker_selesai.Value;
                ts = tanggal2.Subtract(tanggal1); //count days using substract              
                label_jlhHari.Text = Convert.ToString(ts.Days + 1);

                //count total
                total = Convert.ToInt32(label_biayaharian.Text) * Convert.ToInt32(label_jlhHari.Text);
                label_total.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        /*private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(datacustomer);
            DV.RowFilter = string.Format("customer_name LIKE '%{0}%'", textBox_search.Text);
            dataGridView_search.DataSource = DV;
        }

        public void dataGridView_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_data_customer_Click(object sender, EventArgs e)
        {
            dataGridView_search_CellContentClick();
        }*/



        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "SELECT * FROM rentalpro.db_customer where nama='" + comboBox_search.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sID = myReader.GetString("id_customer").ToString();

                    label_id_customer.Text = sID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void comboBox_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "SELECT * FROM rentalpro.db_customer where nama='" + comboBox_search.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sID = myReader.GetString("id_customer").ToString();

                    label_id_customer.Text = sID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

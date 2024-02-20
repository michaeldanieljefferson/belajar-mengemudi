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
    public partial class DataTransaksi : Form
    {
        public DataTransaksi()
        {
            InitializeComponent();
        }

        private void DataTransaksi_Load(object sender, EventArgs e)
        {
            refresh_table();
        }
        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root; convert zero datetime=True ;password= ";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT db_data_transaksi.id_transaksi,db_data_transaksi.id_mobil,db_data_transaksi.id_customer ,db_data_transaksi.Status, db_data_transaksi.mulai_sewa, db_data_transaksi.selesai_sewa,db_data_transaksi.denda_sewa, db_data_transaksi.total_sewa, db_data_transaksi.user,db_customer.nama, db_mobil.no_polisi, db_mobil.jenis_model FROM rentalpro.db_data_transaksi INNER JOIN rentalpro.db_customer INNER JOIN rentalpro.db_mobil; ", myConn);
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
                label_id_customer.Text = row.Cells["id_transaksi"].Value.ToString();
                label_nama_Customer.Text = row.Cells["nama"].Value.ToString();
                label_kendaraan.Text = row.Cells["id_mobil"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Finished_Click(object sender, EventArgs e)
        {
            update_mobil();
            update_transaksi();
        }

        private void update_transaksi() {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE rentalpro.db_data_transaksi SET status= 0 WHERE id_transaksi = " + label_id_customer.Text + ";";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Transaksi Selesai");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_mobil() {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE rentalpro.db_mobil SET status= 0 WHERE id_mobil = " + label_kendaraan.Text + ";";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Mobil Dikembalikan");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

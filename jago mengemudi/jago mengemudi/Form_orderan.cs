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
    public partial class Form_orderan : Form
    {
        public Form_orderan()
        {
            InitializeComponent();
        }

        private void Form_orderan_Load(object sender, EventArgs e)
        {

        }
        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * from jago_mengemudi.db_transaksi where teacher_name='" + label_nama_guru.Text + "' and status = 'Accepted'; ", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGrid_order.DataSource = bSource;
                sda.Update(dbdataset);
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

        private void dataGrid_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGrid_order.Rows[e.RowIndex];

            label_id_transaksi.Text = row.Cells["transaksi_id"].Value.ToString();
            label_id_murid.Text = row.Cells["student_id"].Value.ToString();
            label_nama_murid.Text = row.Cells["student_name"].Value.ToString();
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan menghapus data : " + label_nama_murid.Text + "?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string Query = " DELETE from jago_mengemudi.db_transaksi where transaksi_id = '" + this.label_id_transaksi.Text + "'; ";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    MessageBox.Show("selesai");
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
}

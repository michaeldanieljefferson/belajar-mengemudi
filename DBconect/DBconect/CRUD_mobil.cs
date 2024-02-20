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
    public partial class CRUD_mobil : Form
    {
        public CRUD_mobil()
        {
            InitializeComponent();
        }

        private void CRUD_mobil_Load(object sender, EventArgs e)
        {
           
        }

        private void button_refresh_CDK_Click(object sender, EventArgs e)
        {
            refresh_table();
        }
        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("select * from rentalpro.db_mobil;", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView_CRUD.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView_CRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_CRUD.Rows[e.RowIndex];

                textBox_edit_idmobil.Text = row.Cells["id_mobil"].Value.ToString();
                textBox_edit_nopolisi.Text = row.Cells["no_polisi"].Value.ToString();
                textBox_edit_n_pemilik.Text = row.Cells["nama_pemilik"].Value.ToString();
                textBox_A_pemilik.Text = row.Cells["alamat_pemilik"].Value.ToString();
                textBox_edit_merek.Text = row.Cells["merek"].Value.ToString();
                textBox_edit_T_pembuatan.Text = row.Cells["tahun_pembuatan"].Value.ToString();
                textBox_edit_warna.Text = row.Cells["warna"].Value.ToString();
                textBox_edit_norangka.Text = row.Cells["no_rangka"].Value.ToString();
                textBox_edit_nomesin.Text = row.Cells["no_mesin"].Value.ToString();
                textBox_edit_nobpkb.Text = row.Cells["no_bpkb"].Value.ToString();
                textBox_edit_b_harian.Text = row.Cells["biaya_harian"].Value.ToString();
                textBox_j_model.Text = row.Cells["jenis_model"].Value.ToString();
                textBox_T_perakitan.Text = row.Cells["tahun_perakitan"].Value.ToString();
                textBox_edit_isi_silinder.Text = row.Cells["isi_silinder"].Value.ToString();
                textBox_edit_w_tnkb.Text = row.Cells["warna_tnkb"].Value.ToString();
                textBox_edit_b_bakar.Text = row.Cells["bahan_bakar"].Value.ToString();
                textBox_edit_status.Text = row.Cells["Status"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_edit_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE rentalpro.db_mobil SET no_polisi= '" + this.textBox_edit_nopolisi.Text + "',nama_pemilik='" + this.textBox_edit_n_pemilik.Text + "',merek='" + this.textBox_edit_merek.Text + "',tahun_pembuatan='" + this.textBox_edit_T_pembuatan.Text +"',warna='" + this.textBox_edit_warna.Text + "',no_rangka='" + this.textBox_edit_norangka.Text + "',no_mesin='" + this.textBox_edit_nomesin.Text + "',no_bpkb='" + this.textBox_edit_nobpkb.Text + "',biaya_harian='" + this.textBox_edit_b_harian.Text + "',jenis_model='" + this.textBox_j_model.Text + "',tahun_perakitan='" + this.textBox_T_perakitan.Text + "',isi_silinder='"+ this.textBox_edit_isi_silinder.Text + "',warna_tnkb='" + this.textBox_edit_w_tnkb.Text + "',bahan_bakar='" + this.textBox_edit_b_bakar.Text + "',Status='" + this.textBox_edit_status.Text + "' WHERE id_mobil= '" + this.textBox_edit_idmobil.Text + "';";

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

        private void button_delete_edit_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "DELETE from rentalpro.db_mobil WHERE id_mobil= '" + this.textBox_edit_idmobil.Text + "';";
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

        private void button_insert_db_mobil_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "INSERT INTO rentalpro.db_mobil (id_mobil, no_polisi, nama_pemilik, alamat_pemilik, merek, tahun_pembuatan, warna, no_rangka, no_mesin, no_bpkb, biaya_harian, jenis_model, tahun_perakitan, isi_silinder, warna_tnkb, bahan_bakar, Status) values('','" +  this.INSERT_no_polisi.Text + "','" + this.INSERT_nama_pemilik.Text + "','" + this.INSERT_alamat_pemilik.Text + "','" + this.INSERT_merek.Text + "','" + this.INSERT_tahun_pembuatan.Text + "','" + this.INSERT_warna.Text + "','" + this.INSERT_no_rangka.Text + "','" + this.INSERT_no_mesin.Text + "','" + this.INSERT_no_bpkb.Text + "','" + this.INSERT_biaya_harian.Text + "','" + this.INSERT_jenis_model.Text + "','" + this.INSERT_tahun_perakitan.Text + "','" + this.INSERT_isi_silinder.Text + "','" + this.INSERT_warna_tnkb.Text + "','" + this.INSERT_bahan_bakar.Text + "','" + this.INSERT_status.Text + "');";
           
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
    }
}

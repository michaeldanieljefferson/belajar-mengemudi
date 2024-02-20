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
    public partial class Form_guru_privat_mobil : Form
    {
        public Form_guru_privat_mobil()
        {
            InitializeComponent();
        }
        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM jago_mengemudi.db_teacher WHERE teacher_mengajar = 'mobil';", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                guru_privat_mobil.DataSource = bSource;
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

        private void guru_privat_mobil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow isi = this.guru_privat_mobil.Rows[e.RowIndex];
                label_nama.Text = isi.Cells["teacher_name"].Value.ToString();
                label_nomor.Text = isi.Cells["teacher_number"].Value.ToString();
                label_alamat.Text = isi.Cells["teacher_address"].Value.ToString();
                label_honor.Text = isi.Cells["teacher_honor"].Value.ToString();
                label_teacher_id.Text = isi.Cells["teacher_id"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_guru_privat_mobil_Load(object sender, EventArgs e)
        {

        }

        private void button_kontrak_Click(object sender, EventArgs e)
        {
            int hasil = 0;
            int paket = 0;
            int bayarannya = (int)Convert.ToInt32(label_honor.Text);
            if (rb_paket3.Checked == true)
            {
                paket = 3;
                hasil = paket * bayarannya;
            }
            else if(rb_paket_6.Checked == true)
            {
                paket = 6;
                hasil = paket * bayarannya;
            }
            else if(rb_paket_9.Checked == true)
            {
                paket = 9;
                hasil = paket * bayarannya;
            }
            else if(rb_paket12.Checked == true)
            {
                paket = 0;
                hasil = paket * bayarannya;
            }
            else
            {
                MessageBox.Show("please choose the package");
            }
            label_total.Text = Convert.ToString(hasil);

            string myConnection = "datasource=localhost;port=3306;username=root;password=";

            string Query = "INSERT INTO jago_mengemudi.db_transaksi (transaksi_id,teacher_id,teacher_name,student_id,student_name,paket_pertemuan,total_pembayaran)  VALUES(NULL, '" + label_teacher_id.Text + "', '" + label_nama.Text + "', '" + label_id_student.Text + "', '" + label_nama_Student.Text + "', '" + paket + "', '"+ hasil +"'); ";
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
        }

        private void label_id_student_Click(object sender, EventArgs e)
        {

        }
    }
}

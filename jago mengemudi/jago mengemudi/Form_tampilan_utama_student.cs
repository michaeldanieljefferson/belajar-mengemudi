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
    public partial class Form_tampilan_utama_student : Form
    {
        public Form_tampilan_utama_student()
        {
            InitializeComponent();
        }

        private void btn_edit_datastudent_Click(object sender, EventArgs e)
        {
            Form_edit_data_student edit_student = new Form_edit_data_student();
            edit_student.Show();
        }

        /*public void refresh_table()
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
                label_nama.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        private void Form_tampilan_utama_student_Load(object sender, EventArgs e,int student_name)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            string sql = "SELECT jago_mengemudi.db_student WHERE student_id";
            MySqlCommand cmd;
            try
            {
                myConn.Open();
                cmd = new MySqlCommand(sql, myConn);
                string rows_count = Convert.ToString(cmd.ExecuteScalar());
                cmd.Dispose();
                myConn.Close();
                label_nama_stdn.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void button_private_mobil_Click(object sender, EventArgs e)
        {

            Form_guru_private_motor motor = new Form_guru_private_motor();
            motor.Hide();

            Form_guru_privat_mobil car_driver = new Form_guru_privat_mobil();
            car_driver.TopLevel = false;
            panel_tampilan.Controls.Add(car_driver);
            car_driver.BringToFront();
            car_driver.Show();
            car_driver.label_id_student.Text = label_id.Text;
            car_driver.label_nama_Student.Text = label_nama_stdn.Text;
        }

        private void button_private_motor_Click(object sender, EventArgs e)
        {
            Form_guru_privat_mobil mobil = new Form_guru_privat_mobil();
            mobil.Hide();
            
            Form_guru_private_motor motorcycle_driver = new Form_guru_private_motor();
            motorcycle_driver.TopLevel = false;
            panel_tampilan.Controls.Add(motorcycle_driver);
            motorcycle_driver.BringToFront();
            motorcycle_driver.Show();
            motorcycle_driver.label_id_murid.Text = label_id.Text;
            motorcycle_driver.label_nama_murid.Text = label_nama_stdn.Text;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost; port=3306; username=root; password="; //initial database
            MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
            myDataAdapter.SelectCommand = new MySqlCommand("select * jago_mengemudi.db_student;", myConn);// sql syntax
            MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter); //build data adapter
            myConn.Open();// start connection

            DataSet ds = new DataSet();

            MessageBox.Show("Conected");

            myConn.Close();
        }

        private void Form_tampilan_utama_student_Load(object sender, EventArgs e)
        {
            
        }

        private void label_nama_stdn_Click(object sender, EventArgs e)
        {

        }
    }
}

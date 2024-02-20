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
    public partial class Form_isi_data_student : Form
    {
        public Form_isi_data_student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectiontodatabase = "datasource=localhost; port=3306; username=root; password=";
                MySqlConnection connactlocalhost = new MySqlConnection(connectiontodatabase);
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();
                dataadapter.SelectCommand = new MySqlCommand("select * jago_mengemudi.db_student;", connactlocalhost);
                MySqlCommandBuilder coba = new MySqlCommandBuilder(dataadapter);
                connactlocalhost.Open();

                DataSet dataset = new DataSet();

                MessageBox.Show("Conected");

                connactlocalhost.Close();
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message);
            }
        }

        private void button_contiue_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "INSERT INTO jago_mengemudi.db_student (student_id, student_username, student_password, student_name, student_age, student_number, student_address) values('','" + this.tb_student_username.Text + "','" + this.tb_student_password.Text + "','" + this.tb_student_name.Text + "','" + this.tb_student_age.Text + "','" + this.tb_student_number.Text + "','" + this.tb_student_address.Text + "');";
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
            
            Form_tampilan_utama_student ins = new Form_tampilan_utama_student();
            ins.Show();
            //ins.label_nama.Text = tb_user_student.Text;
            string Connec = "datasource=localhost;port=3306;username=root;password=";
            string Qry1 = "SELECT * FROM jago_mengemudi.db_student where student_username='" + tb_student_username.Text + "';";
            MySqlConnection myCon = new MySqlConnection(Connec);
            MySqlCommand db = new MySqlCommand(Qry1, myCon);
            MySqlDataReader Reader;

            try
            {
                myCon.Open();
                Reader = db.ExecuteReader();
                while (Reader.Read())
                {
                    string name = Reader.GetString("student_name").ToString();

                    ins.label_nama_stdn.Text = name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string Connec1 = "datasource=localhost;port=3306;username=root;password=";
            string Qury1 = "SELECT * FROM jago_mengemudi.db_student where student_username='" + tb_student_username.Text + "';";
            MySqlConnection Conn = new MySqlConnection(Connec1);
            MySqlCommand cmd = new MySqlCommand(Qury1, Conn);
            MySqlDataReader Readerku;

            try
            {
                Conn.Open();
                Readerku = cmd.ExecuteReader();
                while (Readerku.Read())
                {
                    string nomor = Readerku.GetString("student_number").ToString();

                    ins.label_nomor.Text = nomor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string mysambung = "datasource=localhost;port=3306;username=root;password=";
            string Querysaya = "SELECT * FROM jago_mengemudi.db_student where student_username='" + tb_student_username.Text + "';";
            MySqlConnection kuConnec = new MySqlConnection(mysambung);
            MySqlCommand database = new MySqlCommand(Querysaya, kuConnec);
            MySqlDataReader mypembc;

            try
            {
                kuConnec.Open();
                mypembc = database.ExecuteReader();
                while (mypembc.Read())
                {
                    string alamat = mypembc.GetString("student_address").ToString();

                    ins.label_alamat.Text = alamat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string mysambung3 = "datasource=localhost;port=3306;username=root;password=";
            string Querysaya3 = "SELECT * FROM jago_mengemudi.db_student where student_username='" +tb_student_username.Text + "';";
            MySqlConnection kuConnec3 = new MySqlConnection(mysambung3);
            MySqlCommand database3 = new MySqlCommand(Querysaya3, kuConnec3);
            MySqlDataReader mypembc3;

            try
            {
                kuConnec3.Open();
                mypembc3 = database3.ExecuteReader();
                while (mypembc3.Read())
                {
                    string id = mypembc3.GetString("student_id").ToString();

                    ins.label_id.Text = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_isi_data_student_Load(object sender, EventArgs e)
        {

        }
    }
}

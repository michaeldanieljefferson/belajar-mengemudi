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
    public partial class Form_isi_data_teacher : Form
    {
        public Form_isi_data_teacher()
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
                dataadapter.SelectCommand = new MySqlCommand("select * rentalpro.user;", connactlocalhost);
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

        private void button_continue_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "insert into jago_mengemudi.db_teacher (teacher_id, teacher_username, teacher_password, teacher_name, teacher_age, teacher_number, teacher_address, teacher_mengajar, teacher_honor) values('','" + this.tb_teacher_username.Text + "','" + this.tb_teacher_password.Text + "','" + this.tb_teacher_name.Text + "','" + this.tb_teacher_age.Text + "','" + this.tb_teacher_number.Text + "','" + this.tb_teacher_address.Text + "','" + this.tb_teacher_mengajar.Text + "','" + this.tb_teacher_gaji.Text + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Inserted");
                while (myReader.Read())
                {
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            Form_menu_utama_teacher ins = new Form_menu_utama_teacher();
            ins.Show();


            string Connec = "datasource=localhost;port=3306;username=root;password=";
            string Qry1 = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_teacher_username.Text + "';";
            MySqlConnection myCon = new MySqlConnection(Connec);
            MySqlCommand db = new MySqlCommand(Qry1, myCon);
            MySqlDataReader Reader;

            try
            {
                myCon.Open();
                Reader = db.ExecuteReader();
                while (Reader.Read())
                {
                    string name = Reader.GetString("teacher_name").ToString();

                    ins.label_nama_teacher.Text = name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string Connec1 = "datasource=localhost;port=3306;username=root;password=";
            string Qury1 = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_teacher_username.Text + "';";
            MySqlConnection Conn = new MySqlConnection(Connec1);
            MySqlCommand cmd = new MySqlCommand(Qury1, Conn);
            MySqlDataReader Readerku;

            try
            {
                Conn.Open();
                Readerku = cmd.ExecuteReader();
                while (Readerku.Read())
                {
                    string nomor = Readerku.GetString("teacher_number").ToString();

                    ins.label_nomor.Text = nomor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string mysambung = "datasource=localhost;port=3306;username=root;password=";
            string Querysaya = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_teacher_username.Text + "';";
            MySqlConnection kuConnec = new MySqlConnection(mysambung);
            MySqlCommand database = new MySqlCommand(Querysaya, kuConnec);
            MySqlDataReader mypembc;

            try
            {
                kuConnec.Open();
                mypembc = database.ExecuteReader();
                while (mypembc.Read())
                {
                    string alamat = mypembc.GetString("teacher_address").ToString();

                    ins.label_alamat.Text = alamat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string mysambung3 = "datasource=localhost;port=3306;username=root;password=";
            string Querysaya3 = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_teacher_username.Text + "';";
            MySqlConnection kuConnec3 = new MySqlConnection(mysambung3);
            MySqlCommand database3 = new MySqlCommand(Querysaya3, kuConnec3);
            MySqlDataReader mypembc3;

            try
            {
                kuConnec3.Open();
                mypembc3 = database3.ExecuteReader();
                while (mypembc3.Read())
                {
                    string id = mypembc3.GetString("teacher_id").ToString();

                    ins.label_teacher_id.Text = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

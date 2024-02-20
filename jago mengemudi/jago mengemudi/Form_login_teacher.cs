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
    public partial class Form_login_teacher : Form
    {
        public Form_login_teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand SelectCommand = new MySqlCommand("select teacher_username , teacher_password from jago_mengemudi.db_teacher where teacher_username= '" + this.tb_user_teacher.Text + "' and teacher_password='" + this.tb_pass_teacher.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();

                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    // MessageBox.Show("WELCOME");
                    Form_menu_utama_teacher ins = new Form_menu_utama_teacher();
                    ins.Show();
    
                   
                    string Connec = "datasource=localhost;port=3306;username=root;password=";
                    string Qry1 = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_user_teacher.Text + "';";
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
                    string Qury1 = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_user_teacher.Text + "';";
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
                    string Querysaya = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_user_teacher.Text + "';";
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
                    string Querysaya3 = "SELECT * FROM jago_mengemudi.db_teacher where teacher_username='" + tb_user_teacher.Text + "';";
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
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost; port=3306; username=root; password="; //initial database
            MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
            myDataAdapter.SelectCommand = new MySqlCommand("select * jago_mengemudi.db_teacher;", myConn);// sql syntax
            MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter); //build data adapter
            myConn.Open();// start connection

            DataSet ds = new DataSet();

            MessageBox.Show("Conected");

            myConn.Close();
        }

        private void Form_login_teacher_Load(object sender, EventArgs e)
        {

        }

        private void tb_user_teacher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

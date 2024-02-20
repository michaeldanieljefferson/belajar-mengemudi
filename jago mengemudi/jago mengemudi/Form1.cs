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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            { 
                string connectiontodatabase = "datasource=localhost; port=3306; username=root; password=";
                MySqlConnection connactlocalhost = new MySqlConnection(connectiontodatabase); 
                MySqlDataAdapter dataadapter = new MySqlDataAdapter();  
                dataadapter.SelectCommand = new MySqlCommand("select * jago_mengemudi;", connactlocalhost);
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

        private void button_buatakunbaru_Click(object sender, EventArgs e)
        {
            GB_choose_user.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GB_choose_user.Hide();
        }

        private void button_teacher_Click(object sender, EventArgs e)
        {
            Form_isi_data_teacher datateacher = new Form_isi_data_teacher();
            datateacher.Show();
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            Form_isi_data_student datastudent = new Form_isi_data_student();
            datastudent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_login_teacher login_teacher = new Form_login_teacher();
            login_teacher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_login_student login_student = new Form_login_student();
            login_student.Show();
        }
    }
}

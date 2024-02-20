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
    public partial class Form_edit_data_student : Form
    {
        public Form_edit_data_student()
        {
            InitializeComponent();
        }

        private void button_contiue_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE jago_mengemudi.db_student SET student_name= '" + this.tb_nama_student.Text + "',student_age='" + this.tb_umur_student.Text + "',student_number='" + this.tb_nomor_student.Text + "',student_address='" + this.tb_alamat_student.Text + "' WHERE student_id= '" + this.tb_user_id_student.Text + "';";
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

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_edit_data_student hide_student = new Form_edit_data_student();
            hide_student.Hide();
        }
    }
}

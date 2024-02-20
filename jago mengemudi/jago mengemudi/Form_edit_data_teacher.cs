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
    public partial class Form_edit_data_teacher : Form
    {
        public Form_edit_data_teacher()
        {
            InitializeComponent();
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE jago_mengemudi.db_teacher SET teacher_name= '" + this.tb_edit_nama_teacher.Text + "',teacher_age='" + this.tb_edit_umur_teacher.Text + "',teacher_number='" + this.tb_edit_number_teacher.Text + "',teacher_address='" + this.tb_edit_address_teacher.Text + "',teacher_mengajar='" + this.tb_edit_mengajar_teacher + "',teacher_honor='" + this.tb_edit_honor_teacher + "' WHERE teacher_id= '" + this.tb_edit_user_id_teacher.Text + "';";
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
            Form_edit_data_teacher hide_teacher = new Form_edit_data_teacher();
            hide_teacher.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

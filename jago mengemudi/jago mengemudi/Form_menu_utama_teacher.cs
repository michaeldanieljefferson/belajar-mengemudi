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
    public partial class Form_menu_utama_teacher : Form
    {
        public Form_menu_utama_teacher()
        {
            InitializeComponent();
        }

        private void btn_edit_datateacher_Click(object sender, EventArgs e)
        {
            Form_edit_data_teacher edit_teacher = new Form_edit_data_teacher();
            edit_teacher.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost; port=3306; username=root; password="; //initial database
            MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
            MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
            myDataAdapter.SelectCommand = new MySqlCommand("select * jago_mengemudi.db_teacher where teacher_username='" + label_nama_teacher.Text + "';", myConn);// sql syntax
            MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter); //build data adapter
            myConn.Open();// start connection

            DataSet ds = new DataSet();

            MessageBox.Show("Conected");

            myConn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_order_Click(object sender, EventArgs e)
        {
            Form_transaksi_teacher transaksi = new Form_transaksi_teacher();
            transaksi.Hide();

            Form_orderan orderan = new Form_orderan();
            orderan.TopLevel = false;
            panel_tampilan.Controls.Add(orderan);
            orderan.BringToFront();
            orderan.Show();
            orderan.label_nama_guru.Text = label_nama_teacher.Text;
        }

        private void button_edit_transaksi_Click(object sender, EventArgs e)
        {
            Form_orderan order = new Form_orderan();
            order.Hide();

            Form_transaksi_teacher transaksi = new Form_transaksi_teacher();
            transaksi.TopLevel = false;
            panel_tampilan.Controls.Add(transaksi);
            transaksi.BringToFront();
            transaksi.Show();
            transaksi.label_nama_guru.Text = label_nama_teacher.Text;
            transaksi.label_id_guru.Text = label_teacher_id.Text;
        }

        private void label_nama_teacher_Click(object sender, EventArgs e)
        {

        }
    }
}

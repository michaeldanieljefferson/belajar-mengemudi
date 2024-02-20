using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //latihan 15
            combo_B_pilih.Items.Add("Manado");
            combo_B_pilih.Items.Add("Tondano");
            combo_B_pilih.Items.Add("Airmadidi");
            combo_B_pilih.Items.Add("Tomohon");

            //latihan 16
            combo_box_lokasi.Items.Add("Manado");
            combo_box_lokasi.Items.Add("Tondano");
        }

        private void combo_B_pilih_SelectedIndexChanged(object sender, EventArgs e)
        {
            group_B_output.Text = combo_B_pilih.Text;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            combo_B_pilih.Items.Clear(); 
        }

        private void button_satu_Click(object sender, EventArgs e)
        {
            combo_B_pilih.Items.Clear();
            combo_B_pilih.Items.Add("satu A");
            combo_B_pilih.Items.Add("satu B");
            combo_B_pilih.Items.Add("satu C");
            combo_B_pilih.Items.Add("satu D");
            combo_B_pilih.Items.Add("satu E");
        }

        private void button_dua_Click(object sender, EventArgs e)
        {
            combo_B_pilih.Items.Clear();
            combo_B_pilih.Items.Add("dua A");
            combo_B_pilih.Items.Add("dua B");
            combo_B_pilih.Items.Add("dua C");
            combo_B_pilih.Items.Add("dua D");
            combo_B_pilih.Items.Add("dua E");
        }

        private void button_tiga_Click(object sender, EventArgs e)
        {
            combo_B_pilih.Items.Clear();
            combo_B_pilih.Items.Add("tiga A");
            combo_B_pilih.Items.Add("tiga B");
            combo_B_pilih.Items.Add("tiga C");
            combo_B_pilih.Items.Add("tiga D");
            combo_B_pilih.Items.Add("tiga E");
        }

        private void combo_box_lokasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_box_tipe.Items.Clear();
            if(combo_box_lokasi.Text == "Manado"){
                combo_box_tipe.Items.Add("Manado == malalayang");
                combo_box_tipe.Items.Add("Manado == sario");
                combo_box_tipe.Items.Add("Manado == karcabasan");
            }
            else if(combo_box_lokasi.Text == "Tondano"){
                combo_box_tipe.Items.Add("Tondano == kombi");
                combo_box_tipe.Items.Add("Tondano == start");
                combo_box_tipe.Items.Add("Tondano == pante");
            }
        }

        private void button_proses_Click(object sender, EventArgs e)
        {
            GB_hasil_l_16.Text = combo_box_tipe.Text;
        }

        private void GB_hasil_17_Enter(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_vispro1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picture_fox_11_Click(object sender, EventArgs e)
        {
            GB_check_images_11.Text = "gambar 1";
        }

        private void picture_gorila_11_Click(object sender, EventArgs e)
        {
            GB_check_images_11.Text = "gambar 2";
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            GB_all.Visible = true;
        }

        private void button_hide_Click(object sender, EventArgs e)
        {
            GB_all.Visible = false;
        }

        private void picture_duck_12_Click(object sender, EventArgs e)
        {

        }

        private void button_hitung_Click(object sender, EventArgs e)
        {
            //deklarasi & inisilisasi
            int total = 0;
            //proses
            if(CB_keju_13.Checked == true)
            {
                total = total + 5000;
            }
            if(CB_cokelat_13.Checked == true)
            {
                total = total + 5000;
            }
            if(CB_kacang_13.Checked == true)
            {
                total = total + 5000;
            }
            //output
            GB_hasil_13.Text = Convert.ToString(total);
        }

        private void button_proses_Click(object sender, EventArgs e)
        {
            if (RB_merah.Checked == true)
            {
                GB_hasil_14.Text = "merah";
            }
            else if (RB_kuning.Checked == true)
            {
                GB_hasil_14.Text = "kuning";
            }
            else if (RB_hitam.Checked == true)
            {
                GB_hasil_14.Text = "hitam";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_question_vispro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            //deklarasi & inisialisasi
            string nama = box_nama.Text;
            box_output_nama.Text = box_nama.Text;
            string alamat = box_alamat.Text;
            box_output_alamat.Text = box_alamat.Text;
            string tempat_lahir = box_tempat_lahir.Text;
            box_output_TT.Text = box_tempat_lahir.Text;
            string pekerjaan = box_pekerjaan.Text;
            box_output_pekerjaan.Text = box_pekerjaan.Text;
            int tinggi = Convert.ToInt32(box_tinggi.Text);
            box_tinggi.Text = Convert.ToString(tinggi+"cm");
            box_output_tinggi.Text = box_tinggi.Text;
            int nomor_sim = Convert.ToInt32(box_nosim.Text);
            box_nosim.Text = Convert.ToString(nomor_sim + "cm");
            box_output_nosim.Text = box_nosim.Text;
            box_output_TT.Text = box_tanggal_lahir.Text;
            box_output_berlaku.Text = box_berlaku.Text;

            
            if(pilihan_A.Checked == true)
            {
                label_sim.Text = "A";
            }
            else if(pilihan_A_khusus.Checked == true)
            {
                label_sim.Text = "A khusus";
            }
            else if(pilihan_B1.Checked == true)
            {
                label_sim.Text = "B1";
            }
            else if(pilihan_C.Checked == true)
            {
                label_sim.Text = "C";
            }
            else if(pilihan_B2.Checked == true)
            {
                label_sim.Text = "B2";
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

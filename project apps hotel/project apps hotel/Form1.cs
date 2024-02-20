using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace project_apps_hotel
{
    public partial class form_apps_hotel : Form
    {
        public form_apps_hotel()
        {
            InitializeComponent();
        }

        private void box_pilihan_kamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            box_nomor_kamar.Items.Clear();
            if(box_tipe_kamar.Text == "Queen")
            {
                box_nomor_kamar.Items.Add("M1");
                box_nomor_kamar.Items.Add("M2");
                box_nomor_kamar.Items.Add("M3");
                box_nomor_kamar.Items.Add("M4");
            }
            else if(box_tipe_kamar.Text == "Ekonomi")
            {
                box_nomor_kamar.Items.Add("E1");
                box_nomor_kamar.Items.Add("E2");
                box_nomor_kamar.Items.Add("E3");
                box_nomor_kamar.Items.Add("E4");
            }
            else if(box_tipe_kamar.Text == "VIP")
            {
                box_nomor_kamar.Items.Add("V1");
                box_nomor_kamar.Items.Add("V2");
                box_nomor_kamar.Items.Add("V3");
                box_nomor_kamar.Items.Add("V4");
            }
            else if(box_tipe_kamar.Text == "Sultan")
            {
                box_nomor_kamar.Items.Add("S1");
                box_nomor_kamar.Items.Add("S2");
                box_nomor_kamar.Items.Add("S3");
                box_nomor_kamar.Items.Add("S4");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            box_tipe_kamar.Items.Add("Queen");
            box_tipe_kamar.Items.Add("Ekonomi");
            box_tipe_kamar.Items.Add("VIP");
            box_tipe_kamar.Items.Add("Sultan");

            box_fasilitas.Items.Add("TV");
            box_fasilitas.Items.Add("AC");
            box_fasilitas.Items.Add("komputer");
            box_fasilitas.Items.Add("water heater");
        }

        private void box_fasilitas_SelectedIndexChanged(object sender, EventArgs e)
        {
           /*int harga_fasilitas = 0;
           if(box_fasilitas.Text == "TV")
            {
                harga_fasilitas = 100000;
            }
            else if(box_fasilitas.Text == "AC")
            {
                harga_fasilitas = 200000;
            } 
            else if(box_fasilitas.Text == "Komputer")
            {
                harga_fasilitas = 100000;
            }
            else if(box_fasilitas.Text == "water heater")
            {
                harga_fasilitas = 100000;
            }
            output_hargafasilitas.Text = Convert.ToString(harga_fasilitas);*/
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            box_nomor_kamar.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string nama = box_nama.Text;
            output_nama.Text = box_nama.Text;
            output_tipekamar.Text = box_tipe_kamar.Text;
            output_nomorkamar.Text = box_nomor_kamar.Text;
            output_fasilitas.Text = box_fasilitas.Text;
            int harga_fasilitas = 0;
            if (box_fasilitas.Text == "TV")
            {
                harga_fasilitas = 100000;
            }
            else if (box_fasilitas.Text == "AC")
            {
                harga_fasilitas = 200000;
            }
            else if (box_fasilitas.Text == "Komputer")
            {
                harga_fasilitas = 100000;
            }
            else if (box_fasilitas.Text == "water heater")
            {
                harga_fasilitas = 100000;
            }
            output_hargafasilitas.Text = Convert.ToString(harga_fasilitas);

            int harga = 0;
            if (box_tipe_kamar.Text == "Queen")
            {
                harga = 200000;
            }
            else if (box_tipe_kamar.Text == "Ekonomi")
            {
                harga = 900000;
            }
            else if (box_tipe_kamar.Text == "VIP")
            {
                harga = 1400000;
            }
            else if (box_tipe_kamar.Text == "Sultan")
            {
                harga = 15000000;
            }
            output_hargakamar.Text = Convert.ToString(harga);
            /*int hasil = Convert.ToInt32(numeric_tanggal.Value);
            int bulan = 0;
            if (numeric_tanggal.Value > 1 && numeric_tanggal.Value <= 30)
            {
                bulan = 1;
            }
            else if (numeric_tanggal.Value > 31  && numeric_tanggal.Value <= 60)
            {
                bulan = 2;
            }
            else if (numeric_tanggal.Value > 61 && numeric_tanggal.Value <= 90)
            {
                bulan = 3;
            }
            else if (numeric_tanggal.Value > 91 && numeric_tanggal.Value <= 120)
            {
                bulan = 4;
            }
            else if (numeric_tanggal.Value > 121 && numeric_tanggal.Value <= 150)
            {
                bulan = 5;
            }
            else if (numeric_tanggal.Value > 151 && numeric_tanggal.Value <= 180)
            {
                bulan = 6;
            }*/
            DateTime datestart = dateTime_start.Value.Date;
            DateTime dateout = dateTime_out.Value.Date;
            int hari = ((TimeSpan)(dateout - datestart)).Days;
            int bulan = 0;
            if(hari >1 && hari <= 30)
            {
                bulan = 1;
            }
            else if(hari >31 && hari <= 60)
            {
                bulan = 2; 
            }
            else if(hari >61 && hari <= 90)
            {
                bulan = 3;
            }
            else if(hari >91 && hari <= 120)
            {
                bulan = 4;
            }
            else if(hari >121 && hari <= 150)
            {
                bulan = 5;
            }
            else if(hari >151 && hari <= 180)
            {
                bulan = 6;
            }
            long total = 0;
            total = (harga + harga_fasilitas)*bulan;
            output_total.Text = Convert.ToString(total);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_nomor_kamar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

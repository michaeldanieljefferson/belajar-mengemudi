using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_buat_app_sendiri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void box_tiket_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deklarasi (input)
            string nama = textb_nama.Text;
            box_nama.Text = textb_nama.Text;
            string alamat_tujuan = textb_alamat.Text;
            box_tujuan.Text = textb_alamat.Text;
            int kursi = Convert.ToInt32(textb_nokursi.Text);
            box_nokursi.Text = Convert.ToString(kursi);
            box_keberangkatan.Text = time_keberangkatan.Text;
            long no_ktp = Convert.ToInt64(textb_ktp.Text);
            box_ktp.Text = Convert.ToString(no_ktp);
            if(menu_majulancar.Checked == true)
            {
                box_namabus.Text = "maju lancar";
            }
            else if(menu_garudamas.Checked == true)
            {
                box_namabus.Text = "garuda mas";
            }
            else if(menu_sugengrahayu.Checked == true)
            {
                box_namabus.Text = "segeng rahayu";
            }

            int hasil = 0;
            int harga = 0;
            int diskon = 0;
            if(menu_majulancar.Checked == true)
            {
                harga = 120000;
                if(CB_senin.Checked == true)
                {
                    diskon = 40000;
                    hasil = harga - diskon;
                }
                else if(CB_rabu.Checked == true)
                {
                    diskon = 30000;
                    hasil = harga - diskon;
                }
                else if(CB_jumat.Checked == true)
                {
                    diskon = 20000;
                    hasil = harga - diskon;
                }
                else if(CB_harilainnya.Checked == true)
                {
                    hasil = harga;
                }
            }
            else if(menu_garudamas.Checked == true)
            {
                harga = 160000;
                if(CB_senin.Checked == true)
                {
                    diskon = 60000;
                    hasil = harga - diskon;
                }
                else if(CB_rabu.Checked == true)
                {
                    diskon = 35000;
                    hasil = harga - diskon;
                }
                else if(CB_jumat.Checked == true)
                {
                    diskon = 25000;
                    hasil = harga - diskon;
                }
                else if(CB_harilainnya.Checked == true)
                {
                    hasil = harga;
                }
            }
            else if(menu_sugengrahayu.Checked == true)
            {
                harga = 180;
                if(CB_senin.Checked == true)
                {
                    diskon = 56000;
                    hasil = harga - diskon;
                }
                else if(CB_rabu.Checked == true)
                {
                    diskon = 45000;
                    hasil = harga - diskon;
                }
                else if(CB_jumat.Checked == true)
                {
                    diskon = 20000;
                    hasil = harga - diskon;
                }
                else if(CB_harilainnya.Checked == true)
                {
                    hasil = harga;
                }
            }
            box_harga.Text = Convert.ToString(hasil);
        }

        private void box_namabus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace water_park
{
    public partial class form_input : Form
    {
        public form_input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_tiket tiket = new form_tiket();
            //harga tiket berdasarkan tinggi badan
            string nama = box_nama.Text;
            tiket.box_output.Text = box_nama.Text;
            int tinggi1 = 0;
            tinggi1 = tinggi1 * Convert.ToInt32(numeric_tinggi1.Value);

            int tinggi2 = 25000;
            tinggi2 = tinggi2 * Convert.ToInt32(numeric_tinggi2.Value);

            int tinggi3 = 30000;
            tinggi3 = tinggi3 * Convert.ToInt32(numeric_tinggi3.Value);

            int tinggi4 = 50000;
            tinggi4 = tinggi4 * Convert.ToInt32(numeric_tinggi4.Value);

            int total = tinggi1 + tinggi2 + tinggi3 + tinggi4;
            int jumlah_orang = Convert.ToInt32(numeric_tinggi1.Value) + Convert.ToInt32(numeric_tinggi2.Value) + Convert.ToInt32(numeric_tinggi3.Value) + Convert.ToInt32(numeric_tinggi4.Value);
            int harga_tiket = 0;
            if(jumlah_orang > 20)
            {
                harga_tiket = total * 10 / 100;
            }
            else if(jumlah_orang < 20)
            {
                harga_tiket = total;
            }
            //tiket.box_jumlahorang.Text = Convert.ToString(jumlah_orang);

            //sewa baju renang
            int baju_renang1 = 10000;
            baju_renang1 = baju_renang1 * Convert.ToInt32(numeric_bajurenang1.Value);

            int baju_renang2 = 15000;
            baju_renang2 = baju_renang2 * Convert.ToInt32(numeric_bajurenang2.Value);

            int baju_renang3 = 20000;
            baju_renang3 = baju_renang3 * Convert.ToInt32(numeric_bajurenang3.Value);

            int total_bajurenang = baju_renang1 + baju_renang2 + baju_renang3;

            //sewa loker
            int loker_besar = 10000;
            loker_besar = loker_besar * Convert.ToInt32(numeric_lokerbesar.Value);

            int loker_kecil = 5000;
            loker_kecil = loker_kecil * Convert.ToInt32(numeric_lokerkecil.Value);

            int total_loker = loker_besar + loker_kecil;

            //menu makanan
            int menu1 = 10000;
            menu1 = menu1 * Convert.ToInt32(numeric_menu1.Value);

            int menu2 = 15000;
            menu2 = menu2 * Convert.ToInt32(numeric_menu2.Value);

            int menu3 = 20000;
            menu3 = menu3 * Convert.ToInt32(numeric_menu3.Value);


            int total_menu = menu1 + menu2 + menu3;

            //outputnya
            int total_semuanya = harga_tiket + total_bajurenang + total_loker + total_menu;
            tiket.box_total.Text = Convert.ToString(total_semuanya);
            tiket.box_jumlahorang.Text = Convert.ToString(jumlah_orang);
            tiket.Show();
        }
    }
}

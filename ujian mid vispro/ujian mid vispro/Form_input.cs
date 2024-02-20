using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ujian_mid_vispro
{
    public partial class Form_input : Form
    {
        public Form_input()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_total total = new Form_total();
            total.box_output_nama.Text = textBox_nama.Text;
            //1.taart cokelat
            int biaya_tulis_nama = 2000;
            int harga_taart_cokelat = 190000;
          
             int no_toping_taartcokelat = 0;
             int hasil = (biaya_tulis_nama * Convert.ToInt32(numeric_nama_T_N.Value))+;
             no_toping_taartcokelat = (harga_taart_cokelat * Convert.ToInt32(numeric_taart_notoping.Value));
             
             int harga_toping_keju = 15000;
             biaya_tulis_nama = (biaya_tulis_nama * Convert.ToInt32(numeric_nama_T_K.Value));
             int harga__taart_keju = (harga_taart_cokelat * Convert.ToInt32(numeric_taart_keju.Value)) + harga_toping_keju ;
            
             int harga_toping_almond = 20000;
             biaya_tulis_nama = (biaya_tulis_nama * Convert.ToInt32(numeric_nama_T_A.Value));
            int harga_taart_almond = (harga_taart_cokelat * Convert.ToInt32(numeric_taart_almond.Value)) + harga_toping_almond; ;
             
             int harga_toping_mocca = 10000;
             biaya_tulis_nama = (biaya_tulis_nama * Convert.ToInt32(numeric_nama_T_M.Value));
             int harga_taart_mocca = (harga_taart_cokelat * Convert.ToInt32(numeric_taart_mocca.Value)) + harga_toping_mocca 
                ;
           
            //black forest
            int harga_blackforest = 180000;
            int biaya_tulis_nama2 = 2000;
            biaya_tulis_nama2 = (biaya_tulis_nama2 * Convert.ToInt32(numeric_nama_B_N.Value));
            int no_toping_blackforest = (harga_blackforest * Convert.ToInt32(numeric_black_notoping.Value)) + biaya_tulis_nama2;

            int harga_chocochios = 10000;
            biaya_tulis_nama2 = (biaya_tulis_nama2 * Convert.ToInt32(numeric_nama_B_C.Value));
            int harga_black_chocochips = (harga_blackforest * Convert.ToInt32(numeric_Black_Chocochips.Value)) + harga_chocochios + biaya_tulis_nama2;

            int harga_tiramisu = 15000;
            biaya_tulis_nama2 = (biaya_tulis_nama2 * Convert.ToInt32(numeric_nama_B_T.Value));
            int harga_black_tiramisu = (harga_blackforest * Convert.ToInt32(numeric_Black_TIramisu.Value)) + harga_tiramisu + biaya_tulis_nama2;

            //cake keju
            int harga_cakekeju = 170000;
            int biaya_tulis_nama3 = 2000;
            biaya_tulis_nama3 = (biaya_tulis_nama3 * Convert.ToInt32(numeric_nama_C_N.Value));
            int no_toping_cakekeju = (harga_cakekeju * Convert.ToInt32(numeric_cakekeju_notoping.Value)) + biaya_tulis_nama3;

            int harga_toping_fruit = 10000;
            biaya_tulis_nama3 = (biaya_tulis_nama3 * Convert.ToInt32(numeric_nama_C_F.Value));
            int harga_cake_fruit = (harga_cakekeju * Convert.ToInt32(numeric_cakekaju_fruit.Value)) + harga_toping_fruit + biaya_tulis_nama3;

            int harga_toping_kejubatang = 15000;
            biaya_tulis_nama3 = (biaya_tulis_nama3 * Convert.ToInt32(numeric_nama_C_k.Value));
            int harga_cake_kejubatang = (harga_cakekeju * Convert.ToInt32(numeric_cakekaju_k_batang.Value)) + harga_toping_kejubatang + biaya_tulis_nama3;

            //fruit cake
            int harga_fruitcake = 180000;
            int biaya_tulis_nama4 = 2000;
            biaya_tulis_nama4 = (biaya_tulis_nama4 * Convert.ToInt32(numeric_fruitcake_notoping.Value));
            int no_toping_friutcake = (harga_fruitcake * Convert.ToInt32(numeric_fruitcake_notoping.Value)) + biaya_tulis_nama4;

            int harga_toping_apple = 5000;
            biaya_tulis_nama4 = (biaya_tulis_nama4 * Convert.ToInt32(numeric_nama_FC_A.Value));
            int harga_toping_fruitapple = (harga_fruitcake * Convert.ToInt32(numeric_fruitcake_apple.Value)) + harga_toping_apple + biaya_tulis_nama4;

            int harga_toping_guava = 10000;
            biaya_tulis_nama4 = (biaya_tulis_nama4 * Convert.ToInt32(numeric_nama_FC_G.Value));
            int harga_fruit_guava = (harga_fruitcake * Convert.ToInt32(numeric_fruitcake_guava.Value)) + harga_toping_guava + biaya_tulis_nama4;

            int harga_toping_strawbery = 10000;
            biaya_tulis_nama4 = (biaya_tulis_nama4 * Convert.ToInt32(numeric_nama_FC_S.Value));
            int harga_fruit_strawbery = (harga_fruitcake * Convert.ToInt32(numeric_fruitcake_strawbery.Value)) + harga_toping_strawbery + biaya_tulis_nama4;
            int total_all = no_toping_taartcokelat + harga__taart_keju + harga_taart_almond + harga_taart_mocca;//+ no_toping_blackforest + harga_black_chocochips + harga_black_tiramisu + no_toping_cakekeju + harga_cake_fruit + harga_cake_kejubatang + no_toping_friutcake + harga_toping_fruitapple + harga_fruit_guava + harga_fruit_strawbery;
            total.GB_hasil.Text = Convert.ToString(no_toping_taartcokelat);
            total.box_output_karton.Text = textBox_karton.Text;
            total.box_output_mika.Text = textBox_mika.Text;
            total.Show();
        }

        private void Form_input_Load(object sender, EventArgs e)
        {
            
        }

        private void box_menu_toping_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void box_bungkusan_T_N_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void box_bungkusan_T_K_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

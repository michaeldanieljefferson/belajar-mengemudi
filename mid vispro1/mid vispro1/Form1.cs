using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_vispro1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_pilih_kue.Items.Add("1.taart cokelat = Rp.190.000");
            comboBox_pilih_kue.Items.Add("2.black forest = Rp.180.000");
            comboBox_pilih_kue.Items.Add("3.cake keju = Rp.170.000");
            comboBox_pilih_kue.Items.Add("4.fruit cake = Rp.180.000");
            comboBox_pilih_kue.Items.Add("5.tiramisu taart = Rp.200.000");

        }

        private void comboBox_pilih_kue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_pilih_kue.Text == "1.taart cokelet = Rp.190.000")
            {
                comboBox_pilih_toping.Items.Add("no toping taart cokelat");
                comboBox_pilih_toping.Items.Add("toping keju = Rp. 15.000");
                comboBox_pilih_toping.Items.Add("toping almond = Rp.20.000");
                comboBox_pilih_toping.Items.Add("toping mocca = Rp.10.000");
            }
            else if(comboBox_pilih_kue.Text == "2.black forest = Rp.180.000")
            {
                comboBox_pilih_toping.Items.Add("no toping vlack forest");
                comboBox_pilih_toping.Items.Add("chocochips = Rp.10.000");
                comboBox_pilih_toping.Items.Add("tiramisu = Rp.15.000");
            }
            else if(comboBox_pilih_kue.Text == "3.cake keju = Rp.170.000")
            {
                comboBox_pilih_toping.Items.Add("no toping cake keju");
                comboBox_pilih_toping.Items.Add("fruit = Rp.10.000");
                comboBox_pilih_toping.Items.Add("keju batang = Rp.15.000");
          
            }
            else if( comboBox_pilih_kue.Text == "4.fruit cake = Rp.180.000")
            {
                comboBox_pilih_toping.Items.Add("no toping fruit cake");
                comboBox_pilih_toping.Items.Add("apple = Rp.5.000");
                comboBox_pilih_toping.Items.Add("guava = Rp.10.000");
                comboBox_pilih_toping.Items.Add("strawberyy = 10.000");
            }else if( comboBox_pilih_toping.Text == "5.tiramisu taart = Rp.200.000")
            {
                comboBox_pilih_toping.Items.Add("no toping tiramisu taart");
                comboBox_pilih_toping.Items.Add("cokelatt = Rp.15.000");
                comboBox_pilih_toping.Items.Add("strawbery = 10.000");
            }
           
        }

        private void comboBox_pilih_toping_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_pilih_toping.Text == "no toping taart cokelat")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "toping keju = Rp. 15.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "toping almond = Rp.20.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "toping mocca = Rp.10.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "no toping vlack forest")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }else if(comboBox_pilih_toping.Text == "chocochips = Rp.10.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "tiramisu = Rp.15.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "no toping cake keju")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "fruit = Rp.10.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "keju batang = Rp.15.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "strawberyy = Rp.10.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "no toping fruit cake")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "no toping fruit cake")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "apple = Rp.5.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "guava = Rp.10.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "no toping tiramisu taart")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "cokelatt = Rp.15.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
            else if(comboBox_pilih_toping.Text == "strawbery = 10.000")
            {
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000");
                comboBox_pilih_bungkusan.Items.Add("mika = Rp.35.000 dan pake nama = Rp.2.000");
                comboBox_pilih_bungkusan.Items.Add("karton = Rp.3.000 dan pake nama = Rp.2.000");
            }
        }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {


        }
    }
}

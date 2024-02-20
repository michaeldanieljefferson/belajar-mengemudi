using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_combo_box
{
    public partial class Form1 : Form
    {
        int harga = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            box_pilihan.Items.Add("rujak = 3.000");
            box_pilihan.Items.Add("ikan = 5.000");
            box_pilihan.Items.Add("telor = 2.000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int makanan = 5000;
            makanan = harga + makanan * Convert.ToInt32(numeric_tambah.Value);
            total.Text = Convert.ToString(makanan);
        }

        private void box_pilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(box_pilihan.Text == "rujak = 3.000")
            {
                harga = harga + 3000;
            }
            if(box_pilihan.Text == "ikan = 5.000")
            {
                harga = harga + 5000;
            }
            if(box_pilihan.Text == "telor = 2.000")
            {
                harga = harga + 2000;
            }
        }
    }
}

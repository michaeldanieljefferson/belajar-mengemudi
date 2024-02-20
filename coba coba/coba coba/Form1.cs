using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba_coba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int harga = 0;
            if(cekbox_merah.Checked == true)
            {
                harga = harga + 10000;
                harga = harga * Convert.ToInt32(box_merah.Value);
            }
            if(cekbox_kuning.Checked == true)
            {
                harga = harga + 5000;
                harga = harga * Convert.ToInt32(box_kuning.Value);
            }
            total.Text = Convert.ToString(harga);
        }
    }
}

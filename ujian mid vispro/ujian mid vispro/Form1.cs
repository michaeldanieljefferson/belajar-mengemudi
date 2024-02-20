using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ujian_mid_vispro
{
    public partial class Form_PT_Bread_Talk : Form
    {
        public Form_PT_Bread_Talk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_input pilihan = new Form_input();
            pilihan.Show();
        }
    }
}

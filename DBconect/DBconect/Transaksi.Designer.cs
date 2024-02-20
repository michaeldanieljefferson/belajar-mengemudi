namespace DBconect
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_sewa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.dateTimePicker_mulai = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_selesai = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_nomorpolisi = new System.Windows.Forms.Label();
            this.label_biayaharian = new System.Windows.Forms.Label();
            this.label_merk = new System.Windows.Forms.Label();
            this.label_warna = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_id_customer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_jlhHari = new System.Windows.Forms.Label();
            this.lbl_id_mobil = new System.Windows.Forms.Label();
            this.label_th_pembuatan = new System.Windows.Forms.Label();
            this.label_jenis_model = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_sewa
            // 
            this.button_sewa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_sewa.Location = new System.Drawing.Point(738, 413);
            this.button_sewa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sewa.Name = "button_sewa";
            this.button_sewa.Size = new System.Drawing.Size(194, 58);
            this.button_sewa.TabIndex = 0;
            this.button_sewa.Text = "Sewa";
            this.button_sewa.UseVisualStyleBackColor = false;
            this.button_sewa.Click += new System.EventHandler(this.button_sewa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipe Mobil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selesai Sewa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mulai Sewa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(458, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.White;
            this.label_total.Location = new System.Drawing.Point(592, 435);
            this.label_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(32, 36);
            this.label_total.TabIndex = 6;
            this.label_total.Text = "0";
            this.label_total.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker_mulai
            // 
            this.dateTimePicker_mulai.Enabled = false;
            this.dateTimePicker_mulai.Location = new System.Drawing.Point(161, 404);
            this.dateTimePicker_mulai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_mulai.Name = "dateTimePicker_mulai";
            this.dateTimePicker_mulai.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker_mulai.TabIndex = 9;
            // 
            // dateTimePicker_selesai
            // 
            this.dateTimePicker_selesai.Location = new System.Drawing.Point(161, 448);
            this.dateTimePicker_selesai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_selesai.Name = "dateTimePicker_selesai";
            this.dateTimePicker_selesai.Size = new System.Drawing.Size(219, 26);
            this.dateTimePicker_selesai.TabIndex = 10;
            this.dateTimePicker_selesai.ValueChanged += new System.EventHandler(this.dateTimePicker_selesai_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(738, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Daftar Member Baru";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sewa Kendaraan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(771, 164);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_nomorpolisi
            // 
            this.label_nomorpolisi.AutoSize = true;
            this.label_nomorpolisi.ForeColor = System.Drawing.Color.White;
            this.label_nomorpolisi.Location = new System.Drawing.Point(179, 333);
            this.label_nomorpolisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nomorpolisi.Name = "label_nomorpolisi";
            this.label_nomorpolisi.Size = new System.Drawing.Size(93, 20);
            this.label_nomorpolisi.TabIndex = 14;
            this.label_nomorpolisi.Text = "nomor polisi";
            // 
            // label_biayaharian
            // 
            this.label_biayaharian.AutoSize = true;
            this.label_biayaharian.ForeColor = System.Drawing.Color.White;
            this.label_biayaharian.Location = new System.Drawing.Point(380, 302);
            this.label_biayaharian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_biayaharian.Name = "label_biayaharian";
            this.label_biayaharian.Size = new System.Drawing.Size(99, 20);
            this.label_biayaharian.TabIndex = 15;
            this.label_biayaharian.Text = "Biaya Harian";
            // 
            // label_merk
            // 
            this.label_merk.AutoSize = true;
            this.label_merk.ForeColor = System.Drawing.Color.White;
            this.label_merk.Location = new System.Drawing.Point(179, 302);
            this.label_merk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_merk.Name = "label_merk";
            this.label_merk.Size = new System.Drawing.Size(85, 20);
            this.label_merk.TabIndex = 16;
            this.label_merk.Text = "Merk Mobil";
            // 
            // label_warna
            // 
            this.label_warna.AutoSize = true;
            this.label_warna.ForeColor = System.Drawing.Color.White;
            this.label_warna.Location = new System.Drawing.Point(380, 333);
            this.label_warna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_warna.Name = "label_warna";
            this.label_warna.Size = new System.Drawing.Size(56, 20);
            this.label_warna.TabIndex = 17;
            this.label_warna.Text = "Warna";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(610, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_id_customer
            // 
            this.label_id_customer.AutoSize = true;
            this.label_id_customer.ForeColor = System.Drawing.Color.White;
            this.label_id_customer.Location = new System.Drawing.Point(458, 66);
            this.label_id_customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_customer.Name = "label_id_customer";
            this.label_id_customer.Size = new System.Drawing.Size(21, 20);
            this.label_id_customer.TabIndex = 20;
            this.label_id_customer.Text = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(458, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Jumlah Hari";
            // 
            // label_jlhHari
            // 
            this.label_jlhHari.AutoSize = true;
            this.label_jlhHari.ForeColor = System.Drawing.Color.White;
            this.label_jlhHari.Location = new System.Drawing.Point(606, 410);
            this.label_jlhHari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_jlhHari.Name = "label_jlhHari";
            this.label_jlhHari.Size = new System.Drawing.Size(18, 20);
            this.label_jlhHari.TabIndex = 22;
            this.label_jlhHari.Text = "0";
            // 
            // lbl_id_mobil
            // 
            this.lbl_id_mobil.AutoSize = true;
            this.lbl_id_mobil.ForeColor = System.Drawing.Color.White;
            this.lbl_id_mobil.Location = new System.Drawing.Point(606, 302);
            this.lbl_id_mobil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id_mobil.Name = "lbl_id_mobil";
            this.lbl_id_mobil.Size = new System.Drawing.Size(62, 20);
            this.lbl_id_mobil.TabIndex = 23;
            this.lbl_id_mobil.Text = "id mobil";
            // 
            // label_th_pembuatan
            // 
            this.label_th_pembuatan.AutoSize = true;
            this.label_th_pembuatan.ForeColor = System.Drawing.Color.White;
            this.label_th_pembuatan.Location = new System.Drawing.Point(606, 333);
            this.label_th_pembuatan.Name = "label_th_pembuatan";
            this.label_th_pembuatan.Size = new System.Drawing.Size(135, 20);
            this.label_th_pembuatan.TabIndex = 26;
            this.label_th_pembuatan.Text = "tahun pembuatan";
            // 
            // label_jenis_model
            // 
            this.label_jenis_model.AutoSize = true;
            this.label_jenis_model.ForeColor = System.Drawing.Color.White;
            this.label_jenis_model.Location = new System.Drawing.Point(796, 302);
            this.label_jenis_model.Name = "label_jenis_model";
            this.label_jenis_model.Size = new System.Drawing.Size(88, 20);
            this.label_jenis_model.TabIndex = 27;
            this.label_jenis_model.Text = "jenis model";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.ForeColor = System.Drawing.Color.White;
            this.label_status.Location = new System.Drawing.Point(796, 333);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(53, 20);
            this.label_status.TabIndex = 28;
            this.label_status.Text = "status";
            // 
            // comboBox_search
            // 
            this.comboBox_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_search.FormattingEnabled = true;
            this.comboBox_search.Location = new System.Drawing.Point(161, 63);
            this.comboBox_search.Name = "comboBox_search";
            this.comboBox_search.Size = new System.Drawing.Size(272, 28);
            this.comboBox_search.TabIndex = 33;
            this.comboBox_search.SelectedIndexChanged += new System.EventHandler(this.comboBox_search_SelectedIndexChanged);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 488);
            this.Controls.Add(this.comboBox_search);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_jenis_model);
            this.Controls.Add(this.label_th_pembuatan);
            this.Controls.Add(this.lbl_id_mobil);
            this.Controls.Add(this.label_jlhHari);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_id_customer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_warna);
            this.Controls.Add(this.label_merk);
            this.Controls.Add(this.label_biayaharian);
            this.Controls.Add(this.label_nomorpolisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker_selesai);
            this.Controls.Add(this.dateTimePicker_mulai);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sewa);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sewa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.DateTimePicker dateTimePicker_mulai;
        private System.Windows.Forms.DateTimePicker dateTimePicker_selesai;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_nomorpolisi;
        private System.Windows.Forms.Label label_biayaharian;
        private System.Windows.Forms.Label label_merk;
        private System.Windows.Forms.Label label_warna;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_id_customer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_jlhHari;
        private System.Windows.Forms.Label lbl_id_mobil;
        private System.Windows.Forms.Label label_th_pembuatan;
        private System.Windows.Forms.Label label_jenis_model;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_search;
    }
}
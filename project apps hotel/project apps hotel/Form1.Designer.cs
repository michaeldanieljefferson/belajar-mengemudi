
namespace project_apps_hotel
{
    partial class form_apps_hotel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_all = new System.Windows.Forms.GroupBox();
            this.box_nama = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.GB_timestart = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.box_fasilitas = new System.Windows.Forms.ComboBox();
            this.GB_fasilitas_t = new System.Windows.Forms.GroupBox();
            this.box_nomor_kamar = new System.Windows.Forms.ComboBox();
            this.GB_nomor_kamar = new System.Windows.Forms.GroupBox();
            this.GB_tipe_kamar = new System.Windows.Forms.GroupBox();
            this.box_tipe_kamar = new System.Windows.Forms.ComboBox();
            this.GB_hasilsewa = new System.Windows.Forms.GroupBox();
            this.output_total = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.output_hargakamar = new System.Windows.Forms.TextBox();
            this.output_nama = new System.Windows.Forms.TextBox();
            this.GB_nama = new System.Windows.Forms.GroupBox();
            this.output_tipekamar = new System.Windows.Forms.TextBox();
            this.GB_hargafasilitas = new System.Windows.Forms.GroupBox();
            this.output_nomorkamar = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.output_hargafasilitas = new System.Windows.Forms.TextBox();
            this.GB_hargakamar = new System.Windows.Forms.GroupBox();
            this.output_fasilitas = new System.Windows.Forms.TextBox();
            this.GB_nomorkamar = new System.Windows.Forms.GroupBox();
            this.GB_tipekamar = new System.Windows.Forms.GroupBox();
            this.dateTime_out = new System.Windows.Forms.DateTimePicker();
            this.dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.GB_timeout = new System.Windows.Forms.GroupBox();
            this.GB_all.SuspendLayout();
            this.GB_hasilsewa.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_all
            // 
            this.GB_all.Controls.Add(this.dateTime_out);
            this.GB_all.Controls.Add(this.GB_timeout);
            this.GB_all.Controls.Add(this.dateTime_start);
            this.GB_all.Controls.Add(this.box_nama);
            this.GB_all.Controls.Add(this.groupBox2);
            this.GB_all.Controls.Add(this.button_submit);
            this.GB_all.Controls.Add(this.GB_timestart);
            this.GB_all.Controls.Add(this.button_delete);
            this.GB_all.Controls.Add(this.box_fasilitas);
            this.GB_all.Controls.Add(this.GB_fasilitas_t);
            this.GB_all.Controls.Add(this.box_nomor_kamar);
            this.GB_all.Controls.Add(this.GB_nomor_kamar);
            this.GB_all.Controls.Add(this.GB_tipe_kamar);
            this.GB_all.Controls.Add(this.box_tipe_kamar);
            this.GB_all.Location = new System.Drawing.Point(12, 12);
            this.GB_all.Name = "GB_all";
            this.GB_all.Size = new System.Drawing.Size(508, 463);
            this.GB_all.TabIndex = 0;
            this.GB_all.TabStop = false;
            // 
            // box_nama
            // 
            this.box_nama.Location = new System.Drawing.Point(107, 39);
            this.box_nama.Name = "box_nama";
            this.box_nama.Size = new System.Drawing.Size(302, 31);
            this.box_nama.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 32);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "nama :";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(315, 398);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(112, 34);
            this.button_submit.TabIndex = 1;
            this.button_submit.Text = "submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // GB_timestart
            // 
            this.GB_timestart.Location = new System.Drawing.Point(266, 98);
            this.GB_timestart.Name = "GB_timestart";
            this.GB_timestart.Size = new System.Drawing.Size(143, 23);
            this.GB_timestart.TabIndex = 3;
            this.GB_timestart.TabStop = false;
            this.GB_timestart.Text = "mulai sewa :";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(72, 398);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(112, 34);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // box_fasilitas
            // 
            this.box_fasilitas.FormattingEnabled = true;
            this.box_fasilitas.Location = new System.Drawing.Point(6, 306);
            this.box_fasilitas.Name = "box_fasilitas";
            this.box_fasilitas.Size = new System.Drawing.Size(214, 33);
            this.box_fasilitas.TabIndex = 1;
            this.box_fasilitas.SelectedIndexChanged += new System.EventHandler(this.box_fasilitas_SelectedIndexChanged);
            // 
            // GB_fasilitas_t
            // 
            this.GB_fasilitas_t.Location = new System.Drawing.Point(6, 278);
            this.GB_fasilitas_t.Name = "GB_fasilitas_t";
            this.GB_fasilitas_t.Size = new System.Drawing.Size(178, 26);
            this.GB_fasilitas_t.TabIndex = 1;
            this.GB_fasilitas_t.TabStop = false;
            this.GB_fasilitas_t.Text = "fasilitas tambahan :";
            // 
            // box_nomor_kamar
            // 
            this.box_nomor_kamar.FormattingEnabled = true;
            this.box_nomor_kamar.Location = new System.Drawing.Point(6, 213);
            this.box_nomor_kamar.Name = "box_nomor_kamar";
            this.box_nomor_kamar.Size = new System.Drawing.Size(214, 33);
            this.box_nomor_kamar.TabIndex = 1;
            this.box_nomor_kamar.SelectedIndexChanged += new System.EventHandler(this.box_nomor_kamar_SelectedIndexChanged);
            // 
            // GB_nomor_kamar
            // 
            this.GB_nomor_kamar.Location = new System.Drawing.Point(6, 188);
            this.GB_nomor_kamar.Name = "GB_nomor_kamar";
            this.GB_nomor_kamar.Size = new System.Drawing.Size(178, 27);
            this.GB_nomor_kamar.TabIndex = 1;
            this.GB_nomor_kamar.TabStop = false;
            this.GB_nomor_kamar.Text = "nomor kamar :";
            // 
            // GB_tipe_kamar
            // 
            this.GB_tipe_kamar.Location = new System.Drawing.Point(6, 96);
            this.GB_tipe_kamar.Name = "GB_tipe_kamar";
            this.GB_tipe_kamar.Size = new System.Drawing.Size(142, 25);
            this.GB_tipe_kamar.TabIndex = 1;
            this.GB_tipe_kamar.TabStop = false;
            this.GB_tipe_kamar.Text = " tipe kamar :";
            // 
            // box_tipe_kamar
            // 
            this.box_tipe_kamar.FormattingEnabled = true;
            this.box_tipe_kamar.Location = new System.Drawing.Point(6, 127);
            this.box_tipe_kamar.Name = "box_tipe_kamar";
            this.box_tipe_kamar.Size = new System.Drawing.Size(214, 33);
            this.box_tipe_kamar.TabIndex = 2;
            this.box_tipe_kamar.SelectedIndexChanged += new System.EventHandler(this.box_pilihan_kamar_SelectedIndexChanged);
            // 
            // GB_hasilsewa
            // 
            this.GB_hasilsewa.BackColor = System.Drawing.Color.Red;
            this.GB_hasilsewa.Controls.Add(this.output_total);
            this.GB_hasilsewa.Controls.Add(this.groupBox1);
            this.GB_hasilsewa.Controls.Add(this.output_hargakamar);
            this.GB_hasilsewa.Controls.Add(this.output_nama);
            this.GB_hasilsewa.Controls.Add(this.GB_nama);
            this.GB_hasilsewa.Controls.Add(this.output_tipekamar);
            this.GB_hasilsewa.Controls.Add(this.GB_hargafasilitas);
            this.GB_hasilsewa.Controls.Add(this.output_nomorkamar);
            this.GB_hasilsewa.Controls.Add(this.groupBox5);
            this.GB_hasilsewa.Controls.Add(this.output_hargafasilitas);
            this.GB_hasilsewa.Controls.Add(this.GB_hargakamar);
            this.GB_hasilsewa.Controls.Add(this.output_fasilitas);
            this.GB_hasilsewa.Controls.Add(this.GB_nomorkamar);
            this.GB_hasilsewa.Controls.Add(this.GB_tipekamar);
            this.GB_hasilsewa.Location = new System.Drawing.Point(616, 12);
            this.GB_hasilsewa.Name = "GB_hasilsewa";
            this.GB_hasilsewa.Size = new System.Drawing.Size(688, 432);
            this.GB_hasilsewa.TabIndex = 1;
            this.GB_hasilsewa.TabStop = false;
            this.GB_hasilsewa.Text = "hasil sewa kost :";
            // 
            // output_total
            // 
            this.output_total.Location = new System.Drawing.Point(249, 314);
            this.output_total.Name = "output_total";
            this.output_total.Size = new System.Drawing.Size(150, 31);
            this.output_total.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(245, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 30);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "total :";
            // 
            // output_hargakamar
            // 
            this.output_hargakamar.Location = new System.Drawing.Point(245, 124);
            this.output_hargakamar.Name = "output_hargakamar";
            this.output_hargakamar.Size = new System.Drawing.Size(150, 31);
            this.output_hargakamar.TabIndex = 0;
            this.output_hargakamar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // output_nama
            // 
            this.output_nama.Location = new System.Drawing.Point(131, 39);
            this.output_nama.Name = "output_nama";
            this.output_nama.Size = new System.Drawing.Size(266, 31);
            this.output_nama.TabIndex = 11;
            this.output_nama.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // GB_nama
            // 
            this.GB_nama.Location = new System.Drawing.Point(19, 39);
            this.GB_nama.Name = "GB_nama";
            this.GB_nama.Size = new System.Drawing.Size(96, 29);
            this.GB_nama.TabIndex = 10;
            this.GB_nama.TabStop = false;
            this.GB_nama.Text = "nama :";
            // 
            // output_tipekamar
            // 
            this.output_tipekamar.Location = new System.Drawing.Point(19, 126);
            this.output_tipekamar.Name = "output_tipekamar";
            this.output_tipekamar.Size = new System.Drawing.Size(150, 31);
            this.output_tipekamar.TabIndex = 9;
            // 
            // GB_hargafasilitas
            // 
            this.GB_hargafasilitas.Location = new System.Drawing.Point(249, 183);
            this.GB_hargafasilitas.Name = "GB_hargafasilitas";
            this.GB_hargafasilitas.Size = new System.Drawing.Size(148, 28);
            this.GB_hargafasilitas.TabIndex = 8;
            this.GB_hargafasilitas.TabStop = false;
            this.GB_hargafasilitas.Text = "harga fasilitas :";
            // 
            // output_nomorkamar
            // 
            this.output_nomorkamar.Location = new System.Drawing.Point(19, 213);
            this.output_nomorkamar.Name = "output_nomorkamar";
            this.output_nomorkamar.Size = new System.Drawing.Size(150, 31);
            this.output_nomorkamar.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(19, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 27);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "fasilitas tambahan :";
            // 
            // output_hargafasilitas
            // 
            this.output_hargafasilitas.Location = new System.Drawing.Point(247, 213);
            this.output_hargafasilitas.Name = "output_hargafasilitas";
            this.output_hargafasilitas.Size = new System.Drawing.Size(150, 31);
            this.output_hargafasilitas.TabIndex = 5;
            // 
            // GB_hargakamar
            // 
            this.GB_hargakamar.Location = new System.Drawing.Point(247, 94);
            this.GB_hargakamar.Name = "GB_hargakamar";
            this.GB_hargakamar.Size = new System.Drawing.Size(148, 27);
            this.GB_hargakamar.TabIndex = 4;
            this.GB_hargakamar.TabStop = false;
            this.GB_hargakamar.Text = "harga kamar :";
            // 
            // output_fasilitas
            // 
            this.output_fasilitas.Location = new System.Drawing.Point(19, 308);
            this.output_fasilitas.Name = "output_fasilitas";
            this.output_fasilitas.Size = new System.Drawing.Size(150, 31);
            this.output_fasilitas.TabIndex = 3;
            // 
            // GB_nomorkamar
            // 
            this.GB_nomorkamar.Location = new System.Drawing.Point(19, 183);
            this.GB_nomorkamar.Name = "GB_nomorkamar";
            this.GB_nomorkamar.Size = new System.Drawing.Size(148, 27);
            this.GB_nomorkamar.TabIndex = 2;
            this.GB_nomorkamar.TabStop = false;
            this.GB_nomorkamar.Text = "nomor kamar :";
            // 
            // GB_tipekamar
            // 
            this.GB_tipekamar.Location = new System.Drawing.Point(19, 96);
            this.GB_tipekamar.Name = "GB_tipekamar";
            this.GB_tipekamar.Size = new System.Drawing.Size(137, 24);
            this.GB_tipekamar.TabIndex = 1;
            this.GB_tipekamar.TabStop = false;
            this.GB_tipekamar.Text = "tipe kamar :";
            // 
            // dateTime_out
            // 
            this.dateTime_out.Location = new System.Drawing.Point(256, 215);
            this.dateTime_out.Name = "dateTime_out";
            this.dateTime_out.Size = new System.Drawing.Size(246, 31);
            this.dateTime_out.TabIndex = 2;
            // 
            // dateTime_start
            // 
            this.dateTime_start.Location = new System.Drawing.Point(256, 124);
            this.dateTime_start.Name = "dateTime_start";
            this.dateTime_start.Size = new System.Drawing.Size(246, 31);
            this.dateTime_start.TabIndex = 3;
            this.dateTime_start.Value = new System.DateTime(2021, 9, 14, 20, 45, 39, 0);
            // 
            // GB_timeout
            // 
            this.GB_timeout.Location = new System.Drawing.Point(256, 188);
            this.GB_timeout.Name = "GB_timeout";
            this.GB_timeout.Size = new System.Drawing.Size(153, 23);
            this.GB_timeout.TabIndex = 6;
            this.GB_timeout.TabStop = false;
            this.GB_timeout.Text = "terakhir sewa :";
            // 
            // form_apps_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 544);
            this.Controls.Add(this.GB_hasilsewa);
            this.Controls.Add(this.GB_all);
            this.Name = "form_apps_hotel";
            this.Text = "El Pacino Residence";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_all.ResumeLayout(false);
            this.GB_all.PerformLayout();
            this.GB_hasilsewa.ResumeLayout(false);
            this.GB_hasilsewa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_all;
        private System.Windows.Forms.ComboBox box_nomor_kamar;
        private System.Windows.Forms.GroupBox GB_nomor_kamar;
        private System.Windows.Forms.GroupBox GB_tipe_kamar;
        private System.Windows.Forms.ComboBox box_tipe_kamar;
        private System.Windows.Forms.ComboBox box_fasilitas;
        private System.Windows.Forms.GroupBox GB_fasilitas_t;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.GroupBox GB_timestart;
        private System.Windows.Forms.GroupBox GB_hasilsewa;
        private System.Windows.Forms.GroupBox GB_nomorkamar;
        private System.Windows.Forms.GroupBox GB_tipekamar;
        private System.Windows.Forms.TextBox output_hargakamar;
        private System.Windows.Forms.TextBox output_fasilitas;
        private System.Windows.Forms.TextBox output_nama;
        private System.Windows.Forms.GroupBox GB_nama;
        private System.Windows.Forms.TextBox output_tipekamar;
        private System.Windows.Forms.GroupBox GB_hargafasilitas;
        private System.Windows.Forms.TextBox output_nomorkamar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox output_hargafasilitas;
        private System.Windows.Forms.GroupBox GB_hargakamar;
        private System.Windows.Forms.TextBox box_nama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox output_total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_out;
        private System.Windows.Forms.DateTimePicker dateTime_start;
        private System.Windows.Forms.GroupBox GB_timeout;
    }
}


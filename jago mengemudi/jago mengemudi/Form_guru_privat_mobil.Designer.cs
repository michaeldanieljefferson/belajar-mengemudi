
namespace jago_mengemudi
{
    partial class Form_guru_privat_mobil
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
            this.guru_privat_mobil = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_nomor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_paket12 = new System.Windows.Forms.RadioButton();
            this.rb_paket_9 = new System.Windows.Forms.RadioButton();
            this.rb_paket_6 = new System.Windows.Forms.RadioButton();
            this.rb_paket3 = new System.Windows.Forms.RadioButton();
            this.label_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_kontrak = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_honor = new System.Windows.Forms.Label();
            this.label_teacher_id = new System.Windows.Forms.Label();
            this.label_id_student = new System.Windows.Forms.Label();
            this.label_nama_Student = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guru_privat_mobil)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guru_privat_mobil
            // 
            this.guru_privat_mobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guru_privat_mobil.Location = new System.Drawing.Point(1, 1);
            this.guru_privat_mobil.Name = "guru_privat_mobil";
            this.guru_privat_mobil.RowHeadersWidth = 62;
            this.guru_privat_mobil.RowTemplate.Height = 28;
            this.guru_privat_mobil.Size = new System.Drawing.Size(798, 323);
            this.guru_privat_mobil.TabIndex = 0;
            this.guru_privat_mobil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guru_privat_mobil_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(805, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "nama teacher =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(805, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "nomor teacher =";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_nama.Location = new System.Drawing.Point(970, 9);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(21, 20);
            this.label_nama.TabIndex = 4;
            this.label_nama.Text = "...";
            // 
            // label_nomor
            // 
            this.label_nomor.AutoSize = true;
            this.label_nomor.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_nomor.Location = new System.Drawing.Point(936, 45);
            this.label_nomor.Name = "label_nomor";
            this.label_nomor.Size = new System.Drawing.Size(21, 20);
            this.label_nomor.TabIndex = 5;
            this.label_nomor.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(805, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "alamat teacher =";
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_alamat.Location = new System.Drawing.Point(939, 80);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(21, 20);
            this.label_alamat.TabIndex = 7;
            this.label_alamat.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox1.Controls.Add(this.rb_paket12);
            this.groupBox1.Controls.Add(this.rb_paket_9);
            this.groupBox1.Controls.Add(this.rb_paket_6);
            this.groupBox1.Controls.Add(this.rb_paket3);
            this.groupBox1.Controls.Add(this.label_total);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(809, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pilih paket pertemuan:";
            // 
            // rb_paket12
            // 
            this.rb_paket12.AutoSize = true;
            this.rb_paket12.Location = new System.Drawing.Point(110, 55);
            this.rb_paket12.Name = "rb_paket12";
            this.rb_paket12.Size = new System.Drawing.Size(104, 24);
            this.rb_paket12.TabIndex = 9;
            this.rb_paket12.TabStop = true;
            this.rb_paket12.Text = "paket 12";
            this.rb_paket12.UseVisualStyleBackColor = true;
            // 
            // rb_paket_9
            // 
            this.rb_paket_9.AutoSize = true;
            this.rb_paket_9.Location = new System.Drawing.Point(110, 25);
            this.rb_paket_9.Name = "rb_paket_9";
            this.rb_paket_9.Size = new System.Drawing.Size(94, 24);
            this.rb_paket_9.TabIndex = 8;
            this.rb_paket_9.TabStop = true;
            this.rb_paket_9.Text = "paket 9";
            this.rb_paket_9.UseVisualStyleBackColor = true;
            // 
            // rb_paket_6
            // 
            this.rb_paket_6.AutoSize = true;
            this.rb_paket_6.Location = new System.Drawing.Point(10, 55);
            this.rb_paket_6.Name = "rb_paket_6";
            this.rb_paket_6.Size = new System.Drawing.Size(94, 24);
            this.rb_paket_6.TabIndex = 7;
            this.rb_paket_6.TabStop = true;
            this.rb_paket_6.Text = "paket 6";
            this.rb_paket_6.UseVisualStyleBackColor = true;
            // 
            // rb_paket3
            // 
            this.rb_paket3.AutoSize = true;
            this.rb_paket3.Location = new System.Drawing.Point(10, 25);
            this.rb_paket3.Name = "rb_paket3";
            this.rb_paket3.Size = new System.Drawing.Size(94, 24);
            this.rb_paket3.TabIndex = 6;
            this.rb_paket3.TabStop = true;
            this.rb_paket3.Text = "paket 3";
            this.rb_paket3.UseVisualStyleBackColor = true;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(68, 106);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(24, 20);
            this.label_total.TabIndex = 5;
            this.label_total.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "total =";
            // 
            // button_kontrak
            // 
            this.button_kontrak.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_kontrak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kontrak.ForeColor = System.Drawing.Color.White;
            this.button_kontrak.Location = new System.Drawing.Point(1128, 285);
            this.button_kontrak.Name = "button_kontrak";
            this.button_kontrak.Size = new System.Drawing.Size(109, 30);
            this.button_kontrak.TabIndex = 9;
            this.button_kontrak.Text = "kontrak";
            this.button_kontrak.UseVisualStyleBackColor = false;
            this.button_kontrak.Click += new System.EventHandler(this.button_kontrak_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(1128, 232);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(109, 30);
            this.button_refresh.TabIndex = 10;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(805, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "bayaran =";
            // 
            // label_honor
            // 
            this.label_honor.AutoSize = true;
            this.label_honor.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_honor.Location = new System.Drawing.Point(890, 115);
            this.label_honor.Name = "label_honor";
            this.label_honor.Size = new System.Drawing.Size(21, 20);
            this.label_honor.TabIndex = 12;
            this.label_honor.Text = "...";
            // 
            // label_teacher_id
            // 
            this.label_teacher_id.AutoSize = true;
            this.label_teacher_id.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_teacher_id.Location = new System.Drawing.Point(936, 9);
            this.label_teacher_id.Name = "label_teacher_id";
            this.label_teacher_id.Size = new System.Drawing.Size(21, 20);
            this.label_teacher_id.TabIndex = 13;
            this.label_teacher_id.Text = "...";
            // 
            // label_id_student
            // 
            this.label_id_student.AutoSize = true;
            this.label_id_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_student.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_id_student.Location = new System.Drawing.Point(1033, 164);
            this.label_id_student.Name = "label_id_student";
            this.label_id_student.Size = new System.Drawing.Size(24, 20);
            this.label_id_student.TabIndex = 14;
            this.label_id_student.Text = "...";
            this.label_id_student.Click += new System.EventHandler(this.label_id_student_Click);
            // 
            // label_nama_Student
            // 
            this.label_nama_Student.AutoSize = true;
            this.label_nama_Student.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_nama_Student.Location = new System.Drawing.Point(1033, 191);
            this.label_nama_Student.Name = "label_nama_Student";
            this.label_nama_Student.Size = new System.Drawing.Size(21, 20);
            this.label_nama_Student.TabIndex = 15;
            this.label_nama_Student.Text = "...";
            // 
            // Form_guru_privat_mobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1258, 324);
            this.Controls.Add(this.label_nama_Student);
            this.Controls.Add(this.label_id_student);
            this.Controls.Add(this.label_teacher_id);
            this.Controls.Add(this.label_honor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_kontrak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_alamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_nomor);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guru_privat_mobil);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form_guru_privat_mobil";
            this.Text = "Form_guru_privat_mobil";
            this.Load += new System.EventHandler(this.Form_guru_privat_mobil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guru_privat_mobil)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView guru_privat_mobil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_nomor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_kontrak;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_honor;
        private System.Windows.Forms.RadioButton rb_paket12;
        private System.Windows.Forms.RadioButton rb_paket_9;
        private System.Windows.Forms.RadioButton rb_paket_6;
        private System.Windows.Forms.RadioButton rb_paket3;
        private System.Windows.Forms.Label label_teacher_id;
        public System.Windows.Forms.Label label_id_student;
        public System.Windows.Forms.Label label_nama_Student;
    }
}

namespace jago_mengemudi
{
    partial class Form_edit_data_student
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
            this.tb_alamat_student = new System.Windows.Forms.TextBox();
            this.tb_nomor_student = new System.Windows.Forms.TextBox();
            this.tb_umur_student = new System.Windows.Forms.TextBox();
            this.tb_nama_student = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_contiue = new System.Windows.Forms.Button();
            this.tb_user_id_student = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_alamat_student
            // 
            this.tb_alamat_student.ForeColor = System.Drawing.Color.Gray;
            this.tb_alamat_student.Location = new System.Drawing.Point(520, 395);
            this.tb_alamat_student.Name = "tb_alamat_student";
            this.tb_alamat_student.Size = new System.Drawing.Size(274, 26);
            this.tb_alamat_student.TabIndex = 11;
            this.tb_alamat_student.Text = "  alamat...";
            // 
            // tb_nomor_student
            // 
            this.tb_nomor_student.ForeColor = System.Drawing.Color.Gray;
            this.tb_nomor_student.Location = new System.Drawing.Point(520, 331);
            this.tb_nomor_student.Name = "tb_nomor_student";
            this.tb_nomor_student.Size = new System.Drawing.Size(274, 26);
            this.tb_nomor_student.TabIndex = 10;
            this.tb_nomor_student.Text = "  nomor...";
            // 
            // tb_umur_student
            // 
            this.tb_umur_student.ForeColor = System.Drawing.Color.Gray;
            this.tb_umur_student.Location = new System.Drawing.Point(520, 268);
            this.tb_umur_student.Name = "tb_umur_student";
            this.tb_umur_student.Size = new System.Drawing.Size(274, 26);
            this.tb_umur_student.TabIndex = 9;
            this.tb_umur_student.Text = "  umur...";
            // 
            // tb_nama_student
            // 
            this.tb_nama_student.ForeColor = System.Drawing.Color.Gray;
            this.tb_nama_student.Location = new System.Drawing.Point(520, 206);
            this.tb_nama_student.Name = "tb_nama_student";
            this.tb_nama_student.Size = new System.Drawing.Size(274, 26);
            this.tb_nama_student.TabIndex = 8;
            this.tb_nama_student.Text = "  nama...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jago_mengemudi.Properties.Resources.kafe1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(995, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_contiue
            // 
            this.button_contiue.BackColor = System.Drawing.Color.Olive;
            this.button_contiue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contiue.ForeColor = System.Drawing.Color.White;
            this.button_contiue.Location = new System.Drawing.Point(707, 451);
            this.button_contiue.Name = "button_contiue";
            this.button_contiue.Size = new System.Drawing.Size(87, 31);
            this.button_contiue.TabIndex = 14;
            this.button_contiue.Text = "contiune";
            this.button_contiue.UseVisualStyleBackColor = false;
            this.button_contiue.Click += new System.EventHandler(this.button_contiue_Click);
            // 
            // tb_user_id_student
            // 
            this.tb_user_id_student.ForeColor = System.Drawing.Color.Gray;
            this.tb_user_id_student.Location = new System.Drawing.Point(520, 145);
            this.tb_user_id_student.Name = "tb_user_id_student";
            this.tb_user_id_student.Size = new System.Drawing.Size(274, 26);
            this.tb_user_id_student.TabIndex = 15;
            this.tb_user_id_student.Text = "  user id...";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.White;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(830, 599);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(129, 30);
            this.button_back.TabIndex = 12;
            this.button_back.Text = "back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form_edit_data_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 652);
            this.Controls.Add(this.tb_user_id_student);
            this.Controls.Add(this.button_contiue);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.tb_alamat_student);
            this.Controls.Add(this.tb_nomor_student);
            this.Controls.Add(this.tb_umur_student);
            this.Controls.Add(this.tb_nama_student);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_edit_data_student";
            this.Text = "Form_edit_data_student";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_alamat_student;
        private System.Windows.Forms.TextBox tb_nomor_student;
        private System.Windows.Forms.TextBox tb_umur_student;
        private System.Windows.Forms.TextBox tb_nama_student;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_contiue;
        private System.Windows.Forms.TextBox tb_user_id_student;
        private System.Windows.Forms.Button button_back;
    }
}
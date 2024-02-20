
namespace jago_mengemudi
{
    partial class Form_isi_data_student
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
            this.tb_student_username = new System.Windows.Forms.TextBox();
            this.tb_student_password = new System.Windows.Forms.TextBox();
            this.tb_student_age = new System.Windows.Forms.TextBox();
            this.tb_student_name = new System.Windows.Forms.TextBox();
            this.tb_student_number = new System.Windows.Forms.TextBox();
            this.tb_student_address = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_contiue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_student_username
            // 
            this.tb_student_username.ForeColor = System.Drawing.Color.Gray;
            this.tb_student_username.Location = new System.Drawing.Point(89, 138);
            this.tb_student_username.Name = "tb_student_username";
            this.tb_student_username.Size = new System.Drawing.Size(290, 26);
            this.tb_student_username.TabIndex = 1;
            this.tb_student_username.Text = "  username...";
            // 
            // tb_student_password
            // 
            this.tb_student_password.ForeColor = System.Drawing.Color.Gray;
            this.tb_student_password.Location = new System.Drawing.Point(89, 203);
            this.tb_student_password.Name = "tb_student_password";
            this.tb_student_password.Size = new System.Drawing.Size(290, 26);
            this.tb_student_password.TabIndex = 2;
            this.tb_student_password.Text = "  password...";
            // 
            // tb_student_age
            // 
            this.tb_student_age.ForeColor = System.Drawing.Color.Gray;
            this.tb_student_age.Location = new System.Drawing.Point(452, 203);
            this.tb_student_age.Name = "tb_student_age";
            this.tb_student_age.Size = new System.Drawing.Size(290, 26);
            this.tb_student_age.TabIndex = 3;
            this.tb_student_age.Text = "  umur...";
            // 
            // tb_student_name
            // 
            this.tb_student_name.ForeColor = System.Drawing.Color.Gray;
            this.tb_student_name.Location = new System.Drawing.Point(452, 138);
            this.tb_student_name.Name = "tb_student_name";
            this.tb_student_name.Size = new System.Drawing.Size(290, 26);
            this.tb_student_name.TabIndex = 4;
            this.tb_student_name.Text = "  nama...";
            // 
            // tb_student_number
            // 
            this.tb_student_number.ForeColor = System.Drawing.Color.Gray;
            this.tb_student_number.Location = new System.Drawing.Point(452, 269);
            this.tb_student_number.Name = "tb_student_number";
            this.tb_student_number.Size = new System.Drawing.Size(290, 26);
            this.tb_student_number.TabIndex = 5;
            this.tb_student_number.Text = "  nomor...";
            // 
            // tb_student_address
            // 
            this.tb_student_address.ForeColor = System.Drawing.Color.Gray;
            this.tb_student_address.Location = new System.Drawing.Point(452, 336);
            this.tb_student_address.Name = "tb_student_address";
            this.tb_student_address.Size = new System.Drawing.Size(290, 26);
            this.tb_student_address.TabIndex = 6;
            this.tb_student_address.Text = "  alamat...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(117, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jago_mengemudi.Properties.Resources.hh1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(954, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_contiue
            // 
            this.button_contiue.BackColor = System.Drawing.Color.Olive;
            this.button_contiue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_contiue.ForeColor = System.Drawing.Color.White;
            this.button_contiue.Location = new System.Drawing.Point(636, 405);
            this.button_contiue.Name = "button_contiue";
            this.button_contiue.Size = new System.Drawing.Size(106, 33);
            this.button_contiue.TabIndex = 8;
            this.button_contiue.Text = "continue";
            this.button_contiue.UseVisualStyleBackColor = false;
            this.button_contiue.Click += new System.EventHandler(this.button_contiue_Click);
            // 
            // Form_isi_data_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.button_contiue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_student_address);
            this.Controls.Add(this.tb_student_number);
            this.Controls.Add(this.tb_student_name);
            this.Controls.Add(this.tb_student_age);
            this.Controls.Add(this.tb_student_password);
            this.Controls.Add(this.tb_student_username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_isi_data_student";
            this.Text = "Form_isi_data_student";
            this.Load += new System.EventHandler(this.Form_isi_data_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_student_username;
        private System.Windows.Forms.TextBox tb_student_password;
        private System.Windows.Forms.TextBox tb_student_age;
        private System.Windows.Forms.TextBox tb_student_name;
        private System.Windows.Forms.TextBox tb_student_number;
        private System.Windows.Forms.TextBox tb_student_address;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_contiue;
    }
}

namespace jago_mengemudi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_buatakunbaru = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GB_choose_user = new System.Windows.Forms.GroupBox();
            this.button_student = new System.Windows.Forms.Button();
            this.button_teacher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_choose_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(785, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "welcome to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(873, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "jago mengemudi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "choose ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(994, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 10);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(791, 425);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 10);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(954, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "or";
            // 
            // button_buatakunbaru
            // 
            this.button_buatakunbaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_buatakunbaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buatakunbaru.ForeColor = System.Drawing.Color.White;
            this.button_buatakunbaru.Location = new System.Drawing.Point(879, 479);
            this.button_buatakunbaru.Name = "button_buatakunbaru";
            this.button_buatakunbaru.Size = new System.Drawing.Size(173, 31);
            this.button_buatakunbaru.TabIndex = 12;
            this.button_buatakunbaru.Text = "buat akun baru";
            this.button_buatakunbaru.UseVisualStyleBackColor = false;
            this.button_buatakunbaru.Click += new System.EventHandler(this.button_buatakunbaru_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1033, 639);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "connect";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GB_choose_user
            // 
            this.GB_choose_user.BackColor = System.Drawing.Color.Black;
            this.GB_choose_user.Controls.Add(this.button_student);
            this.GB_choose_user.Controls.Add(this.button_teacher);
            this.GB_choose_user.ForeColor = System.Drawing.Color.White;
            this.GB_choose_user.Location = new System.Drawing.Point(801, 516);
            this.GB_choose_user.Name = "GB_choose_user";
            this.GB_choose_user.Size = new System.Drawing.Size(200, 146);
            this.GB_choose_user.TabIndex = 14;
            this.GB_choose_user.TabStop = false;
            this.GB_choose_user.Text = "     choose one of them";
            // 
            // button_student
            // 
            this.button_student.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_student.Location = new System.Drawing.Point(27, 93);
            this.button_student.Name = "button_student";
            this.button_student.Size = new System.Drawing.Size(149, 32);
            this.button_student.TabIndex = 1;
            this.button_student.Text = "student";
            this.button_student.UseVisualStyleBackColor = false;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // button_teacher
            // 
            this.button_teacher.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_teacher.Location = new System.Drawing.Point(27, 38);
            this.button_teacher.Name = "button_teacher";
            this.button_teacher.Size = new System.Drawing.Size(149, 32);
            this.button_teacher.TabIndex = 0;
            this.button_teacher.Text = "teacher";
            this.button_teacher.UseVisualStyleBackColor = false;
            this.button_teacher.Click += new System.EventHandler(this.button_teacher_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(892, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "login teacher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(892, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "login student";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jago_mengemudi.Properties.Resources.pppppppppp;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 693);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 688);
            this.Controls.Add(this.button_buatakunbaru);
            this.Controls.Add(this.GB_choose_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_choose_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_buatakunbaru;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox GB_choose_user;
        private System.Windows.Forms.Button button_student;
        private System.Windows.Forms.Button button_teacher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


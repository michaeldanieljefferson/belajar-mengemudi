
namespace jago_mengemudi
{
    partial class Form_transaksi_teacher
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
            this.dataGridfinish = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_studentid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_nama_Student = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_transaksiid = new System.Windows.Forms.Label();
            this.button_accepted = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_nama_guru = new System.Windows.Forms.Label();
            this.label_id_guru = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridfinish)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridfinish
            // 
            this.dataGridfinish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridfinish.Location = new System.Drawing.Point(1, 0);
            this.dataGridfinish.Name = "dataGridfinish";
            this.dataGridfinish.RowHeadersWidth = 62;
            this.dataGridfinish.RowTemplate.Height = 28;
            this.dataGridfinish.Size = new System.Drawing.Size(687, 350);
            this.dataGridfinish.TabIndex = 0;
            this.dataGridfinish.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridfinish_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(707, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "nama :";
            // 
            // label_studentid
            // 
            this.label_studentid.AutoSize = true;
            this.label_studentid.BackColor = System.Drawing.Color.Black;
            this.label_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentid.ForeColor = System.Drawing.Color.White;
            this.label_studentid.Location = new System.Drawing.Point(841, 86);
            this.label_studentid.Name = "label_studentid";
            this.label_studentid.Size = new System.Drawing.Size(28, 22);
            this.label_studentid.TabIndex = 2;
            this.label_studentid.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(707, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID student :";
            // 
            // label_nama_Student
            // 
            this.label_nama_Student.AutoSize = true;
            this.label_nama_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama_Student.ForeColor = System.Drawing.Color.White;
            this.label_nama_Student.Location = new System.Drawing.Point(783, 142);
            this.label_nama_Student.Name = "label_nama_Student";
            this.label_nama_Student.Size = new System.Drawing.Size(28, 22);
            this.label_nama_Student.TabIndex = 4;
            this.label_nama_Student.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(707, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID transaksi :";
            // 
            // label_transaksiid
            // 
            this.label_transaksiid.AutoSize = true;
            this.label_transaksiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transaksiid.ForeColor = System.Drawing.Color.White;
            this.label_transaksiid.Location = new System.Drawing.Point(841, 32);
            this.label_transaksiid.Name = "label_transaksiid";
            this.label_transaksiid.Size = new System.Drawing.Size(28, 22);
            this.label_transaksiid.TabIndex = 6;
            this.label_transaksiid.Text = "...";
            // 
            // button_accepted
            // 
            this.button_accepted.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_accepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_accepted.ForeColor = System.Drawing.Color.White;
            this.button_accepted.Location = new System.Drawing.Point(936, 294);
            this.button_accepted.Name = "button_accepted";
            this.button_accepted.Size = new System.Drawing.Size(92, 44);
            this.button_accepted.TabIndex = 7;
            this.button_accepted.Text = "accept";
            this.button_accepted.UseVisualStyleBackColor = false;
            this.button_accepted.Click += new System.EventHandler(this.button_finished_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(711, 294);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(92, 44);
            this.button_refresh.TabIndex = 8;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_nama_guru
            // 
            this.label_nama_guru.AutoSize = true;
            this.label_nama_guru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama_guru.ForeColor = System.Drawing.Color.White;
            this.label_nama_guru.Location = new System.Drawing.Point(733, 231);
            this.label_nama_guru.Name = "label_nama_guru";
            this.label_nama_guru.Size = new System.Drawing.Size(24, 20);
            this.label_nama_guru.TabIndex = 9;
            this.label_nama_guru.Text = "...";
            // 
            // label_id_guru
            // 
            this.label_id_guru.AutoSize = true;
            this.label_id_guru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_guru.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_id_guru.Location = new System.Drawing.Point(736, 188);
            this.label_id_guru.Name = "label_id_guru";
            this.label_id_guru.Size = new System.Drawing.Size(24, 20);
            this.label_id_guru.TabIndex = 10;
            this.label_id_guru.Text = "...";
            // 
            // Form_transaksi_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1052, 350);
            this.Controls.Add(this.label_id_guru);
            this.Controls.Add(this.label_nama_guru);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_accepted);
            this.Controls.Add(this.label_transaksiid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_nama_Student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_studentid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridfinish);
            this.Name = "Form_transaksi_teacher";
            this.Text = "Form_transaksi_teacher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridfinish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridfinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_studentid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_nama_Student;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_transaksiid;
        private System.Windows.Forms.Button button_accepted;
        private System.Windows.Forms.Button button_refresh;
        public System.Windows.Forms.Label label_nama_guru;
        public System.Windows.Forms.Label label_id_guru;
    }
}
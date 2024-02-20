namespace DBconect
{
    partial class DataTransaksi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBL_Dashboard = new System.Windows.Forms.Label();
            this.Finished = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_kendaraan = new System.Windows.Forms.Label();
            this.label_nama_Customer = new System.Windows.Forms.Label();
            this.label_id_customer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(35, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(991, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LBL_Dashboard
            // 
            this.LBL_Dashboard.AutoSize = true;
            this.LBL_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Dashboard.ForeColor = System.Drawing.Color.White;
            this.LBL_Dashboard.Location = new System.Drawing.Point(27, 29);
            this.LBL_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Dashboard.Name = "LBL_Dashboard";
            this.LBL_Dashboard.Size = new System.Drawing.Size(204, 36);
            this.LBL_Dashboard.TabIndex = 1;
            this.LBL_Dashboard.Text = "Pengembalian";
            // 
            // Finished
            // 
            this.Finished.BackColor = System.Drawing.Color.Red;
            this.Finished.Location = new System.Drawing.Point(457, 19);
            this.Finished.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Finished.Name = "Finished";
            this.Finished.Size = new System.Drawing.Size(141, 118);
            this.Finished.TabIndex = 2;
            this.Finished.Text = "Fiished";
            this.Finished.UseVisualStyleBackColor = false;
            this.Finished.Click += new System.EventHandler(this.Finished_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.label_kendaraan);
            this.groupBox1.Controls.Add(this.label_nama_Customer);
            this.groupBox1.Controls.Add(this.label_id_customer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Finished);
            this.groupBox1.Location = new System.Drawing.Point(35, 349);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(606, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_kendaraan
            // 
            this.label_kendaraan.AutoSize = true;
            this.label_kendaraan.Location = new System.Drawing.Point(152, 109);
            this.label_kendaraan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_kendaraan.Name = "label_kendaraan";
            this.label_kendaraan.Size = new System.Drawing.Size(14, 20);
            this.label_kendaraan.TabIndex = 8;
            this.label_kendaraan.Text = "-";
            // 
            // label_nama_Customer
            // 
            this.label_nama_Customer.AutoSize = true;
            this.label_nama_Customer.Location = new System.Drawing.Point(152, 68);
            this.label_nama_Customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nama_Customer.Name = "label_nama_Customer";
            this.label_nama_Customer.Size = new System.Drawing.Size(14, 20);
            this.label_nama_Customer.TabIndex = 7;
            this.label_nama_Customer.Text = "-";
            // 
            // label_id_customer
            // 
            this.label_id_customer.AutoSize = true;
            this.label_id_customer.Location = new System.Drawing.Point(152, 31);
            this.label_id_customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id_customer.Name = "label_id_customer";
            this.label_id_customer.Size = new System.Drawing.Size(14, 20);
            this.label_id_customer.TabIndex = 6;
            this.label_id_customer.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "id mobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // DataTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1058, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Dashboard);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataTransaksi";
            this.Text = "DataTransaksi";
            this.Load += new System.EventHandler(this.DataTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBL_Dashboard;
        private System.Windows.Forms.Button Finished;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_kendaraan;
        private System.Windows.Forms.Label label_nama_Customer;
        private System.Windows.Forms.Label label_id_customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
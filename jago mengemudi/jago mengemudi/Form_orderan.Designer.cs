
namespace jago_mengemudi
{
    partial class Form_orderan
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
            this.dataGrid_order = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.label_nama_guru = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_id_transaksi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_id_murid = new System.Windows.Forms.Label();
            this.label_nama_murid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_order)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_order
            // 
            this.dataGrid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_order.Location = new System.Drawing.Point(0, 1);
            this.dataGrid_order.Name = "dataGrid_order";
            this.dataGrid_order.RowHeadersWidth = 62;
            this.dataGrid_order.RowTemplate.Height = 28;
            this.dataGrid_order.Size = new System.Drawing.Size(802, 322);
            this.dataGrid_order.TabIndex = 0;
            this.dataGrid_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_order_CellContentClick);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(849, 271);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(94, 33);
            this.button_refresh.TabIndex = 1;
            this.button_refresh.Text = "refrash";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_finish
            // 
            this.button_finish.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_finish.ForeColor = System.Drawing.Color.White;
            this.button_finish.Location = new System.Drawing.Point(1017, 271);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(94, 37);
            this.button_finish.TabIndex = 2;
            this.button_finish.Text = "finished";
            this.button_finish.UseVisualStyleBackColor = false;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // label_nama_guru
            // 
            this.label_nama_guru.AutoSize = true;
            this.label_nama_guru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama_guru.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_nama_guru.Location = new System.Drawing.Point(823, 219);
            this.label_nama_guru.Name = "label_nama_guru";
            this.label_nama_guru.Size = new System.Drawing.Size(24, 20);
            this.label_nama_guru.TabIndex = 3;
            this.label_nama_guru.Text = "...";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_1.Location = new System.Drawing.Point(814, 59);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(118, 20);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "id transaksi    = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(814, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "nama student =";
            // 
            // label_id_transaksi
            // 
            this.label_id_transaksi.AutoSize = true;
            this.label_id_transaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_transaksi.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_id_transaksi.Location = new System.Drawing.Point(938, 59);
            this.label_id_transaksi.Name = "label_id_transaksi";
            this.label_id_transaksi.Size = new System.Drawing.Size(24, 20);
            this.label_id_transaksi.TabIndex = 6;
            this.label_id_transaksi.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(814, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "id student       =";
            // 
            // label_id_murid
            // 
            this.label_id_murid.AutoSize = true;
            this.label_id_murid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id_murid.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_id_murid.Location = new System.Drawing.Point(940, 96);
            this.label_id_murid.Name = "label_id_murid";
            this.label_id_murid.Size = new System.Drawing.Size(24, 20);
            this.label_id_murid.TabIndex = 8;
            this.label_id_murid.Text = "...";
            // 
            // label_nama_murid
            // 
            this.label_nama_murid.AutoSize = true;
            this.label_nama_murid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama_murid.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_nama_murid.Location = new System.Drawing.Point(940, 134);
            this.label_nama_murid.Name = "label_nama_murid";
            this.label_nama_murid.Size = new System.Drawing.Size(24, 20);
            this.label_nama_murid.TabIndex = 9;
            this.label_nama_murid.Text = "...";
            // 
            // Form_orderan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1123, 320);
            this.Controls.Add(this.label_nama_murid);
            this.Controls.Add(this.label_id_murid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_id_transaksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.label_nama_guru);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGrid_order);
            this.Name = "Form_orderan";
            this.Text = "Form_orderan";
            this.Load += new System.EventHandler(this.Form_orderan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_order;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_finish;
        public System.Windows.Forms.Label label_nama_guru;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_id_transaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_id_murid;
        private System.Windows.Forms.Label label_nama_murid;
    }
}
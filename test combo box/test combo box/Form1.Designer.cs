
namespace test_combo_box
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeric_tambah = new System.Windows.Forms.NumericUpDown();
            this.box_pilihan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_tambah)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(114, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 34);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "makanan = Rp.5000";
            // 
            // numeric_tambah
            // 
            this.numeric_tambah.Location = new System.Drawing.Point(114, 90);
            this.numeric_tambah.Name = "numeric_tambah";
            this.numeric_tambah.Size = new System.Drawing.Size(105, 31);
            this.numeric_tambah.TabIndex = 1;
            // 
            // box_pilihan
            // 
            this.box_pilihan.FormattingEnabled = true;
            this.box_pilihan.Location = new System.Drawing.Point(240, 88);
            this.box_pilihan.Name = "box_pilihan";
            this.box_pilihan.Size = new System.Drawing.Size(276, 33);
            this.box_pilihan.TabIndex = 2;
            this.box_pilihan.SelectedIndexChanged += new System.EventHandler(this.box_pilihan_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(87, 469);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(300, 150);
            this.total.TabIndex = 4;
            this.total.TabStop = false;
            this.total.Text = "groupBox2";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(240, 170);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(276, 33);
            this.comboBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 674);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_pilihan);
            this.Controls.Add(this.numeric_tambah);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_tambah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numeric_tambah;
        private System.Windows.Forms.ComboBox box_pilihan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox total;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}


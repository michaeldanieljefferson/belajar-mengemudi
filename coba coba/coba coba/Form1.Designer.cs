
namespace coba_coba
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
            this.box_kuning = new System.Windows.Forms.NumericUpDown();
            this.cekbox_kuning = new System.Windows.Forms.CheckBox();
            this.box_merah = new System.Windows.Forms.NumericUpDown();
            this.cekbox_merah = new System.Windows.Forms.CheckBox();
            this.total = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_kuning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_merah)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.box_merah);
            this.groupBox1.Controls.Add(this.cekbox_merah);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(75, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "besar";
            // 
            // box_kuning
            // 
            this.box_kuning.Location = new System.Drawing.Point(18, 71);
            this.box_kuning.Name = "box_kuning";
            this.box_kuning.Size = new System.Drawing.Size(99, 31);
            this.box_kuning.TabIndex = 1;
            // 
            // cekbox_kuning
            // 
            this.cekbox_kuning.AutoSize = true;
            this.cekbox_kuning.BackColor = System.Drawing.Color.Yellow;
            this.cekbox_kuning.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cekbox_kuning.Location = new System.Drawing.Point(18, 30);
            this.cekbox_kuning.Name = "cekbox_kuning";
            this.cekbox_kuning.Size = new System.Drawing.Size(104, 27);
            this.cekbox_kuning.TabIndex = 2;
            this.cekbox_kuning.Text = "kuning";
            this.cekbox_kuning.UseVisualStyleBackColor = false;
            // 
            // box_merah
            // 
            this.box_merah.Location = new System.Drawing.Point(19, 71);
            this.box_merah.Name = "box_merah";
            this.box_merah.Size = new System.Drawing.Size(85, 30);
            this.box_merah.TabIndex = 1;
            // 
            // cekbox_merah
            // 
            this.cekbox_merah.AutoSize = true;
            this.cekbox_merah.Location = new System.Drawing.Point(19, 29);
            this.cekbox_merah.Name = "cekbox_merah";
            this.cekbox_merah.Size = new System.Drawing.Size(98, 27);
            this.cekbox_merah.TabIndex = 1;
            this.cekbox_merah.Text = "merah";
            this.cekbox_merah.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.Black;
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(59, 384);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(300, 44);
            this.total.TabIndex = 3;
            this.total.TabStop = false;
            this.total.Text = "groupBox3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Yellow;
            this.groupBox2.Controls.Add(this.box_kuning);
            this.groupBox2.Controls.Add(this.cekbox_kuning);
            this.groupBox2.Location = new System.Drawing.Point(325, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_kuning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_merah)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown box_merah;
        private System.Windows.Forms.CheckBox cekbox_merah;
        private System.Windows.Forms.NumericUpDown box_kuning;
        private System.Windows.Forms.CheckBox cekbox_kuning;
        private System.Windows.Forms.GroupBox total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


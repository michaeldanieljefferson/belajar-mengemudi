
namespace mid_vispro1
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
            this.comboBox_pilih_kue = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_pilih_toping = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_pilih_bungkusan = new System.Windows.Forms.ComboBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 31);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pilih kue :";
            // 
            // comboBox_pilih_kue
            // 
            this.comboBox_pilih_kue.FormattingEnabled = true;
            this.comboBox_pilih_kue.Location = new System.Drawing.Point(12, 127);
            this.comboBox_pilih_kue.Name = "comboBox_pilih_kue";
            this.comboBox_pilih_kue.Size = new System.Drawing.Size(338, 33);
            this.comboBox_pilih_kue.TabIndex = 1;
            this.comboBox_pilih_kue.SelectedIndexChanged += new System.EventHandler(this.comboBox_pilih_kue_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 36);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "pilih toping:";
            // 
            // comboBox_pilih_toping
            // 
            this.comboBox_pilih_toping.FormattingEnabled = true;
            this.comboBox_pilih_toping.Location = new System.Drawing.Point(12, 237);
            this.comboBox_pilih_toping.Name = "comboBox_pilih_toping";
            this.comboBox_pilih_toping.Size = new System.Drawing.Size(338, 33);
            this.comboBox_pilih_toping.TabIndex = 3;
            this.comboBox_pilih_toping.SelectedIndexChanged += new System.EventHandler(this.comboBox_pilih_toping_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 34);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "pilih bungkusan :";
            // 
            // comboBox_pilih_bungkusan
            // 
            this.comboBox_pilih_bungkusan.FormattingEnabled = true;
            this.comboBox_pilih_bungkusan.Location = new System.Drawing.Point(12, 348);
            this.comboBox_pilih_bungkusan.Name = "comboBox_pilih_bungkusan";
            this.comboBox_pilih_bungkusan.Size = new System.Drawing.Size(338, 33);
            this.comboBox_pilih_bungkusan.TabIndex = 5;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(318, 454);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(112, 34);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mid_vispro1.Properties.Resources.backgraund_form2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 669);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.comboBox_pilih_bungkusan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBox_pilih_toping);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox_pilih_kue);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_pilih_kue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_pilih_toping;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_pilih_bungkusan;
        private System.Windows.Forms.Button button_submit;
    }
}


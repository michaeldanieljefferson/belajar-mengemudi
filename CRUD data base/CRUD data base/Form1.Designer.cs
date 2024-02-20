
namespace CRUD_data_base
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
            this.button_sign_in = new System.Windows.Forms.Button();
            this.groupBox_judul = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button_sign_in
            // 
            this.button_sign_in.BackColor = System.Drawing.Color.Black;
            this.button_sign_in.ForeColor = System.Drawing.Color.White;
            this.button_sign_in.Location = new System.Drawing.Point(48, 31);
            this.button_sign_in.Name = "button_sign_in";
            this.button_sign_in.Size = new System.Drawing.Size(103, 33);
            this.button_sign_in.TabIndex = 0;
            this.button_sign_in.Text = "sign in";
            this.button_sign_in.UseVisualStyleBackColor = false;
            this.button_sign_in.Click += new System.EventHandler(this.button_sign_in_Click);
            // 
            // groupBox_judul
            // 
            this.groupBox_judul.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_judul.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_judul.ForeColor = System.Drawing.Color.White;
            this.groupBox_judul.Location = new System.Drawing.Point(413, 206);
            this.groupBox_judul.Name = "groupBox_judul";
            this.groupBox_judul.Size = new System.Drawing.Size(423, 51);
            this.groupBox_judul.TabIndex = 1;
            this.groupBox_judul.TabStop = false;
            this.groupBox_judul.Text = "welcome to data base view";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUD_data_base.Properties.Resources.internet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 685);
            this.Controls.Add(this.groupBox_judul);
            this.Controls.Add(this.button_sign_in);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_sign_in;
        private System.Windows.Forms.GroupBox groupBox_judul;
    }
}


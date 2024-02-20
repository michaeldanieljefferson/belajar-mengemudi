
namespace CRUD_data_base
{
    partial class Form_database
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
            this.button_connect = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_all = new System.Windows.Forms.DataGridView();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_connect.ForeColor = System.Drawing.Color.White;
            this.button_connect.Location = new System.Drawing.Point(75, 125);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(497, 29);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(71, 263);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "name :";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.ForeColor = System.Drawing.Color.White;
            this.label_id.Location = new System.Drawing.Point(71, 203);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(34, 20);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "ID :";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.ForeColor = System.Drawing.Color.White;
            this.label_phone.Location = new System.Drawing.Point(71, 327);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(62, 20);
            this.label_phone.TabIndex = 3;
            this.label_phone.Text = "phone :";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(139, 197);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(58, 26);
            this.textBox_ID.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(139, 260);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(293, 26);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(139, 324);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(293, 26);
            this.textBox_phone.TabIndex = 6;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Maroon;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(75, 540);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(497, 38);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(75, 470);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(497, 38);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_insert
            // 
            this.button_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_insert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_insert.ForeColor = System.Drawing.Color.White;
            this.button_insert.Location = new System.Drawing.Point(75, 404);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(497, 38);
            this.button_insert.TabIndex = 10;
            this.button_insert.Text = "insert";
            this.button_insert.UseVisualStyleBackColor = false;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data base grid view";
            // 
            // dataGridView_all
            // 
            this.dataGridView_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_all.Location = new System.Drawing.Point(730, 197);
            this.dataGridView_all.Name = "dataGridView_all";
            this.dataGridView_all.RowHeadersWidth = 62;
            this.dataGridView_all.RowTemplate.Height = 28;
            this.dataGridView_all.Size = new System.Drawing.Size(586, 435);
            this.dataGridView_all.TabIndex = 12;
            this.dataGridView_all.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_all_CellContentClick);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(730, 125);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(99, 51);
            this.button_refresh.TabIndex = 13;
            this.button_refresh.Text = "refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(878, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // Form_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1341, 721);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.dataGridView_all);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_connect);
            this.Name = "Form_database";
            this.Text = "Form_database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_all;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox1;
    }
}
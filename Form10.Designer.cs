namespace Assignment_SDAM
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.Burrowgrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Burrowgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Borrow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 99);
            this.button2.TabIndex = 20;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b1
            // 
            this.b1.BackgroundImage = global::Assignment_SDAM.Properties.Resources.Ageofai_1_11zon;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.Location = new System.Drawing.Point(367, 34);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(126, 178);
            this.b1.TabIndex = 21;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.BackgroundImage = global::Assignment_SDAM.Properties.Resources.AIBASICS_3_11zon;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.Location = new System.Drawing.Point(505, 34);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(126, 178);
            this.b2.TabIndex = 22;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button3_Click);
            // 
            // b3
            // 
            this.b3.BackgroundImage = global::Assignment_SDAM.Properties.Resources.clean_1_11zon;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.Location = new System.Drawing.Point(649, 34);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(126, 178);
            this.b3.TabIndex = 23;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.BackgroundImage = global::Assignment_SDAM.Properties.Resources.inv;
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.Location = new System.Drawing.Point(367, 247);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(126, 178);
            this.b4.TabIndex = 24;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // b5
            // 
            this.b5.BackgroundImage = global::Assignment_SDAM.Properties.Resources.cleancode_2_11zon;
            this.b5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b5.ForeColor = System.Drawing.Color.Red;
            this.b5.Location = new System.Drawing.Point(508, 248);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(126, 178);
            this.b5.TabIndex = 25;
            this.b5.Text = "Out of Stock";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.BackgroundImage = global::Assignment_SDAM.Properties.Resources.emyth;
            this.b6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b6.Location = new System.Drawing.Point(649, 248);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(126, 178);
            this.b6.TabIndex = 26;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // Burrowgrid
            // 
            this.Burrowgrid.BackgroundColor = System.Drawing.Color.Lime;
            this.Burrowgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Burrowgrid.Location = new System.Drawing.Point(12, 75);
            this.Burrowgrid.Name = "Burrowgrid";
            this.Burrowgrid.RowHeadersWidth = 51;
            this.Burrowgrid.RowTemplate.Height = 29;
            this.Burrowgrid.Size = new System.Drawing.Size(337, 194);
            this.Burrowgrid.TabIndex = 27;
            this.Burrowgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Burrowgrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(82, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Borrow";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 27);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(82, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 39);
            this.button3.TabIndex = 30;
            this.button3.Text = "Reset table";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_SDAM.Properties.Resources.final;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Burrowgrid);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyscoTech";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Burrowgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.DataGridView Burrowgrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}
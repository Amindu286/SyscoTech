namespace Assignment_SDAM
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BurrowD = new System.Windows.Forms.DateTimePicker();
            this.ReturnD = new System.Windows.Forms.DateTimePicker();
            this.ReturnC = new System.Windows.Forms.ComboBox();
            this.btnfin = new System.Windows.Forms.Button();
            this.btndec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IDreturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Return";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Borrow Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Return Date";
            // 
            // BurrowD
            // 
            this.BurrowD.Location = new System.Drawing.Point(283, 229);
            this.BurrowD.Name = "BurrowD";
            this.BurrowD.Size = new System.Drawing.Size(299, 27);
            this.BurrowD.TabIndex = 14;
            // 
            // ReturnD
            // 
            this.ReturnD.Location = new System.Drawing.Point(283, 283);
            this.ReturnD.Name = "ReturnD";
            this.ReturnD.Size = new System.Drawing.Size(299, 27);
            this.ReturnD.TabIndex = 15;
            this.ReturnD.ValueChanged += new System.EventHandler(this.ReturnD_ValueChanged);
            // 
            // ReturnC
            // 
            this.ReturnC.FormattingEnabled = true;
            this.ReturnC.Items.AddRange(new object[] {
            "Age of AI",
            "Artificial Intelligence",
            "Clean Architecture",
            "The intelligent investor",
            "Clean code",
            "The E myth"});
            this.ReturnC.Location = new System.Drawing.Point(283, 173);
            this.ReturnC.Name = "ReturnC";
            this.ReturnC.Size = new System.Drawing.Size(299, 28);
            this.ReturnC.TabIndex = 16;
            // 
            // btnfin
            // 
            this.btnfin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfin.Location = new System.Drawing.Point(533, 356);
            this.btnfin.Name = "btnfin";
            this.btnfin.Size = new System.Drawing.Size(139, 47);
            this.btnfin.TabIndex = 17;
            this.btnfin.Text = "Confirm";
            this.btnfin.UseVisualStyleBackColor = true;
            this.btnfin.Click += new System.EventHandler(this.btnfin_Click);
            // 
            // btndec
            // 
            this.btndec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndec.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndec.Location = new System.Drawing.Point(114, 356);
            this.btndec.Name = "btndec";
            this.btndec.Size = new System.Drawing.Size(139, 47);
            this.btndec.TabIndex = 18;
            this.btndec.Text = "Decline";
            this.btndec.UseVisualStyleBackColor = true;
            this.btndec.Click += new System.EventHandler(this.btndec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Book ID";
            // 
            // IDreturn
            // 
            this.IDreturn.Location = new System.Drawing.Point(283, 124);
            this.IDreturn.Name = "IDreturn";
            this.IDreturn.Size = new System.Drawing.Size(299, 27);
            this.IDreturn.TabIndex = 20;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_SDAM.Properties.Resources.final;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDreturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndec);
            this.Controls.Add(this.btnfin);
            this.Controls.Add(this.ReturnC);
            this.Controls.Add(this.ReturnD);
            this.Controls.Add(this.BurrowD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyscoTech";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker BurrowD;
        private System.Windows.Forms.DateTimePicker ReturnD;
        private System.Windows.Forms.ComboBox ReturnC;
        private System.Windows.Forms.Button btnfin;
        private System.Windows.Forms.Button btndec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDreturn;
    }
}
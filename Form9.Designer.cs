namespace Assignment_SDAM
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.label1 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.purchaseback = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Resetagain = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Purchase";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.BackColor = System.Drawing.Color.Transparent;
            this.isbn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isbn.ForeColor = System.Drawing.Color.White;
            this.isbn.Location = new System.Drawing.Point(-105, 196);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(86, 25);
            this.isbn.TabIndex = 10;
            this.isbn.Text = "ISBN no.";
            this.isbn.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(94, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(633, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "Purchase";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // purchaseback
            // 
            this.purchaseback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.purchaseback.Location = new System.Drawing.Point(94, 401);
            this.purchaseback.Name = "purchaseback";
            this.purchaseback.Size = new System.Drawing.Size(633, 37);
            this.purchaseback.TabIndex = 19;
            this.purchaseback.Text = "Back to topics";
            this.purchaseback.UseVisualStyleBackColor = true;
            this.purchaseback.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(167, 73);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(431, 212);
            this.dataGrid.TabIndex = 20;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Resetagain
            // 
            this.Resetagain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Resetagain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resetagain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Resetagain.Location = new System.Drawing.Point(94, 355);
            this.Resetagain.Name = "Resetagain";
            this.Resetagain.Size = new System.Drawing.Size(633, 37);
            this.Resetagain.TabIndex = 21;
            this.Resetagain.Text = "Reset";
            this.Resetagain.UseVisualStyleBackColor = false;
            this.Resetagain.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(584, 254);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 20);
            this.total.TabIndex = 22;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_SDAM.Properties.Resources.final;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Resetagain);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.purchaseback);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyscoTech";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button purchaseback;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button Resetagain;
        private System.Windows.Forms.Label total;
    }
}
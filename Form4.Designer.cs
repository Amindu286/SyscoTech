namespace Assignment_SDAM
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBurrow = new System.Windows.Forms.Button();
            this.btnHostory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.memshop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the SyscoTech ";
            // 
            // btnBurrow
            // 
            this.btnBurrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBurrow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBurrow.Location = new System.Drawing.Point(257, 230);
            this.btnBurrow.Name = "btnBurrow";
            this.btnBurrow.Size = new System.Drawing.Size(243, 81);
            this.btnBurrow.TabIndex = 2;
            this.btnBurrow.Text = "Borrow Books";
            this.btnBurrow.UseVisualStyleBackColor = true;
            this.btnBurrow.Click += new System.EventHandler(this.btnBurrow_Click);
            // 
            // btnHostory
            // 
            this.btnHostory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHostory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHostory.Location = new System.Drawing.Point(257, 328);
            this.btnHostory.Name = "btnHostory";
            this.btnHostory.Size = new System.Drawing.Size(243, 84);
            this.btnHostory.TabIndex = 3;
            this.btnHostory.Text = "Return books";
            this.btnHostory.UseVisualStyleBackColor = true;
            this.btnHostory.Click += new System.EventHandler(this.btnHostory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(22, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // memshop
            // 
            this.memshop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memshop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memshop.Location = new System.Drawing.Point(257, 131);
            this.memshop.Name = "memshop";
            this.memshop.Size = new System.Drawing.Size(243, 81);
            this.memshop.TabIndex = 5;
            this.memshop.Text = "Enter to the Shop";
            this.memshop.UseVisualStyleBackColor = true;
            this.memshop.Click += new System.EventHandler(this.memshop_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_SDAM.Properties.Resources.final;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memshop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHostory);
            this.Controls.Add(this.btnBurrow);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyscoTech";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBurrow;
        private System.Windows.Forms.Button btnHostory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button memshop;
    }
}
namespace Assignment_SDAM
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.memberresets = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.membermoreoptions = new System.Windows.Forms.Button();
            this.memberbought = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // memberresets
            // 
            this.memberresets.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.memberresets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberresets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberresets.Location = new System.Drawing.Point(113, 350);
            this.memberresets.Name = "memberresets";
            this.memberresets.Size = new System.Drawing.Size(633, 37);
            this.memberresets.TabIndex = 26;
            this.memberresets.Text = "Reset";
            this.memberresets.UseVisualStyleBackColor = false;
            this.memberresets.Click += new System.EventHandler(this.memberresets_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(205, 57);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(431, 212);
            this.dataGrid.TabIndex = 25;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // membermoreoptions
            // 
            this.membermoreoptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membermoreoptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.membermoreoptions.Location = new System.Drawing.Point(113, 396);
            this.membermoreoptions.Name = "membermoreoptions";
            this.membermoreoptions.Size = new System.Drawing.Size(633, 37);
            this.membermoreoptions.TabIndex = 24;
            this.membermoreoptions.Text = "Back to topics";
            this.membermoreoptions.UseVisualStyleBackColor = true;
            this.membermoreoptions.Click += new System.EventHandler(this.purchaseback_Click);
            // 
            // memberbought
            // 
            this.memberbought.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberbought.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.memberbought.Location = new System.Drawing.Point(113, 305);
            this.memberbought.Name = "memberbought";
            this.memberbought.Size = new System.Drawing.Size(633, 37);
            this.memberbought.TabIndex = 23;
            this.memberbought.Text = "Purchase";
            this.memberbought.UseVisualStyleBackColor = true;
            this.memberbought.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Purchase";
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_SDAM.Properties.Resources.final;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberresets);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.membermoreoptions);
            this.Controls.Add(this.memberbought);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyscoTech";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memberresets;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button membermoreoptions;
        private System.Windows.Forms.Button memberbought;
        private System.Windows.Forms.Label label1;
    }
}
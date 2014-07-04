namespace BlockSize_Reporter
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Total_Files = new System.Windows.Forms.Label();
            this.Mean_Size = new System.Windows.Forms.Label();
            this.Median_Size = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Best_Block_Size = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mean Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Median Size";
            // 
            // Total_Files
            // 
            this.Total_Files.AutoSize = true;
            this.Total_Files.Location = new System.Drawing.Point(95, 59);
            this.Total_Files.Name = "Total_Files";
            this.Total_Files.Size = new System.Drawing.Size(0, 13);
            this.Total_Files.TabIndex = 6;
            // 
            // Mean_Size
            // 
            this.Mean_Size.AutoSize = true;
            this.Mean_Size.Location = new System.Drawing.Point(95, 72);
            this.Mean_Size.Name = "Mean_Size";
            this.Mean_Size.Size = new System.Drawing.Size(0, 13);
            this.Mean_Size.TabIndex = 7;
            // 
            // Median_Size
            // 
            this.Median_Size.AutoSize = true;
            this.Median_Size.Location = new System.Drawing.Point(95, 85);
            this.Median_Size.Name = "Median_Size";
            this.Median_Size.Size = new System.Drawing.Size(0, 13);
            this.Median_Size.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Best Block Size";
            // 
            // Best_Block_Size
            // 
            this.Best_Block_Size.AutoSize = true;
            this.Best_Block_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Best_Block_Size.Location = new System.Drawing.Point(19, 152);
            this.Best_Block_Size.Name = "Best_Block_Size";
            this.Best_Block_Size.Size = new System.Drawing.Size(0, 31);
            this.Best_Block_Size.TabIndex = 10;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 98);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 218);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Best_Block_Size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Median_Size);
            this.Controls.Add(this.Mean_Size);
            this.Controls.Add(this.Total_Files);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total_Files;
        private System.Windows.Forms.Label Mean_Size;
        private System.Windows.Forms.Label Median_Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Best_Block_Size;
        private System.Windows.Forms.Label Status;
    }
}


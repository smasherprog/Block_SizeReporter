using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockSize_Reporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label1.Text)) MessageBox.Show("You must select a folder to alanyze!");
            else
            {
                var rep = new BlockSize.Reporter(label1.Text);
                rep.Best_Block_File_Size = (a) =>
                {
                    Best_Block_Size.Text = a;
                    Best_Block_Size.Update();
                };
                rep.Mean_File_Size = (a) =>
                {
                    Mean_Size.Text = a;
                    Mean_Size.Update();
                };
                rep.Median_File_Size = (a) =>
                {
                    Median_Size.Text = a;
                    Median_Size.Update();
                };
                rep.Total_Files = (a) =>
                {
                    Total_Files.Text = a;
                    Total_Files.Update();
                };
                rep.Update_Status = (a) =>
                {
                    Status.Text = a;
                    Status.Update();
                };
                rep.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

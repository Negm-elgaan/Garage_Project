using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamWriter sw;
        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6 form6 = new Form6();

            form6.Show();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            kryptonTextBox1.Text = kryptonTextBox2.Text = kryptonTextBox3.Text = kryptonTextBox4.Text = kryptonTextBox5.Text = null;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            fs=new FileStream("Add_Custmor.txt",FileMode.Append,FileAccess.Write);
            sw=new StreamWriter(fs);
            sw.WriteLine(kryptonTextBox4.Text + "|" + kryptonTextBox1.Text + "|" + kryptonTextBox2.Text + "|" + kryptonTextBox3.Text + "|" + kryptonTextBox5.Text);
            sw.Flush();
            MessageBox.Show("Done");
        }
    }
}

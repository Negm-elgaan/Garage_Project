using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
            fs = new FileStream("employee.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(kryptonTextBox2.Text + "|" + kryptonTextBox1.Text );
            sw.Flush();
            MessageBox.Show("Done");
            Form4 form4 = new Form4();  
            form4.Show();
            this.Hide();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
                this.Hide();

                Form7 form7 = new Form7();

                form7.Show();
            
        }
    }
}

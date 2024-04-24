using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace WindowsFormsApp2
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string ID = Logintext.Text;

            if (ID == "267" || ID == "133" || ID == "493" || ID == "107" || ID == "222")
            {


               this.Hide();

                Form4 form4 = new Form4();
               
                form4.Show();

                
            }
            else
            {
                MessageBox.Show("ID isn't true");
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();

            form2.Show();
        }
    }
}

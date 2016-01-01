using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 四则运算
{
    public partial class ResultForm : Form
    {
        public ResultForm(int correct, int total,float correctrate)
        {
            InitializeComponent();
            textBox1.Text = ""+total ;
            textBox2.Text = ""+ correct;
            textBox3.Text = "" + correctrate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

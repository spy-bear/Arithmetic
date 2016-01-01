using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 四则运算
{
    public partial class introduceForm : Form
    {
        public introduceForm()
        {
            InitializeComponent();
            string []rules = { "1.用户选择要回答的运算方式 包括 加、减、乘、除\n",
                               "2.程序将会随机给出0-10的数字，用户将结果填入结\n",
                                 "果框中并提交。\n" ,
                               "3.用户的回答时间为60秒\n" ,
                               "4.回答结束后系统将自动给出用户的答题结果\n"  };
            foreach (string str in rules)
            {
                textBox1.AppendText(str);
                textBox1.AppendText("\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 mainform = new Form1();    // 启动新窗口，关闭提示窗口
            mainform.ShowDialog();  
            Application.Exit();

        }
    }
}

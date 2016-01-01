using System;
using System.Windows.Forms;
using System.Threading;

namespace 四则运算
{
    public partial class Form1 : Form
    {
        Data data;
        Thread timecontrolThread;
        Thread WatchTimeChange;
        Boolean threadControl;
        public Form1()
        {
            InitializeComponent();
             data = new Data();
    }

        private void startBtn_Click(object sender, EventArgs e)
        {
             timecontrolThread = new Thread(new ThreadStart(TimeControl));
            timecontrolThread.Start();
            timecontrolThread.IsBackground = true;
            WatchTimeChange = new Thread(new ThreadStart(watchTime));
            WatchTimeChange.Start();
            WatchTimeChange.IsBackground = true;


            // 设置输入运算的参数
            setTextboxnumbers();
            startBtn.Enabled = false;
            pauseBtn.Enabled = true;
            
        }
        private void TimeControl()
        {
            int i = 60;
            int sleeptime = 1000;
            threadControl = true;
            try
            {
                while (threadControl)
                {
                    if (i == 0)
                        threadControl = false;
                    timeControlText.Text = "" + i;
                    i--;
                    Thread.Sleep(sleeptime);

                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            operatorlabel.Text = "+";

        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            operatorlabel.Text = "-";
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            operatorlabel.Text = "*";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            operatorlabel.Text = "/";
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (pauseBtn.Text == "PAUSE")
            {
                pauseBtn.Text = "CONTINUE";
                timecontrolThread.Suspend();
                Data.showResult(data.CorrectCount, data.Count, data.calculateCorrectRate);
            }
            else if (pauseBtn.Text == "CONTINUE")
            {
                pauseBtn.Text = "PAUSE";
                timecontrolThread.Resume();
            }

        }
        private void  watchTime()
        {
            Boolean timerunout = true;
            while (timerunout)
            {
                if (timeControlText.Text == "0")
                {
                    ResultForm resultform = new ResultForm(data.CorrectCount, data.Count, data.calculateCorrectRate);
                    resultform.ShowDialog();
                    textBox3.Enabled = false;
                    break;
                }
                else continue;
            }
        }

        // 当用户输入一个数据 系统立即对结果进行处理，并立刻产生一组新的数据
        private void TextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar  != '.')
            {
                e.Handled = true;

                if (e.KeyChar == 13)
                {
                    data.OperatorType = operatorlabel.Text;   // 获取运算符
                    data.Num1 = Convert.ToInt32(textBox1.Text);  // 读取第一个操作数
                    data.Num2 = Convert.ToInt32(textBox2.Text);  // 读取第二个操作数
                    data.Count++;
                    double result = 0;    // 使用除法时数据是 浮点型
                    switch (operatorlabel.Text)
                    {
                        case "+":
                            result = Data.addnumbers(data.Num1, data.Num2);
                            break;
                        case "-":
                            result = Data.subnumbers(data.Num1, data.Num2);
                            break;
                        case "*":
                            result = Data.mulnumbers(data.Num1, data.Num2);
                            break;
                        case "/":
                            result = Data.divnumbers(data.Num1, data.Num2);
                            break;
                    }
                    if (operatorlabel.Text == "/")
                    {
                        if (result == Convert.ToDouble(textBox3.Text))
                        {
                            data.CorrectCount++;
                        }
                        else data.ErrorCount++;
                    }
                    else
                    {
                        if ((int)result == Convert.ToInt32(textBox3.Text))
                        {
                            data.CorrectCount++;
                        }
                        else data.ErrorCount++;

                    }
                    textBox3.Text = "";
                    setTextboxnumbers();
                }
            }
        }
        public void setTextboxnumbers()
        {
            int[] number = Control.randomNumber();
            if (operatorlabel.Text == "/" && number[1] == 0)
            {
                Random random = new Random();
                number[1] = random.Next(1, 10);
            }

            textBox1.Text = "" + number[0];
            textBox2.Text = "" + number[1];
        }
    }
}

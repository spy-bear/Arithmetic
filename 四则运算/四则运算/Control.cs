using System.Windows.Forms;
using System.Threading;
using System;

namespace 四则运算
{
    public static class Control
    {
        public static int[] randomNumber()
        {
            int[] numbers = new int[2];
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
               
                numbers[i] =  random.Next(10);
            }
            return numbers;
        }
    }
}

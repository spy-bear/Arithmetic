using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算
{
    class Data
    {
        private int num1;
        private int num2;
        private string operatorType;
        private float result;
        private int count;
        private int correctCount;
        private int errorCount;
        private float correctRate;
        private float errorRate;

        public float calculateCorrectRate {
            get { return (float)CorrectCount / Count; }
        }
        public float calculateErrorRate {
            get { return (float)ErrorCount / Count; }
        }

        public int Num1
        {
            get
            {
                return num1;
            }

            set
            {
                num1 = value;
            }
        }

        public int Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        public string OperatorType
        {
            get
            {
                return operatorType;
            }

            set
            {
                operatorType = value;
            }
        }

        public float Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int CorrectCount
        {
            get
            {
                return correctCount;
            }

            set
            {
                correctCount = value;
            }
        }

        public int ErrorCount
        {
            get
            {
                return errorCount;
            }

            set
            {
                errorCount = value;
            }
        }
        public static int addnumbers(int n, int m)
        {
            return n + m;
        }
        public static int subnumbers(int n, int m)
        {
            return n - m;
        }
        public static int mulnumbers(int n, int m)
        {
            return n * m;
        }
        public static double divnumbers(int n, int m)
        {
            return (float)n / m;
        }
        public static void showResult(int correct,int total,float correctrate)
        {
            ResultForm resultform = new ResultForm(correct,total,correctrate);
            resultform.Show();

        }
    }
    
}

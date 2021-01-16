using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStep226
{
    public class MyMathClass
    {
        public int myNum = 100;
        
        public int AdditionMethod(int intInput)
        {
            int addAnswer = myNum + intInput;
            return addAnswer;
        }

        public int AdditionMethod(decimal decInput)
        {
            decimal addAnswer = myNum + decInput;
            return Convert.ToInt32(addAnswer);
        }

        public int AdditionMethod(string strInput)
        {
            int addAnswer = myNum + Convert.ToInt32(strInput);
            return addAnswer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
   public class Math
    {
        public int problem(int DivNum_A)
        {
            int DivNum_B = 14;
            int answer = DivNum_A / DivNum_B;
            return answer;
        }
        public decimal problem(decimal RemNum_A)
        {
            decimal RemNum_B = 3.75m;
            decimal answer2 = Convert.ToInt32(RemNum_A % RemNum_B);
            return answer2;
        }
        public int problem(string Conversion)
        {
            int ConNum_A = 4;
            int ConNum_B = Convert.ToInt32(Conversion);
            int answer3 = ConNum_A - ConNum_B;
            return answer3;
        }
    }
}

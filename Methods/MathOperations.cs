using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
        public class MathClass 
        {
            public int Add (int MathNum_A, int MathNum_B)
            {
                int result = MathNum_A + MathNum_B;
                return result;
            }
            public int Sub(int MathNum_A, int MathNum_B)
            {
                int result = MathNum_A - MathNum_B;
                return result;
            }
            public int Rem(int MathNum_A, int MathNum_B)
            {
                int result = MathNum_A % MathNum_B;
                return result;
            }
        }
    }

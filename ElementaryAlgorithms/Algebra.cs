using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryAlgorithms
{
    public class Algebra : IAlgebra
    {
        
        public int Phi(int n)
        {
            int result = n;
            for(int i = 2; i * i <= n; ++i)
            {
                if(n % i == 0)
                {
                    while(n % i == 0)
                    {
                        n /= i;
                    }
                    result -= result / i;
                }
            }

            if(n > 1)
            {
                result -= result / n;
            }

            return result;
        }
               
        public int BinPow(int a, int n)
        {
            if(n == 0)
            {
                return 1;
            }

            if(n % 2 == 0)
            {

                var b = BinPow(a, n / 2);
                return b * b;
            }
            else
            {
                return BinPow(a, n - 1) * a;
            }
        }

        public int GCD(int a, int b)
        {
            return b != 0 ? GCD(b, a % b) : a;
        }
        
        public int LCN(int a, int b)
        {
            return a * b / GCD(a, b);
        }
    }
}

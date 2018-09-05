using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryAlgorithms
{
    public class Algebra : IAlgebra
    {
        /// <summary>
        /// Функция Эйлера phi (n) — это количество чисел от 1 до n, 
        /// взаимно простых с n.
        /// Сложность O(sqrt(n))
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Количество таких чисел в отрезке [1; n], наибольший общий делитель которых с n равен единице</returns>
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
        /// <summary>
        /// Бинарное (двоичное) возведение в степень — это приём, 
        /// позволяющий возводить любое число в n-ую степень 
        /// за O(log n) умножений (вместо n умножений при обычном подходе).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
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
    }
}

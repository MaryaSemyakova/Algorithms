namespace ElementaryAlgorithms
{
    public interface IAlgebra
    {
        /// <summary>
        /// Функция Эйлера phi (n) — это количество чисел от 1 до n, 
        /// взаимно простых с n.
        /// Сложность O(sqrt(n))
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Количество таких чисел в отрезке [1; n], наибольший общий делитель которых с n равен единице</returns>
        int Phi(int n);

        /// <summary>
        /// Бинарное (двоичное) возведение в степень — это приём, 
        /// позволяющий возводить любое число в n-ую степень 
        /// за O(log n) умножений (вместо n умножений при обычном подходе).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        int BinPow(int a, int n);

        /// <summary>
        /// Алгоритм Евклида нахождения НОД (наибольшего общего делителя)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int GCD(int a, int b);

        /// <summary>
        /// НОК (Наименьшее общее кратное)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int LCN(int a, int b);
    }
}
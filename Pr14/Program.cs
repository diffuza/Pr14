using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void QSort(int[] M, int LG, int PG)
        {
            int i = LG, j = PG, T;
            double X = M[((LG + PG) / 2)];
            while (i <= j)
            {
                while (M[i] < X) i += 1;
                while (M[j] > X) j -= 1;
                if (i <= j)
                {
                    T = M[i]; M[i] = M[j]; M[j] = T;
                    i += 1; j -= 1;
                }
            }
            if (LG < j) QSort(M, LG, j);
            if (i < PG) QSort(M, i, PG);
        }

        static void Main(string[] args)
        {
            const int k = 9;
            int[] M = new int[k];
            Random rand = new Random();
            for (int i = 0; i < k; i++) { M[i] = rand.Next(-9, 9); }
            Console.WriteLine("Вывод исходного массива");
            for (int i = 0; i < M.Length; i++) { Console.Write(M[i] + " "); }
            Console.WriteLine();

            QSort(M, 0, M.Length - 1);

            Console.WriteLine("\n\nВывод отсортированного массива");
            for (int i = 0; i < M.Length; i++) { Console.Write(M[i] + " "); }
        }
    }
}

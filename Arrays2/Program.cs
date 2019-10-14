using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double[] mas = new double[100];
            Console.WriteLine("Введите количество элементов: ");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n) && N[0] != '-')
            {
                Console.WriteLine("Ошибка ввода количества элементов!");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите  {i + 1} элемент массива:");
                mas[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Произведение чисел после минимального: {AfterMin(mas, n, PosicionMin(mas, n))}");
            Console.WriteLine($"Cумма элементов после первого отрицательного и второго положительного: {SumFirstNeg(mas, n)}");
            Console.WriteLine($"Cумма элементов после первого нуля и последнего: {SumZero(mas, n)}");
            Console.WriteLine($"Произведение чисел между мах и мин по по модулю: {MaxMinAbs(mas, n)}");
        }
        static int PosicionMin(double[] mas, int size)
        {
            int posicion = 0;
            double min = mas[0];
            for (int i = 1; i < size; i++)
            {
                if (mas[i] < min)
                {
                    min = mas[i];
                    posicion = i;
                }
            }
            return posicion ;
        }
        static double AfterMin(double[] mas, int size,int posmin)
        {
            double dob = 1;
            for (int i = posmin; i < size; i++)
            {
                dob *= mas[i];
            }
            return dob;
        }
        static double SumFirstNeg(double[] mas, int size)
        {
            double sum = 0, firstneg = 0, firstpos = 0;
            int countneg = 0, countpos=0;
            for (int i = 0; i < size; i++)
            {
                if (mas[i] < 0)
                {
                    countneg++;
                    if(countneg==1) firstneg = mas[i];
                }
                if (mas[i] > 0)
                {
                    countpos++;
                    if (countpos == 2) firstpos = mas[i];
                }
                if (countpos > 2 && countneg > 1) break;
                sum += mas[i];
            }
            return sum - firstneg - firstpos;
        }
        static double SumZero(double[] mas, int size)
        {
            double sum = 0;
            int firstzero = 0, lastzero = 0, count=0;
            for (int i = 0; i < size; i++)
            {
                if (mas[i] == 0)
                {
                    if (count == 0) firstzero = i;
                    count++;
                    lastzero = i;
                }
            }
            for(int i = firstzero; i < lastzero; i++)
            {
                sum += mas[i];
            }
            return sum ;
        }
        static double MaxMinAbs(double[] mas, int size)
        {
            double dob = 1, max = mas[0], min = mas[0];
            double[] mas2 = new double[100];
            int maxposicion = 0, minposicion=0,left;
            for (int i = 1; i < size; i++)
            {
                mas2[i] = mas[i];
                if (Math.Abs(mas[i]) > max)
                {
                    max = mas2[i];
                    maxposicion = i;
                }
                if (Math.Abs(mas[i]) < min)
                {
                    min = mas2[i];
                    minposicion = i;
                }
            }
            if (minposicion > maxposicion)
            {
                left = minposicion;
                minposicion = maxposicion;
                maxposicion = left;
            }
            for(int i = minposicion+1; i < maxposicion; i++)
            {
                dob *= mas[i];
            }
            return dob;

        }
    }
}

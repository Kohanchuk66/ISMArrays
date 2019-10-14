using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double [] mas = new double[100];
            Console.WriteLine("Введите количество элементов: ");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n)&&N[0]!='-')
            {
                Console.WriteLine("Ошибка ввода количества элементов!");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите  {i+1} элемент массива:");
                mas[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Сумма отрицательных чисел: {SumNegative(mas, n)}");
            Console.WriteLine($"Mаксимальний элемент массива: {Max(mas, n)}");
            Console.WriteLine($"Hомер максимального элемента массива(для обычных людей): {PosicionMax(mas, n)}");
            Console.WriteLine($"Максимальний за модулем элемент массива: {AbsMax(mas, n)}");
            Console.WriteLine($"Сумма индексов положительных элементов: {SumPosicionPositive(mas, n)}");
            Console.WriteLine($"Количество целих чисел: {SumInt(mas, n)}");
        }
         static double SumNegative(double [] mas,int size)
        {
            double sum = 0;
            for(int i = 0; i < size; i++)
            {
                if (mas[i] < 0) sum+= mas[i];
            }
            return sum;
        }
        static double Max(double[] mas, int size)
        {
            double max = mas[0];
            for (int i = 1; i < size; i++)
            {
                if (mas[i] > max) max=mas[i];
            }
            return max;
        }
        static int PosicionMax(double[] mas, int size)
        {
            int posicion = 0;
            double max = mas[0];
            for (int i = 1; i < size; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    posicion = i;
                }
            }
            return posicion+1;
        }
        static double AbsMax(double[] mas, int size)
        {
            double max = Math.Abs(mas[0]);
            double[] mas2=new double[100];
            for (int i = 1; i < size; i++)
            {
                mas2[i] = mas[i];
                if (Math.Abs(mas[i]) > max) max = mas2[i];
            }
            return max;
        }
        static double SumPosicionPositive(double[] mas, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                if (mas[i] >= 0 ) sum += i+1;
            }
            return sum;
        }
        static double SumInt(double[] mas, int size)
        {
            int sumint = 0;
            for (int i = 0; i < size; i++)
            {
                if (mas[i]*10 == (int)mas[i]*10) sumint += 1;
            }
            return sumint;
        }
    }
}

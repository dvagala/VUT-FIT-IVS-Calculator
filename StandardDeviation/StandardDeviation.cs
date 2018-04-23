using MathLibrary;
using System;

namespace StandardDeviation
{
    class StandardDeviation
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = rand.Next(1, 5000);
            }

            //double[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);            
            Console.WriteLine(StandDev(numbers));
            //Console.ReadLine();
        }
        static double Average(double[] numbers)
        {
            var sut = new Matho();
            double Average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Average = sut.Add(numbers[i],Average);
            }
            return sut.Div(Average,numbers.Length);
        }

        static double StandDev(double[] numbers)
        {
            var sut = new Matho();
            double StandDev = 0;
            int N = numbers.Length;
            double Avg = Average(numbers);
            for (int i=0;i<N;i++)
            {
                StandDev = sut.Add(sut.Pow(sut.Sub(numbers[i], Avg),2),StandDev);
            }
            StandDev = sut.Div(StandDev, (sut.Sub(N, 1)));
            return sut.SquareRoot(StandDev);
        }
    }
}

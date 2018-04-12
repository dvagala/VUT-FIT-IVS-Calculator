using System;

namespace MathLibrary
{

    public class matho
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Sub(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Mul(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Div(double a, double b)
        {
            double result = a / b;
            return result;
        }

        public double Mod(double a, double b)
        {
            double result = a % b;
            return result;
        }

        public int Fakt(double a)
        {
            if (a < 0) { return -1; };//if the number is negative it returns -1 (fail)
            if (Mod(a, 1) != 0) { return -1; };// if the number is decimal, returns -1
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        public double Root(double a, int moc)
        {
            double result = a;
            for (int i = 1; i < moc; i++)
            {
                result *= a;
            }
            return result;
        }

        public double SquareRoot(double num)
        {
            if (num < 0) { return -1; }; // if the number is negative, returns -1 ( fail)
            if (num == 0) { return 0; };
            double x1 = (num * 1.0) / 2;
            double x2 = (x1 + (num / x1)) / 2;
            while (Abs(x1 - x2) >= 0.0000001)
            {
                x1 = x2;
                x2 = (x1 + (num / x1)) / 2;
            }
            return x2;
        }

        public double Abs(double v)
        {
            if (v < 0)
            {
                v = v * (-1);
            }
            return v;
        }
    }
}

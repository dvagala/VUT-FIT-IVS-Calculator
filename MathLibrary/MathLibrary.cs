using System;

namespace MathLibrary
{

    public class matho
    {
        public double add(double a,double b)
        {
            double result = a + b;
            return result;
        }

        public double sub(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double mul(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double div(double a, double b)
        {
            double result = a / b;
            return result;
        }

        public double mod(double a, double b)
        {
            double result = a % b;
            return result;
        }

        public int fakt(double a)
        {
            if (a < 0) { return -1; };//ked je cislo zaporne tak vrati -1 (fail hodnotu)
            if (mod(a, 1) != 0) { return -1; };// ked je cislo desatinne tak vrati -1
            int result=1;
            for (int i=1; i <= a ;i++)
            {
                result *= i;
            }
            return result;
        }

        public double root(double a, int b)
        {
            double result = a;
            for (int i=1;i<b;i++)
            {
                result *= a;
            }
            return result;
        }

        public double square_root(double num)
        {
            if (num < 0) { return -1; }; // pokial je cislo zaporne, tak vrati -1 ( fail)
            if (num == 0) { return 0; };
            double x1 = (num * 1.0) / 2;
            double x2 = (x1 + (num / x1)) / 2;
            while ( Abs(x1 - x2) >= 0.0000001)
            { 
                x1 = x2;
                x2 = (x1 + (num / x1)) / 2;
            }
            return x2;
        }

        public double Abs(double v)
        {
            if (v<0)
            {
                v = v * (-1);
            }
            return v;
        }
    }
}

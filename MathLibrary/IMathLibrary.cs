using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    interface IMathLibrary
    {
        //returns sum of a and b
        double Add(double a, double b);

        // returns division of a and b
        double Sub(double a, double b);

        //returns a multiplied by b
        double Mul(double a, double b);

        //returns a divided by b
        double Div(double a, double b);

        //returns a modulo b
        double Mod(double a, double b);

        //returns factorial of number a
        int Fakt(double a);

        //returns a to the b power
        double Root(double a, int b);

        //returns SquareRoot of num
        double SquareRoot(double num);

        //returns absolute value of number v
        double Abs(double v);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    interface IMathLibrary
    {
        double Add(double a, double b);

        double Sub(double a, double b);

        double Mul(double a, double b);

        double Div(double a, double b);

        double Mod(double a, double b);

        int Fakt(double a);

        double Root(double a, int b);

        double square_root(double num);

        double Abs(double v);
    }
}

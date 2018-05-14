/*******************************************************************
* Názov projektu: Calculator
* Súbor: MathLibrary.cs
* 
* Tým: LastAttic
* Členovia: Arbet Matúš     <xarbet00>
*           Lončík Andrej   <xlonci00>
*           Vagala Dominik  <xvagal00>
*           Vinš Jakub      <xvinsj00>
*           
* Popis: Trieda matematickej knižnice
*******************************************************************/

/**
 * @file MathLibrary.cs 
 * 
 * @brief Trieda matematickej knižnice
 * @author Vinš Jakub
 */

using System;

namespace MathLibrary
{

    public class Matho
    {

        /**
         * Sčítanie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok sčítania ( a + b )
         */
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        /**
         * Odčítanie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok odčítania ( a - b )
         */
        public double Sub(double a, double b)
        {
            double result = a - b;
            return result;
        }

        /**
         * Násobenie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok násobenia ( a * b )
         */
        public double Mul(double a, double b)
        {
            double result = a * b;
            return result;
        }

        /**
         * Delenie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok delenia ( a / b )
         */
        public double Div(double a, double b)
        {
            if(b == 0.0)
            {
                throw new DivideByZeroException();
            }                

            double result = a / b;
            return result;
        }

        /**
         * Modulo
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double zvyšok po celočíselnom delení ( a % b )
         */
        public double Mod(double a, double b)
        {
            double result = a % b;
            return result;
        }

        /**
         * Faktoriál čísla
         * 
         * @param a operand
         * @return int výsledok faktoriálu ( a! )
         */
        public double Fakt(double a)
        {
            if (a < 0 || Mod(a, 1) != 0)    // ak je a záporné, alebo s desatinnou čiarkou -> throw execption
            {
                throw new ArgumentOutOfRangeException();
            }

            if (a > 170)      // Ak je číslo > 170, tak faktoriál určite pretečie cez typ double, vyhneme sa zbytočnému zaťaženiu/pádu programu
            {
                return double.PositiveInfinity;
            }

            double result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        /**
         * Mocnina
         * 
         * @param a základ mocniny
         * @param moc exponent
         * @return double výsledok mocnenia ( a^moc )
         */
        public double Pow(double a, double moc)
        {
            if (moc < 0 || Mod(moc, 1) != 0)    // ak je moc záporné, alebo s desatinnou čiarkou -> throw execption
            {
                throw new ArgumentOutOfRangeException();
            }
            double result = a;
            for (int i = 1; i < moc; i++)
            {
                result *= a;
            }
            return result;
        }

        /**
         * Druhá odmocnina
         * 
         * @param num odmocňované číslo
         * @return double výsledok odmocnenia ( num^(1/2) )
         */
        public double SquareRoot(double num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
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

        /**
         * Tretia odmocnina
         * 
         * @param num odmocňované číslo
         * @return double výsledok odmocnenia ( num^(1/2) )
         */
        public double ThirdRoot(double num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (num == 0) { return 0; };

            double x = 1;
            double y = 1;

            for(int i=0; i<500; i++)
            {
                x = y * (num + x) / (x + y);
                y = x / y;
            }

            return y;
        }

        /**
         * Absolútna hodnota
         * 
         * @param v operand
         * @return double absolútna hodnota operandu ( |v| )
         */
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
/*** Koniec súboru MathLibrary.cs  ***/

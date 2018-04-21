/*******************************************************************
* Názov projektu: Calculator
* Súbor: IMathLibrary.cs
* 
* Tým: LastAttic
* Členovia: Arbet Matúš     <xarbet00>
*           Lončík Andrej   <xlonci00>
*           Vagala Dominik  <xvagal00>
*           Vinš Jakub      <xvinsj00>
*           
* Popis: Rozhranie matematickej knižnice
*******************************************************************/

/**
 * @file IMathLibrary.cs 
 * 
 * @brief Rozhranie matematickej knižnice
 * @author Vinš Jakub
 */

namespace MathLibrary
{
    interface IMathLibrary
    {
        // returns sum of a and b ( a + b)
        double Add(double a, double b);

        // returns division of a and b ( a - b)
        double Sub(double a, double b);

        // returns a multiplied by b ( a * b)
        double Mul(double a, double b);

        // returns a divided by b ( a / b )
        double Div(double a, double b);

        // returns a modulo b ( a % b )
        double Mod(double a, double b);

        // returns factorial of number a ( a! )
        int Fakt(double a);

        // returns a to the b power ( a^moc ) 
        double Pow(double a, int b);

        // returns SquareRoot of num ( num^(1/2) )
        double SquareRoot(double num);

        // returns absolute value of number v ( |v| )
        double Abs(double v);
    }
}
/*** Koniec súboru IMathLibrary.cs  ***/

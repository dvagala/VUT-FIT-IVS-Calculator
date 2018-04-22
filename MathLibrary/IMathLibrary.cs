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
        /**
         * Sčítanie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok sčítania ( a + b )
         */
        double Add(double a, double b);

        /**
         * Odčítanie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok odčítania ( a - b )
         */
        double Sub(double a, double b);

        /**
         * Násobenie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok násobenia ( a * b )
         */
        double Mul(double a, double b);

        /**
         * Delenie
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double výsledok delenia ( a / b )
         */
        double Div(double a, double b);

        /**
         * Modulo
         * 
         * @param a prvý operand
         * @param b druhý operand
         * @return double zvyšok po celočíselnom delení ( a % b )
         */
        double Mod(double a, double b);

        /**
         * Faktoriál čísla
         * 
         * @param a operand
         * @return int výsledok faktoriálu ( a! ), respektíve -1 ak je operand záporný alebo nie je celočíselný
         */
        int Fakt(double a);

        /**
         * Mocnina
         * 
         * @param a základ mocniny
         * @param moc exponent
         * @return double výsledok mocnenia ( a^moc )
         */
        double Pow(double a, int b);

        /**
         * Druhá odmocnina
         * 
         * @param num odmocňované číslo
         * @return double výsledok odmocnenia ( num^(1/2) ), respektíve -1 ak je operand záporný
         */
        double SquareRoot(double num);

        /**
         * Absolútna hodnota
         * 
         * @param v operand
         * @return double absolútna hodnota operandu ( |v| )
         */
        double Abs(double v);
    }
}
/*** Koniec súboru IMathLibrary.cs  ***/

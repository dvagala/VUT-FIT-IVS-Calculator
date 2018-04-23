/*******************************************************************
* Názov projektu: Calculator
* Súbor: Math_handle.cs
* 
* Tým: LastAttic
* Členovia: Arbet Matúš     <xarbet00>
*           Lončík Andrej   <xlonci00>
*           Vagala Dominik  <xvagal00>
*           Vinš Jakub      <xvinsj00>
*           
* Popis: Trieda spracúvajúca chod programu, interakciu GUI s výpočtami skrz matematickú knižnicu
*******************************************************************/

using MathLibrary;
/**
 * @file Math_handle.cs 
 * 
 * @brief Trieda spracúvajúca chod programu, interakciu GUI s výpočtami skrz matematickú knižnicu
 * @author Vagala Dominik
 */

using System;

namespace Calculator
{

    class Math_handle
    {
        // definícia existujúcich operácií
        private enum sign
        {
            add,
            sub,
            mul,
            div,
            mod,
            fac,
            pow_2,
            pow_y,
            sqr,
            none
        }

        // aktuálna operácia
        private sign actual_sign;

        // ak je výsledok vypísaný na displeji
        public bool result_state = false;
        private double result = 0;

        private Output_handle output_handle;
        private Matho matho;

        /**
         * Konštruktor triedy
         */
        public Math_handle(Output_handle ouput_handle)
        {
            this.output_handle = ouput_handle;
            matho = new Matho();

            actual_sign = sign.none;
        }

        /**
         * Funkcia spracuvajúca sčítanie
         */
        public void add_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" + ");
            actual_sign = sign.add;
        }

        /**
         * Funkcia spracuvajúca odčítanie
         */
        public void sub_proceed()
        {
            // Ak je display prázdny, znak mínus patrí ku číslu, neberie sa ako znak pre operáciu odčítať
            if (output_handle.is_display_empty() == true)
                output_handle.print_on_display("-");
            else
            {
                update_result_in_log();
                output_handle.print_log(" - ");
                actual_sign = sign.sub;
            }
        }

        /**
         * Funkcia spracuvajúca násobenie
         */
        public void mul_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" x ");
            actual_sign = sign.mul;
        }

        /**
         * Funkcia spracuvajúca delenie
         */
        public void div_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" / ");
            actual_sign = sign.div;
        }

        /**
         * Funkcia spracuvajúca modulo
         */
        public void mod_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" % ");
            actual_sign = sign.mod;
        }

        /**
         * Funkcia spracuvajúca faktoriál
         */
        public void fac_proceed()
        {
            actual_sign = sign.fac;
            eq_proceed();
        }

        /**
         * Funkcia spracuvajúca druhú odmocninu
         */
        public void sqr_proceed()
        {
            actual_sign = sign.sqr;
            eq_proceed();
        }

        /**
         * Funkcia spracuvajúca druhú mocninu
         */
        public void pow_2_proceed()
        {
            actual_sign = sign.pow_2;
            eq_proceed();
        }

        /**
         * Funkcia spracuvajúca y-tú mocninu
         */
        public void pow_y_proceed()
        {            
            try
            {
                update_result_in_log();     // Ak sa vyskytol error, už sa o neho postaral operation result
                output_handle.print_log(" ^ ");
                actual_sign = sign.pow_y;
            }
            catch { }

        }

        /**
         * Funkcia spracuvajúca výpis výsledku na displej
         */
        public void eq_proceed()
        {
            try
            {
                result = operation_result();
                output_handle.clear_log();
                output_handle.clear_display();
                output_handle.print_on_display(result.ToString());
            }
            catch { }

            result = 0;
            actual_sign = sign.none;
            result_state = true;
        }

        /**
         * Funkcia spracuvajúca vyčistenie displeja
         */
        public void C_proceed()
        {
            result = 0;
            actual_sign = sign.none;
            result_state = false;
            output_handle.clear_display();
            output_handle.clear_log();
        }

        /**
        * Funckia, ktorá aktualizuje reťazec vo vedľajšom displeji
        */
        private void update_result_in_log()
        {
            try
            {
                result = operation_result();
                output_handle.clear_log();
                output_handle.print_log(result.ToString());
                output_handle.clear_display();
            }
            catch
            {
                result = 0;
                actual_sign = sign.none;
                result_state = true;
            }
        }

        /**
         * Funkcia spracuvajúca výsledok operácií kalkulačky
         * 
         * @return double výsledok zadanej operácie, respektíve iba číslo ak nebola zadaná žiadna operácia
         */
        private double operation_result()
        {
            try
            {
                if (actual_sign == sign.add)
                    return matho.Add(result, output_handle.get_num_on_display());
                if (actual_sign == sign.sub)
                    return matho.Sub(result, output_handle.get_num_on_display());
                if (actual_sign == sign.mul)
                    return matho.Mul(result, output_handle.get_num_on_display());
                if (actual_sign == sign.div)
                    return matho.Div(result, output_handle.get_num_on_display());
                if (actual_sign == sign.mod)
                    return matho.Mod(result, output_handle.get_num_on_display());
                if (actual_sign == sign.fac)
                    return matho.Fakt(output_handle.get_num_on_display());
                if (actual_sign == sign.sqr)
                    return matho.SquareRoot(output_handle.get_num_on_display());
                if (actual_sign == sign.pow_2)
                    return matho.Pow(output_handle.get_num_on_display(), 2);
                if (actual_sign == sign.pow_y)
                    return matho.Pow(result, output_handle.get_num_on_display());

                return output_handle.get_num_on_display();
            }

            catch (ArgumentOutOfRangeException)
            {
                output_handle.clear_log();
                output_handle.clear_display();
                if (actual_sign == sign.fac)
                {                    
                    output_handle.print_on_display("Factorial cannot be decimal or < 1!");
                }
                if (actual_sign == sign.pow_y)
                {
                    output_handle.print_on_display("Exponent cannot be decimal or < 1!");
                }
                if (actual_sign == sign.sqr)
                {
                    output_handle.print_on_display("Square root of x cannot b < 0!");
                }
                throw;
            }

            catch (DivideByZeroException)
            {
                output_handle.clear_log();
                output_handle.clear_display();
                output_handle.print_on_display("Cannot divide by zero!");
                throw;
            }
        }
    }
}
/*** Koniec súboru Math_handle.cs  ***/

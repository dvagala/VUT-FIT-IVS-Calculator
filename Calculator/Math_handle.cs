using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MathLibrary;

namespace Calculator
{
    class Math_handle
    {
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

        private sign actual_sign;

        // if there is result on display
        public bool result_state = false;

        private double result = 0;

        private Output_handle output_handle;

        private Matho matho;

        public Math_handle(Output_handle ouput_handle)
        {
            this.output_handle = ouput_handle;
            matho = new Matho();

            actual_sign = sign.none;
        }

        public void add_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" + ");
            actual_sign = sign.add;
        }

        public void sub_proceed()
        {
            // if display is empty the minus belongs to number, not intended as aritmetic operator
            if( output_handle.is_display_empty() == true )
                output_handle.print_on_display("-");
            else
            {
                update_result_in_log();
                output_handle.print_log(" - ");
                actual_sign = sign.sub;
            }                
        }

        public void mul_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" x ");
            actual_sign = sign.mul;
        }

        public void div_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" / ");
            actual_sign = sign.div;
        }

        public void mod_proceed()
        {
            update_result_in_log();
            output_handle.print_log(" % ");
            actual_sign = sign.mod;
        }

        public void fac_proceed()
        {
            actual_sign = sign.fac;
            eq_proceed();
        }

        public void sqr_proceed()
        {
            actual_sign = sign.sqr;
            eq_proceed();
        }

        public void pow_2_proceed()
        {
            actual_sign = sign.pow_2;
            eq_proceed();
        }

        public void pow_y_proceed()
        {
            // if exponent is decimal
            if ((output_handle.get_num_on_display() % 1) > 0 && actual_sign == sign.pow_y)
            {
                dec_exp_error();
                result = 0;
                actual_sign = sign.none;
                result_state = true;
                return;
            }

            update_result_in_log();
            output_handle.print_log(" ^ ");
            actual_sign = sign.pow_y;
        }

        // print result on display
        public void eq_proceed()
        {
            // if exponent is decimal
            if ((output_handle.get_num_on_display() % 1) > 0 && actual_sign == sign.pow_y)
            {
                dec_exp_error();
            }
            else
            {
                result = operation_result();
                output_handle.clear_log();
                output_handle.clear_display();
                output_handle.print_on_display(result.ToString());
            }
            
            result = 0;
            actual_sign = sign.none;
            result_state = true;
        }

        public void C_proceed()
        {
            result = 0;
            actual_sign = sign.none;
            result_state = false;
            output_handle.clear_display();
            output_handle.clear_log();
        }
        
        private void update_result_in_log()
        {
            result = operation_result();

            output_handle.clear_log();
            output_handle.print_log(result.ToString());
            output_handle.clear_display();
        }

        // print decimal exponen error
        private void dec_exp_error()
        {
            output_handle.clear_log();
            output_handle.clear_display();
            output_handle.print_on_display("error: exponent is decimal!");
        }

        // return result depending on actual_sign, if actual_sign is none, return what is on display
        private double operation_result()
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
                return matho.Pow(result, (int) output_handle.get_num_on_display());

            return output_handle.get_num_on_display();
        }



    }
}

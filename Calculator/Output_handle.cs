using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator
{
    class Output_handle
    {
        private TextBox display;
        private TextBox log_display;
        private bool dec_in_display = false;

        public Output_handle(TextBox display, TextBox log_display)
        {
            this.display = display;
            this.log_display = log_display;
        }

        public void print_log(string item_to_add)
        {
            this.log_display.Text += item_to_add;
        }

        public void clear_log()
        {
            this.log_display.Clear();
        }

        public void print_on_display(string item_to_add)
        {
            // cant be two decimals in display
            if (item_to_add == ",")
            {
                if (dec_in_display == true)
                    return;

                if (this.display.Text.Length == 0)
                    item_to_add = item_to_add.Insert(0, "0");

                dec_in_display = true;
            }

            this.display.Text += item_to_add;
        }

        public void clear_display()
        {
            dec_in_display = false;
            this.display.Clear();
        }

        public void backspace_display()
        {
            if (display.Text.Length > 0)
            {
                if (display.Text.Substring(display.Text.Length - 1, 1) == "," || display.Text.Length == 1)
                    dec_in_display = false;

                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

        // return number on display
        public double get_num_on_display()
        {
            double display_number;
            if (double.TryParse(this.display.Text, out display_number))
                return display_number;

            return 0;           // if there ist correct number on display return 0
        }

        public bool is_display_empty()
        {
            if (string.IsNullOrEmpty(this.display.Text))
                return true;
            else
                return false;
        }
    }
}

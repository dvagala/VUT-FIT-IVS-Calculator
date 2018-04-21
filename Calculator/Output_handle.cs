/*******************************************************************
* Názov projektu: Calculator
* Súbor: Output_handle.cs
* 
* Tým: LastAttic
* Členovia: Arbet Matúš     <xarbet00>
*           Lončík Andrej   <xlonci00>
*           Vagala Dominik  <xvagal00>
*           Vinš Jakub      <xvinsj00>
*           
* Popis: Trieda zabezpečujúca výstup programu - výpis na displej
*******************************************************************/

/**
 * @file Output_handle.cs 
 * 
 * @brief Trieda zabezpečujúca výstup programu - výpis na displej
 * @author Vagala Dominik
 */

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

        // prítomnosť desatinnej čiarky na hlavnom displeji (môže byť len jedna)
        private bool dec_in_display = false;

        /**
         * Konštruktor triedy
         * 
         * @param display hlavný displej
         * @param log_display vedľajší displej (s predchádzajúcími výpočtami)
         */
        public Output_handle(TextBox display, TextBox log_display)
        {
            this.display = display;
            this.log_display = log_display;
        }

        /**
         * Výpis na vedľajší displej
         * 
         * @param item_to_add reťazec, ktorý sa má vypísať na vedľajší displej
         */
        public void print_log(string item_to_add)
        {
            this.log_display.Text += item_to_add;
        }

        /**
         * Odstráni obsah vedľajšieho displeja
         */
        public void clear_log()
        {
            this.log_display.Clear();
        }

        /**
         * Výpis na hlavný displej
         * 
         * @param item_to_add reťazec, ktorý sa má vypísať na hlavný displej
         */
        public void print_on_display(string item_to_add)
        {
            // zabezpečenie jedinej desatinnej čiarky
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

        /**
         * Odstráni obsah hlavného displeja
         */
        public void clear_display()
        {
            dec_in_display = false;
            this.display.Clear();
        }

        /**
         * Odstráni posledný znak z hlavného displeja
         */
        public void backspace_display()
        {
            if (display.Text.Length > 0)
            {
                if (display.Text.Substring(display.Text.Length - 1, 1) == "," || display.Text.Length == 1)
                    dec_in_display = false;

                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

        /**
         * Funkcia získa číslo z displeja
         * 
         * @return double číslo z displeja, respektíve 0 ak je číslo nie je korektné
         */
        public double get_num_on_display()
        {
            double display_number;
            if (double.TryParse(this.display.Text, out display_number))
                return display_number;

            return 0;// číslo na displeji nie je korektné
        }

        /**
         * Funkcia zisťujúca prázdnosť displeja
         * 
         * @return bool true ak je displej prázdny, false ak nie je displej prázdny
         */
        public bool is_display_empty()
        {
            if (string.IsNullOrEmpty(this.display.Text))
                return true;
            else
                return false;
        }
    }
}
/*** Koniec súboru Output_handle.cs  ***/

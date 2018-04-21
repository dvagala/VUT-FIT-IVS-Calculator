/*******************************************************************
* Názov projektu: Calculator
* Súbor: MainWindow.xaml.cs
* 
* Tým: LastAttic
* Členovia: Arbet Matúš     <xarbet00>
*           Lončík Andrej   <xlonci00>
*           Vagala Dominik  <xvagal00>
*           Vinš Jakub      <xvinsj00>
*           
* Popis: Trieda prepájajúca GUI interakciu s funkčným kódom
*******************************************************************/

/**
 * @file MainWindow.xaml.cs 
 * 
 * @brief Trieda prepájajúca GUI interakciu s funkčným kódom
 * @author Vagala Dominik
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Calculator
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Output_handle output_handle;
        Math_handle math_handle;

        /**
         * Konštruktor triedy
         */
        public MainWindow()
        {
            InitializeComponent();

            output_handle = new Output_handle(this.display, this.log_display);
            math_handle = new Math_handle(output_handle);
        }

        /**
         * Funkcia zachytávajúca akciu pre všetky tlačidlá obsahujúce číslo
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_num_click(object sender, RoutedEventArgs e)
        {
            // ak je vypísaný výsledok, ale užívateľ zadá nový vstup, displej sa musí vyčistiť
            if (math_handle.result_state == true)
                output_handle.clear_display();

            math_handle.result_state = false;

            // výpis čísla na displej podľa stlačeného tlačidla
            Button btn = (Button)sender;
            output_handle.print_on_display(btn.Content.ToString());
        }

        /**
         * Funkcia volajúca výpis výsledku
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_eq_Click(object sender, RoutedEventArgs e)
        {
            math_handle.eq_proceed();
        }

        /**
         * Funkcia volajúca sčítanie
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            math_handle.add_proceed();
        }

        /**
         * Funkcia volajúca odčítanie
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_sub_Click(object sender, RoutedEventArgs e)
        {
            math_handle.sub_proceed();
        }

        /**
         * Funkcia volajúca násobenie
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_mul_Click(object sender, RoutedEventArgs e)
        {
            math_handle.mul_proceed();
        }

        /**
         * Funkcia volajúca delenie
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            math_handle.div_proceed();
        }

        /**
         * Funkcia volajúca vynulovanie displeja
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_C_Click(object sender, RoutedEventArgs e)
        {
            math_handle.C_proceed();
        }

        /**
         * Funkcia volajúca ostránenie poseldného znaku z displeja
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_bck_Click(object sender, RoutedEventArgs e)
        {
            output_handle.backspace_display();
        }

        /**
         * Funkcia volajúca modulo
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_mod_Click(object sender, RoutedEventArgs e)
        {
            math_handle.mod_proceed();
        }

        /**
         * Funkcia volajúca faktoriál
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_fac_Click(object sender, RoutedEventArgs e)
        {
            math_handle.fac_proceed();
        }

        /**
         * Funkcia volajúca druhú odmocninu
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_sqr_Click(object sender, RoutedEventArgs e)
        {
            math_handle.sqr_proceed();
        }

        /**
         * Funkcia volajúca druhú mocninu
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_pow_2_Click(object sender, RoutedEventArgs e)
        {
            math_handle.pow_2_proceed();
        }


        /**
         * Funkcia volajúca y-tú mocninu 
         * @ param sender implementovaná premenná
         * @ param e implementovaná premenná
         */
        private void button_pow_y_Click(object sender, RoutedEventArgs e)
        {
            math_handle.pow_y_proceed();
        }

        /**
         * Funkcia zachytávajúca vstupné znaky z klávesnice
         * @ param sender implementovaná premenná
         * @ param e vstupný znak
         */
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.NumPad0:
                    output_handle.print_on_display("0");
                    break;
                case Key.NumPad1:
                    output_handle.print_on_display("1");
                    break;
                case Key.NumPad2:
                    output_handle.print_on_display("2");
                    break;
                case Key.NumPad3:
                    output_handle.print_on_display("3");
                    break;
                case Key.NumPad4:
                    output_handle.print_on_display("4");
                    break;
                case Key.NumPad5:
                    output_handle.print_on_display("5");
                    break;
                case Key.NumPad6:
                    output_handle.print_on_display("6");
                    break;
                case Key.NumPad7:
                    output_handle.print_on_display("7");
                    break;
                case Key.NumPad8:
                    output_handle.print_on_display("8");
                    break;
                case Key.NumPad9:
                    output_handle.print_on_display("9");
                    break;
                case Key.OemPeriod:
                case Key.OemComma:
                case Key.Decimal:
                    output_handle.print_on_display(",");
                    break;
                case Key.Add:
                    button_plus_Click(null, null);
                    break;
                case Key.Subtract:
                    button_sub_Click(null, null);
                    break;
                case Key.Multiply:
                    button_mul_Click(null, null);
                    break;
                case Key.Divide:
                    button_div_Click(null, null);
                    break;
                case Key.Back:
                    button_bck_Click(null, null);
                    break;
                case Key.Return:
                    button_eq_Click(null, null);
                    break;
                case Key.Delete:
                case Key.Escape:
                    button_C_Click(null, null);
                    break;

                default:
                    break;
            }
        }
    }
}
/*** Koniec súboru MainWindow.xaml.cs  ***/

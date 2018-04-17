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

        public MainWindow()
        {
            InitializeComponent();

            output_handle = new Output_handle(this.display, this.log_display);
            math_handle = new Math_handle(output_handle);                      
        }

        // for all numeric buttons
        private void button_num_click(object sender, RoutedEventArgs e)
        {
            // if the result is on display, and we type a number, clear display
            if (math_handle.result_state == true)
                output_handle.clear_display();

            math_handle.result_state = false;

            // print operator symbol from button on log
            Button btn = (Button)sender;
            output_handle.print_on_display(btn.Content.ToString());
        }

        private void button_eq_Click(object sender, RoutedEventArgs e)
        {
            math_handle.eq_proceed();
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            math_handle.add_proceed();
        }

        private void button_sub_Click(object sender, RoutedEventArgs e)
        {
            math_handle.sub_proceed();
        }

        private void button_mul_Click(object sender, RoutedEventArgs e)
        {
            math_handle.mul_proceed();
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            math_handle.div_proceed();
        }

        private void button_C_Click(object sender, RoutedEventArgs e)
        {
            math_handle.C_proceed();
        }

        private void button_bck_Click(object sender, RoutedEventArgs e)
        {
            output_handle.backspace_display();
        }

        private void button_mod_Click(object sender, RoutedEventArgs e)
        {
            math_handle.mod_proceed();
        }

        private void button_fac_Click(object sender, RoutedEventArgs e)
        {
            math_handle.fac_proceed();
        }

        private void button_sqr_Click(object sender, RoutedEventArgs e)
        {
            math_handle.sqr_proceed();
        }

        private void button_pow_2_Click(object sender, RoutedEventArgs e)
        {
            math_handle.pow_2_proceed();
        }

        private void button_pow_y_Click(object sender, RoutedEventArgs e)
        {
            math_handle.pow_y_proceed();
        }

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

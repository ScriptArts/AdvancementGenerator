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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace NarangeAdvancement.Rewards
{
    /// <summary>
    /// reward.xaml の相互作用ロジック
    /// </summary>
    public partial class reward : Window
    {
        public reward()
        {
            InitializeComponent();
        }

        private void text_input(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !new Regex("[0-9]+").IsMatch(e.Text);
        }

        private void text_execute(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }

        private void recipes_radiobutton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void loot_radiobutton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void experience_radiobutton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void function_radiobutton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cancel_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

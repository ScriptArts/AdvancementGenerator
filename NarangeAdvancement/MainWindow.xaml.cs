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
using OrangeNBT;
using OrangeNBT.NBT;
using OrangeNBT.NBT.IO;

namespace NarangeAdvancement
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void json_button_1_Click(object sender, RoutedEventArgs e)
        {
            JSON_pop.json_window a = new JSON_pop.json_window();
            a.ShowDialog();
        }
    }
}

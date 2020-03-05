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
using System.IO;
using OrangeNBT;
using OrangeNBT.NBT;
using OrangeNBT.NBT.IO;

namespace NarangeAdvancement.JSON_pop
{
    /// <summary>
    /// json_window.xaml の相互作用ロジック
    /// </summary>
    public partial class json_window : Window
    {

        private TagCompound root = new TagCompound();
        

        public json_window()
        {
            InitializeComponent();
            List<TreeView> c = new List<TreeView>();
            TreeView tr = new TreeView();
            TreeView tra = new TreeView();
            tr.Items.Add("A");
            tra.Items.Add("ABC");
            tr.Items.Add(tra);
            c.Add(tr);
            treeview_2.ItemsSource = c;
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void remove_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void done_button_Click(object sender, RoutedEventArgs e)
        {

        }

        public TagCompound Root //外部からのroot呼び出し
        {
            get { return this.root; }
        }

    }
}

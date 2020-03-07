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
        /// <summary>
        /// 生成するコードの最上階
        /// </summary>
        public TagCompound Adv { get; } = new TagCompound();

        public TagCompound L_icon { get; } = new TagCompound("icon");

        public TagList L_title = new TagList();

        public TagList L_description = new TagList();

        public TagCompound L_rewards { get; } = new TagCompound("rewards");

        public TagCompound L_criteria { get; } = new TagCompound("criteria");

        public TagCompound L_requirements { get; } = new TagCompound("requirements");

        //public JSON_pop.json_window title_json = new JSON_pop.json_window();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void json_button_1_Click(object sender, RoutedEventArgs e)
        {
            JSON_pop.json_window title_json = new JSON_pop.json_window();
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke((Action)(() =>
                {
                    title_json.init(L_title);
                    for (int i = 0; i < title_json.Root.Count; i++)
                    {
                        title_json.main_listview.Items.Add(title_json.Root.Value[i]);
                    }
                    title_json.ShowDialog();
                    if (title_json.SafeClose == true)
                    {
                        L_title = title_json.Root;
                        title_textbox.Text = title_json.Detail;
                    }
                }));
            });
            //if (title_json.isNull(title_json.Root) == false) title_textbox.Text = L_title.ToString();
        }

        private async void json_button_2_Click(object sender, RoutedEventArgs e)
        {
            JSON_pop.json_window description_json = new JSON_pop.json_window();
            await Task.Run(() =>
            {
                this.Dispatcher.Invoke((Action)(() =>
                {
                    description_json.init(L_description);
                    for (int i = 0; i < description_json.Root.Count; i++)
                    {
                        description_json.main_listview.Items.Add(description_json.Root.Value[i]);
                    }
                    description_json.ShowDialog();
                    if (description_json.SafeClose == true)
                    {
                        L_description = description_json.Root;
                        description_textbox.Text = description_json.Detail;
                    }
                }));
            });
        }
    }
}

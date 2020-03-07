﻿using System;
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
using System.Text.RegularExpressions;

namespace NarangeAdvancement.JSON_pop
{
    /// <summary>
    /// json_window.xaml の相互作用ロジック
    /// </summary>
    public partial class json_window : Window
    {
        /// <summary>
        /// JSONが全体が格納された最上位ディレクトリ
        /// </summary>
        public TagList Root { get; set; } = new TagList();

        /// <summary>
        /// "text":のValueだけを並べた変数
        /// </summary>
        public string Detail = "";

        Regex RegularExpression = new Regex("\"text\":\"(?<value>.*?)\"[,|}]", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        
        public json_window()
        {
            InitializeComponent();
            Console.WriteLine("a");
            for (int i = 0; i < Root.Count; i++)
            {
                main_listview.Items.Add(Root.Value[i]);
                Console.WriteLine("aaa");
            }
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            TagCompound tag = new TagCompound();
            if (text_textbox.Text.Length != 0 && string.IsNullOrWhiteSpace(text_textbox.Text) != true)
            {
                // "text":""
                string type = string.Format("{0}", type_combobox.Text);
                string text = string.Format("{0}", text_textbox.Text);
                tag.Add(new TagString(type, text));

                if (color_combobox.Text != "unset")
                {
                    string setter = "color";
                    string value = color_combobox.Text;
                    tag.Add(new TagString(setter, value));
                }

                if (bold_combobox.Text != "unset")
                {
                    string setter = "bold";
                    string value = bold_combobox.Text;
                    tag.Add(new TagString(setter, value));
                }

                if (italic_combobox.Text != "unset")
                {
                    string setter = "italic";
                    string value = italic_combobox.Text;
                    tag.Add(new TagString(setter, value));
                }

                if (underline_combobox.Text != "unset")
                {
                    string setter = "underlined";
                    string value = underline_combobox.Text;
                    tag.Add(new TagString(setter, value));
                }

                if (strike_combobox.Text != "unset")
                {
                    string setter = "strikethrough";
                    string value = strike_combobox.Text;
                    tag.Add(new TagString(setter, value));
                }

                if (obfus_combobox.Text != "unset")
                {
                    string setter = "obfuscated";
                    string value = obfus_combobox.Text;
                    tag.Add(new TagString(setter, value));
                }

                main_listview.Items.Add(tag);
            }
        }

        private void remove_button_Click(object sender, RoutedEventArgs e)
        {
            main_listview.Items.Remove(main_listview.SelectedItem);
        }

        private void done_button_Click(object sender, RoutedEventArgs e)
        {
            Root.Clear();
            int len = main_listview.Items.Count;
            for (int i = 0; i < len; i++)
            {
                TagCompound tag = (TagCompound)main_listview.Items[i];
                Root.Add(new TagCompound(tag));

                //結果表示用にテキストだけの文字列だけ抽出(正規表現)
                Match match = RegularExpression.Match(main_listview.Items[i].ToString());
                string match_detail = match.Groups["value"].Value;
                Detail += match_detail;
            }
            Console.WriteLine("生成されたJSON: " + Root);
            Close();
        }

        /// <summary>
        /// 中身がNULLか?
        /// </summary>
        /// <param name="tag">検査するTagList</param>
        /// <returns></returns>
        public bool isNull(TagList tag)
        {
            if (tag.ToString() == "[]") return true;
            return false;
        }

        public void init(TagList tag)
        {
            Root = tag;
            Console.WriteLine("aa");
            return;
        }

    }
}

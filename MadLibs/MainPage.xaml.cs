using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MadLibs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string[] Adjectives = { "pretty", "good", "tasty", "delicious","adorable",
"adventurous","aggressive","alert","attractive","average","beautiful","blue-eyed","bloody","blushing","bright","clean","clear","cloudy","colorful","crowded","cute","dark","drab","distinct","dull","elegant","excited","fancy","filthy" };
        public string[] Nouns = { "ham", "cheeze", "potatoes", "chair", "apple",
"arm","banana","bike","bird","book","chin","clam","class","clover","club","corn","crayon","crow","crown","crowd","crib","desk","dime","dirt","dress","fang","field",
"flag","flower","fog","game","heat","hill","home","horn","hose","joke","juice","kite","lake","maid","mask","mice","milk","mint","meal","meat","moon","mother","morning","name","nest","nose","pear"};
        public string[] Verbs = { "kick", "lick", "pound", "smash","accept",
"ache","acknowledge","act","add","admire","admit","admonish","advise","berate","besiege","bestow","bet","bid","bite","bleach",
"bleed","bless","blind","blink","blot","blow","blurt","blush","boast","feel","fence","fetch","fight","file","fill","film","find","fire" };

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void place_Adjective(object sender, RoutedEventArgs e)
        {
            TextBox_1.Text=TextBox_1.Text+RandomChooser(1)+" ";
            Focus_TextBox_1();
        }

        private void place_Noun(object sender, RoutedEventArgs e)
        {
            TextBox_1.Text=TextBox_1.Text+RandomChooser(2)+" ";
            Focus_TextBox_1();
        }

        private void place_Verb(object sender, RoutedEventArgs e)
        {
            TextBox_1.Text=TextBox_1.Text+RandomChooser(3)+" ";
            Focus_TextBox_1();
        }

        private void Clear_TextBox1(object sender, RoutedEventArgs e)
        {
            TextBox_1.Text = "";
            Focus_TextBox_1();
        }

        private void Focus_TextBox_1()
        {
            TextBox_1.Focus(Windows.UI.Xaml.FocusState.Programmatic);
            TextBox_1.Select(TextBox_1.Text.Length, 0);
        }

        //Old Code
        string RandomChooser(int Selection)
        {
            int number;
            var r = new Random();

            switch (Selection)
            {
                case 1://Adjective
                    number = r.Next(Adjectives.Length);
                    return Adjectives[number];

                case 2://Noun
                    number = r.Next(Nouns.Length);
                    return Nouns[number];
                case 3://Verb
                    number = r.Next(Verbs.Length);
                    return Verbs[number];
                default:
                    return "Never going to happen";
            }
        }

        private void TextBox_1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            
        }

        private void Toggle_Visibility_About(object sender, RoutedEventArgs e)
        {
            if (About_app_textblock.Visibility == Visibility.Visible)
            {
                About_app_textblock.Visibility = Visibility.Collapsed;
                About_app_textblock_title.Visibility = Visibility.Collapsed;
                Toggle_About.Content = "Show";
            }
            else if (About_app_textblock.Visibility == Visibility.Collapsed)
            {
                About_app_textblock.Visibility = Visibility.Visible;
                About_app_textblock_title.Visibility = Visibility.Visible;
                Toggle_About.Content = "Hide";
            }
            Focus_TextBox_1();
        }

        private void copy_text_box_1(object sender, RoutedEventArgs e)
        {
            var dataPackage = new DataPackage();
            if (TextBox_1.Text == "") ;
            else
            {
                dataPackage.SetText(TextBox_1.Text);
                Clipboard.SetContent(dataPackage);
            }
            Focus_TextBox_1();
        }

        private void Save_text_box_1_data(object sender, RoutedEventArgs e)
        {

        }
    }
}


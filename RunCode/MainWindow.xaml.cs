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

namespace RunCode
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> languages = new Dictionary<string, string> {{"C++", "#include <iostream>\n\nint main(int argc, char* argv)\n{\n}\n"}};
        public MainWindow()
        {
            InitializeComponent();
            LanguageList.ItemsSource = languages.Keys;
            LanguageList.SelectedIndex = 0;
        }

        private void LanguageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if (box.SelectedIndex != -1)
            {
                SourceText.Text = languages[box.SelectedValue as string];
            }
        }

    }
}

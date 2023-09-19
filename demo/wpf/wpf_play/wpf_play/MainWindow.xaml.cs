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

namespace wpf_play
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (btn.Text.IndexOf("OK") > 0)
            {
                btn.Background = new SolidColorBrush(Colors.GhostWhite);
                btn.Text = "1+1=?";
                btn.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btn.Text = "1+1=2.OK?";
                btn.Visibility = Visibility.Visible;
            }
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            string msg = sender.ToString();
            Console.WriteLine(msg);
        }
    }
}

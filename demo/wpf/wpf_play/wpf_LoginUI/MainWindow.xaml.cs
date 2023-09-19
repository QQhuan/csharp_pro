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
using wpf_LoginUI.Views;

namespace wpf_LoginUI
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

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string myUsername = username.Text;
            string myPsd = password.Password;
            bool isRe = rememberMe.IsChecked == true; // 是否选中记住密码
            Console.WriteLine(myUsername+myPsd);
            index mainIndex = new index();
            mainIndex.Show();
            Close();
        }
    }
}

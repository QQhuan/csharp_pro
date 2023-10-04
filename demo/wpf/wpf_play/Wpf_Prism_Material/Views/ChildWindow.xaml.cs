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

namespace Wpf_Prism_Material.Views
{
    /// <summary>
    /// ChildWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ChildWindow : Window
    {
        public string str { get; set; }

        public delegate void SendMsg(string msg);

        public SendMsg Msg { get; set; }
        public ChildWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb_receive.Text = str;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Msg("我进来了哟");
        }
    }
}

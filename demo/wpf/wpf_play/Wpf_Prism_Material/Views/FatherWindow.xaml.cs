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
    /// FatherWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FatherWindow : Window
    {
        public FatherWindow()
        {
            InitializeComponent();
        }

        public void print_msg(string msg)
        {
            rec.Text = msg;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow cw = new ChildWindow();
            cw.str = tb_message.Text;
            cw.Msg = print_msg;
            cw.Show();
        }
    }
}

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
using wpf_LoginUI.Views.Pages;

namespace wpf_LoginUI.Views
{
    /// <summary>
    /// index.xaml 的交互逻辑
    /// </summary>
    public partial class index : Window
    {
        public index()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.Pages.BookViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
        }
    }
}

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
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Threading;
using HandyControl.Controls;

namespace wpf_LoginUI.Views
{
    /// <summary>
    /// index.xaml 的交互逻辑
    /// </summary>
    public partial class index : System.Windows.Window
    {
        private DispatcherTimer timer;
        public index()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.Pages.BookViewModel();
            this.WindowState = WindowState.Maximized;

            // 开个线程计时
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            timer.Stop();
            timer = null;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 更新时间
            realTime.SelectedDateTime = DateTime.Now;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudent add = new AddStudent();
            add.Show();
        }


        private void chart_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // 获取新的控件大小
            var newWidth = e.NewSize.Width;
            var newHeight = e.NewSize.Height;

            // 更新图表的大小
            chart.Width = newWidth;
            chart.Height = newHeight;

            // 调用LiveCharts的Update方法，重新加载图表
            chart.Update(true); // 设置为true表示强制重新加载
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.MessageBox.Show("您确定退出吗？");
        }
    }
}

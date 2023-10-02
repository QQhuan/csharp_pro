using MaterialDesignThemes.Wpf;
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
using Wpf_Prism_Material.Views;

namespace Wpf_Prism_Material.Controls
{
    /// <summary>
    /// Picture_control.xaml 的交互逻辑
    /// </summary>
    public partial class Picture_control : UserControl
    {
        public int Mywidth { get; set; }
        public int Myheight { get; set; }

        public Picture_control()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            // 测量控件内容的大小并返回

            double desiredWidth = 0;
            double desiredHeight = 0;

            // 获取控件的内容元素
            UIElement content = Content as UIElement;
            if (content != null)
            {
                // 测量内容的大小
                content.Measure(availableSize);

                // 获取内容的测量大小
                desiredWidth = content.DesiredSize.Width;
                desiredHeight = content.DesiredSize.Height;
            }

            // 应用边界约束
            desiredWidth = Math.Max(desiredWidth, this.MinWidth);
            desiredHeight = Math.Max(desiredHeight, this.MinHeight);
            return new Size(desiredWidth, desiredHeight);
        }

        private void MenuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            bool isC = (bool)MenuToggleButton.IsChecked;
            MenuToggleButton.IsChecked = !isC;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBinding db_window = new DataBinding();
            db_window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListBindingWindow list_window = new ListBindingWindow();
            list_window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ConvertWindow convertWindow = new ConvertWindow();
            convertWindow.Show();
        }
    }
}

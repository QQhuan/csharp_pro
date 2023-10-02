using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// DataBinding.xaml 的交互逻辑
    /// </summary>
    public partial class DataBinding : Window
    {
        User user = new User();
        public DataBinding()
        {
            InitializeComponent();
            user.Name = "qqhuan";
            this.DataContext = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 获得表达式绑定对象
            var bind = windowTitle.GetBindingExpression(TextBox.TextProperty);
            // 手动触发Explicit
            bind.UpdateSource();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.user.Name = "change";
        }
    }

    public class User : INotifyPropertyChanged
    {
        private string _name { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        // 成员事件，必须实现
        public event PropertyChangedEventHandler PropertyChanged; 

        /// <summary>
        /// 源数据发生变化时，向界面推送更新消息
        /// </summary>
        /// <param name="propertyName">更新的属性名</param>
        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

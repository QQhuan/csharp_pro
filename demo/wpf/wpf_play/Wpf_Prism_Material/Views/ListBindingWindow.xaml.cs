using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// ListBindingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ListBindingWindow : Window
    {
        private ObservableCollection<Userinfo> _list = new ObservableCollection<Userinfo>();
        public ListBindingWindow()
        {
            InitializeComponent();
            InitUserList();
            userlist.ItemsSource = _list;
        }

        private void InitUserList()
        {
            _list.Add(new Userinfo { Name="Java"});
            _list.Add(new Userinfo { Name="C++"});
            _list.Add(new Userinfo { Name="Go"});
            _list.Add(new Userinfo { Name="Python"});
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if(userlist.SelectedItem != null)
            {
                (userlist.SelectedItem as Userinfo).Name = "Golang";
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (userlist.SelectedItem != null)
            {
                _list.Remove((userlist.SelectedItem as Userinfo));
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
                _list.Add(new Userinfo { Name = "C#" });
        }
    }

    public class Userinfo : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { 
                _name = value; 
                OnPropertyChanged(nameof(Name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

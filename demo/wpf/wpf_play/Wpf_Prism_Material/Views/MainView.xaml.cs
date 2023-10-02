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
using Wpf_Prism_Material.Controls;

namespace wpf_album.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            this.DataContext = this;
            this.WindowState = WindowState.Maximized; // 窗口自动最大化
            // loadPictures();
        }

        private void loadPictures()
        {
            string[] quotes = new string[]
            {
                "当思想不崩溃，困难并不能幸免！办法比困难更多！",
                "世上无难事，只怕有心人。",
                "困难只是暂时的，不要放弃希望。",
                "机会总是留给那些勇于追求的人。",
                "勇敢面对困难，才能创造奇迹。",
                "障碍不是终点，而是迈向成功的踏板。",
                "失败只是成功之母，坚持会收获更多。",
                "没有人可以阻止你前进，除非你自己停下脚步。",
                "当你感到困难时，你已经走了一段很长的路了。",
                "困难是通向力量的大门，只要敢于迈出一步。",
                "思考解决问题的方法，不要只关注困难本身。",
                "每一个困难都是一个学习的机会。",
                "挑战困难，找到解决问题的不同角度。",
                "勇往直前，困难也将退避。",
                "没有终点的路，只有不断突破的坎坷。",
                "困难是人生的调味品，让人更加坚强。",
                "无论多困难，只要心有所向，定能成功。",
                "越过困难，你才能看到更广阔的天空。",
                "每一次困难都是信心的考验，不要畏惧。",
                "困难是前进路上的挑战，你可以战胜它。",
                "坚持下去，困难终将离你越来越远。"
            };

            String[] imgUrls = new string[]
            {

                "https://w.wallhaven.cc/full/57/wallhaven-57e6m3.jpg",
                "https://w.wallhaven.cc/full/9d/wallhaven-9d88vd.jpg",
                "https://w.wallhaven.cc/full/we/wallhaven-wellg6.jpg",
                "https://w.wallhaven.cc/full/pk/wallhaven-pkw6v9.jpg",
                "https://w.wallhaven.cc/full/0p/wallhaven-0pmjx3.jpg",
                "https://w.wallhaven.cc/full/jx/wallhaven-jxd1x5.jpg",
                "https://w.wallhaven.cc/full/4x/wallhaven-4xmdmd.jpg",
                "https://w.wallhaven.cc/full/wq/wallhaven-wqe6m7.jpg",
                "https://w.wallhaven.cc/full/1p/wallhaven-1p213w.png",
                "https://w.wallhaven.cc/full/4o/wallhaven-4o6735.jpg",
                "https://w.wallhaven.cc/full/9d/wallhaven-9dgz6w.png",
                "https://w.wallhaven.cc/full/x6/wallhaven-x6919l.jpg",
                "https://w.wallhaven.cc/full/1p/wallhaven-1p2j21.jpg",
                "https://w.wallhaven.cc/full/7p/wallhaven-7pl6ey.jpg",
                "https://w.wallhaven.cc/full/1p/wallhaven-1przog.jpg",
                "https://w.wallhaven.cc/full/1p/wallhaven-1p2p3v.jpg",
                "https://w.wallhaven.cc/full/7p/wallhaven-7pl939.png",
                "https://w.wallhaven.cc/full/q2/wallhaven-q21jx7.jpg",
                "https://w.wallhaven.cc/full/j8/wallhaven-j8p735.jpg",
                "https://w.wallhaven.cc/full/zm/wallhaven-zmw8ww.jpg"
            };

            for (int i = 0; i < 20; i++)
            {
                Picture pic = new Picture();
                pic.ImgUri = imgUrls[i];
                pic.Msg = quotes[i];
                myGrid.Children.Add(pic);
            }
        }
    }
}

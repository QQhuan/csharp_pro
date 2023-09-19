using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_LoginUI.Model;

namespace wpf_LoginUI.ViewModels.Pages
{
    public class BookViewModel : ViewModelBase
    {
        private static BookViewModel instance;
        public static BookViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookViewModel();

                }
                return instance;
            }
            private set { instance = value; }
        }

        public BookList GridSource { get; set; }
        public BookViewModel()
        {
            GridSource = new BookList();
            GridSource.GridData.Add(new Book(1, "边城", "一本小说", "沈从文", "邮电出版社", 2000, "https://www.bilibili.com/?spm_id_from=333.1007.0.0"));
            GridSource.GridData.Add(new Book(2, "三体", "科幻小说", "刘慈欣", "重庆出版社", 1500, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(3, "红楼梦", "古典小说", "曹雪芹", "人民文学出版社", 1800, "https://www.bilibili.com/?spm_id_from=333.1007.0.0"));
            GridSource.GridData.Add(new Book(4, "1984", "反乌托邦小说", "乔治·奥威尔", "机械工业出版社", 1200, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(5, "活着", "小说", "余华", "作家出版社", 1000, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(6, "白夜行", "推理小说", "东野圭吾", "南海出版公司", 1400, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(7, "追风筝的人", "小说", "卡勒德·胡赛尼", "上海人民出版社", 1600, "https://www.bilibili.com/?spm_id_from=333.1007.0.0"));
            GridSource.GridData.Add(new Book(8, "局外人", "小说", "阿尔贝·加缪", "北京十月文艺出版社", 1100, "https://www.bilibili.com/?spm_id_from=333.1007.0.0"));
            GridSource.GridData.Add(new Book(9, "围城", "小说", "钱钟书", "人民文学出版社", 1700, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(10, "平凡的世界", "小说", "路遥", "人民文学出版社", 1900, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(11, "人类简史", "历史", "尤瓦尔·赫拉利", "中信出版社", 1300, "https://www.bilibili.com/?spm_id_from=333.1007.0.0"));
            GridSource.GridData.Add(new Book(12, "时间简史", "科普", "斯蒂芬·霍金", "湖南科学技术出版社", 800, "https://www.bilibili.com/?spm_id_from=333.1007.0.0"));
            GridSource.GridData.Add(new Book(13, "明朝那些事儿", "历史", "当年明月", "湖南文艺出版社", 1500, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(14, "解忧杂货店", "小说", "东野圭吾", "南海出版公司", 1400, "https://www.bilibili.com/?spm_id_from=333.1007.0.0")); 
            GridSource.GridData.Add(new Book(15, "百年孤独", "魔幻现实主义小说", "加西亚·马尔克斯", "南海出版公司", 1700, "https://www.bilibili.com/?spm_id_from=333.1007.0.0"));
        }
    }
}

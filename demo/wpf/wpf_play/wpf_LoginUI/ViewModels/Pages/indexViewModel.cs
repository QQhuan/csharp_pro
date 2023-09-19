using HandyControl.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpf_LoginUI.Commands;
using wpf_LoginUI.Model;
using wpf_LoginUI.Utils;

namespace wpf_LoginUI.ViewModels.Pages
{
    public class indexViewModel : ViewModelBase
    {

        // 1.ViewModel 声明为单例模式
        private static indexViewModel instance;

        public static indexViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new indexViewModel();

                }
                return instance;
            }
            private set { instance = value; }
        }
        // 2.为前端View提供绑定的列表枚举数据（属性方式，字段不行必须声明为静态）
        public List<GenderEnum> Genders
        {
            get
            {
                return new List<GenderEnum>() { GenderEnum.Male, GenderEnum.Female };
            }
        }

        // 3.持有Model对象提供数据绑定Model.xxx（需要先new出来，否则为null）
        public Student StudentModel { get; set; } = new Student();

        // 4.自定义Command绑定的处理方式
        public ICommand ConfirmCommand
        {
            get
            {
                return new RelayCommand((parameter) =>
                {
                    MessageBox.Show("StudentId: " + StudentModel.StudentId + "\n" +
                    "StudentName: " + StudentModel.StudentName + "\n" +
                    "StudentAge: " + StudentModel.StudentAge + "\n" +
                    "StudentGender: " + StudentModel.StudentGender.ToString());
                });
            }
        }

        public ICommand ClearCommand
        {
            get
            {
                return new RelayCommand((parameter) =>
                {
                    StudentModel.StudentId = -1;
                    StudentModel.StudentAge = -1;
                    StudentModel.StudentName = "null";
                    StudentModel.StudentGender = GenderEnum.Male;
                });
            }
        }

    }
}

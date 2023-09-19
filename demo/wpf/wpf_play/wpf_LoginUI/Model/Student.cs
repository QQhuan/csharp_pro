using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_LoginUI.Utils;
using wpf_LoginUI.ViewModels;

namespace wpf_LoginUI.Model
{
    public class Student : ViewModelBase
    {
        private int studentId;
        public int StudentId
        {
            get
            {
                return this.studentId;
            }
            set
            {
                if (this.studentId != value)
                {
                    this.studentId = value;
                    RaisePropertyChanged("StudentId");
                }
            }
        }

        private string studentName;
        public string StudentName
        {
            get
            {
                return this.studentName;
            }
            set
            {
                if (this.studentName != value)
                {
                    this.studentName = value;
                    RaisePropertyChanged("StudentName");
                }
            }
        }

        private int studentAge;
        public int StudentAge
        {
            get
            {
                return this.studentAge;
            }
            set
            {
                if (this.studentAge != value)
                {
                    this.studentAge = value;
                    RaisePropertyChanged("StudentAge");
                }
            }
        }

        private GenderEnum studentGender;
        public GenderEnum StudentGender
        {
            get
            {
                return this.studentGender;
            }
            set
            {
                if (this.studentGender != value)
                {
                    this.studentGender = value;
                    RaisePropertyChanged("StudentGender");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_LoginUI.ViewModels;

namespace wpf_LoginUI.Model
{
    public class Book : ViewModelBase
    {
        private int id;
        public int Id { 
            get { return id; }
            set
            {
                if(id != value)
                { 
                    id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("Description");
                }
            }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set
            {
                if (author != value)
                {
                    author = value;
                    RaisePropertyChanged("Author");
                }
            }
        }

        private string institution;
        public string Institution
        {
            get
            {
                return institution;
            }
            set
            {
                if(institution != value)
                {
                    institution = value;
                    RaisePropertyChanged("Institution");
                }
            }
        }

        private int borrow_number;
        public int BorrowNumber
        {
            get
            {
                return borrow_number;
            }
            set
            {
                if(!borrow_number.Equals(value))
                {
                    borrow_number = value;
                    RaisePropertyChanged("Borrow_number");
                }
            }
        }

        private string imagePath;
        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                if(imagePath != value)
                {
                    imagePath = value;
                    RaisePropertyChanged("ImagePath");
                }
            }
        }

        public Book(int id, string name,  string description, string author, string institution, int borrow_number, string img)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            Institution = institution;
            BorrowNumber = borrow_number;
            ImagePath = img;
        }
    }
}

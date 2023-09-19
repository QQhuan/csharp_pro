using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_LoginUI.Model
{
    public class BookList
    {
        private ObservableCollection<Book> _gridData;
        public ObservableCollection<Book> GridData
        {
            get
            {
                return _gridData;
            }
            set
            {
                _gridData = value;
            }
        }
        public BookList()
        {
            GridData = new ObservableCollection<Book>();
        }
    }
}

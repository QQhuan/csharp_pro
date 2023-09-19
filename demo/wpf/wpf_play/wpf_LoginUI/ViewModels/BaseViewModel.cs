using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_LoginUI.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged, INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void RaiseCollectionChanged(ICollection collection)
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(collection, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }

        public void RaiseCollectionAdd(ICollection collection, object item)
        {
            if (CollectionChanged != null)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(collection, new PropertyChangedEventArgs("Count"));
                    PropertyChanged(collection, new PropertyChangedEventArgs("Item[]"));
                }
                CollectionChanged(collection, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                //CollectionChanged(collection, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            }
        }
    }
}

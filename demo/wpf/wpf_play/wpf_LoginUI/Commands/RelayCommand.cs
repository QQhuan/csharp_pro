using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpf_LoginUI.Commands
{
    //2.默认object命令实现：RelayCommand<object>
    public class RelayCommand : RelayCommand<object>
    {
        public RelayCommand(Action<object> action) : base(action)
        {
        }
    }
    //1.自定义ICommand基类：整合泛型，用于在命令内部实现命令逻辑action
    public class RelayCommand<T> : ICommand
    {
        #region Private Members

        /// <summary>
        /// The _action to run
        /// </summary>
        private Action<T> _action;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action<T> action)
        {
            _action = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _action((T)parameter);
        }

        #endregion

        #region Public Events

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LocalCommon.ViewModels
{
    /// <summary>
    /// an ICommand class that allows binding a component with a command method
    /// and a canExecute method
    /// </summary>
    //source: https://intellitect.com/getting-started-model-view-viewmodel-mvvm-pattern-using-windows-presentation-framework-wpf/
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Func<object, bool> _canExecuteFunc;

        public DelegateCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecuteFunc = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="executeAction">action to be executed when command is needed to be done</param>
        /// <param name="canExecuteFunc"></param>
        public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecuteFunc)
        {
            _executeAction = executeAction;
            _canExecuteFunc = canExecuteFunc;
        }

        public void Execute(object parameter) => _executeAction(parameter);

        public bool CanExecute(object parameter) => _canExecuteFunc?.Invoke(parameter) ?? true;

        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// invokes CanExecute
        /// </summary>
        public void InvokeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}

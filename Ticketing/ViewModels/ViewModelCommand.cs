using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ticketing.ViewModels
{
    public class ViewModelCommand : ICommand
    {

        //Delegados
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _CanexecuteAction;

        //Constructores
        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _CanexecuteAction = null;
        }
        public ViewModelCommand(Action<object> executeAction, Predicate<object> canexecuteAction)
        {
            _executeAction = executeAction;
            _CanexecuteAction = canexecuteAction;
        }


        //Eventos
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove {  CommandManager.RequerySuggested -= value; }
        }

        //Metodos
        public bool CanExecute(object parameter)
        {
            return _CanexecuteAction==null?true: _CanexecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}

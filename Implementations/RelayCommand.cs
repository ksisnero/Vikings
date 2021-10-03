using System;
using System.Windows.Input;

namespace Vikings.Implementations
{
    public class RelayCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;
        private bool _canExecuteCache = true;

        public RelayCommand(Predicate<object> canExecute, Action<object> execute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public RelayCommand(Action<object> executeAction)
        {
            _execute = executeAction;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null) return _canExecuteCache;
            var temp = _canExecute(parameter);

            if (_canExecuteCache == temp) return _canExecuteCache;
            _canExecuteCache = temp;

            CanExecuteChanged?.Invoke(this, new EventArgs());
            return _canExecuteCache;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}

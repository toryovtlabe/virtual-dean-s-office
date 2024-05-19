using System.Windows.Input;

namespace CourseProject.Helpers
{
    internal class MyCommand : ICommand
    {
        private Action<object> execute;
        private Func<Object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public MyCommand(Action<Object> execute, Func<Object, bool> canExecuted = null)
        {
            this.execute = execute;
            this.canExecute = canExecuted;
        }
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}

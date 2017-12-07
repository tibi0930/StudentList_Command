using System;
using System.Windows.Input;

namespace StudentList_Command.ViewModel
{
    public class StudentAddCommand : ICommand
    {
        private StudentsViewModel _viewModel;

        public StudentAddCommand(StudentsViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public Boolean CanExecute(Object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.AddNewStudent();
        }
    }
}

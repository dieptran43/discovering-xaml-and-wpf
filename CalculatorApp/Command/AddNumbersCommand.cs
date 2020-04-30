using CalculatorApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CalculatorApp.Command
{
    class AddNumbersCommand : ICommand
    {
        private CalculatorViewModel _viewModel;

        

        public bool CanExecute(object parameter)
        {
            if (parameter == null)
                return false;
            else
            {
                _viewModel = (CalculatorViewModel)parameter;
            }
            return true;
        }

        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            if(parameter == null)
            {
                if (_viewModel == null)
                    throw new ArgumentNullException("parameter");
            }
            else
            {
                _viewModel = (CalculatorViewModel)parameter;
            }
            _viewModel.Sum = _viewModel.FirstNumber + _viewModel.SecondNumber;
        }
    }
}

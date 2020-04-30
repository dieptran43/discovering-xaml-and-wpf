using CalculatorApp.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace CalculatorApp.ViewModel
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _sum;
        private ICommand _AddNumbersCommand;

        public ICommand AddNumbersCommand
        {
            get { return _AddNumbersCommand; }
            set
            {
                _AddNumbersCommand = value;
                OnPropertyChanged("AddNumbersCommand");
            }
        }
        public int FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                _firstNumber = value;
                OnPropertyChanged("FirstNumber");
            }
        }
        public int SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                _secondNumber = value;
                OnPropertyChanged("SecondNumber");
            }
        }

        public int Sum
        {
            get { return _sum; }
            set
            {
                _sum = value;
                OnPropertyChanged("Sum");
            }
        }

        public CalculatorViewModel()
        {
            _AddNumbersCommand = new AddNumbersCommand();
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using WPFIntro.Model;

namespace WPFIntro
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private PersonModel _Model;
        private string _FullName;

        public MainWindowViewModel()
        {
            _Model = new PersonModel
            {
                FirstName="Luka",
                LastName="Radovanovic"
            };
            this._FullName = string.Format("{0} {1}", _Model.FirstName, _Model.LastName);
        }

        public string FirstName
        {
            get { return _Model.FirstName; }
            set
            {
                _Model.FirstName = value;
                this._FullName = string.Format("{0} {1}", _Model.FirstName, _Model.LastName);

                OnPropertyChange("FirstName");
            }
        }

        public string LastName
        {
            get { return _Model.LastName; }
            set
            {
                _Model.LastName = value;
                this._FullName = string.Format("{0} {1}", _Model.FirstName, _Model.LastName);

                OnPropertyChange("LastName");
            }
        }

        public string FullName
        {
            get { return _FullName; }
            set
            {
                _FullName = value;
                OnPropertyChange("FullName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

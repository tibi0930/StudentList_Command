using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentList_Command.ViewModel
{
    public class Student : INotifyPropertyChanged
    {
        public Int32 Id { get; set; }
        private String _firstName;
        private String _lastName;
        private String _studentCode;

        public String FirstName
        {
            get { return _firstName; }
            set
            {
                if(_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged();
                    OnPropertyChanged("Fullname");
                }
            }
        }

        public String LastName
        {
            get { return _lastName; }
            set
            {
                if(_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged();
                    OnPropertyChanged("FullName");
                }
            }
        }

        public String StudentCode
        {
            get { return _studentCode; }
            set
            {
                if(_studentCode!=value)
                {
                    _studentCode = value;
                    OnPropertyChanged();
                }
            }
        }

        public String FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] String property = null)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}

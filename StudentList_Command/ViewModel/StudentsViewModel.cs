using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace StudentList_Command.ViewModel
{
    public class StudentsViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public Student newStudent { get; private set; }

        public StudentAddCommand AddCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>();
            newStudent = new Student();
            AddCommand = new StudentAddCommand(this); // parancs létrehozása

            Students.Add(new Student { Id = 1, LastName = "Kis", FirstName = "János", StudentCode = "KIJSAAI" });
            Students.Add(new Student { Id = 2, LastName = "Nagy", FirstName = "Ferenc", StudentCode = "NAFSAAI" });
            Students.Add(new Student { Id = 3, LastName = "Huba", FirstName = "Hugó", StudentCode = "HUHSAAI" });
            Students.Add(new Student { Id = 4, LastName = "Gem", FirstName = "Géza", StudentCode = "GEGSAAI" });
            // a tulajdonságokat objektuminicializálás segítségével hozzuk létre
        }

        public void AddNewStudent()
        {
            Students.Add(newStudent);
            newStudent = new Student();
            OnPropertyChanged("newStudent");
        }

        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}

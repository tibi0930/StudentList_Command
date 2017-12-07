using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace StudentList_Command.ViewModel
{
    public class StudentsViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>
            {

                //Students.Add(new Student { Id = 1, LastName = "Kis", FirstName = "János", StudentCode = "KIJSAAI" });
                new Student { Id = 2, LastName = "Nagy", FirstName = "Ferenc", StudentCode = "NAFSAAI" },
                new Student { Id = 3, LastName = "Huba", FirstName = "Hugó", StudentCode = "HUHSAAI" },
                new Student { Id = 4, LastName = "Gem", FirstName = "Géza", StudentCode = "GEGSAAI" }
            };
        }
    }
}

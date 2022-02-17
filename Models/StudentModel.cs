using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Models
{
    public class StudentModel
    {
        private Guid Id { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string StudentNumber { get; set; }
        private List<NoteModel> Notes { get; set; }
        
        public StudentModel() { }
        public StudentModel(string _name, string _surname, string _studentNumber, List<NoteModel> _notes)
        {
            Name = _name;
            Surname = _surname;
            StudentNumber = _studentNumber;
            Notes = _notes;
        }

        [Key]
        public Guid id { get { return Id; } set { Id = value; } }
        public string name { get { return Name; } set { Name = value; } }
        public string surname { get { return Surname; } set { Surname = value; } }
        public string studentNumber { get { return StudentNumber; } set { StudentNumber = value; } }
        public List<NoteModel> notes { get { return Notes; } set { Notes = value; } }


    }
}

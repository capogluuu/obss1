using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Models
{
    public class NoteModel
    {
        private string CourseName { get; set; }
        private int FirstExam { get; set; }
        private int SecondExam { get; set; }
        private bool PassState { get; set; }

        public NoteModel() { }

        public NoteModel(string _courseName, int _firstExam, int _secondExam, bool _passState)
        {
            CourseName = _courseName;
            FirstExam = _firstExam;
            SecondExam = _secondExam;
            PassState = _passState;

        }
        public string courseName { get { return CourseName; } set { CourseName = value; } }
        public int firstExam { get { return FirstExam; } set { FirstExam = value; } }
        public int secondExam { get { return SecondExam; } set { SecondExam = value; } }
        public bool passState { get { return PassState; } set { PassState = value; } }

    }
}

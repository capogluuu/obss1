using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Models
{
    public class DatabaseModel
    {
        private string StudentNumber { get; set; }
        private string CourseName { get; set; }
        private int FirstExam { get; set; }
        private int SecondExam { get; set; }
        private string PassState { get; set; }

        public DatabaseModel() { }

        public DatabaseModel(string _studentNumber, string _courseName, int _firstExam, int _secondExam, string _passState)
        {
            StudentNumber = _studentNumber;
            CourseName = _courseName;
            FirstExam = _firstExam;
            SecondExam = _secondExam;
            PassState = _passState;

        }
        public string studentNumber { get { return StudentNumber; } set { StudentNumber = value; } }
        public string courseName { get { return CourseName; } set { CourseName = value; } }
        public int firstExam { get { return FirstExam; } set { FirstExam = value; } }
        public int secondExam { get { return SecondExam; } set { SecondExam = value; } }
        public string passState { get { return PassState; } set { PassState = value; } }

    }
}

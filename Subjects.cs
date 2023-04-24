using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Subject
    {
        private string _SubjectName;
        private string[] _PreConditionSubjects;
        private int _Credits;
        private int _MaxStudents;

        public Subject(string SubjectName, string[] PreConditionSubjects, int Credits, int maxStudents)
        {
            _SubjectName = SubjectName;
            _PreConditionSubjects = PreConditionSubjects;
            _Credits = Credits;
            _MaxStudents = maxStudents;
        }
    }
}

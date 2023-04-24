using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Teacher
    {
        private string _TeachName;
        private string _TeachLastName;
        private string[] _TeachSubjects;

        public Teacher(string TeachName, string TeachLastName, string[] TeachSubjectst)
        {
            _TeachName = TeachName;
            _TeachLastName = TeachLastName;
            _TeachSubjects = TeachSubjectst;

        }

        //This method throws an exception if the number of subjects exceeds 3
        public string[] limitOfSubjects
        {
            get { return _TeachSubjects; }
            set
            {
                if (_TeachSubjects.Length > 3)
                {
                    throw new ArgumentException("the number of subjects should not be more than 3");
                }

                _TeachSubjects = value;
            }
        }

        public string GetTeacherInfo(string TeachName, string TeachLastName, string[] TeachSubjectst)
        {
            string fullName = TeachName + " " + TeachLastName;
            string subjectList = string.Join(", ", TeachSubjectst);
            return $"{fullName} teaches the following subjects: {subjectList}.";
        }
    }
}

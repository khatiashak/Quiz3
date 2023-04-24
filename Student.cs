using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    private string _StudName;
    private string _StudLastName;
    private string _PinNumber;
    private string[] _StudSubjects;
    private int _Credits;
    private int _SemesterNumb;
    private int _MinCredit;
    private int _MaxCredit;
    private string[] _SemesterSubjects;


    public Student(string StudName, string StudLastName, string PinNumber, string[] StudSubjects,
        int Credits, int SemesterNumb, int MinCredit, int MaxCredit, string[] SemesterSubjects)

    {
        _StudName = StudName;
        _StudLastName = StudLastName;
        _PinNumber = PinNumber;
        _StudSubjects = StudSubjects;
        _Credits = Credits;
        _SemesterNumb = SemesterNumb;
        _MinCredit = MinCredit;
        _MaxCredit = MaxCredit;
        _SemesterSubjects = SemesterSubjects;
    }

    // This property returns full name of a student
    public string FullName
    {
        get
        {
            return $"{_StudName} {_StudLastName}";
        }
    }


    //This method throws an exception if the length of personal number does not equal to 11
    public string pin
    {
        get { return _PinNumber; }
        set
        {
            if (_PinNumber.Length != 11)
            {
                throw new ArgumentException("Pin number's length should be equal to 11");
            }

            _PinNumber = value;
        }
    }


    //This method throws an exception credits exceeds 35
    public int CreditCheck
    {
        get { return _Credits; }
        set
        {
            if (_Credits > 35)
            {
                throw new ArgumentException("Credits should not be more than 35");
            }

            _Credits = value;
        }
    }

    public void PrintSemesterSubjects(List<string> semesterSubjects)
    {
        foreach (string subject in semesterSubjects)
        {
            Console.WriteLine(subject);
        }
    }
}

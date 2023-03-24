using System;


public class Student:IComparable<Student>
{
    public int StudentID{get;set;}
    public int StandardID{get;set;}
    public string StudentName{get;set;}
    public int Age{get;set;}
    public int Salary{get;set;}

    public int CompareTo(Student other)
    {
        if (this.StudentName.Length >= other.StudentName.Length)
            return 1;

        return 0;
    }
}

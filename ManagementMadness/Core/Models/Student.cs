using ManagementMadness.Core.Interfaces;

namespace ManagementMadness.Core.Models;

internal class Student : Person, IStudent
{
    public Student(
        string name, 
        int age, 
        bool isSmoking = false, 
        bool hasDegree = false, 
        bool hasAutism = false, 
        bool hasADHD = false
        ) : base(name, age, isSmoking, hasDegree, hasAutism, hasADHD) {}

    internal override string GetInfo()
    {
        throw new NotImplementedException();
    }

    internal override string GetThoughts()
    {
        throw new NotImplementedException();
    }

    void IStudent.GoToClass()
    {
        throw new NotImplementedException();
    }

    void IStudent.Houdini()
    {
        throw new NotImplementedException();
    }

    void IStudent.MakeExcuse()
    {
        throw new NotImplementedException();
    }

    void IStudent.StudyAtHome()
    {
        throw new NotImplementedException();
    }

    void IStudent.StudyInClass()
    {
        throw new NotImplementedException();
    }
}
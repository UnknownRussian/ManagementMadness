using ManagementMadness.Core.Interfaces;

namespace ManagementMadness.Core.Models;

internal class Teacher : Person, ITeacher
{
    public Teacher(
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

    void ITeacher.MisinformClass()
    {
        throw new NotImplementedException();
    }

    void ITeacher.PrepareMaterial()
    {
        throw new NotImplementedException();
    }

    void ITeacher.TakeBreak()
    {
        throw new NotImplementedException();
    }

    void ITeacher.TeachClass()
    {
        throw new NotImplementedException();
    }
}
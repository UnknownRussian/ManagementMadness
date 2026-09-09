namespace ManagementMadness.Core.Models;

internal class Teacher : Person
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

    internal void MisinformClass()
    {
        throw new NotImplementedException();
    }

    internal void PrepareMaterial()
    {
        throw new NotImplementedException();
    }

    internal void TakeBreak()
    {
        throw new NotImplementedException();
    }

    internal void TeachClass()
    {
        throw new NotImplementedException();
    }
}
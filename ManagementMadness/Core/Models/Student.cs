namespace ManagementMadness.Core.Models;

internal class Student : Person
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
}
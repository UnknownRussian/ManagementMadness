namespace ManagementMadness.Core.Models;

internal abstract class Person
{
    protected string name;
    protected int age;

    // These values are from 0 to 100
    protected int energy;
    protected int sleep;
    protected int attention;
    protected int preparation;

    // These values determain wether or not a person has challenges
    protected bool isSmoking;
    protected bool hasDegree;
    protected bool hasAutism;
    protected bool hasADHD;

    protected Person(string name, int age, bool isSmoking = false, bool hasDegree = false, bool hasAutism = false, bool hasADHD = false)
    {
        this.name = name;
        this.age = age;

        sleep = 100;
        attention = 100;
        energy = 100;
        preparation = 100;

        this.isSmoking = isSmoking;
        this.hasDegree = hasDegree;
        this.hasAutism = hasAutism;
        this.hasADHD = hasADHD;
    }

    internal abstract string GetInfo();

    internal abstract string GetThoughts();
}
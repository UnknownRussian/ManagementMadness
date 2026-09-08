namespace ManagementMadness.Core.Interfaces;

internal interface IRoom
{
    internal bool IsTeacherPresent();
    internal bool IsStudentAllowed();
    internal void Enter();
    internal void Exit();
}
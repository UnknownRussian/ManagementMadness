using ManagementMadness.Core.Interfaces;

namespace ManagementMadness.Core.Models;

internal class TeachersRoom : IRoom
{
    void IRoom.Enter()
    {
        throw new NotImplementedException();
    }

    void IRoom.Exit()
    {
        throw new NotImplementedException();
    }

    bool IRoom.IsStudentAllowed() => false;

    bool IRoom.IsTeacherPresent()
    {
        throw new NotImplementedException();
    }
}
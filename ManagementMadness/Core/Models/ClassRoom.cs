using ManagementMadness.Core.Interfaces;

namespace ManagementMadness.Core.Models;

internal class ClassRoom : IRoom
{
    void IRoom.Enter()
    {
        throw new NotImplementedException();
    }

    void IRoom.Exit()
    {
        throw new NotImplementedException();
    }

    bool IRoom.IsStudentAllowed()
    {
        throw new NotImplementedException();
    }

    bool IRoom.IsTeacherPresent()
    {
        throw new NotImplementedException();
    }
}
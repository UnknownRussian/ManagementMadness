using ManagementMadness.Core.Interfaces;

namespace ManagementMadness.Core.Models;

internal class Floor
{
    internal int Number { get; private set; }
    internal List<IRoom> Rooms { get; private set; }
}
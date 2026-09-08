using ManagementMadness.GUI.Components;

namespace ManagementMadness;

class Program
{
    static void Main(string[] args)
    {
        string[] menuOptions = ["Manage Teachers", "Manage Students", "Manage Class'", "Manage Rooms"];


        var selected = MainMenu.ShowMenu(menuOptions);

        Console.WriteLine(selected);
        Console.ReadLine();

    }

    /*
        Chars for design UI:
        ┏ ━ ┓
        ┃
        ┗   ┛
    */
}

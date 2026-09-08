using ManagementMadness.GUI.Components;

namespace ManagementMadness;

class Program
{
    static void Main(string[] args)
    {
        MenuComponent mainMenu = new (
                "Main Menu",
                [
                    "Manage teachers", 
                    "Manage students", 
                    "Manage professions",
                    "Set game speed"
                ],
                true
            );


        var selected = mainMenu.Show();

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

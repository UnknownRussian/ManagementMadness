namespace ManagementMadness.GUI.Components;

internal class MainMenu
{
    internal static string ShowMenu(string[] menuOptions)
    {
        List<string> options = [.. menuOptions.ToList().Prepend("Exit")];
        
        Console.Clear();
        Console.WriteLine("===============");
        Console.WriteLine(" - Main Menu - ");
        Console.WriteLine("===============");

        options
            .Where(menuOption => options.IndexOf(menuOption) > 0)
            .ToList()
            .ForEach(menuOption => Console.WriteLine($"{options.IndexOf(menuOption)} - {menuOption}"));

        Console.WriteLine($"0 - {options[0]}");
        Console.WriteLine();

        Console.Write("Menu: ");
        int optionChoosen = GetUserInput();

        try
        {
            return menuOptions[optionChoosen];
        } catch
        {
            Console.WriteLine("Please choose an available option from the menu!");
            Thread.Sleep(2000);
            return ShowMenu(menuOptions);
        }
    }

    private static int GetUserInput()
    {
        if (int.TryParse(Console.ReadLine(), out int menuNumber)) return menuNumber;
        return -1;
    }
}
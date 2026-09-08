namespace ManagementMadness.GUI.Components;

internal class MenuComponent
{
    private string[] options;
    private string name;

    internal MenuComponent(string name, string[] options, bool isMain = false)
    {
        this.name = name;
        this.options = [.. options.ToList().Prepend(isMain ? "Exit" : "Back")];
    }

    internal string Show()
    {        
        Console.Clear();
        Console.WriteLine("===============");
        Console.WriteLine($" - {name} - ");
        Console.WriteLine("===============");

        options
            .Where(option => options.IndexOf(option) > 0)
            .ToList()
            .ForEach(option => Console.WriteLine($"{options.IndexOf(option)} - {option}"));

        Console.WriteLine($"0 - {options[0]}");
        Console.WriteLine();

        Console.Write("Menu: ");
        int optionChoosen = GetUserInput();

        try
        {
            return options[optionChoosen];
        } catch
        {
            Console.WriteLine("Please choose an available option from the menu!");
            Thread.Sleep(2000);
            return Show();
        }
    }

    private int GetUserInput()
    {
        if (int.TryParse(Console.ReadLine(), out int menuNumber)) return menuNumber;
        return -1;
    }
}
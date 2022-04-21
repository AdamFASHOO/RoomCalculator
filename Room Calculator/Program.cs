public class Program
{
    public static void Main()
    {
        bool goAgain = true;
        while (goAgain)
        {
            RoomDeterminer();
            goAgain = RunAgain();
        }
    }

    public static void RoomDeterminer()
    {
        double length = double.Parse(GetUserInput("Please enter the length of the classroom: "));
        double width = double.Parse(GetUserInput("Please enter the width of the classroom: "));
        double height = double.Parse(GetUserInput("Please enter the height of the classroom: "));

        double area = length * width;
        double perimeter = 2 * (length + width);
        double volume = width * height * length;
        double surfaceArea = 2 * ((width * length) + (height * length) + (height * width));

        Console.WriteLine("\n\nWith these classroom dimensions:\n\nThe area will be " + area + " square feet.");
        Console.WriteLine("The perimeter will be " + perimeter + " square feet.");
        Console.WriteLine("The volume will be " + volume + " square feet.");
        Console.WriteLine("The surface area will be " + surfaceArea + " square feet.");

        if (area <= 250)
        {
            Console.WriteLine("\nThis will be a small classroom.");
        }
        else if (area >= 251 && area <= 650)
        {
            Console.WriteLine("\nThis will be a medium classroom.");
        }
        else
        {
            Console.WriteLine("\nThis will be a large classroom.");
        }
    }

    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return input;
    }

    public static bool RunAgain()
    {
        string answer = GetUserInput("Would you like to measure another room? y/n").ToLower();
        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("\nI'm sorry, I didn't understand that.");
            return RunAgain();
        }
    }
}


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the length of the classroom: ");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the width of the classroom: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the classroom: ");
        double height = double.Parse(Console.ReadLine());

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
}


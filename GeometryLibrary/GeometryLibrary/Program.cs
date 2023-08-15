
using GeometryLibrary;

Console.WriteLine("Geometry Calculator");

while (true)
{
    Console.WriteLine("Select shape:");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Triangle");
    Console.WriteLine("0. Exit");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            double radius = GetValidDouble("Enter the radius of the circle: ");
            Circle circle = new Circle(radius);
            Console.WriteLine("Circle area is - " + circle.CalculateArea());
            break;

        case 2:
            double side1 = GetValidDouble("Enter the side 1 of Triangle: ");
            double side2 = GetValidDouble("Enter the side 2 of Triangle: ");
            double side3 = GetValidDouble("Enter the side 3 of Triangle: ");
            Triangle triangle = new Triangle(side1, side2, side3);
            Console.WriteLine("Triangle area is - " + triangle.CalculateArea());
            break;

        case 0:
            Console.WriteLine("Exiting the program.");
            return;

        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            break;
    }
}

static double GetValidDouble(string message)
{
    double value = 0;
    bool isValid = false;

    while (!isValid)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        try
        {
            value = double.Parse(input);

            if (value > 0)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Value must be greater than 0.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
    return value;

}  
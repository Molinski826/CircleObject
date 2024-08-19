using CircleObject;


class Program
{
    static void Main()
    {
        Circle circle = null;
        bool continueApp = true;

        while (continueApp)
        {
            // Prompt user for radius
            double radius;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("Enter the radius of the circle: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out radius) && radius > 0)
                {
                    validInput = true;
                    circle = new Circle(radius);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            // Display diameter, circumference, and area
            DisplayCircleProperties(circle);

            // Ask if the circle should grow
            Console.Write("Should the circle grow? (y/n): ");
            string growResponse = Console.ReadLine().Trim().ToLower();

            if (growResponse == "y")
            {
                circle.Double();
                Console.WriteLine($"The circle has grown. Here are the updated properties: ");
                DisplayCircleProperties(circle);
            }
            else if (growResponse == "n")
            {
                continueApp = false;
                Console.WriteLine($"Goodbye! The final radius of the circle is {circle.GetRadius():F2}");
            }
            else
            {
                Console.WriteLine("Invalid response. Exiting the application.");
                continueApp = false;
            }
        }
    }

    static void DisplayCircleProperties(Circle circle)
    {
        Console.WriteLine($"Diameter: {circle.CalculateDiameter():F2}");
        Console.WriteLine($"Circumference: {circle.CalculateCircumference():F2}");
        Console.WriteLine($"Area: {circle.CalculateArea():F2}");
    }
}

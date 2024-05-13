using Ch02BonusMission;

string radiusInput;
double radius;

do
{
    Console.WriteLine("Please enter a positive radius: ");
    radiusInput = Console.ReadLine();
    if (Equals(radiusInput, "") || !double.TryParse(radiusInput, out radius))
    {
        Console.WriteLine("I can't calculate anything with that!");
        return;
    }
    // radius = double.Parse(radiusInput);
} while (radius < 0);

double area = Circle.CalcArea(radius);

Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);

double diameter = Circle.CalcDiameter(radius);
double circumference = Circle.CalcCircumference(radius);

Console.WriteLine("The diameter is " + diameter + " and the circumference is " + circumference);

Console.WriteLine("What is your car's gas mileage (MPG)?");
double mpg = double.Parse(Console.ReadLine());

double gallons = circumference / mpg;

Console.WriteLine("You will need " + gallons + " gallons to drive around the circle.");

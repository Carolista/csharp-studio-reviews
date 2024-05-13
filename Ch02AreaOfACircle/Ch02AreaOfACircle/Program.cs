Console.WriteLine("Please enter a radius: ");
double radius = double.Parse(Console.ReadLine());

double area = Math.Pow(radius, 2) * Math.PI;

Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);

double diameter = 2 * radius;
double circumference = diameter * Math.PI;

Console.WriteLine("The diameter is " + diameter + " and the circumference is " + circumference);

Console.WriteLine("What is your car's gas mileage (MPG)?");
double mpg = double.Parse(Console.ReadLine());

double gallons = circumference / mpg;

Console.WriteLine("You will need " + gallons + " gallons to drive around the circle.");

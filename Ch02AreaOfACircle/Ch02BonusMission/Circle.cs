namespace Ch02BonusMission
{
    public class Circle 
    {
        public static double CalcArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public static double CalcDiameter(double radius)
        {
            return 2 * radius;
        }

        public static double CalcCircumference(double radius)
        {
            return CalcDiameter(radius) * Math.PI; 
        }
    }
}
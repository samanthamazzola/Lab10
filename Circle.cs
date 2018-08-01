using System;
namespace Lab10
{
    public class Circle //Base Class
    {

        //fields //private lowercase
        private double radius


        //properties //{get;set;}
        public double Radius
        {
            set { radius = value; }
            get { return radius; }

        }

        //constructors
        //default
        //overload constructor
        public Circle()
        {
            Radius = 60;
        }
        public Circle(double r)
        {
        Radius = r;
        }

        //methods
        public double CalculateCircumference()
        {
            double Circumfernence = Math.PI * 2 * Radius;
            return Circumfernence;
        }
        public string CalculateFormattedCircumference() //rounded to the nearest 2 decimals, return that value as a string
        {
            Console.WriteLine($"");

        }
        public double CalculateArea()
        {
            double Area = Math.PI * (Radius*Radius);
            Console.WriteLine($"");

        }
        public string CalculateFormattedArea() //rounded to the nearest 2 decimals, return that value as a string
        {
            Console.WriteLine($"");

        }
        private string FormatNumber(double x) // you can take in a double from the CalculateArea(), and CalculateCircumference() and pass a string which is used to round
        {
            
            Console.WriteLine("");

        }
    }
}

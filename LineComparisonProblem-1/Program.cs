namespace LineComparisonProblem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            //UC1 Line Length Calculation
            Console.WriteLine("Enter x1 : ");
            //Here I am Reading Input From User 
            // Here I am initilizing the variable with Double data type because user may give input float values so keeping that as consideration i choose double data type
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 : ");
            double x2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 : ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            //For Finding The Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2-y1) ^2)
            double length =Math.Sqrt(Math.Pow((x2 - x1), 2)+ Math.Pow((y2 - y1), 2));
            Console.WriteLine(length);


        }
    }
}
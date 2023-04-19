using System.ComponentModel.Design;

namespace LineComparisonProblem_1
{
    internal class Program
    {
        class Lines {
            public double FindLengthOfLine(double a1,double b1, double a2,double b2)//this method gives the length of the line this block of code is re used when we find the length of any line;
            {
                //For Finding The Length of a Line = sqrt( (x2 - x1) ^ 2 + (y2-y1) ^2)
                double lengthOfLine = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
                return lengthOfLine;
            }
            public void LineComparision(double lengthOfLine1, double lengthOfLine2)//This Method coparis the Length of Line1 and Length of line2
            {
                if (lengthOfLine1 == lengthOfLine2)
                {

                    Console.WriteLine("Length of line1 is Equal to Length of line2");
                }

                else if (lengthOfLine1 > lengthOfLine2)
                {

                    Console.WriteLine("Length of line1 is Gaterthan  Length of line2");
                }
                else
                {
                    Console.WriteLine("Length of line1 is Lessthan  Length of line2");

                }
            }
            
        }
        
        static void Main(string[] args)
        {
            //UC1 Line Length Calculation
            Console.WriteLine("Enter x1 : ");//Here I am Reading Input From User 
            double x1 = Convert.ToDouble(Console.ReadLine());// Here I am initilizing the variable with Double data type because user may give input float values so keeping that as consideration i choose double data type
            Console.WriteLine("Enter x2 : ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 : ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter m1 : ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter m2 : ");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter n1 : ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter n2 : ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Lines myObj=new Lines();// Here i am creating the Object of class
            double lengthOfLine1=myObj.FindLengthOfLine(x1, x2, y1, y2);//By changing the parametrs we can use same method This is called method overloading
            double lengthOfLine2= myObj.FindLengthOfLine(m1, m2, n1, n2);
            myObj.LineComparision(lengthOfLine1, lengthOfLine2);






        }
    }
}
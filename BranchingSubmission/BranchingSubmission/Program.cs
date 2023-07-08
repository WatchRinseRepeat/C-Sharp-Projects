using System;


namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction text
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Get weight of package
            Console.WriteLine("Please enter the package weight:");
            double pkgWeight = Convert.ToDouble(Console.ReadLine());  // Convert the input from string to Double
            if (pkgWeight > 50) {
                Console.WriteLine("This package is too heavy to be shipped via package express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                //Get width of package
                Console.WriteLine("Please enter the package width:");
                double pkgWidth = Convert.ToDouble(Console.ReadLine());  // Convert the input from string to Double
                                                                         //Get height of package
                Console.WriteLine("Please enter the package Height:");
                double pkgHeight = Convert.ToDouble(Console.ReadLine());  // Convert the input from string to Double
                                                                          //Get length of package
                Console.WriteLine("Please enter the package Length:");
                double pkgLength = Convert.ToDouble(Console.ReadLine());  // Convert the input from string to Double

                if (pkgHeight + pkgLength + pkgWidth > 50) //Check if total of dimensions greater than 50, if so end program with message
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else //if not give price
                {
                    double pkgCost = ((pkgWidth * pkgLength * pkgHeight) * pkgWeight) / 100; //calculate cost
                    Console.WriteLine("Your estimated total for shipping this package is: $" + pkgCost); // Give cost
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
            
        }
    }
}

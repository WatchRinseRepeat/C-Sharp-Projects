using System;


namespace MathComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //print title
            Console.WriteLine("Anonymous Income Comparison Program");
            //user 1
            Console.WriteLine("Person 1:\nEnter Hourly Rate:");
            //  hourly rate
            string userResponse = Console.ReadLine();
            double oneHourly = Convert.ToDouble(userResponse);
            //  hours worked per week
            Console.WriteLine("Person 1:\nEnter Weekly Hours:");
            userResponse = Console.ReadLine();
            double oneHours = Convert.ToDouble(userResponse);
            //user 2
            Console.WriteLine("Person 2:\nEnter Hourly Rate:");
            //  hourly rate
            userResponse = Console.ReadLine();
            double twoHourly = Convert.ToDouble(userResponse);
            //  hours worked per week
            Console.WriteLine("Person 2:\nEnter Weekly Hours:");
            userResponse = Console.ReadLine();
            double twoHours = Convert.ToDouble(userResponse);

            //Annual Salary person 1
            double oneAnnual = 52 * oneHourly * oneHours;
            Console.WriteLine("The annual salary of person 1 is: $" + oneAnnual);
            //Annual Salary person 2
            double twoAnnual = 52 * twoHourly * twoHours;
            Console.WriteLine("The annual salary of person 2 is: $" + twoAnnual);
            //Does Person 1 make mor than Person 2?
            bool oneMore = oneAnnual > twoAnnual;
            Console.WriteLine("Does Person 1 make more than person 2?: " + oneMore);
            Console.ReadLine();

        }

    }

}
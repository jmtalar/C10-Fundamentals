using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {

        public static void ParsingStrings()
        {
            Console.Write("Enter the wage: ");
            string wage = Console.ReadLine();

            int wageValue;

            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing success: " + wageValue);
            else
                Console.WriteLine("Parsing failed");

            string hireDateString = "12/12/2022";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);
        }

        public static void UsingEscapeCharacters()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string displayName = $"Welcome!";

            Console.WriteLine($"You are {firstName} {lastName}.\n{displayName}");
        }

        public static void ManipulatingString()
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            string fullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            string empId = firstName.ToLower() + "-" + lastName.ToLower();
            int length = empId.Length;

            if (fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It's Bethany!");
            }
        }

        public static void UsingSimpleString()
        {
            string firstName = "Bethany";
            string lastName = "Smith";
            string s;
            s = firstName;
            var userName = "BethabyS";
            userName = userName.ToLower();

            userName = string.Empty;
        }
        public static void UsingOptionalParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForMeployee1 = CalculateYearlyWageWithOptional(monthlyWage1, months1);

            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForMeployee1}");

        }

        public static void UsingNamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForMeployee1 = CalculateYearlyWageWithNamed(monthlyWage: months, numberOfMonthsWorked: amount, bonus: bonus);

            Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForMeployee1}");

        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWageWithNamed(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, double bonus)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }
    }
}

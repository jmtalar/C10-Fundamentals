using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;
        private int age;

        private int numberofHoursWorked;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;
        private const int minimalHoursWorkedUnit = 1;

        public static double taxRate = 0.15;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int NumberofHoursWorked
        {
            get { return numberofHoursWorked; }
            protected set { numberofHoursWorked = value; }
        }

        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set { 
                if(hourlyRate > 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
                 }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }


        public Employee(string first, string last, string em, DateTime bd) : this( first, last, em, bd, 0)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double? rate)
        {
            FirstName = first;
            LastName = last;    
            Email = em; 
            BirthDay = bd;  
            HourlyRate = rate ?? 10;
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            NumberofHoursWorked += numberOfHours;

            Console.WriteLine($"{FirstName} {LastName} has worked for {NumberofHoursWorked} hour(s)!");

        }

        public double PerformWork(bool resetHours)
        {
            wage = NumberofHoursWorked * HourlyRate.Value;
            Console.WriteLine($"{FirstName} {LastName} has received wage of {Wage} for {NumberofHoursWorked} hour(s)!");

            if (resetHours)
            {
                NumberofHoursWorked = 0;
            }

            return wage;
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberofHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        //public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        //{
        //    if (numberofHoursWorked > 10)
        //        bonus *= 2;

        //    if(bonus >= 200)
        //    {
        //        bonusTax = bonus / 10;
        //        bonus -= bonusTax;
        //    }

        //    Console.WriteLine($"The employee got a bonus of {bonus} and tax on that bonus of {bonusTax}");
        //    return bonus;
        //}

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberofHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and tax on that bonus of {bonusTax}");
            return bonus;
        }

        public static void UsingACustomType()
        {
            List<string> list = new List<string>();  


        }

        public string ConvertToJson()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return json;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberofHoursWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received wage of {Wage} for {NumberofHoursWorked} hour(s)!");

            if (resetHours)
                NumberofHoursWorked = 0;
            

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"First name: {FirstName}\nLast name: {LastName}\nE-mail: {Email}\nBirthday: {BirthDay}\n");
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        private int numberOfPieTastesInvented = 0;

        public int NumberOfPieTastesInvented
        {
            get { return numberOfPieTastesInvented; }
            set {  numberOfPieTastesInvented = value;}
        }

        public void ResearchNewPieTastes(int researchHours)
        {
            numberOfPieTastesInvented += researchHours;

            if(new Random().Next(100) > 50)
            {
                NumberOfPieTastesInvented++;

                Console.WriteLine($"Researcher {FirstName} {LastName} has just invented a new pie taste! Total number of pies invented: {NumberOfPieTastesInvented}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is still working on a new pie taste!");
            }
        }
    }
}

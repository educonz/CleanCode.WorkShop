using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.DryRefatorado
{
    public class Program
    {
        const string Address = "Stockholm, Sweden";
        const string StandardFormat = "{0} is {1}, lives in {2}, age {3}";

        public void ShowInfoAboutPeople()
        {
            AboutNils();
            AboutChristian();
            AboutEva();
            AboutLilly();
        }

        private void AboutNils()
        {
            WriteToConsole("Nils", "a good friend", 30);
        }

        private void AboutChristian()
        {
            WriteToConsole("Christian", "a neighbour", 54);
        }

        private void AboutEva()
        {
            WriteToConsole("Eva", "my daughter", 4);
        }

        private void AboutLilly()
        {
            WriteToConsole("Lilly", "my daughter's best friend", 4);
        }

        private void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(StandardFormat, name, description, Address, age);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.WorkShop.Dry
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
            string address = Address;
            string format = StandardFormat;
            Console.WriteLine(format, "Nils", "a good friend", address, 30);
        }

        private void AboutChristian()
        {
            string address = Address;
            string format = StandardFormat;
            Console.WriteLine(format, "Christian", "a neighbour", address, 54);
        }

        private void AboutEva()
        {
            string address = Address;
            string format = StandardFormat;
            Console.WriteLine(format, "Eva", "my daughter", address, 4);
        }

        private void AboutLilly()
        {
            string address = Address;
            string format = StandardFormat;
            Console.WriteLine(format, "Lilly", "my daughter's best friend", address, 4);
        }
    }
}

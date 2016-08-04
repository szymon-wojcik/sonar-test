using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("Flash");
            Trout nemo = new Trout("Nemo");
            Animal[] zoo = { kitty, nemo };

            foreach (Animal crit in zoo)
            {
                Console.WriteLine(crit.ToString());
                crit.Move();
                crit.Breathe();
            }

            Console.ReadKey();
        }
    }
}

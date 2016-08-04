using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SonarTest
{
    public class Cat : Mammal
    {
        public override void Run()
        {
            Console.WriteLine("running...");
        }

        public override void Breathe()
        {
            Console.WriteLine("absorb oxygen from air");
        }

        public override void Move()
        {
            Console.WriteLine("walks silently");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarTest
{
    public class Trout : Fish
    {
        public Trout(string name) : base(name)
        {
        }

        public override void Breathe()
        {
            Console.WriteLine("absorb oxygen from water");
        }

        public override void Move()
        {
            Console.WriteLine("swims around");
        }
    }
}

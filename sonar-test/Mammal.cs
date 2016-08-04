using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SonarTest
{
    public abstract class Mammal: Animal
    {
        new readonly int numOfLegs = 4;
        public abstract void Run();
    }
}
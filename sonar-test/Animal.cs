using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarTest
{
    public abstract class Animal
    {
        protected int numOfLegs;
        protected string name;

        public abstract void Breathe();
        public abstract void Move();

        public Animal(string name)
        {
            this.name = name;
        }

        public Animal()
        {

        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.AppendLine(this.GetType() + ":" + this.name);
            return returnString.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Classes
{
    public class Decaf : Beverage
    {
        public Decaf() 
        {
            description = "This is Decaf coffee";
        }
        public override int Cost()
        {
            return 100;
        }
    }
}

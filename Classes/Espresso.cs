using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Classes
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "This is Espresso Coffee";
        }

        public override int Cost()
        {
            return 70;
        }
    }
}

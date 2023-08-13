using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Classes
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() : base("This is Dark Roast Coffee") { }
        public override int Cost()
        {
            return 60;
        }
    }
}

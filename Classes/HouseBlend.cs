using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Classes
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() 
        {
            description = "This is House Blend Coffee";
        }
        public override int Cost()
        {
            return 50;
        }
    }
}

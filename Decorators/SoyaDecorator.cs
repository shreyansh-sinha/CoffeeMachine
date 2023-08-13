using CoffeeMachine.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Decorators
{
    public class SoyaDecorator : BaseDecorator
    {
        public SoyaDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "Soya";
        }

        public override int Cost()
        {
            return beverage.Cost() + 40;
        }
    }
}

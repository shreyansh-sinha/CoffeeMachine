using CoffeeMachine.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Decorators
{
    public class MochaDecorator : BaseDecorator
    {
        public MochaDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "Mocha";
        }

        public override int Cost()
        {
            Size size = beverage.getSize();
            int cost = beverage.Cost();
            switch(size)
            {
                case Size.TALL:
                    cost = cost + 10;
                    break;
                case Size.GRANDE:
                    cost = cost + 20; 
                    break;
                case Size.VENTI:
                    cost = cost + 30;
                    break;
                default:
                    cost = cost + 10;
                    break;
            }
            return cost;
        }
    }
}

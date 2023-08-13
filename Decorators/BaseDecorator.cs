using CoffeeMachine.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Decorators
{
    public abstract class BaseDecorator : Beverage
    {
        public Beverage beverage;
        public abstract string getDescription();
    }
}

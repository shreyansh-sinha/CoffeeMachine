namespace CoffeeMachine.Classes
{
    public abstract class Beverage
    {
        public string description { get; set; }
        public string getDescription()
        {
            return this.description;
        }
        public abstract int Cost();
    }
}

namespace CoffeeMachine.Classes
{
    public abstract class Beverage
    {
        public string description { get; set; }
        public Beverage() { }
        public Beverage(string description)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return this.description;
        }
        public abstract int Cost();
    }
}

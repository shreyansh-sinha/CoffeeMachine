namespace CoffeeMachine.Classes
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };
        Size size = Size.TALL;
        public String description = "Unknown Beverage";
        public string getDescription()
        {
            return this.description;
        }
        public void setSize(Size size)
        {
            this.size = size;
        }
        public Size getSize()
        {
            return this.size;
        }
        public abstract int Cost();
    }
}

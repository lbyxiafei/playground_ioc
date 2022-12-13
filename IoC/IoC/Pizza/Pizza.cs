namespace IoC.PizzaStore
{
    public abstract class Pizza
    {
        public Pizza(string name)
        {
            Console.WriteLine(name);
        }
    }
}

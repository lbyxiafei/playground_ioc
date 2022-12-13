using IoC.PizzaStore;

namespace IoC.PizzaFactory
{
    public interface IPizzaStore
    {
        Pizza CreatePizza(string order);
    }
}

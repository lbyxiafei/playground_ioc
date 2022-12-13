using IoC.PizzaFactory;
using IoC.PizzaStore.IngredientFactory;

namespace IoC.PizzaStore
{
    public class CountrysidePizzaStore : IPizzaStore
    {
        private readonly IIngredientFactory _ingredientFactory;

        public CountrysidePizzaStore(IIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public Pizza CreatePizza(string order)
        {
            throw new NotImplementedException();
        }
    }
}

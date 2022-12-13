using IoC.PizzaFactory;
using IoC.PizzaStore.IngredientFactory;

namespace IoC.PizzaStore
{
    public class MetropolisPizzaStore : IPizzaStore
    {
        private readonly IIngredientFactory _ingredientFactory;

        public MetropolisPizzaStore(IIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public Pizza CreatePizza(string order)
        {
            throw new NotImplementedException();
        }
    }
}

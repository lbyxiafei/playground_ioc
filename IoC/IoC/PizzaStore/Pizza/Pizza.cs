using IoC.PizzaStore.IngredientFactory;

namespace IoC.PizzaStore
{
    public abstract class Pizza
    {
        private readonly IIngredientFactory _ingredientFactory;

        public abstract void Prepare();

        public abstract void Bake();

        public abstract void Cut();
    }
}

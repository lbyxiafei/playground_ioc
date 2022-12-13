using IoC.PizzaStore.IngredientFactory;

namespace IoC.PizzaStore
{
    public class MeatLoverPizza : Pizza
    {
        private readonly IIngredientFactory _ingredientFactory;

        public MeatLoverPizza(IIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }

        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }
    }
}

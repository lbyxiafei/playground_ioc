namespace IoC.PizzaStore.IngredientFactory
{
    public interface IIngredientFactory
    {
        string CreateDough();

        string CreateCheese();

        string CreateTopping();
    }
}

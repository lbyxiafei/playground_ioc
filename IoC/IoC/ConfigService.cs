using IoC.PizzaFactory;
using IoC.PizzaStore;
using IoC.PizzaStore.IngredientFactory;
using System.Runtime.CompilerServices;

namespace IoC
{
    public static class ConfigService
    {
        public static void ConfigDI(IServiceCollection services, ConfigurationManager config)
        {
            //services.AddScoped<Pizza, MeatLoverPizza>();
            //services.AddScoped<Pizza, MeatLoverPizza>(e => new MeatLoverPizza("meat lover"));

            services.AddScoped<IPizzaStore, CountrysidePizzaStore>();
            services.AddScoped<IPizzaStore, MetropolisPizzaStore>();

            services.AddScoped<IIngredientFactory, RuralIngredientFactory>();
            services.AddScoped<IIngredientFactory, UrbanIngredientFactory>();
        }
    }
}

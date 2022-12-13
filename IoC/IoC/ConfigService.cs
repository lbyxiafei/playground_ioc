using IoC.PizzaStore;
using System.Runtime.CompilerServices;

namespace IoC
{
    public static class ConfigService
    {
        public static void ConfigDI(IServiceCollection services, ConfigurationManager config)
        {
            //services.AddScoped<Pizza, MeatLoverPizza>();
            services.AddScoped<Pizza, MeatLoverPizza>(e => new MeatLoverPizza("meat lover"));
        }
    }
}

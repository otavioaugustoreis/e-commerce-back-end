using System.Runtime.CompilerServices;

namespace cadastro_produtos_design_patterns.Util
{
    public  static class RedisStartup 
    {

        public static IServiceCollection Redis(this IServiceCollection builder)
        {
            builder.AddStackExchangeRedisCache(p =>
            {
                p.InstanceName = "instance";
                p.Configuration = "localhost:6379";
            });

            return builder;
        }
    }
}

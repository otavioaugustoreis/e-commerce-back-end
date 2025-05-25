using cadastro_produtos_design_patterns.Mapper;
using System.Runtime.CompilerServices;

namespace cadastro_produtos_design_patterns.Util
{
    public static  class MapperUtil
    {
        public static IServiceCollection  AddMapper(this IServiceCollection builder)
        {
            builder.AddAutoMapper(typeof(DomainMapperProfile));

            return builder;
        }
    }
}

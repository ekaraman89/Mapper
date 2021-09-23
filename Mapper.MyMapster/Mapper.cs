using Mapper.Core;
using Mapster;

namespace Mapper.MyMapster
{
    public class Mapper : IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return source.Adapt<TDestination>();
        }
    }
}
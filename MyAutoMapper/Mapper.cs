using AutoMapper;
using MyAutoMapper.Profiles;
using System.Collections.Generic;

namespace MyAutoMapper
{
    public class Mapper : Core.IMapper
    {
        public Mapper()
        {
            var profiles = new List<Profile>
            {
                new CustomerProfile()
            };

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var item in profiles)
                {
                    cfg.AddProfile(item);
                }
            });

            var mapper = config.CreateMapper();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return AutoMapper.Mapper.Map<TDestination>(source);
        }
    }
}
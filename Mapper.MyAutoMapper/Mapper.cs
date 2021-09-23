using AutoMapper;
using Mapper.MyAutoMapper.Profiles;
using System.Collections.Generic;

namespace Mapper.MyAutoMapper
{
    public class Mapper : Core.IMapper
    {
        private static IMapper _mapper;

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

            _mapper = config.CreateMapper();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}
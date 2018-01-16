using AutoMapper;
using vega.Controllers;
using vega.Controllers.Resources;
using vega.Models;

namespace vega.mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            
        }
        
    }
}
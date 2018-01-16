using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.DataBase;
using vega.Models;

namespace vega.Controllers
{
    public class FeatureController:Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public FeatureController(VegaDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeaturesAsync(){
            var features= await context.Features.ToListAsync();
            return mapper.Map<List<Feature>,List<FeatureResource>>(features);
        }
    }
}
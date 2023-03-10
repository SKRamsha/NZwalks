using NZWalks.API1.Data;
using NZWalks.API1.Models.Domain;

namespace NZWalks.API1.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext) 
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
           return nZWalksDbContext.Regions.ToList();
        }
    }
}

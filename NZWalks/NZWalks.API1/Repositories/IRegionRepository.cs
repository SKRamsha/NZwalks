using NZWalks.API1.Models.Domain;

namespace NZWalks.API1.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region>GetAll();
    }
}

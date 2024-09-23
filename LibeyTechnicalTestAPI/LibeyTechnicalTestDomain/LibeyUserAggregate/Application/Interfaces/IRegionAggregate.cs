using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IRegionAggregate
    {
        IEnumerable<Region> GetAllRegion();
    }
}

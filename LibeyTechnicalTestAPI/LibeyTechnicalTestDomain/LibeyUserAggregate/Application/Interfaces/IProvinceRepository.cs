using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IProvinceRepository
    {
        IEnumerable<Province> GetAll(string regionCode);
    }
}

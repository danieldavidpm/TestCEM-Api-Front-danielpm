using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IProvinceAggregate
    {
        IEnumerable<Province> GetAllProvince(string regionCode);
    }
}

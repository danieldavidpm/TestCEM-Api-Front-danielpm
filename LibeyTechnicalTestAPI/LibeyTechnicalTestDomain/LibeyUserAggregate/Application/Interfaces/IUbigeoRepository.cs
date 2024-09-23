using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IUbigeoRepository
    {
        IEnumerable<Ubigeo> GetAll(string provinceCode);
    }
}

using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IUbigeoAggregate
    {
        IEnumerable<Ubigeo> GetAllUbigeo(string provinceCode);
    }
}

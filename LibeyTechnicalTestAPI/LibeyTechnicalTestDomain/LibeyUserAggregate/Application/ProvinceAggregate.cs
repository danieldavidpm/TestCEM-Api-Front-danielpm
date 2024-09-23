using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class ProvinceAggregate : IProvinceAggregate
    {
        private readonly IProvinceRepository _repository;
        public ProvinceAggregate(IProvinceRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Province> GetAllProvince(string regionCode)
        {
            return _repository.GetAll(regionCode);
        }
    }
}

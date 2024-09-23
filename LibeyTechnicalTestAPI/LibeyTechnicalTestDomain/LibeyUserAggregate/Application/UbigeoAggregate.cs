using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class UbigeoAggregate : IUbigeoAggregate
    {
        private readonly IUbigeoRepository _repository;
        public UbigeoAggregate(IUbigeoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Ubigeo> GetAllUbigeo(string provinceCode)
        {
            return _repository.GetAll(provinceCode);
        }
    }
}

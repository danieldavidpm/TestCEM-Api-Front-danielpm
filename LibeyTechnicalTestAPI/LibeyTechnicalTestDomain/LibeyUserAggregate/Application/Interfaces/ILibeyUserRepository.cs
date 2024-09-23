using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface ILibeyUserRepository
    {
        LibeyUserResponse FindResponse(string documentNumber);
        void Create(LibeyUser libeyUser);
        IEnumerable<LibeyUser> GetAll();
        void Update(LibeyUser libeyUser);
        LibeyUser GetByDocumentNumber(string documentNumber);
        void LogicalDelete(LibeyUser libeyUser);
    }
}

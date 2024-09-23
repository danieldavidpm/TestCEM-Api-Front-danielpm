using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application
{
    public class LibeyUserAggregate : ILibeyUserAggregate
    {
        private readonly ILibeyUserRepository _repository;
        public LibeyUserAggregate(ILibeyUserRepository repository)
        {
            _repository = repository;
        }
        public void Create(UserUpdateorCreateCommand command)
        {
            // Mapear el DTO al dominio
            var libeyUser = new LibeyUser(
                command.DocumentNumber,
                command.DocumentTypeId,
                command.Name,
                command.FathersLastName,
                command.MothersLastName,
                command.Address,
                command.UbigeoCode,
                command.Phone,
                command.Email,
                command.Password
            );

            // Pasar la entidad al repositorio
            _repository.Create(libeyUser);
        }
        public LibeyUserResponse FindResponse(string documentNumber)
        {
            var row = _repository.FindResponse(documentNumber);
            return row;
        }

        public IEnumerable<LibeyUser> GetAllUsers()
        {
            return _repository.GetAll();
        }
        public void Update(UserUpdateorCreateCommand command)
        {
            // Buscar el usuario existente
            var user = _repository.GetByDocumentNumber(command.DocumentNumber);

            if (user != null)
            {
                // Actualizar las propiedades del usuario
                user.UpdateDetails(
                    command.DocumentTypeId,
                    command.Name,
                    command.FathersLastName,
                    command.MothersLastName,
                    command.Address,
                    command.UbigeoCode,
                    command.Phone,
                    command.Email,
                    command.Password
                );

                // Guardar cambios
                _repository.Update(user);
            }
        }

        public void LogicalDelete(string documentNumber)
        {
            // Buscar el usuario existente
            var user = _repository.GetByDocumentNumber(documentNumber);

            if (user != null)
            {
                // Desactivar el usuario
                _repository.LogicalDelete(user);
            }
        }

    }
}
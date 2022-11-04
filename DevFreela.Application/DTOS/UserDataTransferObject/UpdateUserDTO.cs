using DevFreela.Domain.Entities;

namespace DevFreela.Application.DTOS.UserDataTransferObject
{
    public class UpdateUserDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public UpdateUserDTO() { }

        public UpdateUserDTO(string fullName , string email) 
        {
            FullName = fullName;
            Email = email;
        }

        public UpdateUserDTO(User entity)
        {
            FullName = entity.FullName;
            Email = entity.Email;
        }

    }
}

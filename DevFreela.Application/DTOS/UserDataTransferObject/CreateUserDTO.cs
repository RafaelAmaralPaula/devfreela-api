using DevFreela.Application.DTOS.SkillDataTransferObject;
using DevFreela.Domain.Entities;

namespace DevFreela.Application.DTOS.UserDataTransferObject
{
    public class CreateUserDTO
    {
        public int Id { get;  set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public List<FindSkillDTO> Skills { get; set; } = new List<FindSkillDTO>();


        public CreateUserDTO() { }

        public CreateUserDTO(string fullName , string email , DateTime birthDate)
        {   
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
        }

        public CreateUserDTO(User entity)
        {
            Id = entity.Id;
            FullName = entity.FullName;
            Email = entity.Email;
            BirthDate = entity.BirthDate;

        }

        public CreateUserDTO(User entity , List<Skill> skills ) : this (entity) 
        {
            skills.ForEach(skill => Skills.Add(new FindSkillDTO(skill.Id)));
      
        }


    }
}

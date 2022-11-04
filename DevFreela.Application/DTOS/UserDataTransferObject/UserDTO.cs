using DevFreela.Application.DTOS.CommentDataTransferObject;
using DevFreela.Application.DTOS.ProjectDataTransferObject;
using DevFreela.Application.DTOS.SkillDataTransferObject;
using DevFreela.Domain.Entities;

namespace DevFreela.Application.DTOS.UserDataTransferObject
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public List<SkillDTO> Skills { get; set; } = new List<SkillDTO>();

        public List<ProjectDTO> OwnedProjects { get; set; } = new List<ProjectDTO>();

        public List<ProjectDTO> FreelanceProjects { get; set; } = new List<ProjectDTO>();

        public List<CommentDTO> Comments { get; set; } = new List<CommentDTO>();

        public UserDTO()
        {
        
        }

        public UserDTO(int id , string fullName , string email , DateTime birthDate)
        {
            Id = id;    
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
        }

        public UserDTO(User entity)
        {
            Id = entity.Id;
            FullName = entity.FullName;
            Email = entity.Email;
            BirthDate = entity.BirthDate;

        }

        public UserDTO(User entity , List<Skill> skills , List<Project> clients , List<Project> freelancers , List<Comment> comments) : this(entity)
        {
            
            skills.ForEach(skill => Skills.Add(new SkillDTO(skill)));
            clients.ForEach(clients => OwnedProjects.Add(new ProjectDTO(clients)));
            freelancers.ForEach(freelancers => FreelanceProjects.Add(new ProjectDTO(freelancers)));
            comments.ForEach(comments => Comments.Add(new CommentDTO(comments)));
        }




    }
}

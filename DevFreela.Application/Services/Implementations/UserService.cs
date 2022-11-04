
using DevFreela.Application.DTOS.CommentDataTransferObject;
using DevFreela.Application.DTOS.ProjectDataTransferObject;
using DevFreela.Application.DTOS.SkillDataTransferObject;
using DevFreela.Application.DTOS.UserDataTransferObject;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Domain.Entities;
using DevFreela.Infrastructure.Persistences;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;

        public UserService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<UserDTO> FindAll(string query)
        {
            var projects = _dbContext.Users
                            .Include(u => u.Skills)
                            
                            .Select(u => new UserDTO( u , u.Skills , u.OwnedProjects ,
                                                            u.FreelanceProjects , u.Comments))
                           .ToList();
            return projects;

        }
        public UserDTO FindById(int id)
        {
            var entity = _dbContext.Users
                .Include(p => p.Skills)
                .SingleOrDefault(p => p.Id == id);
            return new UserDTO(entity , entity.Skills , entity.OwnedProjects , entity.FreelanceProjects , entity.Comments);
        }

        public CreateUserDTO Save(CreateUserDTO userDTO)
        {
            var user = new User();
            CopyDtoToEntity(user, userDTO);

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return new CreateUserDTO(user);
        }

        public void Update(int id, UpdateUserDTO userUpdateDTO)
        {
            var user = _dbContext.Users.SingleOrDefault(p => p.Id == id);
            user.FullName = userUpdateDTO.FullName;
            user.Email = userUpdateDTO.Email;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _dbContext.Users.Find(id);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public void AddSkills(int id, List<FindSkillDTO> skills)
        {
            var user = _dbContext.Users
                            .Find(id);
            foreach (FindSkillDTO skillDTO in skills)
            {
                var skill = _dbContext.Skills.Find(skillDTO.Id);
                user.Skills.Add(skill);
            }

            _dbContext.SaveChanges();

        }

        public void DeleteSkill(int id , FindSkillDTO skills)
        {
            var user = _dbContext.Users
                        .Include(user => user.Skills)    
                        .SingleOrDefault(user => user.Id == id);
            
            user.Skills.Remove(_dbContext.Skills.Find(skills.Id));
          
            _dbContext.SaveChanges();
            
            
        }

        private void CopyDtoToEntity(User entity, CreateUserDTO dto)
        {
            
            entity.FullName = dto.FullName;
            entity.Email = dto.Email;
            entity.BirthDate = dto.BirthDate;

            SetListSkill(entity , dto);
        }

        private void SetListSkill(User entity , CreateUserDTO dto)
        {
            entity.Skills.Clear();
            foreach(var skillDTO in dto.Skills)
            {
                Skill skill = _dbContext.Skills.Find(skillDTO.Id);
                entity.Skills.Add(skill);

            }
        }

        /*
        private void SetListProjectClient(User entity, CreateUserDTO dto)
        {
            entity.FreelanceProjects.Clear();
            foreach (ProjectDTO projectDTO in dto.FreelanceProjects)
            {
                Project project = _dbContext.Projects.Find(projectDTO.Id);
                entity.FreelanceProjects.Add(project);

            }
        }

        */

        /*
        private void SetListFreelancer(User entity, CreateUserDTO dto)
        {
            entity.OwnedProjects.Clear();
            foreach (ProjectDTO projectDTO in dto.OwnedProjects)
            {
                Project project = _dbContext.Projects.Find(projectDTO.Id);
                entity.OwnedProjects.Add(project);

            }
        }

        */

        /*
        private void SetListComment(User entity, CreateUserDTO dto)
        {
            entity.Comments.Clear();
            foreach (CommentDTO commentDTO in dto.Comments)
            {
                Comment comment = _dbContext.Comments.Find(commentDTO.Id);
                entity.Comments.Add(comment);

            }
        }

        */

    }
}

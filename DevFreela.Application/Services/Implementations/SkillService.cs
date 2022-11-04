using DevFreela.Application.DTOS.SkillDataTransferObject;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Domain.Entities;
using DevFreela.Infrastructure.Persistences;

namespace DevFreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        
        private readonly DevFreelaDbContext _dbContext;

        public SkillService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillDTO> FindAll()
        {

            var skills = _dbContext.Skills
                        .Select(skill => new SkillDTO(skill))
                        .ToList();

            return skills;
            
        }

        public SkillDTO FindById(int id) 
        {
            var entity = _dbContext.Skills
                                .SingleOrDefault(p => p.Id == id);

            return new SkillDTO(entity); 

        }

        public SkillDTO Save(SkillDTO skillDTO)
        {
            var skill = new Skill();
            skill.Description = skillDTO.Description;

            _dbContext.Skills.Add(skill);
            _dbContext.SaveChanges();

            return new SkillDTO(skill);
        }

        public void Update(int id , SkillDTO skillDTO)
        {
            var entity = _dbContext.Skills.SingleOrDefault(skill => skill.Id == id);
            entity.Description = skillDTO.Description;
            _dbContext.SaveChanges();

        }

        public void Delete(int id)
        {
            var skill = _dbContext.Skills.Find(id);
            _dbContext.Skills.Remove(skill);
            _dbContext.SaveChanges();
        }
        
    }
}

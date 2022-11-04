using DevFreela.Domain.Entities;

namespace DevFreela.Application.DTOS.SkillDataTransferObject
{
    public class SkillDTO
    {

        public int Id { get; set; } 

        public string Description { get; set; }

        public SkillDTO() { }

        public SkillDTO(string description)
        {
            Description = description;
        }

        public SkillDTO(Skill entity)
        {
            Id = entity.Id;
            Description = entity.Description;
        }
    }
}

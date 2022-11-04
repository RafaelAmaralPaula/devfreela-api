namespace DevFreela.Application.DTOS.SkillDataTransferObject
{
    public class FindSkillDTO
    {

        public int Id { get; set; }

        
       public FindSkillDTO() { }
        
       public FindSkillDTO(int id) 
       {
            Id = id;
       }
    }
}

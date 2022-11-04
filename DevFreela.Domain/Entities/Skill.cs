namespace DevFreela.Domain.Entities
{
    public class Skill 
    {
        public int Id { get; set; }

        public string Description { get;  set; }

        public DateTime CreatedAt { get;  set; }

        public  List<User> Users { get; set; } = new List<User>();

        public Skill() 
        {
            CreatedAt = DateTime.Now;
        }
        public Skill(string description) 
        {
            Description = description;
            
        }
      
    }
}

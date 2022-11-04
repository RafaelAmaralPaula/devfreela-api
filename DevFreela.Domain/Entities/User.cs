namespace DevFreela.Domain.Entities
{
    public class User 
    {
        public int Id { get; set; }

        public string FullName { get;  set; }

        public string Email { get;  set; }

        public DateTime BirthDate { get;  set; }

        public DateTime CreatedAt { get;  set; }

        public List<Skill> Skills { get; set; } = new List<Skill>();

        public List<Project> OwnedProjects { get;  set; } = new List<Project>();

        public List<Project> FreelanceProjects { get;  set; } = new List<Project>();

        public List<Comment> Comments { get;  set; } = new List<Comment>();

        public bool Active { get; private set; }

        public User()
        {
            CreatedAt = DateTime.Now;
            Active = true;

        }
        public User(string fullName, string email, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
        
        }
    }
}
